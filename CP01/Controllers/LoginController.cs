using Microsoft.AspNetCore.Mvc;

namespace CP01.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            ViewBag.textoLogin = "Login";
            return View();
        }
    }
}
