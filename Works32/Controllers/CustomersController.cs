using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works32.DataAccess;
using Works32.Models;

namespace Works32.Controllers

{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;
        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {

            return await customerRepository.GetCustomers();

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Customer>> GetCustomer(long id)
        {
            var customer = await customerRepository.GetCustomerById(id);

            if (customer == null) { return NotFound(); }
            return customer;
        }


        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {

            Customer c = await customerRepository.AddCustomer(customer);


            return CreatedAtAction(nameof(GetCustomer), new { id = c.Id }, c);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCustomer(long id, Customer customer)
        {
            if (id != customer.Id) { return BadRequest(); }

            if (!await customerRepository.isCustomerExist(id)) return NotFound();

            try
            {
                Customer c = await customerRepository.UpdateCustomer(customer);
            }
            catch (Exception)

            {
                throw;
            }
            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(long id)
        {

            if (!await customerRepository.isCustomerExist(id)) return NotFound();
            bool isDeleted = await customerRepository.DeleteCustomer(id);
            if (!isDeleted) { return BadRequest(); }
            return NoContent();

        }

    }
}
