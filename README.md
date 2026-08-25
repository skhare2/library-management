# NEA Library Management System

A desktop library management application built using **C# (Windows Forms)** and **Microsoft SQL Server**. This application manages library operations including book cataloging, student/librarian user accounts, login authentication (with SHA-256 password hashing), and email notifications via SMTP.

---

## 🚀 Features

- **User Authentication:** Multi-role login (Student & Librarian) with hashed passwords.
- **Library Management:** Catalog books, manage borrowing records, and update user accounts.
- **Email Notifications:** Automated email capabilities for user communication and password recovery.
- **Database Backend:** SQL Server integration for robust data storage and query execution.

---

## 🛠️ Tech Stack & Prerequisites

- **Language / Framework:** C# (.NET / Windows Forms)
- **Database:** Microsoft SQL Server (or SQL Server Express)
- **Packages:** `Microsoft.Data.SqlClient`

---

## 🔧 Setup & Installation

To run this application on your local machine:

### 1. Database Setup
1. Open **SQL Server Management Studio (SSMS)** or Visual Studio's SQL Server Object Explorer.
2. Open and execute the included `DatabaseSetup.sql` script to generate the `Library` database, necessary tables, and default seed data.

### 2. Configure Connection String
1. Open `NEALibrary\DatabaseConnection.cs`.
2. Update the `ConnectionString` variable with your local SQL Server instance name:
   ```csharp
   private static readonly string ConnectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True;";