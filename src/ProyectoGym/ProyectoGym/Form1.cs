using Controller;
using System.Security.Cryptography;

using System;
using System.Drawing;

using System.Windows.Forms;
namespace ProyectoGym
{
    public partial class FRMInicio : Form
    {
        
        public FRMInicio()
        {
            InitializeComponent();

            var people = PersonController.GetPeople();


        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BTInicioSesion_Click(object sender, EventArgs e)
        { 

          this.Hide();
          InicioDeSesion VentanaInicioSesion = new InicioDeSesion();
            VentanaInicioSesion.Show();
        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDeUsuario VentanaUsuario = new RegistroDeUsuario();
            VentanaUsuario.Show();

        }
    }
}
