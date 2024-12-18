using src.Model.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Model.Gestion
{
    /// <summary>
    /// Representa las métricas de cada cliente.
    /// </summary>
    public class Metrica
    {
        [Key]
        public int ID { get; set; }

        public int ClienteID { get; set; }
        public Cliente? Cliente { get; set; }

        public double Peso { get; set; }

        public double IMC { get; set; }

        public double Cintura { get; set; }

        public double Cadera { get; set; }

        public double Brazo { get; set; }

        public double Muslo { get; set; }
    }
}
