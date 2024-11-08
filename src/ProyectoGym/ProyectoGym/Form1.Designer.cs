//Importación de bibliotecas
using System;
using System.Drawing;

using System.Windows.Forms;
namespace ProyectoGym
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameText = new Label();
            BirthText = new Label();
            BTInicioSesion = new Button();
            BTPrueba = new Button();
            BTRegistrar = new Button();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(79, 104);
            NameText.Name = "NameText";
            NameText.Size = new Size(0, 25);
            NameText.TabIndex = 1;
            NameText.Click += label1_Click;
            // 
            // BirthText
            // 
            BirthText.AutoSize = true;
            BirthText.Location = new Point(258, 104);
            BirthText.Name = "BirthText";
            BirthText.Size = new Size(0, 25);
            BirthText.TabIndex = 2;
            // 
            // BTInicioSesion
            // 
            BTInicioSesion.BackColor = SystemColors.ActiveCaption;
            BTInicioSesion.BackgroundImageLayout = ImageLayout.Center;
            BTInicioSesion.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTInicioSesion.Location = new Point(446, 234);
            BTInicioSesion.Name = "BTInicioSesion";
            BTInicioSesion.Size = new Size(178, 51);
            BTInicioSesion.TabIndex = 3;
            BTInicioSesion.Text = "Inicio de Sesión";
            BTInicioSesion.UseVisualStyleBackColor = false;
            BTInicioSesion.Click += button1_Click;
            // 
            // BTPrueba
            // 
            BTPrueba.BackColor = SystemColors.ActiveCaption;
            BTPrueba.BackgroundImageLayout = ImageLayout.Center;
            BTPrueba.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTPrueba.Location = new Point(12, 411);
            BTPrueba.Name = "BTPrueba";
            BTPrueba.Size = new Size(178, 45);
            BTPrueba.TabIndex = 0;
            BTPrueba.Text = "Prueba";
            BTPrueba.UseVisualStyleBackColor = false;
            BTPrueba.Click += but1;
            // 
            // BTRegistrar
            // 
            BTRegistrar.BackColor = SystemColors.ActiveCaption;
            BTRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            BTRegistrar.Location = new Point(446, 146);
            BTRegistrar.Name = "BTRegistrar";
            BTRegistrar.Size = new Size(178, 46);
            BTRegistrar.TabIndex = 4;
            BTRegistrar.Text = "Registrar";
            BTRegistrar.UseVisualStyleBackColor = false;
            BTRegistrar.Click += BTRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 468);
            Controls.Add(BTRegistrar);
            Controls.Add(BTInicioSesion);
            Controls.Add(BirthText);
            Controls.Add(NameText);
            Controls.Add(BTPrueba);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void but1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label NameText;
        private Label BirthText;
        private Button BTInicioSesion;
        private Button BTPrueba;
        private Button BTRegistrar;
    }
}
