

# DevSpot

DevSpot is a simple job posting web application built with ASP.NET Core MVC, Entity Framework Core, and ASP.NET Identity. It allows Employers to create and manage developer job postings, JobSeekers to browse available jobs, and Admins to oversee and moderate content.

---

## Features

- Role-based access control with three roles:  
  - Admin: Full access including moderation and management  
  - Employer: Can create, view, and delete their own job postings  
  - JobSeeker: Can view job postings  
- Job posting CRUD (Create, Read, Delete) operations  
- Secure authentication and authorization using ASP.NET Identity  
- Responsive UI built with Bootstrap 5  
- AJAX-based deletion for smooth user experience  
- Seeded default users and roles for easy setup  
- Repository pattern for data access abstraction  

---

## Technologies Used

- ASP.NET Core MVC  
- Entity Framework Core  
- ASP.NET Core Identity  
- Bootstrap 5  
- jQuery for AJAX  
- SQL Server (or other EF Core supported database)  

---

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download) or later  
- SQL Server or compatible database  
- Visual Studio 2022 / VS Code or any preferred IDE  

### Setup Instructions

1. Clone the repository:

   git clone https://github.com/yourusername/devspot.git
   cd devspot
Configure the database:

Edit appsettings.json to update the connection string to your database.

Run migrations and update database:

dotnet ef database update
Seed roles and users:

The project includes seeding logic for default roles and users in RoleSeeder and UserSeeder.
Ensure seeding is invoked on application startup (e.g., in Program.cs).

Run the application:

dotnet run
Access the app:

Navigate to https://localhost:5001 (or your configured port).

Default Seeded Users
Email	Password	Role
admin@devspot.com	Admin123!	Admin
employer@devspot.com	Employer123!	Employer
jobseeker@devspot.com	JobSeeker123!	JobSeeker

Note: Change seeded passwords for production.

Project Structure
Controllers/ - MVC controllers handling HTTP requests

Models/ - Data models including JobPosting

ViewModels/ - View models for form binding and validation

Views/ - Razor views for UI pages

Data/ - Database context and seeders

Repositories/ - Data access layer implementing repository pattern

Constants/ - Application constants like role names

Usage
Browse Jobs: All users (including anonymous) can view job postings.

Create Job Posting: Employers and Admins can create new job postings via a form.

Delete Job Posting: Employers can delete their own postings; Admins can delete any. Deletion happens with confirmation and AJAX UI update.

Authentication: Login and registration are handled via ASP.NET Identity.

Contribution
Contributions are welcome! Please fork the repository and submit pull requests.

License
This project is licensed under the MIT License. See LICENSE for details.

Author
Abdul Kader (Fahad)
Toronto, Canada
Email: hello.fahadkader@gmail.com
GitHub: https://github.com/hello-fahad
LinkedIn: https://linkedin.com/in/hello-fahad

Acknowledgments
ASP.NET Core Documentation

Bootstrap 5

Entity Framework Core

Thank you for checking out DevSpot! 
