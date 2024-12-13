using src.Model.Personas;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGym.src.Model.Finanzas
{
    /// <summary>
    /// Representa una factura generada en el sistema.
    /// </summary>
    public class Factura
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la factura.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del cliente asociado a la factura.
        /// </summary>
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de emisión de la factura.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el monto de la factura.
        /// </summary>
        public decimal Monto { get; set; }
    }
}


