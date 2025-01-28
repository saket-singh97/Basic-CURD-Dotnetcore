using System;
using System.Collections.Generic;
using EmployeeService.Models;
namespace EmployeeService.Functionality
{
    public interface IEmplyeeRepostory
    {
        
            List<Employee> GetEmployees();//we well get multiple records of employee
            int CreateEmployee(Employee emp);// we will save recored of employee in database 

            Employee GetEmployee(int id);//searching the record of employee using id. IMportant 
             
           int  DeleteEmployee(int id); //Employee record will be deleted on the basis of id.
           Employee UpdateEmployee(int id);//here we are updating the employee Important
    }
}