<h3 align="center">Wisej.Net TakeHome</h3>

## About The Project

This project is the take-home assessment for Wisej.Net/Ice Tea Group. I had never used C#/WiseJ.Net prior to this take home assessment so, there were learning curves.

If I had time to go back to the project, I would not focus on making the desktop responsive; instead opting for a fixed min-width, and anchor to the left/top for the container instead. And, for displaying the data, I would use the DataGridView instead of a Table View (w/ grid-columns).

This project used barebones C#/WiseJ.Net, EF6 for the ORM (to be compatible w/ .Net 4.8), and Microsoft SQL Server.

### Project Overview
#### Objective: Develop a small address manager application.
#### Requirements:
- <b>Data Management</b>:
Organizations: Include fields for name, street, zip, city, and country.
Staff: Include fields for title, first name, last name, phone number, and email.
Relationship: An organization can have 0, 1, or more employees.
- <b>Key Deliverables</b>:
Develop the solution using Wisej.NET and C#.
Implement data storage using SQLite (or a similar lightweight database).
Provide a simple UI for data display (e.g., grid view).
Implement a UI for adding and editing data.
Design a modern, clean base layout for the application.

### Prerequisites
1. Install Visual Studio 2022
2. Ensure that you have .NET versions 4.8 and 9.0
3. Install [WiseJ.net ](https://wisej.com/tools/installing-wisej-net/)
4. Make sure you have SQL Server installed

### Instructions to Run Locally on Visual Studio
1. Clone the repository
   ```sh
   git clone https://github.com/bobandash/iceteagroup_wisej.git
   ```
2. Change the working directory on Visual Studio to WisejWebApplication3 (the cloned repo).
3. Go to Tools --> NuGet Package Manager --> Package Manager Console
- Install the NuGet dependencies
   ```sh
   dotnet restore
   ```
- Update your local database to have the migrations
   ```sh
   Update-Database
   ```
4. Press F5 and the application should run

If you have any questions, please feel free to contact me at brucehsu1126@gmail.com.
   
