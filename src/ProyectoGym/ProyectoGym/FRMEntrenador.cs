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
    }
}
