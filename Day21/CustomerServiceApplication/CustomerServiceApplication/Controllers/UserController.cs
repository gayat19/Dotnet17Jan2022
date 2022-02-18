using CustomerServiceApplication.Models;
using CustomerServiceApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerServiceApplication.Controllers
{
    public class UserController : Controller
    {
        private LoginService _loginService;

        public UserController(LoginService loginService)
        {
            _loginService = loginService;
        }
        // GET: UserController
       

        // GET: UserController/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            try
            {

                User usr = await _loginService.Register(user);
                HttpContext.Session.SetString("token", usr.Token);
                return RedirectToAction("Index","Customer");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            try
            {
                User usr = await _loginService.Login(user);
                HttpContext.Session.SetString("token", user.Token);
                return RedirectToAction("Index", "Customer");
            }
            catch
            {
                return View();
            }
        }

    }
}
