# Supplier Management POC (3-Tier Architecture)

## 📌 Overview
This is a **Proof of Concept (POC)** application designed for a cleaning products company to demonstrate a scalable supplier management system.

The solution is implemented as a **full 3-tier architecture** consisting of:

- 🎨 **Frontend**: React + TypeScript (Vite)
- ⚙️ **Backend**: ASP.NET Core Web API (C#)
- 🗄️ **Database**: Microsoft SQL Server (Developer Edition)

---

## 🧩 Database Structure

The system uses the following SQL Server table:

```sql
SELECT TOP (1000) [Code],
       [Name],
       [TelephoneNo]
FROM [SupplierPOC].[dbo].[Suppliers]

## ⚠️ Running the Frontend and Backend

Although both the **SupplierFrontend (React + TypeScript)** and **SupplierApi (C# Web API)** are located within the same repository/folder structure, they are completely separate applications and must be run independently.

### ▶️ Backend (SupplierApi)
- Navigate to the `SupplierApi` project folder
- Run the API using:
```bash
dotnet run
