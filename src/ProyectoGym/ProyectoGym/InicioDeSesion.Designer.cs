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
            BTLimpiar.Location = new Point(319, 308);
            BTLimpiar.Margin = new Padding(1, 2, 1, 2);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(142, 53);
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
            BTIniciarSesion.Location = new Point(96, 308);
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
            TBContraseña.Location = new Point(96, 196);
            TBContraseña.Margin = new Padding(1, 2, 1, 2);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(365, 31);
            TBContraseña.TabIndex = 21;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.White;
            TBNombre.Location = new Point(96, 108);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(365, 31);
            TBNombre.TabIndex = 20;
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.ForeColor = SystemColors.ActiveCaptionText;
            LBContraseña.Location = new Point(229, 169);
            LBContraseña.Margin = new Padding(4, 0, 4, 0);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(101, 25);
            LBContraseña.TabIndex = 15;
            LBContraseña.Text = "Contraseña";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.ForeColor = SystemColors.ActiveCaptionText;
            LBNombreDeUsuario.Location = new Point(201, 80);
            LBNombreDeUsuario.Margin = new Padding(4, 0, 4, 0);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(170, 25);
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
            BTInicioPag.Location = new Point(227, 379);
            BTInicioPag.Name = "BTInicioPag";
            BTInicioPag.Size = new Size(103, 39);
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
            LBIniciodeSesion.Location = new Point(155, 18);
            LBIniciodeSesion.Name = "LBIniciodeSesion";
            LBIniciodeSesion.Size = new Size(247, 45);
            LBIniciodeSesion.TabIndex = 25;
            LBIniciodeSesion.Text = "Inicio De Sesión";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Items.AddRange(new object[] { "Cliente", "Entrenador" });
            cmbUsuarios.Location = new Point(201, 249);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(158, 33);
            cmbUsuarios.TabIndex = 26;
            cmbUsuarios.Text = "Tipo Usuario";
            // 
            // FRMInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 435);
            Controls.Add(cmbUsuarios);
            Controls.Add(LBIniciodeSesion);
            Controls.Add(BTInicioPag);
            Controls.Add(BTLimpiar);
            Controls.Add(BTIniciarSesion);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombre);
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
        private Label LBContraseña;
        private Label LBNombreDeUsuario;
        private Button BTInicioPag;
        private Label LBIniciodeSesion;
        private ComboBox cmbUsuarios;
    }
}