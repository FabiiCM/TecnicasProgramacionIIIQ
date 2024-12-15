using ProyectoGym.src.Model.Finanzas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Model.Finanzas
{
    /// <summary>
    /// Clase encargada de gestionar los ingresos financieros almacenados en un archivo CSV.
    /// </summary>
    internal class IngresoManager
    {
        /// <summary>
        /// Ruta del archivo donde se almacenan los ingresos.
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="IngresoManager"/> y verifica la existencia del archivo.
        /// </summary>
        /// <param name="filePath">Ruta del archivo CSV.</param>
        public IngresoManager(string filePath)
        {
            this.filePath = filePath;

            // Verifica si el archivo existe; si no, lo crea con encabezados.
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "ID,Fecha,Concepto,Monto,MetodoPago,Cliente\n");
            }
        }

        /// <summary>
        /// Agrega un nuevo ingreso al archivo CSV.
        /// </summary>
        /// <param name="nuevoIngreso">El ingreso a agregar.</param>
        public void AgregarIngreso(Ingreso nuevoIngreso)
        {
            var ingresos = LeerIngresos();
            nuevoIngreso.ID = ingresos.Any() ? ingresos.Max(i => i.ID) + 1 : 1;
            File.AppendAllText(filePath, nuevoIngreso.ToString() + Environment.NewLine);
        }

        /// <summary>
        /// Actualiza un ingreso existente en el archivo CSV.
        /// </summary>
        /// <param name="ingresoActualizado">El ingreso actualizado con nuevos datos.</param>
        public void ActualizarIngreso(Ingreso ingresoActualizado)
        {
            var ingresos = LeerIngresos();
            var ingreso = ingresos.FirstOrDefault(i => i.ID == ingresoActualizado.ID);
            if (ingreso != null)
            {
                ingresos.Remove(ingreso);
                ingresos.Add(ingresoActualizado);
                GuardarIngresos(ingresos);
            }
        }

        /// <summary>
        /// Elimina un ingreso del archivo CSV basado en su ID.
        /// </summary>
        /// <param name="id">El ID del ingreso a eliminar.</param>
        public void EliminarIngreso(int id)
        {
            var ingresos = LeerIngresos();
            ingresos.RemoveAll(i => i.ID == id);
            GuardarIngresos(ingresos);
        }

        /// <summary>
        /// Guarda una lista completa de ingresos en el archivo CSV.
        /// </summary>
        /// <param name="ingresos">La lista de ingresos a guardar.</param>
        private void GuardarIngresos(List<Ingreso> ingresos)
        {
            var lines = new List<string> { "ID,Fecha,Concepto,Monto,MetodoPago,Cliente" };
            lines.AddRange(ingresos.Select(i => i.ToString()));
            File.WriteAllLines(filePath, lines);
        }

        /// <summary>
        /// Lee todos los ingresos del archivo CSV.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Ingreso"/> con los datos leídos.</returns>
        public List<Ingreso> LeerIngresos()
        {
            var lines = File.ReadAllLines(filePath).Skip(1); // Saltar encabezados
            return lines.Select(Ingreso.FromCsv).ToList();
        }
    }
}

