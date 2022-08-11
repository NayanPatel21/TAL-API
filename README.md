# TAL-API


Prerequisite:-
Visual Studio 2022 community
SQL server 

1. Git clone into local machine
 - Open git Bash
  - Navigate to local folder where you want to copy. : Like D:/TAL/API
  - Execute following command " git clone https://github.com/NayanPatel21/TAL-API.git"
  
2. After download the code change the connection string.
  - Update connection string in appsettings.json file into "TAL API" project
  - Open Package  manager Console in Visual studio
  - Run below command for initial data migration      
	 1. Update-Database
	 2. Add-Migration InitialMigration ( RUN this command if your db is not created and after run this command run "Update Database")
	 
3. You can run the unit test project.