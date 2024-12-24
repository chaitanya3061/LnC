using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees = new List<Employee>();

        public void save(Employee employee)
        {
           _employees.Add(employee); 
        }

        public Employee getById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> getAll()
        {
            return _employees;
        }
    }
}
