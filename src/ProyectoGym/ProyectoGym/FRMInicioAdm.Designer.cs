namespace ProyectoGym
{
    partial class FRMInicioAdm
    {
        /// <summary>
        /// Required designer variable.
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
            BTInicioSesion = new Button();
            TBUsuario = new TextBox();
            LBUsuario = new Label();
            LBContraseña = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BTInicioSesion
            // 
            BTInicioSesion.BackColor = SystemColors.Window;
            BTInicioSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTInicioSesion.FlatAppearance.BorderSize = 2;
            BTInicioSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTInicioSesion.FlatStyle = FlatStyle.Flat;
            BTInicioSesion.Font = new Font("Segoe UI", 10F);
            BTInicioSesion.ForeColor = Color.FromArgb(255, 128, 0);
            BTInicioSesion.Location = new Point(143, 229);
            BTInicioSesion.Name = "BTInicioSesion";
            BTInicioSesion.Size = new Size(141, 43);
            BTInicioSesion.TabIndex = 0;
            BTInicioSesion.Text = "Iniciar Sesión";
            BTInicioSesion.UseVisualStyleBackColor = false;
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(79, 76);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(283, 31);
            TBUsuario.TabIndex = 1;
            // 
            // LBUsuario
            // 
            LBUsuario.AutoSize = true;
            LBUsuario.Location = new Point(176, 48);
            LBUsuario.Name = "LBUsuario";
            LBUsuario.Size = new Size(72, 25);
            LBUsuario.TabIndex = 2;
            LBUsuario.Text = "Usuario";
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.Location = new Point(160, 138);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(101, 25);
            LBContraseña.TabIndex = 3;
            LBContraseña.Text = "Contraseña";
            LBContraseña.Click += LBContraseña_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 31);
            textBox1.TabIndex = 4;
            // 
            // FRMInicioAdm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 296);
            Controls.Add(textBox1);
            Controls.Add(LBContraseña);
            Controls.Add(LBUsuario);
            Controls.Add(TBUsuario);
            Controls.Add(BTInicioSesion);
            Name = "FRMInicioAdm";
            Text = "FRMInicioAdm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTInicioSesion;
        private TextBox TBUsuario;
        private Label LBUsuario;
        private Label LBContraseña;
        private TextBox textBox1;
    }
}