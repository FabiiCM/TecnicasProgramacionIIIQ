﻿namespace ProyectoGym
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
            label1 = new Label();
            TBIdentificacion = new TextBox();
            SuspendLayout();
            // 
            // LBNombre
            // 
            LBNombre.AutoSize = true;
            LBNombre.Location = new Point(171, 117);
            LBNombre.Margin = new Padding(2, 0, 2, 0);
            LBNombre.Name = "LBNombre";
            LBNombre.Size = new Size(107, 15);
            LBNombre.TabIndex = 0;
            LBNombre.Text = "Nombre Completo";
            // 
            // LBMail
            // 
            LBMail.AutoSize = true;
            LBMail.Location = new Point(204, 163);
            LBMail.Margin = new Padding(2, 0, 2, 0);
            LBMail.Name = "LBMail";
            LBMail.Size = new Size(41, 15);
            LBMail.TabIndex = 1;
            LBMail.Text = "E-mail";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.Location = new Point(165, 209);
            LBNombreDeUsuario.Margin = new Padding(2, 0, 2, 0);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(111, 15);
            LBNombreDeUsuario.TabIndex = 2;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // LBContraseña
            // 
            LBContraseña.AutoSize = true;
            LBContraseña.Location = new Point(185, 259);
            LBContraseña.Margin = new Padding(2, 0, 2, 0);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(67, 15);
            LBContraseña.TabIndex = 3;
            LBContraseña.Text = "Contraseña";
            // 
            // LBRegistrar
            // 
            LBRegistrar.AutoSize = true;
            LBRegistrar.BackColor = SystemColors.Window;
            LBRegistrar.Font = new Font("Mongolian Baiti", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            LBRegistrar.Location = new Point(146, 22);
            LBRegistrar.Margin = new Padding(2, 0, 2, 0);
            LBRegistrar.Name = "LBRegistrar";
            LBRegistrar.Size = new Size(167, 24);
            LBRegistrar.TabIndex = 4;
            LBRegistrar.Text = "Registrar Usuario";
            // 
            // TBNombreCompleto
            // 
            TBNombreCompleto.Location = new Point(36, 133);
            TBNombreCompleto.Margin = new Padding(2, 2, 2, 2);
            TBNombreCompleto.Name = "TBNombreCompleto";
            TBNombreCompleto.Size = new Size(392, 23);
            TBNombreCompleto.TabIndex = 6;
            // 
            // TBMail
            // 
            TBMail.Location = new Point(36, 184);
            TBMail.Margin = new Padding(2, 2, 2, 2);
            TBMail.Name = "TBMail";
            TBMail.Size = new Size(392, 23);
            TBMail.TabIndex = 7;
            // 
            // TBNombreDeUsuario
            // 
            TBNombreDeUsuario.Location = new Point(36, 230);
            TBNombreDeUsuario.Margin = new Padding(2, 2, 2, 2);
            TBNombreDeUsuario.Name = "TBNombreDeUsuario";
            TBNombreDeUsuario.Size = new Size(392, 23);
            TBNombreDeUsuario.TabIndex = 8;
            TBNombreDeUsuario.TextChanged += TBNombreDeUsuario_TextChanged;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(36, 276);
            TBContraseña.Margin = new Padding(2, 2, 2, 2);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(392, 23);
            TBContraseña.TabIndex = 9;
            // 
            // BTRegistrar
            // 
            BTRegistrar.BackColor = SystemColors.Window;
            BTRegistrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTRegistrar.FlatStyle = FlatStyle.Flat;
            BTRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTRegistrar.Location = new Point(36, 349);
            BTRegistrar.Margin = new Padding(2, 2, 2, 2);
            BTRegistrar.Name = "BTRegistrar";
            BTRegistrar.Size = new Size(93, 32);
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
            BTLimpiar.Location = new Point(185, 349);
            BTLimpiar.Margin = new Padding(2, 2, 2, 2);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(93, 32);
            BTLimpiar.TabIndex = 11;
            BTLimpiar.Text = "Limpiar";
            BTLimpiar.UseVisualStyleBackColor = false;
            BTLimpiar.Click += BTLimpiar_Click;
            // 
            // RBtnCliente
            // 
            RBtnCliente.AutoSize = true;
            RBtnCliente.Location = new Point(36, 314);
            RBtnCliente.Name = "RBtnCliente";
            RBtnCliente.Size = new Size(62, 19);
            RBtnCliente.TabIndex = 12;
            RBtnCliente.TabStop = true;
            RBtnCliente.Text = "Cliente";
            RBtnCliente.UseVisualStyleBackColor = true;
            // 
            // RBtnEntrenador
            // 
            RBtnEntrenador.AutoSize = true;
            RBtnEntrenador.Location = new Point(335, 314);
            RBtnEntrenador.Name = "RBtnEntrenador";
            RBtnEntrenador.Size = new Size(83, 19);
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
            BTNCerrar.Location = new Point(337, 349);
            BTNCerrar.Margin = new Padding(2, 2, 2, 2);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(91, 31);
            BTNCerrar.TabIndex = 14;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 15;
            label1.Text = "Identificación";
            label1.Click += label1_Click;
            // 
            // TBIdentificacion
            // 
            TBIdentificacion.Location = new Point(36, 82);
            TBIdentificacion.Name = "TBIdentificacion";
            TBIdentificacion.Size = new Size(392, 23);
            TBIdentificacion.TabIndex = 16;
            // 
            // RegistroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(467, 419);
            Controls.Add(TBIdentificacion);
            Controls.Add(label1);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private Label label1;
        private TextBox TBIdentificacion;
    }
}