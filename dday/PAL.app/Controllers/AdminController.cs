using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAL.DataModel;

namespace PAL.app.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        public AdminController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> AssignRoleToUser(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            userId = "entprogadmin@gmail.com";
            await userManager.AddToRoleAsync(user, "Admin");

            if (user != null)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }

            // Redirect or return appropriate response
            return View("Index", "Home");
        }
    }
}
