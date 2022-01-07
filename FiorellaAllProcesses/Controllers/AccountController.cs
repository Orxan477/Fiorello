using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.Utilities;
using FiorellaAllProcesses.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailService _emailService;
        private AppDbContext _context;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager,
                              AppDbContext context,
                              IEmailService emailService,
                              RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _context = context;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            ApplicationUser newUser = new ApplicationUser
            {
                Fullname = register.Fullname,
                Email = register.Email,
                UserName = register.Username,
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);

            if (identityResult.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

                string link = Url.Action(nameof(VerifyEmail), "Account", new { userId = newUser.Id, code },
                                                                       Request.Scheme, Request.Host.ToString());

                await _emailService.SendAsync("orxanqanbarov73@gmail.com", "Fiorello Email Verify", $"<a href=\"{link}\">Verify Email</a>", true);

                await _userManager.AddToRoleAsync(newUser, UserRoles.Member.ToString());
                return RedirectToAction("EmailVerification", "Account");
            }

            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }

        }

        public async Task<IActionResult> VerifyEmail(string userid, string code)
        {
            var user = await _userManager.FindByIdAsync(userid);
            if (user == null) return BadRequest("User Could Not Found");
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                user.IsActived = true;
                await _context.SaveChangesAsync();
                return View();
            }
            else return BadRequest();
        }
        public IActionResult EmailVerification()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm, string ReturnUrl)
        {
            if (!ModelState.IsValid) return View(loginVm);
            ApplicationUser user = await _userManager.FindByEmailAsync(loginVm.Email.ToString());
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email and Password is Wrong");
                return View(loginVm);
            }
            if (user.IsActived == false)
            {
                ModelState.AddModelError(string.Empty, "Please Confirm Your Email");
                return View(loginVm);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, loginVm.RememberMe,true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError(string.Empty, "Your Account is locked. Few minutes leter is unlocked");
                return View(loginVm);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Email and Password is Wrong");
                return View(loginVm);
            }
            //await _signInManager.SignInAsync(user, loginVm.RememberMe);
            if (ReturnUrl != null)
            {
                return LocalRedirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        #region Create Role
        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(UserRoles)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //}
        #endregion

    }
}
