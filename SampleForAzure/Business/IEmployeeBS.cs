using SampleForAzure.Models;

namespace SampleForAzure.Business
{
    public interface IEmployeeBS
    {
        // Define business service methods for Employee here
        public void AddEmployee(Employee employee);
        public Employee GetEmployeeById(int id);

        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(int id); 

        public List<Employee> GetAllEmployees();
        
    }
}