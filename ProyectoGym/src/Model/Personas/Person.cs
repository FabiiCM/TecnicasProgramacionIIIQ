using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Personas
{
    /// <summary>
    /// Representa a una persona con propiedades básicas como nombre y fecha de nacimiento.
    /// </summary>
    /// <remarks>
    /// Inicializa una nueva instancia de la clase <see cref="Person"/>.
    /// </remarks>

    public class Person
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento de la persona.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo de la persona.
        /// </summary>
        public required string NombreCompleto { get; set; } 

        /// <summary>
        /// Obtiene o establece la contraseña de la persona.
        /// </summary>
        public required string Contraseña { get; set; }

        /// <summary>
        /// Obtiene o establece el correo electrónico de la persona.
        /// </summary>
        public required string CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario de la persona.
        /// </summary>
        public required string NombreUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono de la persona.
        /// </summary>
        public string? Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece el rol de la persona.
        /// </summary>
        public string? Rol { get; set; }
    }
}


