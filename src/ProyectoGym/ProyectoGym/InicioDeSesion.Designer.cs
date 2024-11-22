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
            LBContraseña = new Label();
            LBNombreDeUsuario = new Label();
            BTInicioPag = new Button();
            LBIniciodeSesion = new Label();
            cmbUsuarios = new ComboBox();
            SuspendLayout();
            // 
            // BTLimpiar
            // 
            BTLimpiar.BackColor = Color.White;
            BTLimpiar.FlatStyle = FlatStyle.Flat;
            BTLimpiar.ForeColor = Color.FromArgb(255, 128, 0);
            BTLimpiar.Location = new Point(223, 185);
            BTLimpiar.Margin = new Padding(1, 1, 1, 1);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(99, 32);
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
            BTIniciarSesion.Location = new Point(67, 185);
            BTIniciarSesion.Margin = new Padding(1, 1, 1, 1);
            BTIniciarSesion.Name = "BTIniciarSesion";
            BTIniciarSesion.Size = new Size(93, 32);
            BTIniciarSesion.TabIndex = 22;
            BTIniciarSesion.Text = "Iniciar Sesión";
            BTIniciarSesion.UseVisualStyleBackColor = false;
            BTIniciarSesion.Click += BTIniciarSesion_Click;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(67, 118);
            TBContraseña.Margin = new Padding(1, 1, 1, 1);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(257, 23);
            TBContraseña.TabIndex = 21;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.White;
            TBNombre.Location = new Point(67, 65);
            TBNombre.Margin = new Padding(2, 2, 2, 2);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(257, 23);
            TBNombre.TabIndex = 20;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.ForeColor = SystemColors.ActiveCaptionText;
            LBContraseña.Location = new Point(160, 101);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(67, 15);
            LBContraseña.TabIndex = 15;
            LBContraseña.Text = "Contraseña";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.ForeColor = SystemColors.ActiveCaptionText;
            LBNombreDeUsuario.Location = new Point(141, 48);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(111, 15);
            LBNombreDeUsuario.TabIndex = 14;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // BTInicioPag
            // 
            BTInicioPag.BackColor = SystemColors.Window;
            BTInicioPag.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTInicioPag.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTInicioPag.FlatStyle = FlatStyle.Flat;
            BTInicioPag.ForeColor = Color.FromArgb(255, 128, 0);
            BTInicioPag.Location = new Point(159, 227);
            BTInicioPag.Margin = new Padding(2, 2, 2, 2);
            BTInicioPag.Name = "BTInicioPag";
            BTInicioPag.Size = new Size(72, 23);
            BTInicioPag.TabIndex = 24;
            BTInicioPag.Text = "Inicio";
            BTInicioPag.UseVisualStyleBackColor = false;
            BTInicioPag.Click += button1_Click;
            // 
            // LBIniciodeSesion
            // 
            LBIniciodeSesion.AutoSize = true;
            LBIniciodeSesion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBIniciodeSesion.ForeColor = Color.FromArgb(255, 128, 0);
            LBIniciodeSesion.Location = new Point(108, 11);
            LBIniciodeSesion.Margin = new Padding(2, 0, 2, 0);
            LBIniciodeSesion.Name = "LBIniciodeSesion";
            LBIniciodeSesion.Size = new Size(166, 30);
            LBIniciodeSesion.TabIndex = 25;
            LBIniciodeSesion.Text = "Inicio De Sesión";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Items.AddRange(new object[] { "Cliente", "Entrenador" });
            cmbUsuarios.Location = new Point(141, 149);
            cmbUsuarios.Margin = new Padding(2, 2, 2, 2);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(112, 23);
            cmbUsuarios.TabIndex = 26;
            cmbUsuarios.Text = "Tipo Usuario";
            // 
            // FRMInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 261);
            Controls.Add(cmbUsuarios);
            Controls.Add(LBIniciodeSesion);
            Controls.Add(BTInicioPag);
            Controls.Add(BTLimpiar);
            Controls.Add(BTIniciarSesion);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombre);
            Controls.Add(LBContraseña);
            Controls.Add(LBNombreDeUsuario);
            Margin = new Padding(1, 1, 1, 1);
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
        private Label LBContraseña;
        private Label LBNombreDeUsuario;
        private Button BTInicioPag;
        private Label LBIniciodeSesion;
        private ComboBox cmbUsuarios;
    }
}