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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTIniciarSesion_Click(object sender, EventArgs e)
        {
            ////Concatenamos para que nos diga si hay error o no 
            ///....
            try
            {
                TextReader Inicio = new StreamReader(TBNombre.Text + ".txt");
                if (Inicio.ReadLine() == TBContraseña.Text)
                {
                    MessageBox.Show("Se inició sesión");
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Hubo un error" + z, "Error");
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

        private void LBRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
