using System;
using System.Collections.Generic;

namespace src.Model.Personas
{
    /// <summary>
    /// Define el contrato para un cliente en el sistema de gestión.
    /// </summary>
    public interface ICliente : IPerson
    {
        /// <summary>
        /// Lista de IDs de clases reservadas por el cliente.
        /// </summary>
        List<int> ClasesReservadas { get; set; }

        /// <summary>
        /// ID único del cliente.
        /// </summary>
        int ClienteID { get; set; }

        /// <summary>
        /// ID de la membresía asociada al cliente.
        /// </summary>
        int MembresiaID { get; set; }

        /// <summary>
        /// Método para cancelar una reserva de clase.
        /// </summary>
        /// <param name="claseID">ID de la clase a cancelar.</param>
        void CancelarReserva(int claseID);

        /// <summary>
        /// Método para reservar una clase.
        /// </summary>
        /// <param name="claseID">ID de la clase a reservar.</param>
        void ReservarClase(int claseID);
    }
}
