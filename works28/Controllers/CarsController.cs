using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using works28.Data;
using works28.Models;

namespace works28.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarContext _carContext;
        public CarsController(CarContext carContext)
        {
            _carContext = carContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            var cars= await _carContext.Cars.ToListAsync();

            return cars;
        }
        
        [HttpGet("{Id}")]
        public async Task<ActionResult<Car>> GetCar(long id)
        {
            var  car = await _carContext.Cars.FindAsync(id);
            if (car == null) { return NotFound(); }

            return  car;

        }

        [HttpPost]
        public async Task<ActionResult<Car>> CreateCar(Car car)
        {
            _carContext.Cars.Add(car);
            await _carContext.SaveChangesAsync();

           return CreatedAtAction(nameof(GetCar),new { id = car.Id },car);
        }
        
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateCar(long id,Car car)
        {
         if (id != car.Id) { return BadRequest(); }
            _carContext.Entry(car).State = EntityState.Modified;
            try
            {
                await _carContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
             if (!CarExists(id)) 
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
        private bool CarExists(long id) =>
     _carContext.Cars.Any(e => e.Id == id);
        
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteCar(long id)
        {
            var car = await _carContext.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            _carContext.Cars.Remove(car);
            await _carContext.SaveChangesAsync();

            return NoContent();

        }

    }
}
