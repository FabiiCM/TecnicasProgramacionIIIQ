using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class FRMMembresias : Form
    {
        // Lista para almacenar las membresías
        private readonly List<Membresia> listaMembresias = [];

        public FRMMembresias()
        {
            InitializeComponent();
        }

        private void ActualizarDataGridView()
        {
            DgvMembresias.DataSource = null;
            DgvMembresias.DataSource = listaMembresias;
        }

        private void BTNAgregar_Click_1(object sender, EventArgs e)
        {

            // Obtener datos de los controles
            int id = int.Parse(TXBId.Text);
            string nombre = TXTNombre.Text;
            decimal precio = decimal.Parse(TXBPrecio.Text);
            string tipo = CMBTipo.Text;

            // Crear una nueva membresía
            Membresia nuevaMembresia = new()
            {
                ID = id,
                Nombre = nombre,
                Precio = precio,
                DuracionMeses = tipo
            };

            // Agregar a la lista
            listaMembresias.Add(nuevaMembresia);
            ActualizarDataGridView();
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {

            // Eliminar una membresía por ID
            int id = int.Parse(TXBId.Text);
            listaMembresias.RemoveAll(m => m.ID == id);
            ActualizarDataGridView();
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario principal (FRMInicio)
            FRMInicio inicioForm = new();
            inicioForm.Show();

            // Cerrar el formulario actual (FRMMembresias)
            this.Close();
        }
    }

    public class Membresia
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public string? DuracionMeses { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - Precio: {Precio:C} - Duración: {DuracionMeses} meses";
        }
    }
}

