using Entities.IdentityEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movie_Review_Website.Models;

namespace Movie_Review_Website.Controllers
{
    [Route("[controller]/[action]")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, ILogger<AccountController> logger,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _logger = logger;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation("Invalid model state");
                ViewBag.errors = ModelState.Values.SelectMany(tmp => tmp.Errors).Select(tmp => tmp.ErrorMessage).ToList();
                return View(register);
            }
            ApplicationUser user = new ApplicationUser()
            {
                Email = register.Email,
                UserName = register.Email,
                PhoneNumber = register.PhoneNumber,
                PersonName = register.PersonName,
            };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction(nameof(MoviesController.Index), "Movies");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            ViewBag.errors = ModelState.Values.SelectMany(tmp => tmp.Errors).Select(tmp => tmp.ErrorMessage).ToList();
            return View(register);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation("Invalid model state");
                ViewBag.errors = ModelState.Values.SelectMany(tmp => tmp.Errors).Select(tmp => tmp.ErrorMessage).ToList();
                return View(login);
            }

            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation($"User {login.Email} successfully logged in.");
                return RedirectToAction(nameof(MoviesController.Index), "Movies");
            }
            else if (result.IsLockedOut)
            {
                _logger.LogWarning($"User {login.Email} is locked out.");
                ModelState.AddModelError("Login", "This account has been locked out. Please try again later.");
            }
            else if (result.IsNotAllowed)
            {
                _logger.LogWarning($"User {login.Email} login not allowed.");
                ModelState.AddModelError("Login", "Login not allowed. Please confirm your email.");
            }
            else
            {
                _logger.LogWarning($"Failed login attempt for {login.Email}");
                ModelState.AddModelError("Login", "Invalid Email or Password");
            }

            ViewBag.errors = ModelState.Values.SelectMany(tmp => tmp.Errors).Select(tmp => tmp.ErrorMessage).ToList();
            return View(login);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
