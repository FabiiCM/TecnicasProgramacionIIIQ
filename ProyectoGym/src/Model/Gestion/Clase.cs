using Model.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Gestion
{
    /// <summary>
    /// Representa una clase disponible en el sistema de gestión.
    /// </summary>
    public class Clase
    {
        /// <summary>
        /// Identificador único de la clase.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Lista de reservas asociadas a la clase.
        /// </summary>
        public List<Reserva> Reservas { get; set; }

        /// <summary>
        /// Capacidad máxima de la clase.
        /// </summary>
        public int CupoMaximo { get; set; }

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

        public Entrenador Entrenador { get; set; }  

        public Clase() { }  

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
            Reservas = new List<Reserva>();
        }

        /// <summary>
        /// Inscribe a un cliente en la clase si hay cupo disponible.
        /// </summary>
        /// <param name="reserva">Objeto reserva con los detalles del cliente y la clase.</param>
        /// <returns>
        /// <c>true</c> si la inscripción fue exitosa; de lo contrario, <c>false</c>.
        /// </returns>
        public bool InscribirCliente(Reserva reserva)
        {
            if (Reservas.Count < CupoMaximo)
            {
                Reservas.Add(reserva);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina una reserva de la clase.
        /// </summary>
        /// <param name="clienteID">Identificador del cliente cuya reserva se eliminará.</param>
        /// <returns>
        /// <c>true</c> si la reserva fue eliminada correctamente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarCliente(int clienteID)
        {
            var reserva = Reservas.Find(r => r.ClienteID == clienteID);
            if (reserva != null)
            {
                Reservas.Remove(reserva);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtiene una lista de los identificadores de los clientes inscritos en la clase.
        /// </summary>
        /// <returns>Lista de IDs de clientes inscritos.</returns>
        public List<int> ObtenerClientesInscritos()
        {
            return Reservas.ConvertAll(r => r.ClienteID);
        }

        /// <summary>
        /// Devuelve una representación en cadena de la clase.
        /// </summary>
        /// <returns>Una cadena con los detalles de la clase.</returns>
        public override string ToString()
        {
            return $"Clase: {Nombre}, Horario: {Horario}, Cupo: {Reservas.Count}/{CupoMaximo}, Entrenador ID: {EntrenadorID}";
        }
    }
}
