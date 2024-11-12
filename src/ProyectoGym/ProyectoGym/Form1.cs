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
        private Button BTEntrenadores = null!;
        private Button BTClasesReservas = null!;
        private Button BTMembresias = null!;
        private Button BTInventario = null!;
        private Button BTFacturacion = null!;



        public FRMInicio()
        {
            InitializeComponent();
            var people = PersonController.GetPeople();
        }

        private void InitializeComponent()
        {
            BTInicioSesion = new Button();
            BTRegistro = new Button();
            BTEntrenadores = new Button();
            BTClasesReservas = new Button();
            BTMembresias = new Button();
            BTInventario = new Button();
            BTFacturacion = new Button();
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
            BTInicioSesion.Location = new Point(125, 47);
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
            BTRegistro.Location = new Point(127, 138);
            BTRegistro.Name = "BTRegistro";
            BTRegistro.Size = new Size(153, 63);
            BTRegistro.TabIndex = 1;
            BTRegistro.Text = "Registro";
            BTRegistro.UseVisualStyleBackColor = false;
            BTRegistro.Click += BTRegistro_Click;
            // 
            // BTEntrenadores
            // 
            BTEntrenadores.Location = new Point(125, 229);
            BTEntrenadores.Name = "BTEntrenadores";
            BTEntrenadores.Size = new Size(152, 63);
            BTEntrenadores.TabIndex = 2;
            BTEntrenadores.Text = "Entrenadores";
            BTEntrenadores.UseVisualStyleBackColor = true;
            // 
            // BTClasesReservas
            // 
            BTClasesReservas.Location = new Point(384, 91);
            BTClasesReservas.Name = "BTClasesReservas";
            BTClasesReservas.Size = new Size(152, 65);
            BTClasesReservas.TabIndex = 3;
            BTClasesReservas.Text = "Clases y Reservas";
            BTClasesReservas.UseVisualStyleBackColor = true;
            BTClasesReservas.Click += BTClasesReservas_Click;
            // 
            // BTMembresias
            // 
            BTMembresias.Location = new Point(125, 317);
            BTMembresias.Name = "BTMembresias";
            BTMembresias.Size = new Size(152, 62);
            BTMembresias.TabIndex = 4;
            BTMembresias.Text = "Membresias";
            BTMembresias.UseVisualStyleBackColor = true;
            // 
            // BTInventario
            // 
            BTInventario.Location = new Point(389, 182);
            BTInventario.Name = "BTInventario";
            BTInventario.Size = new Size(147, 63);
            BTInventario.TabIndex = 5;
            BTInventario.Text = "Inventario";
            BTInventario.UseVisualStyleBackColor = true;
            BTInventario.Click += BTInventario_Click;
            // 
            // BTFacturacion
            // 
            BTFacturacion.Location = new Point(389, 271);
            BTFacturacion.Name = "BTFacturacion";
            BTFacturacion.Size = new Size(147, 63);
            BTFacturacion.TabIndex = 6;
            BTFacturacion.Text = "Facturación";
            BTFacturacion.UseVisualStyleBackColor = true;
            // 
            // FRMInicio
            // 
            ClientSize = new Size(774, 459);
            Controls.Add(BTFacturacion);
            Controls.Add(BTInventario);
            Controls.Add(BTMembresias);
            Controls.Add(BTClasesReservas);
            Controls.Add(BTEntrenadores);
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
    }
}

