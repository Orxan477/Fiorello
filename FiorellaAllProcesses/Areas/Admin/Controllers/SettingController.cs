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
    public class SettingController : Controller
    {
        private AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Settings=await _context.Settings.ToListAsync(),
            };
            return View(homeVM);
        }
        public IActionResult Update(int id)
        {
            Setting setting = _context.Settings.Find(id);
            if (setting == null) return NotFound();

            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Setting setting)
        {
            //if (ModelState.IsValid) return View();
            if (id != setting.Id) return BadRequest();

            Setting dbsetting = await _context.Settings
                                                .Where(c=>c.Id == id)
                                                .FirstOrDefaultAsync();
            if (dbsetting == null) return NotFound();

            dbsetting.Value = setting.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Setting");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

            Setting dbsetting = await _context.Settings
                                              .Where(p => p.Id == id)
                                              .FirstOrDefaultAsync();

            if (dbsetting == null) return NotFound();
            //return Json("sa");
            _context.Remove(dbsetting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
