using Microsoft.AspNetCore.Mvc;

namespace LedgerSync.Web.Controllers
{
    public class ReconciliationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            return View();
        }
    }
}
