using ProyectoGym;
using System;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class FRMInventario : Form
    {
        public FRMInventario()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new();
            ventanaSesion.Show();
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un elemento al inventario
            MessageBox.Show("Elemento agregado al inventario.");
        }

        private void BTActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un elemento del inventario
            MessageBox.Show("Elemento actualizado en el inventario.");
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            // Lógica para eliminar un elemento del inventario
            MessageBox.Show("Elemento eliminado del inventario.");
        }
    }
}

