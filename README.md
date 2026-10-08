# Employee Leave Management System

A simple desktop application developed using **C# Windows Forms** to manage employee leave requests.

The system allows employees to submit leave requests and administrators to view and manage those requests.

---

## Features

### Employee
- Employee login
- View employee information
- View available leave
- Submit leave requests
- Select leave type and date
- Enter a reason for leave

### Administrator
- Admin login
- View employee leave requests
- Search requests using Employee ID
- Search by leave type
- View leave history
- Update the status of leave requests

---

## Technologies Used

- **C#**
- **Windows Forms**
- **.NET Framework 4.7.2**
- **MySQL / MariaDB**
- **XAMPP**
- **phpMyAdmin**
- **Visual Studio**

---

## Database

The application uses a MySQL database called:

```text
LeaveManagementDB

The main tables are:

Employee
Request
State
Admin
How to Run
1. Install the Requirements

Make sure you have:

Visual Studio
.NET Framework 4.7.2
XAMPP
MySQL / MariaDB
2. Start MySQL

Open XAMPP Control Panel and start:

MySQL
3. Create the Database

Open phpMyAdmin:

http://localhost/phpmyadmin/

Create a database named:

LeaveManagementDB

Create the required tables inside the database.

4. Open the Project

Open the project in Visual Studio.

Make sure the MySQL connection string is:

Server=localhost;Port=3306;Database=LeaveManagementDB;Uid=root;Pwd=;
5. Run the Application

Build and run the project from Visual Studio.

Example Employee Accounts

For testing, you can use:

Employee ID	Name	Password
1001	Test Employee	123456
1002	Kasun Perera	123456
1003	Nimali Fernando	123456

These accounts are only for testing.

Project Structure
Employee Leave Management System
│
├── Employee Login
├── Employee Leave
├── Employee Request
├── Admin Login
├── Admin Request
├── Leave History
└── MySQL Database
Future Improvements

Some possible improvements are:

Password hashing
Better security
Email notifications
Leave approval and rejection notifications
Improved user interface
Employee leave history
Admin dashboard
Better error handling
Purpose

This project was created as an educational project to demonstrate:

C# programming
Windows Forms development
MySQL database integration
Database operations
User authentication
Leave management

Admin password
username - Admin
password - Admin@1234

Author - MDCADER
