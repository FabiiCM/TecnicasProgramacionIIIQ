using Model.Gestion;
using src.Model.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Model.Inventario
{
    /// <summary>
    /// Administra el inventario de máquinas del gimnasio.
    /// </summary>
    public class Inventario
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del inventario.
        /// </summary>
        public string Nombre{ get; set; }

        /// <summary>
        /// Lista de máquinas en el inventario.
        /// </summary>
        public List<Maquina> maquinas { get; set; } = new List<Maquina>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Inventario"/>.
        /// </summary>
        public Inventario()
        {
            maquinas = new List<Maquina>();
        }

        /// <summary>
        /// Agrega una máquina al inventario.
        /// </summary>
        /// <param name="maquina">La máquina a agregar.</param>
        public void AgregarMaquina(Maquina maquina)
        {
            maquinas.Add(maquina);
        }

        /// <summary>
        /// Elimina una máquina del inventario por su identificador único.
        /// </summary>
        /// <param name="idMaquina">El identificador único de la máquina a eliminar.</param>
        /// <returns>
        /// <c>true</c> si la máquina fue eliminada correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarMaquina(int idMaquina)
        {
            var maquina = maquinas.FirstOrDefault(m => m.ID == idMaquina);
            if (maquina != null)
            {
                maquinas.Remove(maquina);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtiene una lista de todas las máquinas en el inventario.
        /// </summary>
        /// <returns>Lista de todas las máquinas en el inventario.</returns>
        public List<Maquina> ObtenerTodasLasMaquinas()
        {
            return maquinas;
        }

        /// <summary>
        /// Obtiene la lista de máquinas que están cerca de cumplir su vida útil (3 meses o menos).
        /// </summary>
        /// <returns>Lista de máquinas próximas a vencer.</returns>
        public List<Maquina> ObtenerMaquinasPorVencer()
        {
            return maquinas.Where(m => m.EstaPorVencer()).ToList();
        }

        /// <summary>
        /// Obtiene una máquina específica del inventario por su identificador único.
        /// </summary>
        /// <param name="idMaquina">El identificador único de la máquina.</param>
        /// <returns>La máquina encontrada o <c>null</c> si no existe.</returns>
        public Maquina ObtenerMaquinaPorID(int idMaquina)
        {
            return maquinas.FirstOrDefault(m => m.ID == idMaquina);
        }

        /// <summary>
        /// Actualiza la información de una máquina en el inventario.
        /// </summary>
        /// <param name="maquinaActualizada">La máquina con la información actualizada.</param>
        /// <returns>
        /// <c>true</c> si la máquina fue actualizada correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ActualizarMaquina(Maquina maquinaActualizada)
        {
            var maquinaExistente = maquinas.FirstOrDefault(m => m.ID == maquinaActualizada.ID);
            if (maquinaExistente != null)
            {
                maquinas.Remove(maquinaExistente);
                maquinas.Add(maquinaActualizada);
                return true;
            }
            return false;
        }
    }
}
