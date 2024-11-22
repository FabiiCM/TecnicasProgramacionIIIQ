using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Personas
{
    public class Entrenador
    {
        // Propiedades del entrenador
        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad { get; set; }
        public string HorariosDisponibles { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int AñosDeExperiencia { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }

        // Constructor
        public Entrenador(int id, string nombreCompleto, string especialidad, string horariosDisponibles,
                          string telefono, string correoElectronico, int añosDeExperiencia, string contraseña, string nombreUsuario)
        {
            ID = id;
            NombreCompleto = nombreCompleto;
            Especialidad = especialidad;
            HorariosDisponibles = horariosDisponibles;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            AñosDeExperiencia = añosDeExperiencia;
            Contraseña = contraseña;
            NombreUsuario = nombreUsuario;
        }

        // Método para validar credenciales del entrenador
        public static bool ValidarEntrenador(string usuario, string contraseña, string rutaArchivo)
        {
            try
            {
                // Leer las líneas del archivo de entrenadores
                var lineas = File.ReadAllLines(rutaArchivo);

                // Buscar el entrenador en el archivo CSV
                var entrenador = lineas.FirstOrDefault(e =>
                {
                    var datos = e.Split(','); // Separar por comas
                    return datos.Length > 8 && datos[8].Trim() == usuario && datos[7].Trim() == contraseña; // Índices para NombreUsuario y Contraseña
                });

                // Retorna true si encontró al entrenador y la contraseña es correcta
                return entrenador != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al validar entrenador: {ex.Message}");
                return false;
            }
        }
    }
}
