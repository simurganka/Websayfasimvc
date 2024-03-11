using Microsoft.AspNetCore.Mvc;
using MvcLoginExample.Models;

namespace MvcLoginExample.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel user)
        {
            if (ModelState.IsValid)
            {
                // Burada kullanıcı doğrulama mantığınızı uygulayın
                // Bu örnek için basit bir kontrol yapalım
                if (user.Username == "admin" && user.Password == "password")
                {
                    return RedirectToAction("Index", "Home"); // Başarılı giriş
                }
                else
                {
                    ViewBag.Error = "Invalid credentials";
                    return View(user);
                }
            }

            return View(user);
        }
    }
}
