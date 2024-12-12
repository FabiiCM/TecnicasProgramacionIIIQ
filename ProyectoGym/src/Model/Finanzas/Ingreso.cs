using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Finanzas
{
    /// <summary>
    /// Representa un ingreso financiero registrado en el sistema.
    /// </summary>
    public class Ingreso
    {
        /// <summary>
        /// Obtiene o establece el identificador único del ingreso.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del cliente asociado al ingreso.
        /// </summary>
        public string? Cliente { get; set; }

        /// <summary>
        /// Obtiene o establece el concepto del ingreso.
        /// </summary>
        public string? Concepto { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha del ingreso.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el monto del ingreso.
        /// </summary>
        public decimal Monto { get; set; }

        /// <summary>
        /// Obtiene o establece el método de pago utilizado para el ingreso.
        /// </summary>
        public string? MetodoPago { get; set; }

        /// <summary>
        /// Convierte un objeto <see cref="Ingreso"/> a una representación en cadena CSV.
        /// </summary>
        /// <returns>Una cadena con los datos del ingreso separados por comas.</returns>
        public override string ToString()
        {
            return $"{ID},{Fecha:yyyy-MM-dd},{Concepto},{Monto},{MetodoPago},{Cliente}";
        }

        /// <summary>
        /// Crea un objeto <see cref="Ingreso"/> a partir de una línea en formato CSV.
        /// </summary>
        /// <param name="csvLine">La línea en formato CSV.</param>
        /// <returns>Un objeto <see cref="Ingreso"/> con los datos deserializados.</returns>
        public static Ingreso FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Ingreso
            {
                ID = int.Parse(values[0]),
                Fecha = DateTime.Parse(values[1]),
                Concepto = values[2],
                Monto = decimal.Parse(values[3]),
                MetodoPago = values[4],
                Cliente = values[5]
            };
        }
    }
}
