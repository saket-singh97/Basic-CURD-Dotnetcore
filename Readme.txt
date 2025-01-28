Case Study 1
1.We have to create Service in CorewebApi for EmployeeTable To Perform all the operation Like 
 1)Insert,Update, Delete,Search etc 
2.Ef Core (Entity FramWork Core Provide pacage known as library which consist several classes help to communicate with backend(SQL Server))
3.We have packages for EFCore 
  1.dotnet add package Microsoft.EntityFrameworkCore
  2.dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  3.dotnet add package Microsoft.EntityFrameworkCore.Tools
  4.dotnet add package Microsoft.EntityFrameworkCore.Design
5.Example to install the above package 
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  dotnet add package Microsoft.EntityFrameworkCore.Tools
  dotnet add package Microsoft.EntityFrameworkCore.Design
6.dotnet restore
7.dotnet build to compile 
8.Dotnet CorewebApi gives by default weatherforcost end poin to show the temprature.
9. Dotnet watch run to start the server and run the code 

--------------------------------------------------
 to Devlop the appication i have take the certain function
 1.Models
 2.Functionality
 3.Repositry
 4.Database
 5.Controller


 ---------------Date 16-10-2024------------------------
1.We are creating our own controller that is EmplyeeController to create the end point 
2.To enable the EmplyeeController we have to configure in program.cs file.
  2.1-builder.Services.AddControllers();
  2.2-app.MapControllers();
3.To enable to ef core one time 
  dotnet tool install --global dotnet-ef --version 8.0.4

  this is the commond to configure the core only one time.  
dotnet ef ->is the commond used with data base an also can we check ef core is working or not.

-----------------18/10/2024(Threading , properties,delegate,TPL,Inheritance ,Garbage,Generics)---------------------
Finally in last session We have configure EF core.
1)EF core is a package help to communicate backed 
 there are two approach provided by ef core to cummunicate backend
  a)Code first approach (Checks fundamental )
    * Code first means we are generating the database dynamically with the help of migration technique
    * there are few classes provided by ef core plays a major role
       -> DbContext---DbContext class support tranction menas we can perfrom insert update delet with the help of savechanges functio  (predefindend function).
                     It also help to communicate backend 
                     DbContext class support inheritance and most of the fuction of this class are virtual
                     If any function mark as a virtual mens we have to override those methods and customize according to our need 
                     overAll to use Db context class we have to go "inheritance" 
         Example-
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //We can connect to databse with the help of on configuring function
            optionsBuilder.UseSqlServer("");
        }


       -> DbSet---DbSet is Generics class , need to search , fetch menas i want to perform retariva process.In this casem DbSet class play a major role.
                  DbSet does not support Sql query .It support linkQuery to perform the operation to perform the operation.
  b)Database first approach (mainly use in project)


---------------date 19-10-2024-------------------
Finally we define the data access layer and we have to use 
  a)DbContext- Defined in last session.Overall DbContext referst o database.
  b)DbSet-It refers to table .it point to table 

public DbSet<Employee> Employees {get;set;}
   Remark: DbSet It is a generating class takes parameter as a model known as employee.
           Employees is an object of DbSet class refert to table in database.
           By the getter and setter we can access private variable in the class 

Now we can apply migration technique  to create database and table dynamically.
There are 2 syntax avilable for migration 
1.Dotnet ef migration add phase1(Shekhar)
   This commond will generate migrations folder and Generics script file.
2.Dotnet ef database update
    this commond make the table in database

--------------date 22-10-2024-------------
1->Finally we have to use migration technique to create database and table dynamically.So database and table created 
2->Now we have to work on Functionality part known as operation against to database tables so 
3-> so we need to create interface for providing list of operations and we can access the interface from the controller to create table

Can you explain  the architure of the project of .net core?
 I am giving the demeo of 2 tables.(Employee table , Department table )
i)1.Model folder have all the classess will have all the classes concerns to both tables.

ii)Functionality/operations folder
1. We will provide list of interfaces for  employee and department.

iii)Repositry/Service folder:
1.We will define all the classes and implement frojm the respective intervace

------------------------date 24-10-2024--------------------------------

a)Finally we have discuss in last session, request flow architure.
b)Browser to     controller .............interface...........EmployeeRepository.............DataAccessLayer...........Employee(table).
                  compleated            compleated             nocompleated                      Done              table Created (migration)                    

--------------------date 27-10-22024------------------
In last session we are success full to fecth the data from database Now
Performing the most Important function to save the data

Q.Can you Write the suyntax of EFCore to save the record in database****Most Important
 public int CreateEmployee(Employee emp)
        {
            dataAccess.Employees.Add(emp);//New record of employee of object is added 
             dataAccess.SaveChanges();//Save Changes Function will save the record in database
        }



