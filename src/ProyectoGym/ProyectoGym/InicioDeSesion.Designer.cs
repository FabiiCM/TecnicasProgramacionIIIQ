namespace ProyectoGym
{
    partial class InicioDeSesion
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
            BTLimpiar = new Button();
            BTIniciarSesion = new Button();
            TBContraseña = new TextBox();
            TBNombreDeUsuario = new TextBox();
            LBRegistrar = new Label();
            LBContraseña = new Label();
            LBNombreDeUsuario = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BTLimpiar
            // 
            BTLimpiar.BackColor = SystemColors.Window;
            BTLimpiar.Location = new Point(220, 223);
            BTLimpiar.Margin = new Padding(2, 2, 2, 2);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(93, 32);
            BTLimpiar.TabIndex = 23;
            BTLimpiar.Text = "Limpiar";
            BTLimpiar.UseVisualStyleBackColor = false;
            BTLimpiar.Click += BTLimpiar_Click;
            // 
            // BTIniciarSesion
            // 
            BTIniciarSesion.BackColor = SystemColors.Window;
            BTIniciarSesion.Location = new Point(220, 188);
            BTIniciarSesion.Margin = new Padding(2, 2, 2, 2);
            BTIniciarSesion.Name = "BTIniciarSesion";
            BTIniciarSesion.Size = new Size(93, 32);
            BTIniciarSesion.TabIndex = 22;
            BTIniciarSesion.Text = "Iniciar Sesión";
            BTIniciarSesion.UseVisualStyleBackColor = false;
            BTIniciarSesion.Click += BTIniciarSesion_Click;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(80, 144);
            TBContraseña.Margin = new Padding(2, 2, 2, 2);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(392, 23);
            TBContraseña.TabIndex = 21;
            // 
            // TBNombreDeUsuario
            // 
            TBNombreDeUsuario.Location = new Point(80, 103);
            TBNombreDeUsuario.Margin = new Padding(2, 2, 2, 2);
            TBNombreDeUsuario.Name = "TBNombreDeUsuario";
            TBNombreDeUsuario.Size = new Size(392, 23);
            TBNombreDeUsuario.TabIndex = 20;
            TBNombreDeUsuario.TextChanged += TBNombreDeUsuario_TextChanged_1;
            // 
            // LBRegistrar
            // 
            LBRegistrar.AutoSize = true;
            LBRegistrar.BackColor = SystemColors.Window;
            LBRegistrar.Font = new Font("Mongolian Baiti", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBRegistrar.Location = new Point(220, 26);
            LBRegistrar.Margin = new Padding(2, 0, 2, 0);
            LBRegistrar.Name = "LBRegistrar";
            LBRegistrar.Size = new Size(157, 24);
            LBRegistrar.TabIndex = 16;
            LBRegistrar.Text = "Inicio De Sesión";
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.Location = new Point(79, 127);
            LBContraseña.Margin = new Padding(2, 0, 2, 0);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(67, 15);
            LBContraseña.TabIndex = 15;
            LBContraseña.Text = "Contraseña";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.Location = new Point(79, 86);
            LBNombreDeUsuario.Margin = new Padding(2, 0, 2, 0);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(111, 15);
            LBNombreDeUsuario.TabIndex = 14;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(80, 19);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 36);
            textBox1.TabIndex = 17;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 325);
            Controls.Add(BTLimpiar);
            Controls.Add(BTIniciarSesion);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombreDeUsuario);
            Controls.Add(LBRegistrar);
            Controls.Add(LBContraseña);
            Controls.Add(LBNombreDeUsuario);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "InicioDeSesion";
            Text = "InicioDeSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTLimpiar;
        private Button BTIniciarSesion;
        private TextBox TBContraseña;
        private TextBox TBNombreDeUsuario;
        private Label LBRegistrar;
        private Label LBContraseña;
        private Label LBNombreDeUsuario;
        private TextBox textBox1;
    }
}