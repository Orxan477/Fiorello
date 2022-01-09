using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.Utilities;
using FiorellaAllProcesses.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System;
using System.Net;
using System.Net.Mail;
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
            IsAuthenticated();
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
                Email.SendEmailAsync(newUser.Email, $"<a href=\"{link}\">Verify Email</a>", "Confirmation Link Fiorello");
                
                await _userManager.AddToRoleAsync(newUser, UserRoles.Member.ToString());
                ViewBag.IsSuccessRegister = true;
                return View();
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
                Email.SendEmailAsync(user.Email, $"Thanks Verify Email.", "Fiorello");
                user.IsActived = true;
                await _context.SaveChangesAsync();
                ViewBag.IsSuccessVerify = true;
                return View(nameof(Login));
            }
            else return BadRequest();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm, string ReturnUrl)
        {
            IsAuthenticated();
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
            var device = Environment.MachineName.ToString();
            var osVersion = Environment.OSVersion.ToString();
            var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, loginVm.RememberMe,true);
            Email.SendEmailAsync(user.Email, $"Dear {user.Fullname}. Your account has been logged in from this {device} device. Version={osVersion}. " +
                                                            "If you are not, change your password.", "Fiorello");
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
            if (ReturnUrl != null)
            {
                return LocalRedirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        private void IsAuthenticated()
        {
            if (User.Identity.IsAuthenticated)
            {
                throw new Exception("You alredy authenticated");
            }
        }
        public IActionResult SettingAccount()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SettingAccount(string ReturnUrl)
        {
            if (ReturnUrl != null)
            {
                return LocalRedirect(ReturnUrl);
            }
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePasswordVM)
        {
            if (!ModelState.IsValid) return View(changePasswordVM);
            var user = await _userManager.GetUserAsync(User);
            if (user==null)
            {
                ModelState.AddModelError(string.Empty, "User is Not Found");
                return View();
            }
            var result = await _userManager.ChangePasswordAsync(user, changePasswordVM.CurrentPassword, 
                                                                                    changePasswordVM.NewPassword);
            if (result.Succeeded)
            {
                Email.SendEmailAsync(user.Email, $"Your Password Is Changed", "Fiorello");
                ViewBag.IsSuccessPassword = true;
                return View(nameof(SettingAccount));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(changePasswordVM);
            }
        }
        public IActionResult ChangeMail()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeMail(ChangeEmailVM changeEmail)
        {
            if (!ModelState.IsValid) return View(changeEmail);
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User is Not Found");
                return View(changeEmail);
            }

            var checkPasword=await  _userManager.CheckPasswordAsync(user, changeEmail.Password);
            if (!checkPasword)
            {
                ModelState.AddModelError(string.Empty, "Incorrect Password");
                return View(changeEmail);
            }
            var token = await _userManager.GenerateChangeEmailTokenAsync(user, changeEmail.NewEmail);
            var result = await _userManager.ChangeEmailAsync(user, changeEmail.NewEmail, token);
            if (result.Succeeded)
            {
                Email.SendEmailAsync(user.Email, "Your Email Is Changed", "Fiorello");
                ViewBag.IsSuccessMail = true;
                return View(nameof(SettingAccount));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(nameof(ChangeMail));
            }
        }
        //public async Task<IActionResult> VerifyChangeEmail(ChangeEmailVM changeEmail, string token, string userid)
        //{
        //    var user = await _userManager.FindByIdAsync(userid);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError(string.Empty, "User is Not Found");
        //        return View(nameof(Login));
        //    }
        //    var result = await _userManager.ChangeEmailAsync(user, changeEmail.NewEmail, token);
        //    if (result.Succeeded)
        //    {
        //        ViewBag.IsSuccessMail = true;
        //        return View(nameof(SettingAccount));
        //    }
        //    else
        //    {
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //        return View(nameof(ChangeMail));
        //    }
        //}
        public IActionResult ChangeUsername()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeUsername(ChangeUsername changeUsername)
        {
            if (!ModelState.IsValid) return View(changeUsername);
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User is Not Found");
                return View(changeUsername);
            }
            var checkPasword = await _userManager.CheckPasswordAsync(user, changeUsername.Password);
            if (!checkPasword)
            {
                ModelState.AddModelError(string.Empty, "Incorrect Password");
                return View(changeUsername);
            }
            var result = await _userManager.SetUserNameAsync(user, changeUsername.NewUsername);
            if (result.Succeeded)
            {
                Email.SendEmailAsync(user.Email, "Your Username Is Changed", "Fiorello");
                await _signInManager.RefreshSignInAsync(user);
                ViewBag.IsSuccessUsername = true;
                return View(nameof(SettingAccount));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
        }
        public async Task<IActionResult> Logout(string ReturnUrl)
        {
            await _signInManager.SignOutAsync();
            if (ReturnUrl != null)
            {
                return LocalRedirect(ReturnUrl);
            }
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(PasswordMailVM password)
        {
            if (!ModelState.IsValid) return View(password.Email);
            ApplicationUser user =await _userManager.FindByEmailAsync(password.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User Is Not Found");
                return View();
            }
            if (user.IsActived == false)
            {
                ModelState.AddModelError(string.Empty, "Please Confirm Your Email");
                return View(password);
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            
            string link = Url.Action(nameof(ForgotPasswordConfirm), "Account", new { userId = user.Id, token },
                                                                            Request.Scheme, Request.Host.ToString());
            Email.SendEmailAsync(user.Email, $"New Password Link: <a href=\"{link}\">Change Password</a>",
                                                                                        "Forgot Password Link Fiorello");
            ViewBag.IsSuccessReset = true;
            return View();
        }
        public IActionResult ForgotPasswordConfirm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPasswordConfirm(ForgotPassword forgotPassword,string token)
        {
            if (!ModelState.IsValid) return View(forgotPassword);
            ApplicationUser user = await _userManager.FindByEmailAsync(forgotPassword.Email);
            if (user == null) return BadRequest("User Could Not Found");
            IdentityResult identityResult = await _userManager.ResetPasswordAsync(user, token, forgotPassword.NewPassword);
            if (identityResult.Succeeded)
            {
                Email.SendEmailAsync(user.Email, $"Your Password Is Changed", "Fiorello");
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index","Home");
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(forgotPassword);
            }
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