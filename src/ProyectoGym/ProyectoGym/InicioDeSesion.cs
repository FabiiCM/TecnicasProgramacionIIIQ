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
using Controller.DataHandler;

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
            try
            {
                // Obtener datos del formulario
                string nombreUsuario = TBNombre.Text.Trim(); // Capturar Nombre de Usuario
                string contraseña = TBContraseña.Text.Trim(); // Capturar Contraseña
                string tipoUsuario = cmbUsuarios.SelectedItem?.ToString(); // Validar tipo de usuario

                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(tipoUsuario))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear instancia del FileDataHandler
                var fileDataHandler = new FileDataHandler("Assets/clientes.csv", "Assets/entrenadores.csv");
                List<string> usuarios;

                // Determinar el archivo correcto según el tipo de usuario
                int indiceUsuario, indiceContraseña;
                if (tipoUsuario == "Cliente")
                {
                    usuarios = fileDataHandler.GetClientes();
                    indiceUsuario = 10; // Índice de NombreUsuario en clientes.csv
                    indiceContraseña = 9; // Índice de Contraseña en clientes.csv
                }
                else if (tipoUsuario == "Entrenador")
                {
                    usuarios = fileDataHandler.GetEntrenadores();
                    indiceUsuario = 8; // Índice de NombreUsuario en entrenadores.csv
                    indiceContraseña = 7; // Índice de Contraseña en entrenadores.csv
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de usuario válido.");
                    return;
                }

                // Buscar el usuario en el archivo CSV
                var usuario = usuarios.FirstOrDefault(u =>
                {
                    var datos = u.Split(','); // Separar por comas
                    return datos.Length > Math.Max(indiceUsuario, indiceContraseña) &&
                           datos[indiceUsuario].Trim() == nombreUsuario; // Comparar NombreUsuario
                });

                if (usuario == null)
                {
                    // Usuario no existe
                    MessageBox.Show("El usuario no está registrado. Por favor, regístrese.");
                    return;
                }

                // Verificar contraseña
                var datosUsuario = usuario.Split(',');
                if (datosUsuario[indiceContraseña].Trim() == contraseña) // Comparar Contraseña
                {
                    // Contraseña correcta
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirigir al menú correspondiente (según tipoUsuario)
                }
                else
                {
                    // Contraseña incorrecta
                    MessageBox.Show("La contraseña es incorrecta. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Archivo no encontrado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}