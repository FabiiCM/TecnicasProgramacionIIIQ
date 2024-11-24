using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class RegistroDeUsuario : Form
    {
        public RegistroDeUsuario()
        {
            InitializeComponent();
        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TBNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(TBMail.Text) ||
                string.IsNullOrWhiteSpace(TBNombreDeUsuario.Text) ||
                string.IsNullOrWhiteSpace(TBContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar si se seleccionó el tipo de usuario
            if (!RBtnCliente.Checked && !RBtnEntrenador.Checked)
            {
                MessageBox.Show("Por favor, seleccione el tipo de usuario.", "Tipo de usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos del usuario
            string nombreCompleto = TBNombreCompleto.Text;
            string email = TBMail.Text;
            string nombreDeUsuario = TBNombreDeUsuario.Text;
            string contraseña = TBContraseña.Text;

            // Ruta de la carpeta donde se guardarán los archivos
            string folderPath = @"C:\sources\RepoQ3\src\Controller\Assets";

            // Crear la carpeta si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Determinar el archivo donde se guardará la información
            string filePath;
            if (RBtnCliente.Checked)
            {
                filePath = Path.Combine(folderPath, "clientes.csv");
            }
            else
            {
                filePath = Path.Combine(folderPath, "entrenadores.csv");
            }

            // Formatear los datos para guardarlos en CSV
            string datos = $"{nombreCompleto},{email},{nombreDeUsuario},{contraseña}";

            try
            {
                // Guardar los datos en el archivo correspondiente
                File.AppendAllText(filePath, datos + Environment.NewLine);
                MessageBox.Show("Usuario registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            TBNombreCompleto.Clear();
            TBMail.Clear();
            TBNombreDeUsuario.Clear();
            TBContraseña.Clear();
            RBtnCliente.Checked = false;
            RBtnEntrenador.Checked = false;
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombreCompleto.Clear();
            TBMail.Clear();
            TBNombreDeUsuario.Clear();
            TBContraseña.Clear();
            RBtnCliente.Checked = false;
            RBtnEntrenador.Checked = false;
        }
    }
}

