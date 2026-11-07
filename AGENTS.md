# LEDGERSYNC AGENT CONSTRAINTS & DESIGN SYSTEM

## 1. Core Architecture & Stack
- Target: ASP.NET Core MVC (.NET 10.0 / .NET 8 compatible)
- Engine: Pure ADO.NET Architecture (Sprint 1: Static Views Only, No DbContext)
- Styling: Bootstrap 5.3 + Bootstrap Icons via CDN + AOS (Animate on Scroll) 2.3.4
- Currency & Locale: Pakistani Rupee (`PKR`), Metric Tons (`MT`), Bags (`Bardana`), Maunds.
- Trading Entities: Pakistani wholesale mills (e.g., Sabir Vegetable Oil, Faisal Feeds, Sh Sharif & Sons Multan).

## 2. UI/UX & Spacing Standards
- **Breathing Room:** Never cram components. Enforce minimum padding (`p-4` or `p-5`) on cards and `mb-4` to `mb-5` section separations.
- **Radius Hierarchy:** Outer wrapper cards = `rounded-3` (12px). Inner cards, inputs, selects, and buttons = `rounded-2` (8px). Badges = `rounded-1` or `rounded-pill`.
- **Card Nesting Ban:** Never place a `.card` inside another `.card`. Group inner sub-sections with clean borders (`border rounded-2 p-3 bg-light-subtle`) or responsive grid columns (`row g-3`).
- **Table Density:** Table rows must have comfortable padding (`py-3 ps-3`). Never use full-row background color fills (`table-success`, `table-danger`). Tint only status pills and delta text.
- **Scroll Animations:** All feature sections, cards, and data matrices must include subtle AOS attributes: `data-aos="fade-up"` with `data-aos-duration="600"`.
- **Auth Separation:** `/Account/Login` and `/Account/Register` MUST use `@{ Layout = "_AuthLayout"; }`. Do not render main application navbar or complex footers on authentication pages.
- **Tone & Aesthetic:** Light Slate theme. High contrast typography. Strictly zero crypto/Web3 jargon (no "Consensus Node", "Attestation Hash", or "Cryptographic Invariants").