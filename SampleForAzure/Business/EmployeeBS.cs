using SampleForAzure.Models;

namespace SampleForAzure.Business
{
    public class EmployeeBS : IEmployeeBS
    {
        // Define business service methods for Employee here
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
           
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
                return new List<Employee>() { new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "" },
                new Employee { Id = 3, FirstName = "Bob", LastName = "Johnson", Email = "" }    

            };
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}