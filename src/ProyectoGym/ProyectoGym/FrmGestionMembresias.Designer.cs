namespace ProyectoGym
{
    partial class FrmGestionMembresias
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
            txtBGestionMembresia = new TextBox();
            BtnNotificarGestionMembresia = new Button();
            BtnActualizarGestionMembresia = new Button();
            BtnBuscarGestionMembresia = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBGestionMembresia
            // 
            txtBGestionMembresia.Enabled = false;
            txtBGestionMembresia.Location = new Point(25, 353);
            txtBGestionMembresia.Multiline = true;
            txtBGestionMembresia.Name = "txtBGestionMembresia";
            txtBGestionMembresia.Size = new Size(486, 70);
            txtBGestionMembresia.TabIndex = 0;
            // 
            // BtnNotificarGestionMembresia
            // 
            BtnNotificarGestionMembresia.Location = new Point(423, 296);
            BtnNotificarGestionMembresia.Name = "BtnNotificarGestionMembresia";
            BtnNotificarGestionMembresia.Size = new Size(75, 23);
            BtnNotificarGestionMembresia.TabIndex = 1;
            BtnNotificarGestionMembresia.Text = "Notificar";
            BtnNotificarGestionMembresia.UseVisualStyleBackColor = true;
            // 
            // BtnActualizarGestionMembresia
            // 
            BtnActualizarGestionMembresia.Location = new Point(51, 296);
            BtnActualizarGestionMembresia.Name = "BtnActualizarGestionMembresia";
            BtnActualizarGestionMembresia.Size = new Size(75, 23);
            BtnActualizarGestionMembresia.TabIndex = 2;
            BtnActualizarGestionMembresia.Text = "Actualizar";
            BtnActualizarGestionMembresia.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarGestionMembresia
            // 
            BtnBuscarGestionMembresia.Location = new Point(423, 48);
            BtnBuscarGestionMembresia.Name = "BtnBuscarGestionMembresia";
            BtnBuscarGestionMembresia.Size = new Size(75, 23);
            BtnBuscarGestionMembresia.TabIndex = 3;
            BtnBuscarGestionMembresia.Text = "Buscar";
            BtnBuscarGestionMembresia.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(486, 150);
            dataGridView1.TabIndex = 4;
            // 
            // FrmGestionMembresias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(533, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnBuscarGestionMembresia);
            Controls.Add(BtnActualizarGestionMembresia);
            Controls.Add(BtnNotificarGestionMembresia);
            Controls.Add(txtBGestionMembresia);
            Name = "FrmGestionMembresias";
            Text = "Gestion Membresias";
            Load += FrmGestionMembresias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBGestionMembresia;
        private Button button1;
        private Button button2;
        private Button BtnNotificarGestionMembresia;
        private Button BtnActualizarGestionMembresia;
        private Button BtnBuscarGestionMembresia;
        private DataGridView dataGridView1;
    }
}