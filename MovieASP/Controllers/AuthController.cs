using Dal.Interface;
using Microsoft.AspNetCore.Mvc;
using MovieASP.Models;
using MovieASP.Tools;


namespace MovieASP.Controllers
{

    public class AuthController : Controller
    {

        private IUserRepository _userRepo;

        public AuthController(IUserRepository ur)
        {
            _userRepo = ur;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm loginForm)
        {
            if(!ModelState.IsValid)
            {
                return View(loginForm);
            }
            User u = _userRepo.Login(loginForm.Email, loginForm.Password).ToDal();
            HttpContext.Session.SetUser(u);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(UserForm userForm)
        {
            if (!ModelState.IsValid)
            {
                return View(userForm);
            }
            _userRepo.Register(userForm.ToDal());
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Disconnect();
            return RedirectToAction("Index", "Home");
        }

    }
}
