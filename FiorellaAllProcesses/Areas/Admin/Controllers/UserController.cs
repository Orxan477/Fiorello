using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private AppDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public UserController(AppDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<UserVM> model = new List<UserVM>();
            model = _userManager.Users.Select(u => new UserVM
            {
                Name = u.Fullname,
                Email = u.Email, 
                Status=u.Status,
            }).ToList();
            return View(model);
        }
    }
}
