using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JQueryPage.Data;
using JQueryPage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JQueryPage.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        private static CustomerDto CustomerToDto(Customer customer) =>
            new()
            {
                Id = customer.Id,
                Name = customer.Name,
                Drink = customer.Drink

            };


        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {
            var customerItem = await _context.Customers.FindAsync(id);
            if (customerItem == null)
                return NotFound();

            return CustomerToDto(customerItem);

        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            return await _context.Customers
                .Select(x => CustomerToDto(x))
                .ToListAsync();
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerItem(int id, CustomerDto customerDto)
        {
            if (id != customerDto.Id)
                return BadRequest();

            Customer customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return NotFound();

            customer.Name = customerDto.Name;
            customer.Drink = customerDto.Drink;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CustomerExists(id))
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDto>> CreateCustomerItem(CustomerDto customerDto)
        {
            var customer = new Customer
            {
                Name = customerDto.Name,
                Drink = customerDto.Drink,
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCustomer),
                new { id = customer.Id },
                CustomerToDto(customer)
                );
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return NotFound();

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id) =>
          _context.Customers.Any(e => e.Id == id);


    }

}
