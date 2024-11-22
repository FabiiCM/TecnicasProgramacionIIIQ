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
    public partial class FRMEntrenador : Form
    {
        public FRMEntrenador()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new FRMInicio();
            ventanaSesion.Show();
        }

        private void FRMEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void MSInventario_Click(object sender, EventArgs e)
        {

        }

        private void MSMembresias_Click(object sender, EventArgs e)
        {

        }

        private void MSReservas_Click(object sender, EventArgs e)
        {

        }

        private void MSReportes_Click(object sender, EventArgs e)
        {

        }

        private void MSIngresos_Click(object sender, EventArgs e)
        {
            // Abre el formulario de reportes de ingresos
            FRMIngresos reporteIngresos = new FRMIngresos();
            reporteIngresos.Show();
        }
    }
}
