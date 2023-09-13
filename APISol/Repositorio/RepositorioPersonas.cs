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

        // Alta persona
        public async Task<Persona> AltaPersona(Persona nuevaPersona)
        {
            Persona existePersona = _context.personas.FirstOrDefault(p => p.id == nuevaPersona.id);
            Persona listaPersona = new Persona();
            if (existePersona == null)
            {
                listaPersona.id = Guid.NewGuid().ToString();
                listaPersona.Nombre = nuevaPersona.Nombre;
                listaPersona.Apellido = nuevaPersona.Apellido;
                listaPersona.Telefono = nuevaPersona.Telefono;
                listaPersona.FechaNacimiento = nuevaPersona.FechaNacimiento;

                _context.Add(listaPersona);
                _context.SaveChangesAsync();
            }
            return nuevaPersona;
        }

        // Obtener Personas
        public async Task<IEnumerable<Persona>> ObtenerTodasPersonas()
        {
            return _context.personas;
        }

        // Obtener Una Persona
        public async Task<Persona> ObtenerPersona(string personaId)
        {

            return _context.personas.FirstOrDefault(p => p.id == personaId);
        }

        // Listado de registros ordenado por nombre, devolviendo los 10 últimos mayores de 21 años
        public async Task<IEnumerable<Persona>> Obtener10()
        {
            var personasMayoresDe21 = await _context.personas.ToListAsync();

            var ultimosMayoresDe21 = personasMayoresDe21
                .Where(p => CalcularEdad(p.FechaNacimiento) > 21)
                .OrderBy(p => p.Nombre)
                .ToList();

            return ultimosMayoresDe21.TakeLast(10);
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
