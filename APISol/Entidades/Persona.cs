using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre debe tener como máximo 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(50, ErrorMessage = "El apellido debe tener como máximo 50 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento debe ser una fecha válida")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [StringLength(25, ErrorMessage = "El teléfono debe tener como máximo 25 caracteres")]
        public string Telefono { get; set; }
    }
}