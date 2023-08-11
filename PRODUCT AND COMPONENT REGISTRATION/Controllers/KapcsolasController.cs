using Microsoft.AspNetCore.Mvc;

namespace Keszprojekt.Controllers
{
    public class KapcsolasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
