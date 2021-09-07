using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works32.Models;

namespace Works32.DataAccess
{
    public class CustomerRepository:ICustomerRepository
    {
        
        private readonly CRMDbContext _crmDbContext;
        public CustomerRepository(CRMDbContext crmDbContext)
        {
            _crmDbContext = crmDbContext;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _crmDbContext.Customers.AddAsync(customer);
            Customer c = new Customer();
            await _crmDbContext.SaveChangesAsync();
            c.Id = customer.Id;
            c.Name = customer.Name;
            c.PhoneNumber = customer.PhoneNumber;
            c.Address = customer.Address;
            c.TaxId = customer.TaxId;
            return c;

        }

        public async Task<bool> DeleteCustomer(long id)
        {
            if (!await isCustomerExist(id)) { return false; }
            try
            {
                Customer c = await _crmDbContext.Customers.FindAsync(id);

                _crmDbContext.Customers.Remove(c);
                await _crmDbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public async Task<Customer> GetCustomerById(long id)
        {
            return await _crmDbContext.Customers.FindAsync(id);
        }

        public async Task<List<Customer>> GetCustomers()

        {
            return await _crmDbContext.Customers.ToListAsync();

        }

        public async Task<bool> isCustomerExist(long id)
        {
            return await _crmDbContext.Customers.AnyAsync(c => c.Id == id);


        }

      

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _crmDbContext.Customers.Update(customer);
            Customer c = new Customer();
            await _crmDbContext.SaveChangesAsync();
            c.Id = customer.Id;
            c.Name = customer.Name;
            c.PhoneNumber = customer.PhoneNumber;
            c.Address = customer.Address;
            c.TaxId = customer.TaxId;
            return c;

        }


    }
}
