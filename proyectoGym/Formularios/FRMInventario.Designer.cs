namespace ProyectoGym
{
    partial class FRMInventario
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
            TXBNombre = new TextBox();
            TXBCantidad = new TextBox();
            CMBEstado = new ComboBox();
            BTAgregar = new Button();
            BTActualizar = new Button();
            BTNEliminar = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            BTNCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TXBNombre
            // 
            TXBNombre.Location = new Point(26, 22);
            TXBNombre.Margin = new Padding(2, 2, 2, 2);
            TXBNombre.Name = "TXBNombre";
            TXBNombre.Size = new Size(106, 23);
            TXBNombre.TabIndex = 0;
            TXBNombre.Text = "Nombre";
            // 
            // TXBCantidad
            // 
            TXBCantidad.Location = new Point(144, 23);
            TXBCantidad.Margin = new Padding(2, 2, 2, 2);
            TXBCantidad.Name = "TXBCantidad";
            TXBCantidad.Size = new Size(106, 23);
            TXBCantidad.TabIndex = 1;
            TXBCantidad.Text = "Cantidad";
            // 
            // CMBEstado
            // 
            CMBEstado.FormattingEnabled = true;
            CMBEstado.Items.AddRange(new object[] { "Nuevo", "Usado", "Malo" });
            CMBEstado.Location = new Point(265, 22);
            CMBEstado.Margin = new Padding(2, 2, 2, 2);
            CMBEstado.Name = "CMBEstado";
            CMBEstado.Size = new Size(119, 23);
            CMBEstado.TabIndex = 2;
            CMBEstado.Text = "Estado";
            // 
            // BTAgregar
            // 
            BTAgregar.BackColor = SystemColors.Window;
            BTAgregar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTAgregar.FlatStyle = FlatStyle.Flat;
            BTAgregar.ForeColor = Color.FromArgb(255, 128, 0);
            BTAgregar.Location = new Point(26, 130);
            BTAgregar.Margin = new Padding(2, 2, 2, 2);
            BTAgregar.Name = "BTAgregar";
            BTAgregar.Size = new Size(78, 33);
            BTAgregar.TabIndex = 3;
            BTAgregar.Text = "Agregar";
            BTAgregar.UseVisualStyleBackColor = false;
            BTAgregar.Click += BTAgregar_Click;
            // 
            // BTActualizar
            // 
            BTActualizar.BackColor = SystemColors.Window;
            BTActualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTActualizar.FlatStyle = FlatStyle.Flat;
            BTActualizar.ForeColor = Color.FromArgb(255, 128, 0);
            BTActualizar.Location = new Point(170, 130);
            BTActualizar.Margin = new Padding(2, 2, 2, 2);
            BTActualizar.Name = "BTActualizar";
            BTActualizar.Size = new Size(78, 33);
            BTActualizar.TabIndex = 4;
            BTActualizar.Text = "Actualizar";
            BTActualizar.UseVisualStyleBackColor = false;
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = SystemColors.Window;
            BTNEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNEliminar.FlatStyle = FlatStyle.Flat;
            BTNEliminar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNEliminar.Location = new Point(304, 130);
            BTNEliminar.Margin = new Padding(2, 2, 2, 2);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(78, 33);
            BTNEliminar.TabIndex = 5;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cantidad, Estado });
            dataGridView1.Location = new Point(26, 53);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(356, 56);
            dataGridView1.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.Width = 150;
            // 
            // BTNCerrar
            // 
            BTNCerrar.BackColor = SystemColors.Window;
            BTNCerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNCerrar.FlatStyle = FlatStyle.Flat;
            BTNCerrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.Location = new Point(314, 185);
            BTNCerrar.Margin = new Padding(2, 2, 2, 2);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(59, 27);
            BTNCerrar.TabIndex = 7;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = false;
            BTNCerrar.Click += BTNCerrar_Click;
            // 
            // FRMInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(421, 243);
            Controls.Add(BTNCerrar);
            Controls.Add(dataGridView1);
            Controls.Add(BTNEliminar);
            Controls.Add(BTActualizar);
            Controls.Add(BTAgregar);
            Controls.Add(CMBEstado);
            Controls.Add(TXBCantidad);
            Controls.Add(TXBNombre);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FRMInventario";
            Text = "FRMInventario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXBNombre;
        private TextBox TXBCantidad;
        private ComboBox CMBEstado;
        private Button BTAgregar;
        private Button BTActualizar;
        private Button BTNEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Estado;
        private Button BTNCerrar;
    }
}