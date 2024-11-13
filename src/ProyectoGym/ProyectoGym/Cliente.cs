using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGym
{
   
        public class Cliente
        {
        private List<Cliente> ObtenerClientes()
{
    return new List<Cliente>
    {
        new Cliente { MatriculaID = 1, Nombre = "Juan Perez", Email = "juan.perez@example.com" },
        new Cliente { MatriculaID = 2, Nombre = "Maria Gomez", Email = "maria.gomez@example.com" }
    };
}

            public int MatriculaID { get; set; }  // ID único de cliente (matrícula)
            public string? Nombre { get; set; }     // Nombre del cliente
            public string? Email { get; set; }      // Correo electrónico del cliente
        }

    }

