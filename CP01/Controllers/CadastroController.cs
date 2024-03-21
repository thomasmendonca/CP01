using Microsoft.AspNetCore.Mvc;

namespace CP01.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            ViewBag.textoCadastro = "Cadastro";
            return View();
        }
    }
}
