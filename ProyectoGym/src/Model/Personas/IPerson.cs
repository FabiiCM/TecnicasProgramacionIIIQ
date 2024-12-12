using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Personas
{
    /// <summary>
    /// Define el contrato para una persona en el sistema.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Propiedad para obtener o establecer la fecha de nacimiento de la persona.
        /// </summary>
        DateTime Birthday { get; set; }

        /// <summary>
        /// Propiedad para obtener o establecer el nombre de la persona.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Método para calcular la edad de la persona en años.
        /// </summary>
        /// <returns>Edad de la persona como un número entero.</returns>
        int CalcularEdad();
    }
}

