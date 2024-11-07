using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGym.Properties;
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
            ///Concatenar para evitar cualquier Error y muestra un mensaje de que hubo un error y si se registra bien o mal           
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\sources\RepoQ3\src\ProyectoGym\ProyectoGym\bin\Debug\" + TBNombreDeUsuario.Text+ ".txt", true);
                RegistrarUsuario.WriteLine(TBContraseña.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("Se registró correctamente");
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "Error");

            }
        }
    }
}
