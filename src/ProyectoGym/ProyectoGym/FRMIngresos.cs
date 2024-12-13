using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class FRMIngresos : Form
    {
        public FRMIngresos()
        {
            InitializeComponent();


        }

        private void FRMIngresos_Load(object sender, EventArgs e)
        {

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new();
            ventanaSesion.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

