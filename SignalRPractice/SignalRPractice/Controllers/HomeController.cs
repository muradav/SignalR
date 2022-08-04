using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRPractice.DAL;
using SignalRPractice.Models;
using SignalRPractice.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHubContext<ChatHub> _hubContext;



        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IHubContext<ChatHub> hubContext)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _hubContext = hubContext;
        }
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult Chat()
        {
            List<AppUser> users = _userManager.Users.ToList();
            return View(users);
        }

        public async Task<IActionResult> CreateUser()
        {
            var result = await _userManager.CreateAsync(new AppUser { UserName = "_rashid", Email = "rashidrma@code.edu.az", isOnline = false, Fullname = "Rashid" }, "12345@Ca");
            var result1 = await _userManager.CreateAsync(new AppUser { UserName = "_farid", Email = "feridtb@code.edu.az", isOnline = false, Fullname = "Ferid" }, "12345@Ca");
            var result2 = await _userManager.CreateAsync(new AppUser { UserName = "_murad", Email = "muradav@code.edu.az", isOnline = false, Fullname = "Murad" }, "12345@Ca");
            var result3 = await _userManager.CreateAsync(new AppUser { UserName = "_huseyn", Email = "huseynfh@code.edu.az", isOnline = false, Fullname = "Huseyn" }, "12345@Ca");
            return Ok("User Created");

        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            var user = _userManager.FindByNameAsync(model.Username).Result;
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            return RedirectToAction("Index");

        }
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("index");
        }

        public async Task<IActionResult> PrivateSend(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            await _hubContext.Clients.Client(appUser.ConnectId).SendAsync("PrivateMessage");
            return RedirectToAction("chat");
        }

    }
}
