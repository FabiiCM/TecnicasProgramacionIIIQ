using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Personas
{
    public interface ICliente : IPerson
    {
        /// <summary>
        /// ID único del cliente.
        /// </summary>
        int ClienteID { get; set; }

        /// <summary>
        /// ID de la membresía asociada al cliente.
        /// </summary>
        int MembresiaID { get; set; }

        /// <summary>
        /// Lista de IDs de clases reservadas por el cliente.
        /// </summary>
        List<int> ClasesReservadas { get; set; }

        /// <summary>
        /// Método para reservar una clase.
        /// </summary>
        /// <param name="claseID">ID de la clase a reservar.</param>
        void ReservarClase(int claseID);

        /// <summary>
        /// Método para cancelar una reserva de clase.
        /// </summary>
        /// <param name="claseID">ID de la clase a cancelar.</param>
        void CancelarReserva(int claseID);
    }
}
