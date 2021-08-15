using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using works27.Models;

namespace works27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
    {
        private List<Guitar> guitars = new List<Guitar>() {
            new Guitar()
            {
                Id = 1,
                Name = "Yamaha ",
                Model = "Fz400",
                Type = "Acoustic"
            },
        new Guitar()
            {
                Id = 2,
                Name = "Ibanez ",
                Model = "C70",
                Type = "Electro"
            },
        new Guitar()
            {
                Id = 3,
                Name = "Fender ",
                Model = "fl55",
                Type = "Acoustic"
            },
        new Guitar()
        {
        Id = 4,
        Name = "OcarScmith",
        Model = "S40",
        Type = "Bass"
        }

        };
        [HttpGet]
        public async Task<ActionResult<List<Guitar>>> GetGuitars()
        {


            return guitars;
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Guitar>> GetGuitar(int id)
        {
            var guitar = guitars.Find(x => x.Id == id);

            return guitar;
        }

        [HttpPost]
        public async Task<ActionResult<List<Guitar>>> CreateGuitar(Guitar guitar)
        {
            guitars.Add(guitar);

            return guitars; 
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Guitar>>> UpdateGuitar(Guitar guitar)
        {
            var updateguitar = guitars.Find(x => x.Id == guitar.Id);
            updateguitar.Id = guitar.Id;
            updateguitar.Name = guitar.Name;
            updateguitar.Model = guitar.Model;
            updateguitar.Type = guitar.Type;
            guitars.Remove(guitars.Find(x => x.Id == guitar.Id));
            guitars.Add(updateguitar);

            return guitars;
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Guitar>>> DeleteGuitar(int id)
        {
         
            guitars.Remove(guitars.Find(x => x.Id == id));
     

            return guitars;
        }
    }

    
}
