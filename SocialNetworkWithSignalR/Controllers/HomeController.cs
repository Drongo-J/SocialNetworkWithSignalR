using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetworkWithSignalR.Entities;
using SocialNetworkWithSignalR.Models;
using System.Diagnostics;

namespace SocialNetworkWithSignalR.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager { get; set; }
        private CustomIdentityDbContext _context;

        public HomeController(UserManager<CustomIdentityUser> userManager, CustomIdentityDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = user;
            return View();
        }
    }
}