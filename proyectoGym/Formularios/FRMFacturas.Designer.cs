namespace ProyectoGym
{
    partial class FRMFacturas
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
            menuStrip1 = new MenuStrip();
            btnConsultarFacturas = new Button();
            BTNSalir = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(249, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnConsultarFacturas
            // 
            btnConsultarFacturas.BackColor = SystemColors.Window;
            btnConsultarFacturas.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnConsultarFacturas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnConsultarFacturas.FlatStyle = FlatStyle.Flat;
            btnConsultarFacturas.ForeColor = Color.FromArgb(255, 128, 0);
            btnConsultarFacturas.Location = new Point(49, 37);
            btnConsultarFacturas.Margin = new Padding(2, 2, 2, 2);
            btnConsultarFacturas.Name = "btnConsultarFacturas";
            btnConsultarFacturas.Size = new Size(141, 34);
            btnConsultarFacturas.TabIndex = 2;
            btnConsultarFacturas.Text = "Consultar Facturas";
            btnConsultarFacturas.UseVisualStyleBackColor = false;
            btnConsultarFacturas.Click += btnConsultarFacturas_Click;
            // 
            // BTNSalir
            // 
            BTNSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNSalir.FlatStyle = FlatStyle.Flat;
            BTNSalir.ForeColor = Color.FromArgb(255, 128, 0);
            BTNSalir.Location = new Point(80, 85);
            BTNSalir.Margin = new Padding(2, 2, 2, 2);
            BTNSalir.Name = "BTNSalir";
            BTNSalir.Size = new Size(78, 20);
            BTNSalir.TabIndex = 3;
            BTNSalir.Text = "Salir";
            BTNSalir.UseVisualStyleBackColor = true;
            BTNSalir.Click += BTNSalir_Click;
            // 
            // FRMFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(249, 145);
            Controls.Add(BTNSalir);
            Controls.Add(btnConsultarFacturas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FRMFacturas";
            Text = "FRMFacturas";
            Load += FRMFacturas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnConsultarFacturas;
        private Button BTNSalir;
    }
}