using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuClasesReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMAsignacionHorarios ventanaSesion = new FRMAsignacionHorarios();
            ventanaSesion.Show();
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cerrar la ventana actual y mostrar el formulario de inicio de sesión
                this.Hide();
                FRMInicio loginForm = new FRMInicio();
                loginForm.Show();
                this.Close();
            }
            // Si elige No, no hace nada y permanece en la aplicación

        }

        private void frmMenuUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new FRMInicio();
            ventanaSesion.Show();
        }

        private void mnuFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void mnuPagos_Click(object sender, EventArgs e)
        {

        }

        private void mnuPagos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRMFacturas ventanaSesion = new FRMFacturas();
            ventanaSesion.Show();
        }
    }
}
