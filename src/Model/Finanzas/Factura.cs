using System;

namespace ProyectoGym
{
    /// <summary>
    /// Representa una factura generada en el sistema.
    /// </summary>
    public class Factura
    {
        /// <summary>
        /// Obtiene o establece el ID de la matrícula asociada a la factura.
        /// </summary>
        public int MatriculaID { get; set; }

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


