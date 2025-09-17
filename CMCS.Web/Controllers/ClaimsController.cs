using Microsoft.AspNetCore.Mvc;

namespace CMCS.Web.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            // Simulated list of claims
            var claims = new[] {
                new { ClaimId = "CLM-001", Period = "Aug 2025", Status = "Submitted", TotalHours = 12, Amount = 4800 },
                new { ClaimId = "CLM-002", Period = "Sep 2025", Status = "Draft", TotalHours = 6, Amount = 2400 }
            };
            return View(claims);
        }

        public IActionResult Detail(string id)
        {
            // Simulated claim detail
            ViewBag.ClaimId = id ?? "CLM-001";
            return View();
        }

        public IActionResult New()
        {
            return View();
        }
    }
}
