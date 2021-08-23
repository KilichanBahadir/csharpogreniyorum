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
        }
    [HttpGet]
    public async Task<ActionResult<List<Personel>>> GetPersonels()
    {

        var personels = await jobApplicationContext.Personels.ToListAsync(); //asıldeğişkeni çağırmak için personel üzerine metod uygulanır.
        return personels;

    }
    [HttpGet("{Id}")]
    public async Task<ActionResult<Personel>> GetPersonel(long id)
    {
        var personel = await jobApplicationContext.Personels.FindAsync(id);
        
        if (personel == null) { return NotFound(); }
        return personel;
    }
    

 }

    
    
    

