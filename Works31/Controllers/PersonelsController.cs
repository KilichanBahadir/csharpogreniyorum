using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Data;
using Works31.Models;

namespace Works31.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelsController:ControllerBase
        {
            private readonly JobApplicationContext jobApplicationContext;
            public PersonelsController(JobApplicationContext jobApplicationContext)
            {
             this.jobApplicationContext = jobApplicationContext;
            }
        
    [HttpGet]
    public async Task<ActionResult<List<Personel>>> GetPersonels()
    {

        var personels = await jobApplicationContext.Personels.ToListAsync(); 
        return personels;

    }
    [HttpGet("{Id}")]
    public async Task<ActionResult<Personel>> GetPersonel(long id)
    {
        var personel = await jobApplicationContext.Personels.FindAsync(id);
        
        if (personel == null) { return NotFound(); }
        return personel;
    }
        [HttpPost]
        public async Task<ActionResult<Personel>> CreatePersonel(Personel personel)
        {
            jobApplicationContext.Personels.Add(personel);
            await jobApplicationContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPersonel), new { id = personel.Id }, personel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePersonel(long id, Personel personel)
        {
            if (id != personel.Id) { return BadRequest(); }
            jobApplicationContext.Entry(personel).State = EntityState.Modified;
            try
            {
                await jobApplicationContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonelExists(id))
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

        private bool PersonelExists(long id) => jobApplicationContext.Personels.Any(p => p.Id == id);

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonel(long id)
        {
            var personel = await jobApplicationContext.Personels.FindAsync(id);
            if (personel == null)
            {
                return NotFound();

            }
            jobApplicationContext.Personels.Remove(personel);
            await jobApplicationContext.SaveChangesAsync();
            return NoContent();

        }
    }
}

 

    
    
    

