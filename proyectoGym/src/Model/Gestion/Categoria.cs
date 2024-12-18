using Model.Gestion;
using src.Model.Personas;
using System.ComponentModel.DataAnnotations;

namespace src.Model.Gestion
{
    /// <summary>
    /// Representa una rutina específica para cada cliente.
    /// </summary>
    public class Categoria
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el cliente a la rutina.
        /// </summary>
        public string Nombre { get; set; }
    }
}
