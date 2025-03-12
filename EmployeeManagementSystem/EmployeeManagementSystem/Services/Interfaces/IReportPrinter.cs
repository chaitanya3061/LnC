using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services.Interfaces
{
    public interface IReportPrinter
    {
        void printEmployeeDetailReportXML(Employee employee);
        void printEmployeeDetailReportCSV(Employee employee);
    }
}
