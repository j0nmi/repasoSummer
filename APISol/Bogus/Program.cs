using Context;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Bogus
{
    class Bogus
    {
        private readonly Bogus _context;

        public Bogus(ApplicationDbContext context)
        {
            _context = context;
        }
        static void Main()
        {
            var faker = new Faker<Persona>()
                .RuleFor(p => p.Nombre, f => f.Name.FirstName())
                .RuleFor(p => p.Apellido, f => f.Name.LastName())
                .RuleFor(p => p.FechaNacimiento, f => f.Date.Past(30))
                .RuleFor(p => p.Telefono, f => f.Phone.PhoneNumber());

            var personasFicticias = faker.Generate(15);

            using (var context = new ApplicationDbContext())
            {
                context.AddRange(personasFicticias);
                context.SaveChanges();
            }

            Console.WriteLine("Registros ficticios creados y guardados en la base de datos.");
        }
    }
}