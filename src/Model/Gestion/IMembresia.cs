using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Gestion
{
    public interface IMembresia
    {
        int ID { get; set; }
        int ClienteID { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaVencimiento { get; set; }

        bool EstaPorVencer();
    }
}
