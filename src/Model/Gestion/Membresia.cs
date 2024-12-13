using System;

namespace Model.Gestion
{
    /// <summary>
    /// Representa una membresía de cliente en el sistema de gestión.
    /// </summary>
    public class Membresia
    {
        /// <summary>
        /// Obtiene o establece el identificador del cliente asociado a la membresía.
        /// </summary>
        public int ClienteID { get; set; }

        /// <summary>
        /// Obtiene o establece el costo de la membresía.
        /// </summary>
        public decimal Costo { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de inicio de la membresía.
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de vencimiento de la membresía.
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la membresía.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Membresia"/>.
        /// </summary>
        /// <param name="id">Identificador único de la membresía.</param>
        /// <param name="clienteID">Identificador del cliente asociado a la membresía.</param>
        /// <param name="fechaInicio">Fecha de inicio de la membresía.</param>
        /// <param name="fechaVencimiento">Fecha de vencimiento de la membresía.</param>
        /// <param name="costo">Costo de la membresía.</param>
        public Membresia(int id, int clienteID, DateTime fechaInicio, DateTime fechaVencimiento, decimal costo)
        {
            ID = id;
            ClienteID = clienteID;
            FechaInicio = fechaInicio;
            FechaVencimiento = fechaVencimiento;
            Costo = costo;
        }

        /// <summary>
        /// Determina si la membresía está por vencer en los próximos 5 días.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la membresía vence en los próximos 5 días; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EstaPorVencer()
        {
            return (FechaVencimiento - DateTime.Now).TotalDays <= 5;
        }

        /// <summary>
        /// Devuelve una representación en cadena de la membresía.
        /// </summary>
        /// <returns>Una cadena con los detalles de la membresía.</returns>
        public override string ToString()
        {
            return $"Membresía ID: {ID}, Cliente ID: {ClienteID}, Vence el: {FechaVencimiento.ToShortDateString()}, Costo: {Costo:C}";
        }
    }
}
