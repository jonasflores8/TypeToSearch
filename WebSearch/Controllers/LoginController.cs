using Microsoft.AspNetCore.Mvc;

namespace WebSearch.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
