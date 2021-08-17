using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works30.Data;
using Works30.Models;

namespace Works30.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly OnlineStoreContext _onlineStoreContext;
        public ProductsController(OnlineStoreContext onlineStoreContext)
        {
            _onlineStoreContext = onlineStoreContext;   
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _onlineStoreContext.Products.ToListAsync();
            return products;

        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var product = await _onlineStoreContext.Products.FindAsync(id);
            if (product == null) { return NotFound(); }
            return product;
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _onlineStoreContext.Products.Add(product);
            await _onlineStoreContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(long id, Product product)
        {
            if (id != product.Id) { return BadRequest(); }
            _onlineStoreContext.Entry(product).State = EntityState.Modified;
            try
            {
                await _onlineStoreContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool ProductExists(long id) => _onlineStoreContext.Products.Any(p => p.Id == id);

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInstrument(long id)
        {
            var instrument = await _onlineStoreContext.Products.FindAsync(id);
            if (instrument == null)
            {
                return NotFound();

            }
            _onlineStoreContext.Products.Remove(instrument);
            await _onlineStoreContext.SaveChangesAsync();
            return NoContent();

        }
    }
}
