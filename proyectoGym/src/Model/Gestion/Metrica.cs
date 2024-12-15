using src.Model.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGym.src.Model.Gestion
{
    /// <summary>
    /// Representa las métricas de cada cliente.
    /// </summary>
    public class Metrica
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el cliente a la métrica.
        /// </summary>
        public Cliente? Cliente { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de métrica.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Obtiene o establece el valor según el tipo de métrica.
        /// </summary>
        public double Valor { get; set; }
    }
}
