using System;

namespace Model.Personas
{
    /// <summary>
    /// Representa a una persona con propiedades básicas como nombre y fecha de nacimiento.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Person"/>.
        /// </summary>
        /// <param name="name">Nombre de la persona.</param>
        /// <param name="birth">Fecha de nacimiento de la persona.</param>
        public Person(string name, DateTime birth)
        {
            Name = name;
            Birthday = birth;
        }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento de la persona.
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Name { get; set; }
    }
}


