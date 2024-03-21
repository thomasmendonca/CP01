using Microsoft.AspNetCore.Mvc;

namespace CP01.Controllers
{
    public class GitHubPageController : Controller
    {
        public IActionResult GitHubPage()
        {
            return View();
        }
    }
}
