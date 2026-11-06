# LEDGERSYNC SPRINT 1 RULES

### Framework & Constraints
1. Target: ASP.NET Core MVC (.NET 10.0 / .NET 8.0 compatible).
2. SPRINT 1 SCOPE: Static presentation views only. DO NOT write database models, DbContext, or SQL queries yet.
3. Styling: Bootstrap 5.3 + Bootstrap Icons via CDN. Clean, responsive layouts.
4. Routing: All links must use ASP.NET Tag Helpers (`asp-controller`, `asp-action`).

### Required Files to Populate:
- `LedgerSync.Web/Views/Shared/_Layout.cshtml`
- `LedgerSync.Web/Views/Home/Index.cshtml`
- `LedgerSync.Web/Views/Account/Login.cshtml`
- `LedgerSync.Web/Views/Account/Register.cshtml`
- `LedgerSync.Web/Views/Deals/Create.cshtml`
- `LedgerSync.Web/Views/Reconciliation/Index.cshtml`