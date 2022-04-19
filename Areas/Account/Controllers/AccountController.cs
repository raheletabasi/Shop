using Microsoft.AspNetCore.Mvc;
using Shop.Areas.Account.Models;
using Shop.Data;
using System.Linq;

namespace Shop.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {
        readonly ShopDbContext _dbContext;

        public AccountController(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var userLogin = _dbContext.Users
                .Where(usr => usr.Email == loginViewModel.Email.ToLower()
                           && usr.IsActive == true);

            if (userLogin == null)
            {
                ModelState.AddModelError(string.Empty, $"ایمیل {loginViewModel.Email} در سامانه ثبت نشده است");
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register", "Account");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if(!ModelState.IsValid)
                return View(registerViewModel);

            if (_dbContext.Users.Any(usr => usr.Email == registerViewModel.Email.ToLower()))
                ModelState.AddModelError("Email", $" ایمیل {registerViewModel.Email} قبلا ثبت شده است");

            return RedirectToAction("Login", "Account");
        }
    }
}
