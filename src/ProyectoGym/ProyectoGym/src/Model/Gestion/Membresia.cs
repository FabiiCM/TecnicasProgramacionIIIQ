﻿using Model.Personas;
using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Gestion
{
    /// <summary>
    /// Representa una membresía de cliente en el sistema de gestión.
    /// </summary>
    public class Membresia
    {

        /// <summary>
        /// Obtiene o establece el identificador único de la membresía.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Obtiene o establece el costo de la membresía.
        /// </summary>
        public decimal Costo { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de inicio de la membresía.
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de vencimiento de la membresía.
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador del cliente asociado a la membresía.
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public Membresia()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Membresia"/>.
        /// </summary>
        /// <param name="id">Identificador único de la membresía.</param>
        /// <param name="clienteId">Identificador del cliente asociado a la membresía.</param>
        /// <param name="fechaInicio">Fecha de inicio de la membresía.</param>
        /// <param name="fechaVencimiento">Fecha de vencimiento de la membresía.</param>
        /// <param name="costo">Costo de la membresía.</param>
        public Membresia(int id, int clienteId, DateTime fechaInicio, DateTime fechaVencimiento, decimal costo)
        {
            ID = id;
            ClienteId = clienteId;
            FechaInicio = fechaInicio;
            FechaVencimiento = fechaVencimiento;
            Costo = costo;
        }

        /// <summary>
        /// Determina si la membresía está por vencer en los próximos 5 días.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la membresía vence en los próximos 5 días; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EstaPorVencer()
        {
            return (FechaVencimiento - DateTime.Now).TotalDays <= 5;
        }

        /// <summary>
        /// Devuelve una representación en cadena de la membresía.
        /// </summary>
        /// <returns>Una cadena con los detalles de la membresía.</returns>
        public override string ToString()
        {
            return $"Membresía ID: {ID}, Cliente ID: {ClienteId}, Vence el: {FechaVencimiento.ToShortDateString()}, Costo: {Costo:C}";
        }
    }
}