using CustomerManagementSystem.Models;

namespace CustomerManagementSystem.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> getByCountry(string country);
        List<Customer> getByCompanyName(string company);
        List<Customer> getByContact(string contact);
        string exportToCSV();
        void add(Customer customer);
    }
}
