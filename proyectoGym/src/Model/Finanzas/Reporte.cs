using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Model.Finanzas
{
    /// <summary>
    /// Reporte sobre la situación financiera del gym.
    /// </summary>
    public class Reporte
    {
        /// <summary>
        /// Obtiene o establece el identificador único del reporte.
        /// </summary>
        [Key]
        public int ID { get; set; }
    }
}
