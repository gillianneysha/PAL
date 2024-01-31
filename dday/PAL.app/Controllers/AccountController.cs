using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAL.app.Models;
using PAL.DataModel;

namespace PAL.app.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid == true)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = model.Email;
                user.Email = model.Email;
                await userManager.CreateAsync(user, model.Password);
                return RedirectToAction("SignIn", "Account");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult SignIn(string? returnUrl)
        {
            SignInVM vm = new SignInVM();
            if (!string.IsNullOrEmpty(returnUrl))
                vm.ReturnUrl = returnUrl;
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInVM model, string? returnUrl)
        {
            ApplicationUser user = await userManager.FindByEmailAsync(model.Username);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                        return LocalRedirect(returnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Login Error", "Invalid Credentials");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Login Error", "Invalid Credentials");
                return View(model);
            }


            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("IndexStart", "HomeLog");
        }
    }
}
