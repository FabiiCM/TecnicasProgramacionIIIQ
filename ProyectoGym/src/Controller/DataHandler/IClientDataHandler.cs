using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DataHandler
{
    /// <summary>
    /// Contrato específico para manejar clientes.
    /// </summary>
    public interface IClientDataHandler
    {
        /// <summary>
        /// Obtiene los datos de clientes.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de clientes.</returns>
        List<string> GetClientes();
    }
}
