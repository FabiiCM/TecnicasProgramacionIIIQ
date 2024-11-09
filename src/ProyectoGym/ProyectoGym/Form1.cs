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


        private void BTInicioSesion_Click(object sender, EventArgs e)
        {


            private void InitializeComponent()
            {

                BTInicioSesion = new Button();
                BTRegistro = new Button();
                SuspendLayout();
                // 
                // BTInicioSesion
                // 
                BTInicioSesion.BackColor = SystemColors.Window;
                BTInicioSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                BTInicioSesion.FlatAppearance.BorderSize = 2;
                BTInicioSesion.FlatAppearance.MouseDownBackColor = Color.White;
                BTInicioSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
                BTInicioSesion.FlatStyle = FlatStyle.Flat;
                BTInicioSesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                BTInicioSesion.ForeColor = Color.FromArgb(255, 128, 0);
                BTInicioSesion.Location = new Point(127, 57);
                BTInicioSesion.Name = "BTInicioSesion";
                BTInicioSesion.RightToLeft = RightToLeft.No;
                BTInicioSesion.Size = new Size(147, 61);
                BTInicioSesion.TabIndex = 0;
                BTInicioSesion.Text = "Iniciar Sesión";
                BTInicioSesion.UseVisualStyleBackColor = false;
                BTInicioSesion.Click += BTInicioSesion_Click_1;
                // 
                // BTRegistro
                // 
                BTRegistro.BackColor = SystemColors.Window;
                BTRegistro.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                BTRegistro.FlatAppearance.BorderSize = 2;
                BTRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
                BTRegistro.FlatStyle = FlatStyle.Flat;
                BTRegistro.Font = new Font("Segoe UI", 10F);
                BTRegistro.ForeColor = Color.FromArgb(255, 128, 0);
                BTRegistro.Location = new Point(127, 138);
                BTRegistro.Name = "BTRegistro";
                BTRegistro.Size = new Size(152, 61);
                BTRegistro.TabIndex = 1;
                BTRegistro.Text = "Registro";
                BTRegistro.UseVisualStyleBackColor = false;
                BTRegistro.Click += BTRegistro_Click;
                // 
                // FRMInicio
                // 
                BackColor = Color.White;
                ClientSize = new Size(774, 459);
                Controls.Add(BTRegistro);
                Controls.Add(BTInicioSesion);
                Name = "FRMInicio";
                Text = "Inicio";
                ResumeLayout(false);
            }
        }
        private Button BTInicioSesion;
        private Button BTRegistro;

        private void BTRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDeUsuario VentanaUsuario = new RegistroDeUsuario();
            VentanaUsuario.Show();
        }

        private void BTInicioSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicioDeSesion VentanaUsuario = new FRMInicioDeSesion();
            VentanaUsuario.Show();

        }

        private void FRMInicio_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FRMInicio
            // 
            ClientSize = new Size(907, 385);
            Name = "FRMInicio";
            Load += FRMInicio_Load;
            ResumeLayout(false);
        }
    }
}
