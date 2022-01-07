using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExpertController : Controller
    {
        private AppDbContext _context;

        public ExpertController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Experts = await _context.Experts
                                        .Where(c => c.IsDeleted == false)
                                        .ToListAsync(),
            };
            return View(homeVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Expert expert)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Experts.Any(e => e.NameSurname
                                                    .Trim().ToLower() == expert.NameSurname.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("NameSurname", "Bu Kateqoriya artiq var");
                return View();
            }
            await _context.Experts.AddAsync(expert);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Expert");
        }
        public IActionResult Update(int id)
        {
            Expert expert = _context.Experts.Find(id);
            if (expert == null) return NotFound();

            return View(expert);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Expert expert)
        {
            //if (ModelState.IsValid) return View();
            if (id != expert.Id) return BadRequest();

            Expert dbexpert = await _context.Experts.FindAsync(id);
            if (dbexpert == null) return NotFound();
            if (dbexpert.NameSurname.Trim().ToLower() == expert.NameSurname.Trim().ToLower())
            {
                return RedirectToAction("Index", "Expert");
            }

            bool isExist = _context.Experts
                                         .Any(c => c.NameSurname.ToLower().Trim() == expert.NameSurname.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("NameSurname", "Bu Kateqoriya artiq var");
                return View();
            }
            dbexpert.NameSurname = expert.NameSurname;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Expert");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Expert dbexpert = await _context.Experts
                                              .Where(p => p.IsDeleted == false && p.Id == id)
                                              .FirstOrDefaultAsync();
            if (dbexpert == null) return NotFound();
            dbexpert.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Expert");
        }
    }
}
