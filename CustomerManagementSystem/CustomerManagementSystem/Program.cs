using CustomerManagementSystem.Repositories.Interfaces;
using CustomerManagementSystem.Repositories;
using CustomerManagementSystem.Services.Interfaces;
using CustomerManagementSystem.Services;
using CustomerManagementSystem.Models;

namespace CustomerManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepo = new CustomerRepository();
            ICustomerService customerService = new CustomerService(customerRepo);

            Console.Write("Search by Country/Company/Contact: ");

            string searchTerm = Console.ReadLine();

            var customers = searchTerm.ToLower() == "country"
                ? customerService.getByCountry("India")
                : searchTerm.ToLower() == "company"
                    ? customerService.getByCompanyName("In Time Tec ")
                    : customerService.getByContact("Chaitanya");
        }
    }
}
