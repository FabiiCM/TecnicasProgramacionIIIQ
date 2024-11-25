namespace ProyectoGym
{
    partial class RegistroDeUsuario
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
            LBNombre = new Label();
            LBMail = new Label();
            LBNombreDeUsuario = new Label();
            LBContraseña = new Label();
            LBRegistrar = new Label();
            TBNombreCompleto = new TextBox();
            TBMail = new TextBox();
            TBNombreDeUsuario = new TextBox();
            TBContraseña = new TextBox();
            BTRegistrar = new Button();
            BTLimpiar = new Button();
            RBtnCliente = new RadioButton();
            RBtnEntrenador = new RadioButton();
            BTNCerrar = new Button();
            SuspendLayout();
            // 
            // LBNombre
            // 
            LBNombre.AutoSize = true;
            LBNombre.Location = new Point(244, 92);
            LBNombre.Name = "LBNombre";
            LBNombre.Size = new Size(162, 25);
            LBNombre.TabIndex = 0;
            LBNombre.Text = "Nombre Completo";
            // 
            // LBMail
            // 
            LBMail.AutoSize = true;
            LBMail.Location = new Point(291, 168);
            LBMail.Name = "LBMail";
            LBMail.Size = new Size(61, 25);
            LBMail.TabIndex = 1;
            LBMail.Text = "E-mail";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.Location = new Point(236, 245);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(170, 25);
            LBNombreDeUsuario.TabIndex = 2;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.Location = new Point(269, 322);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(101, 25);
            LBContraseña.TabIndex = 3;
            LBContraseña.Text = "Contraseña";
            // 
            // LBRegistrar
            // 
            LBRegistrar.AutoSize = true;
            LBRegistrar.BackColor = SystemColors.Window;
            LBRegistrar.Font = new Font("Mongolian Baiti", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            LBRegistrar.Location = new Point(209, 37);
            LBRegistrar.Name = "LBRegistrar";
            LBRegistrar.Size = new Size(241, 34);
            LBRegistrar.TabIndex = 4;
            LBRegistrar.Text = "Registrar Usuario";
            // 
            // TBNombreCompleto
            // 
            TBNombreCompleto.Location = new Point(51, 118);
            TBNombreCompleto.Name = "TBNombreCompleto";
            TBNombreCompleto.Size = new Size(558, 31);
            TBNombreCompleto.TabIndex = 6;
            // 
            // TBMail
            // 
            TBMail.Location = new Point(51, 197);
            TBMail.Name = "TBMail";
            TBMail.Size = new Size(558, 31);
            TBMail.TabIndex = 7;
            // 
            // TBNombreDeUsuario
            // 
            TBNombreDeUsuario.Location = new Point(51, 273);
            TBNombreDeUsuario.Name = "TBNombreDeUsuario";
            TBNombreDeUsuario.Size = new Size(558, 31);
            TBNombreDeUsuario.TabIndex = 8;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(51, 350);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(558, 31);
            TBContraseña.TabIndex = 9;
            // 
            // BTRegistrar
            // 
            BTRegistrar.BackColor = SystemColors.Window;
            BTRegistrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTRegistrar.FlatStyle = FlatStyle.Flat;
            BTRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTRegistrar.Location = new Point(56, 535);
            BTRegistrar.Name = "BTRegistrar";
            BTRegistrar.Size = new Size(133, 53);
            BTRegistrar.TabIndex = 10;
            BTRegistrar.Text = "Registrar";
            BTRegistrar.UseVisualStyleBackColor = false;
            BTRegistrar.Click += BTRegistrar_Click;
            // 
            // BTLimpiar
            // 
            BTLimpiar.BackColor = SystemColors.Window;
            BTLimpiar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTLimpiar.FlatStyle = FlatStyle.Flat;
            BTLimpiar.ForeColor = Color.FromArgb(255, 128, 0);
            BTLimpiar.Location = new Point(269, 533);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(133, 53);
            BTLimpiar.TabIndex = 11;
            BTLimpiar.Text = "Limpiar";
            BTLimpiar.UseVisualStyleBackColor = false;
            BTLimpiar.Click += BTLimpiar_Click;
            // 
            // RBtnCliente
            // 
            RBtnCliente.AutoSize = true;
            RBtnCliente.Location = new Point(99, 423);
            RBtnCliente.Margin = new Padding(4, 5, 4, 5);
            RBtnCliente.Name = "RBtnCliente";
            RBtnCliente.Size = new Size(90, 29);
            RBtnCliente.TabIndex = 12;
            RBtnCliente.TabStop = true;
            RBtnCliente.Text = "Cliente";
            RBtnCliente.UseVisualStyleBackColor = true;
            // 
            // RBtnEntrenador
            // 
            RBtnEntrenador.AutoSize = true;
            RBtnEntrenador.Location = new Point(479, 423);
            RBtnEntrenador.Margin = new Padding(4, 5, 4, 5);
            RBtnEntrenador.Name = "RBtnEntrenador";
            RBtnEntrenador.Size = new Size(124, 29);
            RBtnEntrenador.TabIndex = 13;
            RBtnEntrenador.TabStop = true;
            RBtnEntrenador.Text = "Entrenador";
            RBtnEntrenador.UseVisualStyleBackColor = true;
            // 
            // BTNCerrar
            // 
            BTNCerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNCerrar.FlatStyle = FlatStyle.Flat;
            BTNCerrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.Location = new Point(479, 535);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(130, 51);
            BTNCerrar.TabIndex = 14;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = true;
            // 
            // RegistroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(667, 626);
            Controls.Add(BTNCerrar);
            Controls.Add(RBtnEntrenador);
            Controls.Add(RBtnCliente);
            Controls.Add(BTLimpiar);
            Controls.Add(BTRegistrar);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombreDeUsuario);
            Controls.Add(TBMail);
            Controls.Add(TBNombreCompleto);
            Controls.Add(LBRegistrar);
            Controls.Add(LBContraseña);
            Controls.Add(LBNombreDeUsuario);
            Controls.Add(LBMail);
            Controls.Add(LBNombre);
            Name = "RegistroDeUsuario";
            Text = "RegistroDeUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBNombre;
        private Label LBMail;
        private Label LBNombreDeUsuario;
        private Label LBContraseña;
        private Label LBRegistrar;
        private TextBox TBNombreCompleto;
        private TextBox TBMail;
        private TextBox TBNombreDeUsuario;
        private TextBox TBContraseña;
        private Button BTRegistrar;
        private Button BTLimpiar;
        private RadioButton RBtnCliente;
        private RadioButton RBtnEntrenador;
        private Button BTNCerrar;
    }
}