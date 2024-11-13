namespace ProyectoGym
{
    partial class FRMInicioDeSesion
    {
        /// <summary>
        ///Se requiere asignar una variable 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTLimpiar = new Button();
            BTIniciarSesion = new Button();
            TBContraseña = new TextBox();
            TBNombre = new TextBox();
            LBRegistrar = new Label();
            LBContraseña = new Label();
            LBNombreDeUsuario = new Label();
            BTInicioPag = new Button();
            SuspendLayout();
            // 
            // BTLimpiar
            // 
            BTLimpiar.BackColor = Color.White;
            BTLimpiar.FlatStyle = FlatStyle.Flat;
            BTLimpiar.ForeColor = Color.FromArgb(255, 128, 0);
            BTLimpiar.Location = new Point(453, 367);
            BTLimpiar.Margin = new Padding(1, 2, 1, 2);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(133, 53);
            BTLimpiar.TabIndex = 23;
            BTLimpiar.Text = "Limpiar";
            BTLimpiar.UseVisualStyleBackColor = false;
            BTLimpiar.Click += BTLimpiar_Click;
            // 
            // BTIniciarSesion
            // 
            BTIniciarSesion.BackColor = Color.White;
            BTIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTIniciarSesion.FlatStyle = FlatStyle.Flat;
            BTIniciarSesion.ForeColor = Color.FromArgb(255, 128, 0);
            BTIniciarSesion.Location = new Point(161, 367);
            BTIniciarSesion.Margin = new Padding(1, 2, 1, 2);
            BTIniciarSesion.Name = "BTIniciarSesion";
            BTIniciarSesion.Size = new Size(133, 53);
            BTIniciarSesion.TabIndex = 22;
            BTIniciarSesion.Text = "Iniciar Sesión";
            BTIniciarSesion.UseVisualStyleBackColor = false;
            BTIniciarSesion.Click += BTIniciarSesion_Click;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(256, 140);
            TBContraseña.Margin = new Padding(1, 2, 1, 2);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(365, 31);
            TBContraseña.TabIndex = 21;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.White;
            TBNombre.Location = new Point(256, 192);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(365, 31);
            TBNombre.TabIndex = 20;
            // 
            // LBRegistrar
            // 
            LBRegistrar.AutoSize = true;
            LBRegistrar.BackColor = SystemColors.Window;
            LBRegistrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            LBRegistrar.Location = new Point(331, 65);
            LBRegistrar.Margin = new Padding(4, 0, 4, 0);
            LBRegistrar.Name = "LBRegistrar";
            LBRegistrar.Size = new Size(215, 38);
            LBRegistrar.TabIndex = 16;
            LBRegistrar.Text = "Inicio De Sesión";
            LBRegistrar.Click += LBRegistrar_Click;
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.ForeColor = SystemColors.ControlDarkDark;
            LBContraseña.Location = new Point(50, 197);
            LBContraseña.Margin = new Padding(4, 0, 4, 0);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(101, 25);
            LBContraseña.TabIndex = 15;
            LBContraseña.Text = "Contraseña";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.ForeColor = SystemColors.ControlDarkDark;
            LBNombreDeUsuario.Location = new Point(50, 145);
            LBNombreDeUsuario.Margin = new Padding(4, 0, 4, 0);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(170, 25);
            LBNombreDeUsuario.TabIndex = 14;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // BTInicioPag
            // 
            BTInicioPag.Location = new Point(655, 531);
            BTInicioPag.Name = "BTInicioPag";
            BTInicioPag.Size = new Size(103, 31);
            BTInicioPag.TabIndex = 24;
            BTInicioPag.Text = "Inicio";
            BTInicioPag.UseVisualStyleBackColor = true;
            BTInicioPag.Click += button1_Click;
            // 
            // FRMInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 585);
            Controls.Add(BTInicioPag);
            Controls.Add(BTLimpiar);
            Controls.Add(BTIniciarSesion);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombre);
            Controls.Add(LBRegistrar);
            Controls.Add(LBContraseña);
            Controls.Add(LBNombreDeUsuario);
            Margin = new Padding(1, 2, 1, 2);
            Name = "FRMInicioDeSesion";
            Text = "Inicio De Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTLimpiar;
        private Button BTIniciarSesion;
        private TextBox TBContraseña;
        private TextBox TBNombre;
        private Label LBRegistrar;
        private Label LBContraseña;
        private Label LBNombreDeUsuario;
        private Button BTInicioPag;
    }
}