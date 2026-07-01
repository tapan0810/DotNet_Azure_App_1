# 🚀 ASP.NET Core Web API with Azure CI/CD

A production-ready ASP.NET Core Web API demonstrating CRUD operations with Entity Framework Core, SQL Server, and automated deployment to Azure App Service using GitHub Actions.

---

## 📌 Features

- ✅ ASP.NET Core Web API (.NET 10)
- ✅ RESTful CRUD APIs
- ✅ Entity Framework Core
- ✅ SQL Server Database
- ✅ Dependency Injection
- ✅ Repository/Service Pattern
- ✅ Swagger UI
- ✅ Azure App Service Deployment
- ✅ GitHub Actions CI/CD Pipeline

---

## 🛠 Tech Stack

- ASP.NET Core 10
- C#
- Entity Framework Core
- SQL Server
- Azure App Service
- GitHub Actions
- Swagger/OpenAPI

---

## 📁 Project Structure

```
DotNet_Azure_App_1/
│
├── Controllers/
├── Models/
├── Services/
├── Data/
├── Migrations/
├── Properties/
├── Program.cs
├── appsettings.json
└── DotNet_Azure_App_1.csproj
```

---

## ⚙️ Prerequisites

- Visual Studio 2022
- .NET 10 SDK
- SQL Server
- Azure Subscription
- GitHub Account

---

## 🚀 Getting Started

### Clone Repository

```bash
git clone https://github.com/tapan0810/DotNet_Azure_App_1.git
```

### Navigate to Project

```bash
cd DotNet_Azure_App_1
```

### Restore Packages

```bash
dotnet restore
```

### Apply Migrations

```bash
dotnet ef database update
```

### Run Project

```bash
dotnet run
```

---

## 📖 API Documentation

Swagger UI

```
https://localhost:xxxx/swagger
```

---

## ☁️ Azure Deployment

This project is automatically deployed to **Azure App Service** using **GitHub Actions**.

### CI/CD Workflow

Whenever code is pushed to GitHub:

- Checkout Repository
- Setup .NET SDK
- Restore Dependencies
- Build Project
- Publish Application
- Deploy to Azure App Service

The deployment pipeline is implemented using a GitHub Actions YAML workflow.

---

## 🔐 GitHub Secrets

Configure the following secret inside your GitHub repository.

| Secret Name | Description |
|-------------|-------------|
| AZURE_WEBAPP_PUBLISH_PROFILE | Azure App Service Publish Profile |

---

## 📦 Build

```bash
dotnet build
```

## Publish

```bash
dotnet publish -c Release
```

---

## 📷 Screenshots

- Swagger API
- Azure App Service
- GitHub Actions Pipeline
- Azure Portal Deployment

(Add screenshots here)

---

## 📈 Future Enhancements

- JWT Authentication
- Role-Based Authorization
- Docker Support
- Azure Key Vault
- Azure SQL Database
- Logging with Serilog
- Unit Testing
- Redis Caching

---

## 👨‍💻 Author

**Tapan Ray**

Software Engineer | ASP.NET Core | Azure | SQL Server | C#

GitHub: https://github.com/tapan0810

LinkedIn: https://www.linkedin.com/in/tapan-ray

---

## ⭐ Support

If you found this project useful, consider giving it a ⭐ on GitHub.