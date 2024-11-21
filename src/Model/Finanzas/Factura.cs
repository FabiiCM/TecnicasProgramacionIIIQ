using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGym
{
    public class Factura
    {

        public int MatriculaID { get; set; }    // ID de cliente asociado a la factura
        public DateTime Fecha { get; set; }     // Fecha de emisión de la factura
        public decimal Monto { get; set; }      // Monto de la factura
    }

}

