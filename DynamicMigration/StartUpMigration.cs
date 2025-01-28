using System;
using EmployeeService.Database;
using Microsoft.EntityFrameworkCore;

namespace EmployeeService.DynamicMigration;

    public static class StartUpMigration
    {
        public static void CreateDbIfNotExists(this IHost host)         //static is must for extension method
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var blogContext = services.GetRequiredService<DataAccessLayer>();

            try
            {
                blogContext.Database.EnsureCreated();
                blogContext.Database.Migrate();
                DBInitializerSeedData.InitializeDatabase(blogContext);
            }
            catch (Exception ex)
            {

                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError($"migration issue {ex.Message}");
            }
           
        }
    }