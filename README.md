# NEA Library Management System

A desktop library management application built using **C# (Windows Forms)** and **Microsoft SQL Server**. This application manages comprehensive library operations including book cataloging, reservation workflows, dynamic system settings, an undo stack for returns, late fee processing, and email notifications via SMTP.

---

## 🚀 Features

- **User Authentication:** Multi-role login (Student & Librarian) with hashed passwords.
- **Reservation Workflow:** Queue priority system allowing eligible students to reserve currently unavailable books with built-in active limits and auto-expiration[cite: 1].
- **Undo Stack:** Revert accidental book returns in the UI using a LIFO data structure[cite: 1].
- **Late Fee & Analytics Engine:** Automated overdue dynamic calculations and leaderboards for tracking top reading students[cite: 1].
- **Data Validation:** Strict ISBN-13 check digit validation using alternating weight algorithms[cite: 1].
- **Dynamic Settings Configuration:** Centralized management for fine rates, checkout durations, and reservation hold limits via system settings[cite: 1].
- **Email Notifications:** Automated email capabilities for user communication and password recovery.

---

## 📊 Core Technical Modules & Architecture

| Feature | Primary Database Entities | Core Technical Rules / Algorithms |
| :--- | :--- | :--- |
| **Reservation System** | `Reservation`, `BookCopy`, `Book`, `LibrarySettings` | • Max **1 active reservation** per student[cite: 1].<br>• Max **1 reservation** allowed per book title[cite: 1].<br>• Automatic expiration cleanup based on `Reservation Expire` setting[cite: 1]. |
| **ISBN-13 Check Digit** | `WishList` | • Alternating $1$ and $3$ weight multiplier algorithm for inputs[cite: 1].<br>• Verifies input string integrity before adding to wishlist[cite: 1]. |
| **Late Fee Engine** | `BookLoaned`, `Loan`, `LibrarySettings` | • Daily overdue fee calculation formula: $\text{Overdue Days} \times \text{DailyLateFee}$[cite: 1].<br>• Dynamically populated per system configuration settings[cite: 1]. |
| **Undo Stack (Returns)** | `BookLoaned`, `BookCopy` | • Uses LIFO `StaticStack` array data structure[cite: 1].<br>• Allows librarians to revert accidental book returns in form UI[cite: 1]. |
| **Leaderboard Analytics** | `Loan`, `BookLoaned`, `Student` | • SQL aggregation utilizing `COUNT()`, `GROUP BY`, and `OFFSET/FETCH` queries[cite: 1].<br>• Ranks top reading students within customizable date ranges[cite: 1]. |

---

## ⚙️ Key Subsystems & Logic

### Reservation System
- **Business Logic:** Students can reserve titles that have no available copies remaining. Only one active reservation per student and one reservation per book title is permitted simultaneously[cite: 1].
- **Lifecycle:** When a copy is checked back in, the pending reservation state switches to `Complete` and flags the book for pickup.
- **Expiration Handling:** An automated process runs on application launch to remove completed reservations exceeding the `Reservation Expire` day limit.

### ISBN-13 Validation Algorithm
- Strips hyphens and verifies that the provided input is a valid 13-digit string.
- Multiplies the first 12 digits alternating between $1$ and $3$, calculates the modulo 10 remainder, and verifies the final check digit before inserting records into the Wishlist table[cite: 1].

### Dynamic System Configuration (`LibrarySettings`)
Stored in a configurable database table so administrators can update global rules without rebuilding source code:
- **DailyLateFee:** Daily fine rate per overdue item[cite: 1].
- **DueDateTimeSpan:** Standard checkout duration in days.
- **Reservation Expire:** Days a completed reservation remains on hold before expiring[cite: 1].
- **StudentUsernameLength & SchoolDomain:** Input validation constraints.

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