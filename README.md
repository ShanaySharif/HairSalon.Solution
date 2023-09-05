Eau Claire's Salon
By Shankaron Mohamed 
## Technologies Used
- C#
- Entity Framework Core
- MySQL Workbench
- Razor
- ASP.NET Core MVC
- Command Line
- VS Code
- .NET6

Description

This application enables Claire, a friend of Pierre (please refer to the Pierre's Bakery project), to efficiently oversee her team of stylists and their clientele. As the salon owner, Claire can effortlessly maintain a comprehensive list of stylists employed at her establishment. Moreover, for each stylist, she has the ability to manage their respective clients. The application empowers users to seamlessly create, add, edit, and delete both stylists and clients.

## Setup Instructions
- Open your shell of choice (e.g., Terminal or GitBash) and run these commands:
Clone the project using $ git clone https://github.com/user/Salon.Solution.git
- Navigate to the root directory (HairSalon.Solution)
- Run $ touch .gitignore
- Copy/paste this into the .gitignore file: obj bin appsettings.json
- Importing the MySQL Database:
- Open MySQL Workbench, in the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File.
- Navigate to the sql file located in the root directory of this project called lindsay_warr.sql
- Under Default Schema to be Imported To, select the New button.
- Choose a name for your database, or simply use Shankaron_Mohamed.sql and
Click OK
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
- After you are finished with the above steps, reopen the Navigator > Schemas tab.
- Right click and select Refresh All.
- Your new database will appear!
- Navigate to this project's production directory (HairSalon) using $ cd HairSalon.
- Within the production directory create a new file called appsettings.json.
- In appsettings.json, paste in the following code, replacing your_database, user-id, and password values with your newly created database name, own username and password for MySQL (remove square brackets when inputting your details): {   "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[your_database];uid=[user-id];pwd=[password];"   } }
Within the production directory (HairSalon), run dotnet watch runto start the application in development mode with a watcher.
## Known Bugs
None

License
MIT License Copyright (c) 2023 Shankaron Mohamed 
