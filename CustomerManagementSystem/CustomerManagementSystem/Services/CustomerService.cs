using CustomerManagementSystem.Models;
using CustomerManagementSystem.Repositories.Interfaces;
using CustomerManagementSystem.Services.Interfaces;

namespace CustomerManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> getByCountry(string country)
        {
            return _customerRepository.getByCountry(country);
        }

        public List<Customer> getByCompanyName(string company)
        {
            return _customerRepository.getByCompanyName(company);
        }

        public List<Customer> getByContact(string contact)
        {
            return _customerRepository.getByContact(contact);
        }
        public void add(Customer customer)
        {
            _customerRepository.add(customer);
        }

        public string exportToCSV()
        {
            return _customerRepository.exportToCSV();
        }

    }
}
