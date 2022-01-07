using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private AppDbContext _context;
        private RoleManager<IdentityRole> _roleManager;

        public RoleController(AppDbContext context,
                              RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<UserVM> model = new List<UserVM>();
            model =  _roleManager.Roles.Select(r => new UserVM
            {
                RoleName = r.Name,
            }).ToList();
            return View(model);
        }
    }
}
