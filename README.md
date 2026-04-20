# Supplier Management POC (3-Tier Architecture)

## 📌 Overview

This is a **Proof of Concept (POC)** application designed for a cleaning products company to demonstrate a scalable supplier management system.

The solution is implemented as a **full 3-tier architecture** consisting of:

- 🎨 Frontend: React + TypeScript (Vite)  
- ⚙️ Backend: ASP.NET Core Web API (C#)  
- 🗄️ Database: Microsoft SQL Server (Developer Edition)  

---

## ⚠️ The frontend and backend are two completely independent projects.
They are not part of the same Visual Studio solution and must be run separately.

## 🧩 Database Structure

The system uses the following SQL Server table:

```sql
SELECT TOP (1000) [Code],
       [Name],
       [TelephoneNo]
FROM [SupplierPOC].[dbo].[Suppliers]
