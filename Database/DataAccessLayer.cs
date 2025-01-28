using EmployeeService.Models;

//Implementing Ef Core To define Access layer 
using Microsoft.EntityFrameworkCore;//DbContext , DbSet 

namespace EmployeeService.Database
{
    public class DataAccessLayer : DbContext
    {
        public DataAccessLayer(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //We can connect to database with the help of on configuring function
            //optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=SaketDb;User Id=sa;Password=Saket!Password;TrustServerCertificate=True;");
        }

        public DbSet<Employee>? Employees { get; set; }//Employee Refer to table and we can perform all the operation by employee object 

        

    }
}