# ST10443991_PROG6212_POE_Part1

Contract Monthly Claim System (CMCS) – .NET 9 Prototype

This project is a non-functional UI prototype for the Contract Monthly Claim System (CMCS). It demonstrates the user journey for lecturers to submit claims and for coordinators/managers to review them.

Note: This version is for UI demonstration only – no database, authentication, or business rules are implemented.

Tech Stack

.NET 9 (ASP.NET Core MVC)

Razor Views + simple CSS/JS

Prototype only: no EF Core, Identity, or persistence

Project Structure
src/CMCS.Web
├── Controllers (Home, Claims, Approvals)
├── Views (Dashboard, Claims, Approvals, Shared)
├── wwwroot (css, js)
├── Program.cs
└── CMCS.Web.csproj

Getting Started

Install .NET SDK 9.x
Check with: dotnet --info

Navigate to project:

cd src/CMCS.Web
dotnet run


Open in browser:

https://localhost:5001/

Features

Dashboard (/) with sample KPIs

Claims (/Claims) list, details, and new claim form

Approvals (/Approvals) with detail view

All data is mock/sample only.

Next Steps (Future Work)

Add database with EF Core

Implement authentication & roles

Enable workflow (Draft → Submitted → Approved)

Support file uploads and notifications

License

Prototype provided for academic use.
