using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
