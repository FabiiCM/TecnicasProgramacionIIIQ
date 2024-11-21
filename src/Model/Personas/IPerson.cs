using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Personas
{
    public interface IPerson
    {
        /// <summary>
        /// Propiedad para obtener o establecer el nombre de la persona.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Propiedad para obtener o establecer la fecha de nacimiento de la persona.
        /// </summary>
        DateTime Birthday { get; set; }

        /// <summary>
        /// Método para calcular la edad de la persona.
        /// </summary>
        /// <returns>Edad en años.</returns>
        int CalcularEdad();
    }
}
