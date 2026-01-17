# Identity Cookie Auth Demo (ASP.NET Core MVC)

A compact demo project built to showcase **ASP.NET Core Identity** with **cookie-based authentication** and **role-based authorization** (Admin).  
The goal is to demonstrate real-world Identity fundamentals with a clean, review-friendly codebase.

---

## ✨ Features

### Authentication
- User registration & login using ASP.NET Core Identity
- Cookie-based authentication (Identity cookie)
- Logout
- ReturnUrl flow (redirect back to the requested page after login/register)

### Authorization
- Protected pages using `[Authorize]` (Dashboard)
- Role-based authorization using `[Authorize(Roles = "Admin")]` (Admin area)
- Access denied page

### Admin Panel
- List all users
- Assign / remove **Admin** role from users (UI-based role management)
- Seeded **Admin** role and a default admin user for quick testing

### Diagnostics / Learning View
- Dashboard shows the current `ClaimsPrincipal` (claims created from the Identity cookie)

---

## 🧰 Tech Stack
- ASP.NET Core MVC
- ASP.NET Core Identity
- Entity Framework Core
- SQLite

---

## 🚀 Getting Started

### 1) Clone
git clone https://github.com/0Suphan0/Identity-App.git <br>


###  2) Run
dotnet restore <br>
dotnet tool install --global dotnet-ef <br>
dotnet ef database update <br>
dotnet run

## 🔑 Demo Credentials (Seeded)

A default admin account is seeded on application startup (for demo purposes only):

- **Admin**
  - **Email:** `admin@test.com`
  - **Password:** `Admin123!`

---

## 🧭 Useful Routes

- **Home:** `/`
- **Register:** `/Account/Register`
- **Login:** `/Account/Login`
- **Dashboard (Protected):** `/Home/Dashboard`
- **Admin Panel (Admin only):** `/Admin`
- **Admin User Management:** `/Admin/Users`

---

## 🖼️ Screenshots 

ProjectSS/ss1.png

## ✅ What this project demonstrates

- How ASP.NET Core Identity creates an authentication cookie on successful login
- How `[Authorize]` and `[Authorize(Roles = "Admin")]` work with cookie-based authentication
- How user–role relationships are stored and managed via `UserManager` and `RoleManager`
- A minimal but practical admin panel for user and role management

---

## 📌 Notes

This is a learning / portfolio project.

In a real production application:

- Admin credentials should **not** be hardcoded
- Secrets should be managed via **User Secrets**, **environment variables**, or a secure vault
- Additional security measures should be enabled, such as:
  - Email confirmation
  - Password reset flows
  - Two-factor authentication (2FA)
