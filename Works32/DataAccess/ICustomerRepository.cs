using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works32.Models;

namespace Works32.DataAccess
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(long id);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<Boolean> isCustomerExist(long id);
        Task<Boolean> DeleteCustomer(long id);
    }
}
