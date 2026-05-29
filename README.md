# Accounting Management System

A robust and efficient desktop accounting application built with **C# Windows Forms**, utilizing **Entity Framework Core (Database-First approach)** and **SQL Server** for data persistence.

The system simplifies personal and small business financial management by enabling users to track transactions, manage contacts, and generate financial reports.

---

## ✨ Features

### 👥 Contact Management

* Create, update, and manage contacts.
* Store personal information such as:

  * Full Name
  * Address
  * Phone Number

### 💰 Transaction Processing

* Record financial transactions with ease.
* Support for:

  * Receivables (Income)
  * Payables (Expenses)
* Associate transactions with specific contacts.

### 📊 Comprehensive Reporting

* View detailed reports of:

  * Received transactions
  * Paid transactions
* Track financial activities over time.

### ✏️ Data Manipulation

* Edit existing records.
* Delete transactions and contacts when necessary.

### 🔍 Advanced Filtering & Search

* Search contacts quickly.
* Filter transaction reports based on different criteria.

---

## 📸 Screenshots

### Main Dashboard

<img width="726" height="395" alt="1" src="https://github.com/user-attachments/assets/8daf67a3-bd52-472c-b7a4-3530a4193eaa" />



### New Transaction

<img width="725" height="395" alt="2" src="https://github.com/user-attachments/assets/d884404f-f667-4f99-aacf-30e71d19fc43" />


### Transaction Report

<img width="727" height="395" alt="3" src="https://github.com/user-attachments/assets/9222c15e-f40b-4656-afd2-31f704bf524c" />


### Report Management

<img width="726" height="395" alt="4" src="https://github.com/user-attachments/assets/70351fe4-9473-492f-a180-78f245cf91e0" />



### Contacts List

<img width="1053" height="295" alt="5" src="https://github.com/user-attachments/assets/99a3fa88-db31-4157-99ea-b8a2c9c652c7" />



---

## 🛠️ Technical Stack

| Technology | Description                            |
| ---------- | -------------------------------------- |
| Language   | C#                                     |
| Framework  | .NET Windows Forms (WinForms)          |
| Database   | SQL Server                             |
| ORM        | Entity Framework Core (Database First) |

---

## 🚀 Getting Started

### Prerequisites

Before running the project, make sure you have:

* Visual Studio 2022 or later
* .NET SDK compatible with the project version
* SQL Server (LocalDB or SQL Server Instance)
* SQL Server Management Studio (SSMS)

---

## ⚙️ Installation

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/your-repository-name.git
```

### 2. Configure the Database

Open SQL Server Management Studio (SSMS) and execute the SQL script located in:

```text
/Database/schema.sql
```

This will create the required database tables.

### 3. Update the Connection String

Open the configuration file and update the connection string according to your SQL Server instance.

```xml
<connectionStrings>
    <add
        name="AccountingDbContext"
        connectionString="Data Source=YOUR_SERVER;Initial Catalog=AccountingDB;Integrated Security=True;"
        providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 4. Build and Run

1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Build the project.
4. Run the application.

---

## 📂 Project Architecture

* **Presentation Layer** → Windows Forms UI
* **Data Access Layer** → Entity Framework Core
* **Database Layer** → SQL Server
* **Database First Approach** → Models generated from existing database schema

---

## 🤝 Contributing

Contributions are welcome!

If you find a bug or have suggestions for improvements:

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Open a Pull Request.

---

## 📄 License

This project is intended for educational and portfolio purposes.
Feel free to modify and extend it according to your needs.
"# accounting-app" 
