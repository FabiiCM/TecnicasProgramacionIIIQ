using System;
using System.Collections.Generic;

namespace ProyectoGym
{
    public class Cliente
    {
        // Propiedades del cliente
        public int IDCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoUsuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }

        // Constructor
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

        // Método para validar credenciales del cliente
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

