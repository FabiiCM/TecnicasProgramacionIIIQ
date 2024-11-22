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
            //limpia los campos de texto
            TBNombreCompleto.Clear();
            TBMail.Clear();
            TBNombreDeUsuario.Clear();
            TBContraseña.Clear();

            //Desmarca los radio buttons
            RBtnCliente.Checked = false;
            RBtnEntrenador.Checked = false;


            //Enfoca el primer campo de texto por si quieren registrar a una nueva persona
            TBNombreCompleto.Focus();


        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            // Muestra mensaje de éxito
            MessageBox.Show("Se registró correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia los campos después de guardar
            BTLimpiar_Click(sender, e);

            this.Hide();
            FRMInicio ventanaSesion = new FRMInicio();
            ventanaSesion.Show();
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



        private void RBtnCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtnEntrenador_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
