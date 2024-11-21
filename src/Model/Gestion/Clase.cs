using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Gestion
{
    public class Clase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public int CupoMaximo { get; set; }
        public int EntrenadorID { get; set; }
        public List<int> ClientesInscritos { get; set; }

        public Clase(int id, string nombre, string horario, int cupoMaximo, int entrenadorID)
        {
            ID = id;
            Nombre = nombre;
            Horario = horario;
            CupoMaximo = cupoMaximo;
            EntrenadorID = entrenadorID;
            ClientesInscritos = new List<int>();
        }

        public bool InscribirCliente(int clienteID)
        {
            if (ClientesInscritos.Count < CupoMaximo)
            {
                ClientesInscritos.Add(clienteID);
                return true;
            }
            return false;
        }

        public bool EliminarCliente(int clienteID)
        {
            return ClientesInscritos.Remove(clienteID);
        }

        public override string ToString()
        {
            return $"Clase: {Nombre}, Horario: {Horario}, Cupo: {ClientesInscritos.Count}/{CupoMaximo}, Entrenador ID: {EntrenadorID}";
        }
    }
}
