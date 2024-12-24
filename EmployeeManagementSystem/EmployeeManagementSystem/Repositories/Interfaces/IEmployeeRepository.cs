using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        void save(Employee employee);
        Employee getById(int id);
        List<Employee> getAll();
    }
}
