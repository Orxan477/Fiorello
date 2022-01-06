using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailService _emailService;

        public AuthController(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager,
                              IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            ApplicationUser newUser = new ApplicationUser
            {
                Fullname=register.Fullname,
                Email=register.Email,
                UserName=register.Username,
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (identityResult.Succeeded)
            {
                Task<string> codeData = _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                string code = codeData.Result;

                string link = Url.Action(nameof(VerifyEmail),"Auth", new { userId = newUser.Id, code }
                                                                        , Request.Scheme, Request.Host.ToString());

                await _emailService.SendAsync("orxanqanbarov73@gmail.com", "Fiorello Email Verify", $"<a href=\"{link}\">Verify Email</a>", true);

                return RedirectToAction("EmailVerification", "Auth");
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
        //[HttpGet]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyEmail(string userId,string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) BadRequest();
           var result= await _userManager.ConfirmEmailAsync(user,code);

            if (result.Succeeded) //return RedirectToAction(nameof(Login));
                                  return Content("Thank you verify Email.");
                                  //return RedirectToAction(nameof(VerifyEmail));

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
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if (!ModelState.IsValid) return View(loginVm);
            ApplicationUser user = await _userManager.FindByNameAsync(loginVm.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View(loginVm);

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
