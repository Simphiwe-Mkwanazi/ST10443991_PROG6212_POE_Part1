using Microsoft.AspNetCore.Mvc;

namespace CMCS.Web.Controllers
{
    public class ApprovalsController : Controller
    {
        public IActionResult Index()
        {
            var queue = new[] {
                new { ClaimId = "CLM-001", Stage = "Coordinator", Lecturer = "A. Lecturer", Status = "Pending" },
            };
            return View(queue);
        }

        public IActionResult Detail(string id)
        {
            ViewBag.ClaimId = id ?? "CLM-001";
            return View();
        }
    }
}
