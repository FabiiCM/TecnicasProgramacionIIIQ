using Model.Personas;
using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Inventario
{
    /// <summary>
    /// Representa una máquina del gimnasio.
    /// </summary>
    public class Maquina
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la máquina.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de la máquina.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del inventario relacionado a la maquina.
        /// </summary>
        public int InventarioID { get; set; }

        public Inventario Inventario{ get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de adquisición de la máquina.
        /// </summary>
        public DateTime FechaAdquisicion { get; set; }

        /// <summary>
        /// Obtiene o establece la vida útil de la máquina en meses.
        /// </summary>
        public int VidaUtilMeses { get; set; }

        public Maquina() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Maquina"/>.
        /// </summary>
        /// <param name="id">Identificador único de la máquina.</param>
        /// <param name="nombre">Nombre de la máquina.</param>
        /// <param name="fechaAdquisicion">Fecha de adquisición de la máquina.</param>
        /// <param name="vidaUtilMeses">Vida útil de la máquina en meses.</param>
        public Maquina(int id, string nombre, DateTime fechaAdquisicion, int vidaUtilMeses)
        {
            ID = id;
            Nombre = nombre;
            FechaAdquisicion = fechaAdquisicion;
            VidaUtilMeses = vidaUtilMeses;
        }

        /// <summary>
        /// Calcula si la máquina está cerca de cumplir su vida útil (3 meses o menos).
        /// </summary>
        /// <returns><c>true</c> si está cerca de cumplir su vida útil; de lo contrario, <c>false</c>.</returns>
        public bool EstaPorVencer()
        {
            DateTime fechaVencimiento = FechaAdquisicion.AddMonths(VidaUtilMeses);
            return (fechaVencimiento - DateTime.Now).TotalDays <= 90;
        }

        /// <summary>
        /// Devuelve la fecha de vencimiento de la vida útil de la máquina.
        /// </summary>
        /// <returns>La fecha en que la máquina cumple su vida útil.</returns>
        public DateTime ObtenerFechaVencimiento()
        {
            return FechaAdquisicion.AddMonths(VidaUtilMeses);
        }

        /// <summary>
        /// Devuelve una representación en cadena de los detalles de la máquina.
        /// </summary>
        /// <returns>Una cadena con los detalles clave de la máquina.</returns>
        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Fecha de Adquisición: {FechaAdquisicion:yyyy-MM-dd}, Vida Útil: {VidaUtilMeses} meses";
        }
    }
}
