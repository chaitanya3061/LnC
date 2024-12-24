using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repositories.Interfaces;
using EmployeeManagementSystem.Services.Interfaces;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IReportPrinter _reportPrinter;

        public EmployeeService(IEmployeeRepository employeeRepository, IReportPrinter reportPrinter)
        {
            _employeeRepository = employeeRepository;
            _reportPrinter = reportPrinter;
        }

        public void addEmployee(Employee employee)
        {
            _employeeRepository.save(employee);
        }

        public Employee getEmployee(int id)
        {
            return _employeeRepository.getById(id);
        }

        public void terminateEmployee(int id)
        {
            var employee = _employeeRepository.getById(id);

            if (employee != null)
            {
                employee.Terminate();
                _employeeRepository.save(employee);
            }
        }

        public void printEmployeeDetailReportXML(Employee employee)
        {
            _reportPrinter.printEmployeeDetailReportXML(employee);
        }

        public void printEmployeeDetailReportCSV(Employee employee)
        {
            _reportPrinter.printEmployeeDetailReportCSV(employee);
        }
    }
}
