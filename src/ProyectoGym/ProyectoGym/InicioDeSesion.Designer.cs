﻿namespace ProyectoGym
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
            TBNombre = new TextBox();
            LBRegistrar = new Label();
            LBContraseña = new Label();
            LBNombreDeUsuario = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BTLimpiar
            // 
            BTLimpiar.BackColor = Color.White;
            BTLimpiar.FlatStyle = FlatStyle.Flat;
            BTLimpiar.ForeColor = Color.FromArgb(255, 128, 0);
            BTLimpiar.Location = new Point(315, 372);
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
            BTIniciarSesion.Location = new Point(314, 313);
            BTIniciarSesion.Name = "BTIniciarSesion";
            BTIniciarSesion.Size = new Size(133, 53);
            BTIniciarSesion.TabIndex = 22;
            BTIniciarSesion.Text = "Iniciar Sesión";
            BTIniciarSesion.UseVisualStyleBackColor = false;
            BTIniciarSesion.Click += BTIniciarSesion_Click;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(115, 240);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(559, 31);
            TBContraseña.TabIndex = 21;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.White;
            TBNombre.Location = new Point(115, 171);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(559, 31);
            TBNombre.TabIndex = 20;
            // 
            // LBRegistrar
            // 
            LBRegistrar.AutoSize = true;
            LBRegistrar.BackColor = SystemColors.Window;
            LBRegistrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBRegistrar.ForeColor = Color.FromArgb(255, 128, 0);
            LBRegistrar.Location = new Point(266, 36);
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
            LBContraseña.Location = new Point(113, 212);
            LBContraseña.Name = "LBContraseña";
            LBContraseña.Size = new Size(101, 25);
            LBContraseña.TabIndex = 15;
            LBContraseña.Text = "Contraseña";
            // 
            // LBNombreDeUsuario
            // 
            LBNombreDeUsuario.AutoSize = true;
            LBNombreDeUsuario.ForeColor = SystemColors.ControlDarkDark;
            LBNombreDeUsuario.Location = new Point(113, 143);
            LBNombreDeUsuario.Name = "LBNombreDeUsuario";
            LBNombreDeUsuario.Size = new Size(170, 25);
            LBNombreDeUsuario.TabIndex = 14;
            LBNombreDeUsuario.Text = "Nombre De Usuario";
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.TitleBar;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(113, 28);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(559, 50);
            textBox1.TabIndex = 17;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(BTLimpiar);
            Controls.Add(BTIniciarSesion);
            Controls.Add(TBContraseña);
            Controls.Add(TBNombre);
            Controls.Add(LBRegistrar);
            Controls.Add(LBContraseña);
            Controls.Add(LBNombreDeUsuario);
            Controls.Add(textBox1);
            Name = "InicioDeSesion";
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
        private TextBox textBox1;
    }
}