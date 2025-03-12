using CustomerManagementSystem.Models;

namespace CustomerManagementSystem.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> getByCountry(string country);
        List<Customer> getByCompanyName(string companyName);
        List<Customer> getByContact(string contactName);
        string exportToCSV();
        void add(Customer customer);
    }
}
