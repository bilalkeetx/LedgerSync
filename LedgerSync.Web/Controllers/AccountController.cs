using Microsoft.AspNetCore.Mvc;

namespace LedgerSync.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string? email, string? password, string? fiscalYear, string? role)
        {
            // Static presentation flow: Redirect to Home upon submission
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string? tenantName, string? email, string? password, string? fiscalYear, string? role)
        {
            // Static presentation flow: Redirect to Login upon registration
            return RedirectToAction("Login");
        }
    }
}
