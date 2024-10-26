# DemoRazorPageWorkWithJson-XML

## Introduction

The **DemoRazorPageWorkWithJson-XML** project is a web application built using ASP.NET Razor Pages, designed for managing data with JSON and XML formats. This application allows users to add, edit, delete, and display student, course, and enrollment information while supporting the import and export of data in JSON and XML files.

## Features

- **Data Management**: Manage student, course, and enrollment information.
- **File Upload**: Upload JSON or XML files to import data into the system.
- **User-Friendly Interface**: An intuitive interface for performing CRUD operations on data.
- **Dynamic Data Loading**: Load and display data dynamically from JSON and XML files.

## Technologies Used

- **ASP.NET Razor Pages**: For creating dynamic web pages and managing data.
- **Entity Framework**: To interact with the database.
- **JSON and XML**: For data storage and transfer.

## Installation

1. **Clone the Repository**: 
    ```bash
    git clone https://github.com/hieuvuanguday/DemoRazorPageWorkWithJson-XML.git
    cd DemoRazorPageWorkWithJson-XML
    ```

2. **Open the Project in Visual Studio**: 
    - Open the solution file in Visual Studio.

3. **Install Required NuGet Packages**: 
    - Open the Package Manager Console and run:
    ```bash
    Install-Package Microsoft.EntityFrameworkCore
    Install-Package Microsoft.EntityFrameworkCore.SqlServer
    Install-Package Microsoft.AspNetCore.Razor.Design
    ```

4. **Run the Application**: 
    - Set up the connection string in `appsettings.json` if needed.
    - Press F5 to run the application.

## How to Use

- **Student Management Page**: Allows adding, editing, deleting, and viewing student information.
- **Course Management Page**: Allows adding, editing, deleting, and viewing course information.
- **Enrollment Page**: Manage student enrollment information in courses.
- **File Upload**: Import data by uploading JSON or XML files.

## Contribute

Contributions are welcome! If you would like to enhance this project, please create a pull request or open an issue to discuss your ideas.

## Contact

- **Name**: The Hieu (Ryan)  
- **Email**: dothehieu.92.20172018@gmail.com
