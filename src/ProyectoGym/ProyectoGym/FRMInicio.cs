using Controller;

namespace ProyectoGym
{
    public partial class FRMInicio : Form
    {
        /// <summary>
        /// Declaracion de botones Asignar null! a los botones al declararlos 
        /// permitirá indicar al compilador que te aseguras de que estos campos 
        /// se inicializan correctamente en InitializeComponent(). Así se evita 
        /// la advertencia sin afectar el comportamiento del programa.
        /// </summary>
        private Button BTInicioSesion = null!;
        private Button BTRegistro = null!;



        public FRMInicio()
        {
            InitializeComponent();
            var people = PersonController.GetPeople();
        }

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
            BTInicioSesion.Location = new Point(12, 174);
            BTInicioSesion.Name = "BTInicioSesion";
            BTInicioSesion.Size = new Size(155, 63);
            BTInicioSesion.TabIndex = 0;
            BTInicioSesion.Text = "Iniciar Sesión";
            BTInicioSesion.UseVisualStyleBackColor = false;
            BTInicioSesion.Click += BTInicioSesion_Click;
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
            BTRegistro.Location = new Point(212, 174);
            BTRegistro.Name = "BTRegistro";
            BTRegistro.Size = new Size(153, 63);
            BTRegistro.TabIndex = 1;
            BTRegistro.Text = "Registro";
            BTRegistro.UseVisualStyleBackColor = false;
            BTRegistro.Click += BTRegistro_Click;
            // 
            // FRMInicio
            // 
            ClientSize = new Size(391, 346);
            Controls.Add(BTInicioSesion);
            Controls.Add(BTRegistro);
            Name = "FRMInicio";
            Text = "Inicio";
            Load += FRMInicio_Load;
            ResumeLayout(false);
        }

        private void BTInicioSesion_Click(object? sender, EventArgs e)
        {
            this.Hide();
            FRMInicioDeSesion ventanaSesion = new FRMInicioDeSesion();
            ventanaSesion.Show();
        }
        /// <summary>
        /// El uso de object? sender le indica al compilador que sender puede ser null, 
        /// lo que es compatible con el delegado EventHandler. Esto debería eliminar la
        /// advertencia y permitir que el código se compile sin problemas.
        /// </summary>
        private void BTRegistro_Click(object? sender, EventArgs e)
        {
            this.Hide();
            RegistroDeUsuario ventanaRegistro = new RegistroDeUsuario();
            ventanaRegistro.Show();
        }


        private void FRMInicio_Load(object? sender, EventArgs e)
        {
            // Código para la carga inicial del formulario
        }

        private void BTInicioDeSesion_Click(object sender, EventArgs e)
        {
            FRMInicioDeSesion nuevaVentana = new FRMInicioDeSesion();
            nuevaVentana.Show();
        }

        private void BTClasesReservas_Click(object? sender, EventArgs e)
        {
            this.Hide();
            FRMAsignacionHorarios ventanaSesion = new FRMAsignacionHorarios();
            ventanaSesion.Show();
        }

        private void BTInventario_Click(object sender, EventArgs e)
        {

        }

        private void BTEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void BTMembresias_Click(object sender, EventArgs e)
        {

        }
    }
}

