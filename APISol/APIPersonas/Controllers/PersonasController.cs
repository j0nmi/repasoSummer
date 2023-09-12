using Microsoft.AspNetCore.Mvc;
using Context; 
using Entidades;
using AutoMapper;
using DTOs;
using Repositorio;

namespace APIPersonas.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IRepositorioPersonas _repositorioPersonas;

        public PersonasController(ApplicationDbContext context, IMapper mapper, IRepositorioPersonas repositorioPersonas)
        {
            _context = context;
            _mapper = mapper;
            _repositorioPersonas = repositorioPersonas;
        }

        // GET: api/personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaVerDto>>> Index()
        {
            var listaPersonas = _mapper.Map<List<PersonaVerDto>>(await _repositorioPersonas.ObtenerTodasPersonas());
            return Ok(listaPersonas);
        }

        // GET: api/personas/{id}
        [HttpGet("{id}", Name = "GetPersonas")]
        public async Task<ActionResult<PersonaVerDto>> GetPersonas([FromRoute] Guid id)
        {
            var persona = await _repositorioPersonas.ObtenerPersona(id);
            if (persona == null)
            {
                return NotFound();
            }
            var personaDto = _mapper.Map<PersonaVerDto>(persona);
            return Ok(personaDto);
        }

        // GET: api/personas/ultimos10
        [HttpGet("ultimos10")]
        public async Task<ActionResult<IEnumerable<PersonaVerDto>>> GetUltimosMayoresDe21()
        {
            var ultimosMayoresDe21 = await _repositorioPersonas.Obtener10();

            var ultimosMayoresDe21Dto = _mapper.Map<List<PersonaVerDto>>(ultimosMayoresDe21);
            return Ok(ultimosMayoresDe21Dto);
        }

        // POST: api/Personas
        [HttpPost]
        public async Task<ActionResult<PersonaVerDto>> PostPersona([FromBody] PersonaAltaDto personaDto)
        {
            if (personaDto == null)
            {
                return BadRequest("Los datos de la persona son nulos.");
            }

            var nuevaPersona = _mapper.Map<Persona>(personaDto);
            var result = await _repositorioPersonas.AltaPersona(nuevaPersona);
            var resultDto = _mapper.Map<PersonaVerDto>(result);

            return Ok(personaDto);
        }
    }
}
