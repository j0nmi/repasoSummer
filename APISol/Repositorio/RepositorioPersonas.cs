using Entidades;
using Context;

namespace Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas 
    {

        private readonly ApplicationDbContext _context;

        public RepositorioPersonas(ApplicationDbContext context)
        {
            _context = context;
        }

        // Existe persona
        public bool PersonaExiste(Guid personaId)
        {
            return _context.personas.Any(p => p.id == personaId);
        }


        // Alta persona
        public async Task<Persona> AltaPersona(Persona nuevaPersona)
        {
            if (PersonaExiste(nuevaPersona.id))
            {
                Persona existePersona = _context.personas.First(p => p.id == nuevaPersona.id);
                existePersona.Nombre = nuevaPersona.Nombre;
                existePersona.Apellido = nuevaPersona.Apellido;
                existePersona.FechaNacimiento = nuevaPersona.FechaNacimiento;
                existePersona.Telefono = nuevaPersona.Telefono;
            }
            else
            {
                _context.personas.Add(nuevaPersona);
            }

            _context.SaveChanges();
            return nuevaPersona;
        }

        // Obtener Personas
        public async Task<IEnumerable<Persona>> ObtenerTodasPersonas()
        {
            return _context.personas;
        }

        // Obtener Una Persona
        public async Task<Persona> ObtenerPersona(Guid id)
        {

            return _context.personas.FirstOrDefault(p => p.id == id);
        }
    }
}
