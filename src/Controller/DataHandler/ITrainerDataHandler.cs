using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DataHandler
{
    /// <summary>
    /// Contrato específico para manejar entrenadores.
    /// </summary>
    public interface ITrainerDataHandler
    {
        /// <summary>
        /// Obtiene los datos de entrenadores.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de entrenadores.</returns>
        List<string> GetEntrenadores();
    }
}
