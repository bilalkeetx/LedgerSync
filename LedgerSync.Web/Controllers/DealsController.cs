using Microsoft.AspNetCore.Mvc;

namespace LedgerSync.Web.Controllers
{
    public class DealsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            // Static presentation flow: Redirect to Tally Desk after capturing deal
            return RedirectToAction("Index", "Reconciliation");
        }
    }
}
