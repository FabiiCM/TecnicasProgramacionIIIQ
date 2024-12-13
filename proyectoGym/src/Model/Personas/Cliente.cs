using src.Model.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace src.Model.Personas
{
    /// <summary>
    /// Representa a un cliente del sistema de gimnasio.
    /// </summary>
    public class Cliente : Person
    {
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece la membresía asociada al cliente.
        /// </summary>
        public Membresia Membresia { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de usuario del cliente.
        /// </summary>
        public string TipoUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece las reservas asociadas al cliente.
        /// </summary>
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        public Cliente() { }

       /* /// <summary>
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
        /// <param name="membresia">Membresía asociada al cliente.</param>
        public Cliente(int idCliente, string nombreCompleto, string correoElectronico, string telefono,
                       DateTime fechaNacimiento, string tipoUsuario, string contraseña, string nombreUsuario, Membresia membresia)
        {
            ID = idCliente;
            NombreCompleto = nombreCompleto;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            TipoUsuario = tipoUsuario;
            Contraseña = contraseña;
            NombreUsuario = nombreUsuario;
            Membresia = membresia;
        }*/

        /// <summary>
        /// Notifica al cliente si su membresía está por vencer.
        /// </summary>
        /// <returns>
        /// Un mensaje notificando que la membresía está por vencer; de lo contrario, una cadena vacía.
        /// </returns>
        public string NotificarMembresia()
        {
            if (Membresia != null && Membresia.EstaPorVencer())
            {
                return "¡Atención! Su membresía está por vencer en los próximos días. Por favor, renueve su mensualidad.";
            }
            return string.Empty;
        }

        /// <summary>
        /// Realiza una reserva para el cliente.
        /// </summary>
        /// <param name="reserva">Objeto reserva a agregar.</param>
        public void AgregarReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
        }

        /// <summary>
        /// Elimina una reserva específica del cliente.
        /// </summary>
        /// <param name="reservaID">ID de la reserva a eliminar.</param>
        /// <returns>
        /// <c>true</c> si la reserva fue eliminada correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarReserva(int reservaID)
        {
            var reserva = Reservas.FirstOrDefault(r => r.ID == reservaID);
            if (reserva != null)
            {
                Reservas.Remove(reserva);
                return true;
            }
            return false;
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
