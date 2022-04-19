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
                ModelState.AddModelError(string.Empty, $"ایمیل {0} در سامانه ثبت نشده است");
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register", "Account");
        }

        
    }
}
