using System;
using EmployeeService.Models;

namespace EmployeeService.Database;

    public static class DBInitializerSeedData
    {
        public static void InitializeDatabase(DataAccessLayer bLobDbContext)
        {
            if (bLobDbContext.Employees.Any())
                return;

            var blogOne = new Employee
            {
                Name = "c#",
                
            };
            var blogTwo = new Employee
            {
                Name = "web api",

            };
            var blogThree = new Employee
            {
                Name = "Blazor",
            };

            bLobDbContext.Employees.Add(blogOne);
            bLobDbContext.Employees.Add(blogTwo);
            bLobDbContext.Employees.Add(blogThree);

            bLobDbContext.SaveChanges();
        }
    }
