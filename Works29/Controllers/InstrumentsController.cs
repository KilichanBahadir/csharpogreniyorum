using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works29.Data;
using Works29.Models;

namespace Works29.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase

    {
        private readonly InstrumentContext _instrumentContext;
        public InstrumentsController(InstrumentContext instrumentContext)
        {
            _instrumentContext = instrumentContext;
        }




        [HttpGet]
        public async Task<ActionResult<List<Instrument>>> GetInstruments()
        {
            var instruments = await _instrumentContext.Instruments.ToListAsync();
            return instruments;

        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Instrument>> GetInstrument(long id)
        {
            var instrument = await _instrumentContext.Instruments.FindAsync(id);
            if (instrument == null) { return NotFound(); }
            return instrument;
        }
        [HttpPost]
        public async Task<ActionResult<Instrument>> CreateInstrument(Instrument instrument)
        {
            _instrumentContext.Instruments.Add(instrument);
            await _instrumentContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInstrument), new{ id = instrument.Id},instrument);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateInstrument(long id,Instrument instrument)
        {
            if (id != instrument.Id) { return BadRequest(); }
            _instrumentContext.Entry(instrument).State = EntityState.Modified;
            try
            {
                await _instrumentContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumentExists(id))
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

        private bool InstrumentExists(long id)=>_instrumentContext.Instruments.Any(i => i.Id == id);
        
        [HttpDelete("{id}")] 
        public async Task<ActionResult> DeleteInstrument(long id)
        {
            var instrument = await _instrumentContext.Instruments.FindAsync(id);
            if (instrument == null)
            {
                return NotFound();

            }
            _instrumentContext.Instruments.Remove(instrument);
            await _instrumentContext.SaveChangesAsync();
            return NoContent();

        }

        
    }

}

