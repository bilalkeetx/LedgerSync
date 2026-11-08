using LedgerSync.Web.Models;
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
        // GET: /Account/ForgotPassword
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // POST: /Account/ForgotPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // In production with SQL/ADO.NET, verify email existence and store a secure 6-digit OTP or GUID token.
            // Generate mock secure token for now:
            var resetToken = Guid.NewGuid().ToString("N")[..8].ToUpper();

            // Set TempData so the verification screen can prefill or display test credentials
            TempData["UserEmail"] = model.Email;
            TempData["DemoToken"] = resetToken; // For easy local testing without SMTP server

            return RedirectToAction(nameof(ResetPassword), new { email = model.Email });
        }

        // GET: /Account/ResetPassword
        [HttpGet]
        public IActionResult ResetPassword(string? email)
        {
            var model = new ResetPasswordViewModel
            {
                Email = email ?? TempData["UserEmail"]?.ToString() ?? string.Empty
            };
            return View(model);
        }

        // POST: /Account/ResetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // In production with ADO.NET:
            // 1. Validate token from database
            // 2. Hash new password (e.g. BCrypt / Argon2 / PBKDF2)
            // 3. Execute UPDATE Users SET PasswordHash = @Hash WHERE Email = @Email

            TempData["SuccessMessage"] = "Your desk password has been successfully reset. Please sign in.";
            return RedirectToAction(nameof(Login));
        }
    }
}
