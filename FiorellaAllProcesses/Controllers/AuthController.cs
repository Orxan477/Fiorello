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
                var code =await  _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                //var code = codeData.Result;

                var link = Url.Action(nameof(VerifyEmail), "Auth",
                                                new { userid = newUser.Id, code }, Request.Scheme, Request.Host.ToString());

                await _emailService.SendAsync("orxanqanbarov73@gmail.com", "Confirm", $"<a href={link}>Verify Link</a>", true);
                return RedirectToAction("EmailVerification", "Auth");
            }
            return View();
            #region MyRegion

            //if (identityResult.Succeeded)
            //{
            //    Task<string> codeData = _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            //    string code = codeData.Result;

            //    string link = Url.Action(nameof(VerifyEmail),"Auth", new { userId = newUser.Id, code },
            //                                                           Request.Scheme, Request.Host.ToString());

            //    await _emailService.SendAsync("orxanqanbarov73@gmail.com", "Fiorello Email Verify", $"<a href=\"{link}\">Verify Email</a>",true+);

            //    return RedirectToAction("EmailVerification", "Auth");
            //}

            //else
            //{
            //    foreach (var error in identityResult.Errors)
            //    {
            //        ModelState.AddModelError("", error.Description);
            //    }
            //    return View(register);
            //}
            #endregion

        }
        
        public async Task<IActionResult> VerifyEmail(string userid,string code)
        {
            var user = await _userManager.FindByIdAsync(userid);
            if (user == null) return BadRequest("User Could Not Found");
            var result =await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return View();
            }
            else return BadRequest();
        }
        //public async Task<IActionResult> VerifyEmail(string userId,string code)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user == null) BadRequest();
        //   var result= await _userManager.ConfirmEmailAsync(user,code);

        //    if (result.Succeeded)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
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
            ApplicationUser user = await _userManager.FindByEmailAsync(loginVm.Email.ToString());
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, loginVm.RemembeMe, true);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index","Home");
                }
                //else
                //{
                //    foreach (var error in user.Errors)
                //    {
                //        ModelState.AddModelError("", error.Description);
                //    }
                //    return View(loginVm);
                //}
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
