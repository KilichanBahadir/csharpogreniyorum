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
        private readonly OnlineStoreContext onlineStoreContext;//  << asıl değişken
        public ProductsController(OnlineStoreContext onlineStoreContext)//<< parametre/değişken 
        {
            this.onlineStoreContext = onlineStoreContext;   
        }

        //OnlineStoreContext= sınıfı onlineStoreContext=değişkeni/instance (örnek)

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            
            var products = await onlineStoreContext.Products.ToListAsync(); //asıldeğişkeni çağrımak için product üzerine metod uygulanır.
            return products;

        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var product = await onlineStoreContext.Products.FindAsync(id);
            if (product == null) { return NotFound(); }
            return product;
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            onlineStoreContext.Products.Add(product);
            await onlineStoreContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(long id, Product product)
        {
            if (id != product.Id) { return BadRequest(); }
            onlineStoreContext.Entry(product).State = EntityState.Modified;
            try
            {
                await onlineStoreContext.SaveChangesAsync();
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

        private bool ProductExists(long id) => onlineStoreContext.Products.Any(p => p.Id == id);

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInstrument(long id)
        {
            var instrument = await onlineStoreContext.Products.FindAsync(id);
            if (instrument == null)
            {
                return NotFound();

            }
            onlineStoreContext.Products.Remove(instrument);
            await onlineStoreContext.SaveChangesAsync();
            return NoContent();

        }
    }
}
