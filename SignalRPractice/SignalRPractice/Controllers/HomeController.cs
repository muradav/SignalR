using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private static string CurUserName;
        private readonly AppDbContext _context;



        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult Chat()
        {
            List<AppUser> users = _userManager.Users.Where(u => u.ConnectId != null).ToList();
            ViewBag.ChatUsers = users;
            return View();
        }

        public async Task<IActionResult> CreateUser()
        {
            var result = await _userManager.CreateAsync(new AppUser { UserName = "_rashid", Email = "rashidrma@code.edu.az", isOnline = false, Fullname = "Elgun" }, "12345@Ca");
            var result1 = await _userManager.CreateAsync(new AppUser { UserName = "_farid", Email = "feridtb@code.edu.az", isOnline = false, Fullname = "Ferid" }, "12345@Ca");
            var result2 = await _userManager.CreateAsync(new AppUser { UserName = "_murad", Email = "muradav@code.edu.az", isOnline = false, Fullname = "Xalid" }, "12345@Ca");
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
            CurUserName = user.Email;
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            user.isOnline = true;
            _context.SaveChanges();
            ViewBag.UserName = user.Fullname;
            return RedirectToAction("chat", "home");

        }
        public async Task<IActionResult> Logout()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(CurUserName);
            appUser.isOnline = false;
            _context.SaveChanges();
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

    }
}
