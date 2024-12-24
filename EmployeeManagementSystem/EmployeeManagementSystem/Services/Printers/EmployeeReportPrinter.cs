using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services.Interfaces;

namespace EmployeeManagementSystem.Services.Printers
{
    public class EmployeeReportPrinter : IReportPrinter
    {
        public void printEmployeeDetailReportXML(Employee employee)
        {
            Console.WriteLine($"Employee Detail Xml Report for {employee.Name}:");
            Console.WriteLine($"ID: {employee.Id}, Department: {employee.Department}, Active: {employee.IsWorking}");
        }

        public void printEmployeeDetailReportCSV(Employee employee)
        {
            Console.WriteLine($"Employee Detail Csv Report for {employee.Name}:");
            Console.WriteLine($"ID: {employee.Id}, Department: {employee.Department}, Active: {employee.IsWorking}");
        }
    }
}
