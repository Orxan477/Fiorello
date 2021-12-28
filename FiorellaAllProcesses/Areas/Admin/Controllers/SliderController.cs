using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private Task<int> _size;

        private AppDbContext _context { get; }

        private IWebHostEnvironment _env { get; }

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            _size = _context.Settings
                          .Where(s => s.Key == "Size")
                          .Select(s => s.Value)
                          .FirstOrDefaultAsync();
            
        }

        public IActionResult Index()
        {
            return View(_context.Sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
           

            if (ModelState["Photo"].ValidationState==ModelValidationState.Invalid) return View();
            if (slider.Photo.CheckSize(await _size))
            {
                ModelState.AddModelError("Photo", $"Şəkilin fotmatı {_size} kb-dan çoxdur");
                return View();
            }

            if (!slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi duzgun deyil");
                return View();
            }

            string fileName = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            slider.Image = fileName;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            Helper.RemoveFile(_env.WebRootPath, "img", slider.Image);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Slider slider)
        {
            if (id != slider.Id) return BadRequest();

            Slider dbslider = await _context.Sliders
                                            .Where(c => c.Id == id)
                                            .FirstOrDefaultAsync();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)  return View();
            if (slider.Photo.CheckSize(await _size))
            {
                ModelState.AddModelError("Photo", $"Şəkilin fotmatı {_size} kb-dan çoxdur");
                return View();
            }

            if (!slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi duzgun deyil");
                return View();
            }

            string fileName = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            dbslider.Image = fileName;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
