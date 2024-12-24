using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repositories;
using EmployeeManagementSystem.Repositories.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Services.Interfaces;
using EmployeeManagementSystem.Services.Printers;

namespace EmployeeManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            IEmployeeRepository employeeRepository = new EmployeeRepository();
            IReportPrinter reportPrinter = new EmployeeReportPrinter();
            EmployeeService employeeService = new EmployeeService(employeeRepository, reportPrinter);

            var newEmployee = new Employee(1, "Nomula SaiChaitanya", "Software Engineer");

            employeeService.addEmployee(newEmployee);

            employeeService.printEmployeeDetailReportXML(newEmployee);

            employeeService.terminateEmployee(1);
            employeeService.printEmployeeDetailReportCSV(newEmployee);
        }
    }
}
