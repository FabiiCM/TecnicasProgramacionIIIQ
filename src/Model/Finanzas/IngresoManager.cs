using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Finanzas
{
    internal class IngresoManager
    {
        private readonly string filePath;

        public IngresoManager(string filePath)
        {
            this.filePath = filePath;

            // Verifica si el archivo existe; si no, lo crea con encabezados.
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "ID,Fecha,Concepto,Monto,MetodoPago,Cliente\n");
            }
        }

        public List<Ingreso> LeerIngresos()
        {
            var lines = File.ReadAllLines(filePath).Skip(1); // Saltar encabezados
            return lines.Select(Ingreso.FromCsv).ToList();
        }

        public void AgregarIngreso(Ingreso nuevoIngreso)
        {
            var ingresos = LeerIngresos();
            nuevoIngreso.ID = ingresos.Any() ? ingresos.Max(i => i.ID) + 1 : 1;
            File.AppendAllText(filePath, nuevoIngreso.ToString() + Environment.NewLine);
        }

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

        public void EliminarIngreso(int id)
        {
            var ingresos = LeerIngresos();
            ingresos.RemoveAll(i => i.ID == id);
            GuardarIngresos(ingresos);
        }

        private void GuardarIngresos(List<Ingreso> ingresos)
        {
            var lines = new List<string> { "ID,Fecha,Concepto,Monto,MetodoPago,Cliente" };
            lines.AddRange(ingresos.Select(i => i.ToString()));
            File.WriteAllLines(filePath, lines);
        }
    }
}
