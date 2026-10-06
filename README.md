StudentAPI - ASP.NET Core 8 REST API
A clean, RESTful Student Management API built with ASP.NET Core 8, Entity Framework Core In-Memory Database, and Swagger (OpenAPI 3.0) documentation.
.NET Swagger License
Live Swagger UI: http://localhost:5120/swagger

 Features
* Full CRUD for Students
* Entity Framework Core InMemory (no external DB needed)
* Swagger UI auto-generated docs
* RESTful best practices with proper status codes (200, 201, 204, 404)
* CORS enabled & ready for frontend integration
 Tech Stack
* Framework: ASP.NET Core 8.0 Web API
* Database: EF Core InMemory
* Documentation: Swashbuckle.AspNetCore / Swagger
* Language: C#
   Project Structure

StudentAPI/
├── Controllers/
│   └── StudentsController.cs   # All CRUD endpoints
├── Models/
│   └── Student.cs              # Student entity
├── Data/
│   └── ApplicationDbContext.cs # EF InMemory context
├── Program.cs                  # App startup & DI
└── StudentAPI.csproj
 Getting Started
Prerequisites
* .NET 8 SDK installed
* Visual Studio 2022 or VS Code
1. Clone & Restore
powershell
git clone https://github.com/your-username/StudentAPI.git
cd StudentAPI/StudentAPI
dotnet restore
2. Run
powershell
dotnet run
You should see:



Now listening on: http://localhost:5120
Now listening on: https://localhost:7249
Application started. Press Ctrl+C to shut down.
Keep this terminal open!
3. Open Swagger

http://localhost:5120/swagger
 API Endpoints
Method	Endpoint	Description	Status
GET	/api/Students	Get all students	200 OK
POST	/api/Students	Create new student	201 Created
GET	/api/Students/{studentId}	Get student by ID	200 / 404
PUT	/api/Students/{studentId}	Update student	204 / 404
DELETE	/api/Students/{studentId}	Delete student	204 / 404
Model: Student
json
{
  "studentId": 1,
  "studentName": "Tumi M",
  "studentAge": 23,
  "studentEmail": "tumi@example.com"
}
 Example Requests
Create Student
http
POST /api/Students
Content-Type: application/json

{
  "studentName": "Tumi M",
  "studentAge": 23,
  "studentEmail": "tumi@test.com"
}
Get All
http
GET /api/Students
 Troubleshooting
Error: The build failed. Fix the build errors and run again. ... 'StudentAPI.exe' because it is being used by another process.
The old API is still running in background and locking the file.
Fix:
powershell
taskkill /F /IM StudentAPI.exe /T
Get-Process dotnet | Stop-Process -Force
dotnet clean
dotnet run
Always press Ctrl+C in the running terminal before rebuilding.
Error: ERR_CONNECTION_REFUSED / localhost:5120 refused to connect
Your API is not running. Make sure the terminal says Now listening on: http://localhost:5120AND keep it open while browsing to /swagger.
Swagger not loading on https? Use http: http://localhost:5120/swagger instead of https. Or trust the dev cert:
powershell
dotnet dev-certs https --trust
 License
MIT License - free to use for assignments and portfolios.
 Author
Tumi M - Emalahleni, South Africa Built for ice task- 2026



