using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Settings);
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
            if (dbsetting.Value.Trim().ToLower() == setting.Value.Trim().ToLower())
            {
                return RedirectToAction("Index", "Setting");
            }

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
