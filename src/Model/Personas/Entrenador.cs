
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace Model.Personas
{
    /// <summary>
    /// Representa a un entrenador del sistema de gimnasio.
    /// </summary>
    public class Entrenador
    {
        /// <summary>
        /// Obtiene o establece los años de experiencia del entrenador.
        /// </summary>
        public int AñosDeExperiencia { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña del entrenador.
        /// </summary>
        public string Contraseña { get; set; }

        /// <summary>
        /// Obtiene o establece el correo electrónico del entrenador.
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece la especialidad del entrenador.
        /// </summary>
        public string Especialidad { get; set; }

        /// <summary>
        /// Obtiene o establece los horarios disponibles del entrenador.
        /// </summary>
        public string HorariosDisponibles { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del entrenador.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo del entrenador.
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario del entrenador.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono del entrenador.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Entrenador"/>.
        /// </summary>
        /// <param name="id">Identificador único del entrenador.</param>
        /// <param name="nombreCompleto">Nombre completo del entrenador.</param>
        /// <param name="especialidad">Especialidad del entrenador.</param>
        /// <param name="horariosDisponibles">Horarios disponibles del entrenador.</param>
        /// <param name="telefono">Número de teléfono del entrenador.</param>
        /// <param name="correoElectronico">Correo electrónico del entrenador.</param>
        /// <param name="añosDeExperiencia">Años de experiencia del entrenador.</param>
        /// <param name="contraseña">Contraseña del entrenador.</param>
        /// <param name="nombreUsuario">Nombre de usuario del entrenador.</param>
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

        /// <summary>
        /// Valida las credenciales de un entrenador buscando en un archivo CSV.
        /// </summary>
        /// <param name="usuario">Nombre de usuario proporcionado.</param>
        /// <param name="contraseña">Contraseña proporcionada.</param>
        /// <param name="rutaArchivo">Ruta del archivo CSV que contiene los datos de los entrenadores.</param>
        /// <returns>
        /// <c>true</c> si las credenciales son válidas; de lo contrario, <c>false</c>.
        /// </returns>
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

