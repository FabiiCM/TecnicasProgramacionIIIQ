using Model.Personas;
using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Gestion
{
    /// <summary>
    /// Representa una reserva realizada por un cliente para una clase en el sistema.
    /// </summary>
    public class Reserva
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Obtiene o establece el identificador de la clase reservada.
        /// </summary>
        public int ClaseID { get; set; }

        public required Clase Clase { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del cliente que realizó la reserva.
        /// </summary>
        public int ClienteID { get; set; }

        public Cliente Cliente { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha en que se realizó la reserva.
        /// </summary>
        public DateTime FechaReserva { get; set; }

        public Reserva() { }    

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Reserva"/>.
        /// </summary>
        /// <param name="id">Identificador único de la reserva.</param>
        /// <param name="clienteID">Identificador del cliente que realizó la reserva.</param>
        /// <param name="claseID">Identificador de la clase reservada.</param>
        /// <param name="fechaReserva">Fecha en que se realizó la reserva.</param>
        public Reserva(int id, int clienteID, int claseID, DateTime fechaReserva)
        {
            ID = id;
            ClienteID = clienteID;
            ClaseID = claseID;
            FechaReserva = fechaReserva;
        }

        /// <summary>
        /// Devuelve una representación en cadena de la reserva.
        /// </summary>
        /// <returns>Una cadena con los detalles de la reserva.</returns>
        public override string ToString()
        {
            return $"Reserva ID: {ID}, Cliente ID: {ClienteID}, Clase ID: {ClaseID}, Fecha: {FechaReserva.ToShortDateString()}";
        }
    }
}
