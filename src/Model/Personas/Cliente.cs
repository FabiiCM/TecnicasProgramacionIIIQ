using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProyectoGym
{
    /// <summary>
    /// Representa a un cliente del sistema de gimnasio.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Obtiene o establece la contraseña del cliente.
        /// </summary>
        public string Contraseña { get; set; }

        /// <summary>
        /// Obtiene o establece el correo electrónico del cliente.
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento del cliente.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del cliente.
        /// </summary>
        public int IDCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo del cliente.
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario del cliente.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono del cliente.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de usuario del cliente.
        /// </summary>
        public string TipoUsuario { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Cliente"/>.
        /// </summary>
        /// <param name="idCliente">Identificador único del cliente.</param>
        /// <param name="nombreCompleto">Nombre completo del cliente.</param>
        /// <param name="correoElectronico">Correo electrónico del cliente.</param>
        /// <param name="telefono">Número de teléfono del cliente.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del cliente.</param>
        /// <param name="tipoUsuario">Tipo de usuario (Cliente, Administrador, etc.).</param>
        /// <param name="contraseña">Contraseña del cliente.</param>
        /// <param name="nombreUsuario">Nombre de usuario para iniciar sesión.</param>
        public Cliente(int idCliente, string nombreCompleto, string correoElectronico, string telefono,
                       DateTime fechaNacimiento, string tipoUsuario, string contraseña, string nombreUsuario)
        {
            IDCliente = idCliente;
            NombreCompleto = nombreCompleto;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            TipoUsuario = tipoUsuario;
            Contraseña = contraseña;
            NombreUsuario = nombreUsuario;
        }

        /// <summary>
        /// Valida las credenciales de un cliente buscando en un archivo CSV.
        /// </summary>
        /// <param name="usuario">Nombre de usuario proporcionado.</param>
        /// <param name="contraseña">Contraseña proporcionada.</param>
        /// <param name="rutaArchivo">Ruta del archivo CSV que contiene los datos de los clientes.</param>
        /// <returns>
        /// <c>true</c> si las credenciales son válidas; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCliente(string usuario, string contraseña, string rutaArchivo)
        {
            try
            {
                // Leer todas las líneas del archivo
                var lineas = File.ReadAllLines(rutaArchivo);

                // Buscar el cliente en el archivo CSV
                var cliente = lineas.FirstOrDefault(c =>
                {
                    var datos = c.Split(','); // Separar por comas
                    return datos.Length > 8 && // Validar que haya suficientes columnas
                           datos[7].Trim() == contraseña && // Contraseña (índice 7)
                           datos[8].Trim() == usuario && // NombreUsuario (índice 8)
                           datos[5].Trim() == "Cliente"; // TipoUsuario (índice 5)
                });

                // Retorna true si encontró al cliente
                return cliente != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al validar cliente: {ex.Message}");
                return false;
            }
        }
    }
}

