using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Gestion
{
    /// <summary>
    /// Define el contrato para una membresía gestionada en el sistema.
    /// </summary>
    public interface IMembresia
    {
        /// <summary>
        /// Obtiene o establece el identificador del cliente asociado a la membresía.
        /// </summary>
        int ClienteID { get; set; }

        /// <summary>
        /// Determina si la membresía está por vencer según la fecha actual.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la membresía está por vencer; de lo contrario, <c>false</c>.
        /// </returns>
        bool EstaPorVencer();

        /// <summary>
        /// Obtiene o establece la fecha de inicio de la membresía.
        /// </summary>
        DateTime FechaInicio { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de vencimiento de la membresía.
        /// </summary>
        DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la membresía.
        /// </summary>
        int ID { get; set; }
    }
}
