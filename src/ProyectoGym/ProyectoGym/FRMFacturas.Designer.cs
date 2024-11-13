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
            btnGenerarFacturas = new Button();
            btnConsultarFacturas = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnGenerarFacturas
            // 
            btnGenerarFacturas.Location = new Point(71, 116);
            btnGenerarFacturas.Name = "btnGenerarFacturas";
            btnGenerarFacturas.Size = new Size(170, 56);
            btnGenerarFacturas.TabIndex = 1;
            btnGenerarFacturas.Text = "Generar Facturas";
            btnGenerarFacturas.UseVisualStyleBackColor = true;
            btnGenerarFacturas.Click += btnGenerarFacturas_Click;
            // 
            // btnConsultarFacturas
            // 
            btnConsultarFacturas.Location = new Point(296, 116);
            btnConsultarFacturas.Name = "btnConsultarFacturas";
            btnConsultarFacturas.Size = new Size(202, 56);
            btnConsultarFacturas.TabIndex = 2;
            btnConsultarFacturas.Text = "Consultar Facturas";
            btnConsultarFacturas.UseVisualStyleBackColor = true;
            // 
            // FRMFacturas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 274);
            Controls.Add(btnConsultarFacturas);
            Controls.Add(btnGenerarFacturas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FRMFacturas";
            Text = "FRMFacturas";
            Load += FRMFacturas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnGenerarFacturas;
        private Button btnConsultarFacturas;
    }
}