using LoginApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // /Admin/Users
        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var users = _userManager.Users.ToList();

            var vm = new List<UserWithRolesVm>();

            foreach (var u in users)
            {
                var roles = await _userManager.GetRolesAsync(u);
                vm.Add(new UserWithRolesVm
                {
                    UserId = u.Id,
                    Email = u.Email ?? "",
                    UserName = u.UserName ?? "",
                    IsAdmin = roles.Contains("Admin")
                });
            }

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleAdmin(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return RedirectToAction(nameof(Users));

            // Kendini adminlikten çıkarmayı engellemek istersen:
            // var currentUserId = _userManager.GetUserId(User);
            // if (currentUserId == userId) return RedirectToAction(nameof(Users));

            var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");

            if (isAdmin)
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            else
                await _userManager.AddToRoleAsync(user, "Admin");

            return RedirectToAction(nameof(Users));
        }
    }
}
