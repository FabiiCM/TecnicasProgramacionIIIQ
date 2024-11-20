using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ProyectoGym
{
    public partial class FRMInicioDeSesion : Form
    {
        public FRMInicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificar campos vacíos
            if (string.IsNullOrEmpty(TBNombre.Text) ||
                string.IsNullOrEmpty(TBContraseña.Text) ||
                cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del evento si los campos no están completos
            }

            // Obtener el tipo de usuario seleccionado (asegurándose de que no sea nulo)
            string tipoUsuario = cmbUsuarios.SelectedItem?.ToString() ?? string.Empty; // Asignamos un valor predeterminado si es nulo

            // Validar las credenciales
            if (Cliente.Validacion(TBNombre.Text, TBContraseña.Text, tipoUsuario))
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir otro formulario
                this.Hide();
                frmMenuUsuario ventanaSesion = new frmMenuUsuario();
                ventanaSesion.Show();
            }
            else
            {
                MessageBox.Show("Usuario, contraseña o rol incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBContraseña.Clear();
        }

        private void TBNombreDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreDeUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new FRMInicio();
            ventanaSesion.Show();
        }
    }
}