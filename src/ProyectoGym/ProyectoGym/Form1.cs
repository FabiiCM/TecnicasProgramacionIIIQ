using Controller;
using System.Security.Cryptography;

namespace ProyectoGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var people = PersonController.GetPeople();


        }

        private void button1_Click(object sender, EventArgs e)
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
