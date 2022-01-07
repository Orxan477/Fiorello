using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.Utilities;
using FiorellaAllProcesses.ViewModels.Sliders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }

        private IWebHostEnvironment _env { get; }

        private int _sCount;
        private int _size;
        private string _errorMessageValid;
        private string _errorMessageCount;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            _sCount = Setting("Slider Count");
            _size = Setting("Size");
        }
        public int Setting(string key)
        {
            string dbSetting = _context.Settings
                             .Where(s => s.Key == key)
                             .Select(s => s.Value)
                             .FirstOrDefault();
            int option = int.Parse(dbSetting);
            return (option);
        }

        public IActionResult Index()
        {
            ViewBag.say = _sCount;
            return View(_context.Sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MultipleSliderVM multipleSliderVM)
        {
            #region Old 
            //if (ModelState["Photo"].ValidationState==ModelValidationState.Invalid) return View();
            //if (slider.Photo.CheckSize(await _size))
            //{
            //    ModelState.AddModelError("Photo", $"Şəkilin fotmatı {_size} kb-dan çoxdur");
            //    return View();
            //}

            //if (!slider.Photo.CheckType("image/"))
            //{
            //    ModelState.AddModelError("Photo", "File tipi duzgun deyil");
            //    return View();
            //}

            //string fileName = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            //slider.Image = fileName;
            //await _context.Sliders.AddAsync(slider);
            //await _context.SaveChangesAsync();
            #endregion

            if (ModelState["Photos"].ValidationState == ModelValidationState.Invalid) return View();

            if (!CheckImageCount(multipleSliderVM.Photos))
            {
                ModelState.AddModelError("Photos", _errorMessageCount);
                return View();
            }

            if (!CheckImageValid(multipleSliderVM.Photos))
            {
                ModelState.AddModelError("Photos", _errorMessageValid);
                return View();
            }

            foreach (var photo in multipleSliderVM.Photos)
            {
                string fileName = await photo.SaveFileAsync(_env.WebRootPath, "img");
                Slider slider = new Slider
                {
                    Image = fileName
                };
                await _context.Sliders.AddAsync(slider);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool CheckImageCount(List<IFormFile> photos)
        {
            int maxImageUpload = _sCount,
               dbSliderImageCount = _context.Sliders.Count(),
               upload = maxImageUpload - dbSliderImageCount;
            if (dbSliderImageCount == maxImageUpload)
            {
                _errorMessageCount=$"Slider-də şəkil sayı maximumdur";
                return false;
            }
            if (!(photos.Count() <= upload))
            {
                _errorMessageCount = $"Slider-a {upload}-dən artıq şəkil yükləmək olmaz";
                return false;
            }
            return true;
        }
        private bool CheckImageValid(List<IFormFile> photos)
        {
            foreach (var photo in photos)
            {
                if (photo.CheckSize(_size))
                {
                    _errorMessageValid=$"{photo.FileName} adlı şəkilin formatı {_size} kb-dan çoxdur";
                    return false;
                }

                if (!photo.CheckType("image/"))
                {
                    _errorMessageValid=$"{photo.FileName} adlı şəkilin tipi duzgun deyil";
                    return false;
                }
            }
            return true;
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
            if (slider.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", $"Şəkilin fotmatı {200} kb-dan çoxdur");
                return View();
            }

            if (!slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File tipi duzgun deyil");
                return View();
            }
            Helper.RemoveFile(_env.WebRootPath, "img", dbslider.Image);
            string fileName = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            dbslider.Image = fileName;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
