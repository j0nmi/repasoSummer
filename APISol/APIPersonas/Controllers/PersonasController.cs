using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Context; 
using Entidades;

namespace APIPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            return await _context.personas.ToListAsync();
        }

        // GET: api/Personas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersona(Guid id)
        {
            var persona = await _context.personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return persona;
        }

        // POST: api/Personas
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
            _context.personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.id }, persona);
        }

        // PUT: api/Personas/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPersona(Guid id, Persona persona)
        //{
        //    if (id != persona.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(persona).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PersonaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // DELETE: api/Personas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePersona(Guid id)
        //{
        //    var persona = await _context.personas.FindAsync(id);
        //    if (persona == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.personas.Remove(persona);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool PersonaExists(Guid id)
        {
            return _context.personas.Any(persona => persona.id == id);
        }
    }
}
