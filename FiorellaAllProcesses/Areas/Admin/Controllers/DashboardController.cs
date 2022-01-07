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
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        private AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Categories=await _context.Categories
                                          .Where(c=>c.IsDeleted==false)
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
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Categories
                                         .Any(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Kateqoriya artiq var");
                return View();
            }
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Dashboard");
        }
        public IActionResult Update(int id)
        {
            Category category = _context.Categories.Find(id);
            if (category == null)  return NotFound();

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Category category)
        {
            //if (ModelState.IsValid) return View();
            if (id != category.Id) return BadRequest();

            Category dbcategory = await _context.Categories
                                                .Where(c=>c.IsDeleted==false&&c.Id==id)
                                                .FirstOrDefaultAsync();
            if (dbcategory == null) return NotFound();
            if(dbcategory.Name.Trim().ToLower()==category.Name.Trim().ToLower())
            {
                return RedirectToAction("Index", "Dashboard");
            }

            bool isExist = _context.Categories
                                         .Any(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Kateqoriya artiq var");
                return View();
            }
            dbcategory.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            
            Category dbcategory = await _context.Categories
                                              .Where(p => p.IsDeleted == false && p.Id == id)
                                              .FirstOrDefaultAsync();
            
            if (dbcategory == null) return NotFound();
            //return Json("sa");
            dbcategory.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
