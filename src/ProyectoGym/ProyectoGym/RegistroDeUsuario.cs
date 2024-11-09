using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.IO;

namespace ProyectoGym
{
    public partial class RegistroDeUsuario : Form
    {
        public RegistroDeUsuario()
        {
            InitializeComponent();
        }

        private void LBNombre_Click(object sender, EventArgs e)
        {

        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombreCompleto.Clear();
            TBMail.Clear();
            TBNombreDeUsuario.Clear();
            TBContraseña.Clear();

        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void TBNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroDeUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
