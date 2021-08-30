using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Data;
using Works31.DataAccess;
using Works31.Models;

namespace Works31.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelsController:ControllerBase
        {
            private readonly IPersonelRepository  personelRepository;
            public PersonelsController(IPersonelRepository personelRepository)
            {
             this.personelRepository = personelRepository;
            }
        
    [HttpGet]
    public async Task<ActionResult<List<Personel>>> GetPersonels()
    {

            return await personelRepository.GetPersonels();

    }
        
    [HttpGet("{Id}")]
    public async Task<ActionResult<Personel>> GetPersonel(long id)
    {
        var personel = await personelRepository.GetPersonelById(id);
        
        if (personel == null) { return NotFound(); }
        return personel;
    }

        
        [HttpPost]
        public async Task<ActionResult<Personel>> CreatePersonel(Personel personel)
        {
           
            Personel p= await personelRepository.AddPersonel(personel);

                                    
            return CreatedAtAction(nameof(GetPersonel), new { id = p.Id }, p);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePersonel(long id, Personel personel)
        {
            if (id != personel.Id) { return BadRequest(); }

            if (!await personelRepository.isPersonelExist(id)) return NotFound();

             try
             {
              Personel p= await personelRepository.UpdatePersonel(personel);
             }
             catch (Exception)
   
             {
             throw;
             }
             return NoContent();
        }

       
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonel(long id)
        {
            
            if (!await personelRepository.isPersonelExist(id)) return NotFound();
            bool isDeleted = await personelRepository.DeletePersonel(id);
            if (!isDeleted) { return BadRequest(); }
            return NoContent();

        }
        
    }
}

 

    
    
    

