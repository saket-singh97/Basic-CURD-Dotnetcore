using EmployeeService.Database;
using EmployeeService.Functionality;
using EmployeeService.Properties;
using Microsoft.EntityFrameworkCore;
using EmployeeService.DynamicMigration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddTransient<IEmplyeeRepostory, EmployeeRepostory>();
builder.Services.AddDbContext<DataAccessLayer>
(
    t => t.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();   //internally at this point IHost interface is called implicitly 



//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
//app.UseHttpsRedirection();
app.MapControllers();


app.CreateDbIfNotExists();  //before the run command we have to add this line to create the database if it doesn't exist

app.Run();


