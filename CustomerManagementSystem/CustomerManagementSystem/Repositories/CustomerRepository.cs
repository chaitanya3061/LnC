using CustomerManagementSystem.Models;
using CustomerManagementSystem.Repositories.Interfaces;
using System.Text;

namespace CustomerManagementSystem.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public List<Customer> getByCountry(string country)
        {
            return customers.Where(c => c.Country.Contains(country, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Customer> getByCompanyName(string companyName)
        {
            return customers.Where(c => c.CompanyName.Contains(companyName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Customer> getByContact(string contactName)
        {
            return customers.Where(c => c.ContactName.Contains(contactName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void add(Customer customer)
        {
            customers.Add(customer);
        }

        public string exportToCSV()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in customers)
            {
                sb.AppendFormat("{0},{1},{2},{3}", item.CustomerID, item.CompanyName, item.ContactName, item.Country);
                sb.AppendLine();  
            }

            return sb.ToString();

        }
    }
}
