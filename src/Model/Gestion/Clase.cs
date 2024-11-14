
using ProyectoGym.Model.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model/Gestion/Clase.cs
namespace ProyectoGym.Model.Gestion
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  // Ej: Zumba, CardioDance
        public DateTime Horario { get; set; }
        public int CupoMaximo { get; set; }
        public Entrenador EntrenadorAsignado { get; set; }
        public List<Cliente> ClientesInscritos { get; set; }

        public Clase()
        {
            ClientesInscritos = new List<Cliente>();
        }
    }
}
