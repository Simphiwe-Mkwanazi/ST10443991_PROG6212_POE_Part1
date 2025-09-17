using Microsoft.AspNetCore.Mvc;

namespace CMCS.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to CMCS (Non-Functional Prototype)";
            return View();
        }
    }
}
