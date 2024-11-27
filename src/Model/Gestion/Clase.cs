using System;
using System.Collections.Generic;

namespace Model.Gestion
{
    /// <summary>
    /// Representa una clase disponible en el sistema de gestión.
    /// </summary>
    public class Clase
    {
        /// <summary>
        /// Lista de identificadores de los clientes inscritos en la clase.
        /// </summary>
        public List<int> ClientesInscritos { get; set; }

        /// <summary>
        /// Capacidad máxima de la clase.
        /// </summary>
        public int CupoMaximo { get; set; }

        /// <summary>
        /// Identificador único de la clase.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Horario de la clase.
        /// </summary>
        public string Horario { get; set; }

        /// <summary>
        /// Nombre de la clase.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador del entrenador asignado a la clase.
        /// </summary>
        public int EntrenadorID { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Clase"/>.
        /// </summary>
        /// <param name="id">Identificador único de la clase.</param>
        /// <param name="nombre">Nombre de la clase.</param>
        /// <param name="horario">Horario de la clase.</param>
        /// <param name="cupoMaximo">Capacidad máxima de la clase.</param>
        /// <param name="entrenadorID">Identificador del entrenador asignado.</param>
        public Clase(int id, string nombre, string horario, int cupoMaximo, int entrenadorID)
        {
            ID = id;
            Nombre = nombre;
            Horario = horario;
            CupoMaximo = cupoMaximo;
            EntrenadorID = entrenadorID;
            ClientesInscritos = new List<int>();
        }

        /// <summary>
        /// Inscribe un cliente en la clase si hay cupo disponible.
        /// </summary>
        /// <param name="clienteID">Identificador del cliente a inscribir.</param>
        /// <returns>
        /// <c>true</c> si el cliente fue inscrito correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool InscribirCliente(int clienteID)
        {
            if (ClientesInscritos.Count < CupoMaximo)
            {
                ClientesInscritos.Add(clienteID);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina a un cliente inscrito en la clase.
        /// </summary>
        /// <param name="clienteID">Identificador del cliente a eliminar.</param>
        /// <returns>
        /// <c>true</c> si el cliente fue eliminado correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarCliente(int clienteID)
        {
            return ClientesInscritos.Remove(clienteID);
        }

        /// <summary>
        /// Devuelve una representación en cadena de la clase.
        /// </summary>
        /// <returns>Una cadena con los detalles de la clase.</returns>
        public override string ToString()
        {
            return $"Clase: {Nombre}, Horario: {Horario}, Cupo: {ClientesInscritos.Count}/{CupoMaximo}, Entrenador ID: {EntrenadorID}";
        }
    }
}

