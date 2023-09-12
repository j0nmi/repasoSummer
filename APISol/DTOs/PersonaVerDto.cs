using System.ComponentModel.DataAnnotations.Schema;

namespace DTOs
{
    public class PersonaVerDto
    {
        public Guid id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        [NotMapped]
        public string resumenPersona
        {
            get
            {
                return $"{Nombre} {Apellido} | {FechaNacimiento} | {Telefono}";
            }
        }
    }
}