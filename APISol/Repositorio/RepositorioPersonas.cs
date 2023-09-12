using Entidades;
using Context;
using Microsoft.EntityFrameworkCore;

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

        // Listado de registros ordenado por nombre, devolviendo los 10 últimos mayores de 21 años
        public async Task<IEnumerable<Persona>> Obtener10()
        {
            var personasMayoresDe21 = await _context.personas.ToListAsync();

            var ultimosMayoresDe21 = personasMayoresDe21
                .Where(p => CalcularEdad(p.FechaNacimiento) > 21)
                .OrderBy(p => p.Nombre)
                .TakeLast(10)
                .ToList();

            return ultimosMayoresDe21;
        }




        // Calcular Edad Persona
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

    }
}
