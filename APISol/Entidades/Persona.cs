using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        [Key]
        public string id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Telefono { get; set; }
    }
}