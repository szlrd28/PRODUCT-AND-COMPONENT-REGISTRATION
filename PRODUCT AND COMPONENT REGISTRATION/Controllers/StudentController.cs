using Microsoft.AspNetCore.Mvc;

namespace Keszprojekt.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
