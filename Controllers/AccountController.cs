using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballStarz.ViewModels;
using FootballStarz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FootballStarz.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IWebHostEnvironment _HostingEnv;
        //private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AccountController(//IConfiguration configuration,
                                //IWebHostEnvironment HostingEnvironment,
                                ILogger<AccountController> logger,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager)
        {
            //_configuration = configuration;
            //_HostingEnv = HostingEnvironment;
            _logger = logger;

            _userManager = userManager;
            _signInManager = signInManager;


        }

        public IActionResult Login()
        {
            return View();
        }


        public async Task<IActionResult> LoggedIn(LoginViewModel LoginVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                return View("Login");
            }

            _logger.LogInformation("AccountController- Model state VALID");

            var result = await _signInManager.PasswordSignInAsync(LoginVM.Email, LoginVM.Password, true, false);
            _logger.LogInformation($"_signInManager.PasswordSignInAsync returns:\t{result}");

            if (result.Succeeded)
            {
                return RedirectToAction("AllClubs", "Club", new RouteValueDictionary(LoginVM));
            }
            else
            {
                _logger.LogInformation("AccountController- Sign in failed, back to login");

                return View("Login");
            }
        }
        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> Registered(RegisterViewModel registerVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");

                return View("Register");
            }

            var user = new ApplicationUser() { UserName = registerVM.Email, Email = registerVM.Email };
            var result = await _userManager.CreateAsync(user, registerVM.Password);

            if (result.Succeeded)
            {
                _logger.LogInformation("AccountController- Succesful user creation");

                return RedirectToAction("AllClubs", "Club");
            }

            _logger.LogInformation("AccountController- Register failed, back to login");

            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            _logger.LogInformation("AccountController- Succesfull logout");

            return RedirectToAction("Login", "Account");
        }
    }
}