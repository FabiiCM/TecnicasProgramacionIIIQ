using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Finanzas
{
    internal class Ingreso
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string? Concepto { get; set; }
        public decimal Monto { get; set; }
        public string? MetodoPago { get; set; }
        public string? Cliente { get; set; }

        public override string ToString()
        {
            return $"{ID},{Fecha:yyyy-MM-dd},{Concepto},{Monto},{MetodoPago},{Cliente}";
        }

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