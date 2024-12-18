using Model.Gestion;
using src.Model.Personas;
using System.ComponentModel.DataAnnotations;


namespace src.Model.Gestion
{
    /// <summary>
    /// Representa una rutina específica para cada cliente.
    /// </summary>
    public class Rutina
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el cliente a la rutina.
        /// </summary>
        public Cliente? Cliente { get; set; }

        /// <summary>
        /// Obtiene o establece el cliente a la rutina.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la descripción de la rutina.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de asignación de la rutina.
        /// </summary>
        public DateTime FechaAsignación { get; set; }
    }
}
