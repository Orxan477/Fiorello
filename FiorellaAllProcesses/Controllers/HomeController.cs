using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                HomeIntro = await _context.HomeIntros.FirstOrDefaultAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Valentines=await _context.Valentines.FirstOrDefaultAsync(),
                ValentineOption=await _context.ValentineOptions.ToListAsync(),
                FlowerExpert=await _context.FlowerExperts.FirstOrDefaultAsync(),
                Experts=await _context.Experts.ToListAsync(),
                Blogs = await _context.Blogs.FirstOrDefaultAsync(),
                BlogFlowers = await _context.BlogFlowers.ToListAsync(),
                Comments = await _context.Comments.ToListAsync(),
                Instagrams = await _context.Instagrams.ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
