# Student & Teacher Management System - Windows Forms + SQL Server 🎓🧑‍🏫

## 📋 Project Description

This is a **Windows Forms Application** developed using **C#** and connected to a **SQL Server database**.  
The application represents an **Admin Dashboard** that allows managing both **Teachers** and **Students**.

The dashboard contains two main buttons:
- **Teachers**: Displays a list of all teachers including First Name, Gender, Email, Salary, and other details.
- **Students**: Displays a list of all students including ID, Gender, GPA, and other details.

For both sections (Teachers and Students), the admin can:
- **Insert** new records.
- **Update** existing records.
- **Delete** records.
- **Search** by name or ID.
- **View** all data in a table format (DataGridView).

## ⭐ Features

- Built with **C# and Windows Forms**.
- Connected to a **SQL Server database**.
- Clean and simple user interface.
- Full **CRUD** operations (Create, Read, Update, Delete).
- Search functionality for both Teachers and Students.
- Organized and modular code using **OOP** principles.

## ⚙️ Requirements

- Visual Studio
- SQL Server (any edition, including SQL Server Express)
- .NET Framework compatible with Windows Forms

## ▶️ How to Run the Project

1. **Open the Solution:**
   - Open the project in **Visual Studio**.

2. **Set up the Database:**
   - Open **SQL Server Management Studio (SSMS)**.
   - Execute the provided SQL script (`database_script.sql`) to create the database and necessary tables.
   - Note the connection string parameters (server name, database name, authentication).

3. **Configure the Connection String:**
   - Update the connection string in `App.config`:
     ```xml
     <connectionStrings>
       <add name="MyConnection" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True" providerName="System.Data.SqlClient"/>
     </connectionStrings>
     ```

4. **Build and Run the Project:**
   - Click **Build** then **Start** to run the project.
   - The admin dashboard will appear with two main options: **Teachers** and **Students**.

5. **Use the Application:**
   - Manage data with Insert, Update, Delete, and Search functions.
   - View data directly in tables.

## 🖼️ Screenshots

[Admin Dashboard Screenshot](![admin main](https://github.com/user-attachments/assets/4d57c361-4612-4971-93e7-3e422656a4bc)
)

# 🧑‍🏫 Teachers Dashboards
[Teachers main Dashboard Screenshot](![Teach main](https://github.com/user-attachments/assets/5b064923-7e7b-4b5c-b6f0-27b426f6b864)
)

[Display Teachers List Screenshot](![display teach](https://github.com/user-attachments/assets/62b1604c-b985-402c-b228-7ddaf7fa58f3)
)

[Manage Teachers Dashboard Screenshot](![manage teach](https://github.com/user-attachments/assets/1f0f60ff-ce9f-414e-94b1-dce1e61f9ee8)
)

# 🧑‍🎓 Students Dashboards
[Students main Dashboard Screenshot](![image](https://github.com/user-attachments/assets/738af072-3626-4b53-94b6-5daa2f875dea)
)

[Display Students List Screenshot](![image](https://github.com/user-attachments/assets/4fabbd74-4867-43d0-a0e6-d6747cf20375)
)

[Manage Students Dashboard Screenshot](![asdasd](https://github.com/user-attachments/assets/e56b02a1-c42f-4a00-a45c-ac05fba388f6)
)

## 📝 Notes

- Make sure **SQL Server** is running before launching the application.
- This project demonstrates practical integration of **frontend** (Windows Forms) and **backend** (SQL Server) using **C#**.

---

**This project was created as part of a university assignment to demonstrate database connectivity and CRUD operations using Windows Forms and SQL Server.**

