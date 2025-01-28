using EmployeeService.Functionality;
using EmployeeService.Models;
using EmployeeService.Database;

namespace EmployeeService.Properties
{
    public class EmployeeRepostory : IEmplyeeRepostory// if any class implementing the interface we have to define all the function of that class known as contract
    {
        DataAccessLayer _dataAccess;

        public EmployeeRepostory(DataAccessLayer dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public int CreateEmployee(Employee emp)
        {
            _dataAccess.Employees.Add(emp);//New record of employee of object is added 
            return _dataAccess.SaveChanges();//Save Changes Function will save the record in database
        }

        public int DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return _dataAccess.Employees.ToList();
        }

        public Employee UpdateEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}