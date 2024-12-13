namespace ProyectoGym
{
    partial class FRMMembresias
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
            TXBId = new TextBox();
            TXTNombre = new TextBox();
            TXBPrecio = new TextBox();
            CMBTipo = new ComboBox();
            DgvMembresias = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Membresía = new DataGridViewTextBoxColumn();
            Datos = new DataGridViewTextBoxColumn();
            BTNAgregar = new Button();
            BTNEliminar = new Button();
            BTNActualizar = new Button();
            BTNCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvMembresias).BeginInit();
            SuspendLayout();
            // 
            // TXBId
            // 
            TXBId.Location = new Point(21, 17);
            TXBId.Margin = new Padding(2, 2, 2, 2);
            TXBId.Name = "TXBId";
            TXBId.Size = new Size(106, 23);
            TXBId.TabIndex = 0;
            TXBId.Text = "ID";
            // 
            // TXTNombre
            // 
            TXTNombre.Location = new Point(137, 17);
            TXTNombre.Margin = new Padding(2, 2, 2, 2);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(106, 23);
            TXTNombre.TabIndex = 1;
            TXTNombre.Text = "Nombre";
            // 
            // TXBPrecio
            // 
            TXBPrecio.Location = new Point(257, 17);
            TXBPrecio.Margin = new Padding(2, 2, 2, 2);
            TXBPrecio.Name = "TXBPrecio";
            TXBPrecio.Size = new Size(106, 23);
            TXBPrecio.TabIndex = 2;
            TXBPrecio.Text = "Precio";
            // 
            // CMBTipo
            // 
            CMBTipo.FormattingEnabled = true;
            CMBTipo.Items.AddRange(new object[] { "Mensual", "Trimestral", "Anual" });
            CMBTipo.Location = new Point(379, 17);
            CMBTipo.Margin = new Padding(2, 2, 2, 2);
            CMBTipo.Name = "CMBTipo";
            CMBTipo.Size = new Size(129, 23);
            CMBTipo.TabIndex = 3;
            CMBTipo.Text = "Tipo Membresía";
            // 
            // DgvMembresias
            // 
            DgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMembresias.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, Membresía, Datos });
            DgvMembresias.Location = new Point(32, 53);
            DgvMembresias.Margin = new Padding(2, 2, 2, 2);
            DgvMembresias.Name = "DgvMembresias";
            DgvMembresias.RowHeadersWidth = 62;
            DgvMembresias.Size = new Size(465, 67);
            DgvMembresias.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Membresía
            // 
            Membresía.HeaderText = "Membresía";
            Membresía.MinimumWidth = 8;
            Membresía.Name = "Membresía";
            Membresía.Width = 150;
            // 
            // Datos
            // 
            Datos.HeaderText = "Datos";
            Datos.MinimumWidth = 8;
            Datos.Name = "Datos";
            Datos.Width = 150;
            // 
            // BTNAgregar
            // 
            BTNAgregar.BackColor = SystemColors.Window;
            BTNAgregar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNAgregar.FlatStyle = FlatStyle.Flat;
            BTNAgregar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNAgregar.Location = new Point(32, 136);
            BTNAgregar.Margin = new Padding(2, 2, 2, 2);
            BTNAgregar.Name = "BTNAgregar";
            BTNAgregar.Size = new Size(78, 20);
            BTNAgregar.TabIndex = 5;
            BTNAgregar.Text = "Agregar";
            BTNAgregar.UseVisualStyleBackColor = false;
            BTNAgregar.Click += BTNAgregar_Click_1;
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = SystemColors.Window;
            BTNEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNEliminar.FlatStyle = FlatStyle.Flat;
            BTNEliminar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNEliminar.Location = new Point(163, 136);
            BTNEliminar.Margin = new Padding(2, 2, 2, 2);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(79, 20);
            BTNEliminar.TabIndex = 6;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += BTNEliminar_Click_1;
            // 
            // BTNActualizar
            // 
            BTNActualizar.BackColor = SystemColors.Window;
            BTNActualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNActualizar.FlatStyle = FlatStyle.Flat;
            BTNActualizar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNActualizar.Location = new Point(293, 136);
            BTNActualizar.Margin = new Padding(2, 2, 2, 2);
            BTNActualizar.Name = "BTNActualizar";
            BTNActualizar.Size = new Size(78, 20);
            BTNActualizar.TabIndex = 7;
            BTNActualizar.Text = "Actualizar";
            BTNActualizar.UseVisualStyleBackColor = false;
            BTNActualizar.Click += BTNActualizar_Click;
            // 
            // BTNCerrar
            // 
            BTNCerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNCerrar.FlatStyle = FlatStyle.Flat;
            BTNCerrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.Location = new Point(415, 136);
            BTNCerrar.Margin = new Padding(2, 2, 2, 2);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(82, 20);
            BTNCerrar.TabIndex = 8;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = true;
            BTNCerrar.Click += BTNCerrar_Click;
            // 
            // FRMMembresias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(529, 218);
            Controls.Add(BTNCerrar);
            Controls.Add(BTNActualizar);
            Controls.Add(BTNEliminar);
            Controls.Add(BTNAgregar);
            Controls.Add(DgvMembresias);
            Controls.Add(CMBTipo);
            Controls.Add(TXBPrecio);
            Controls.Add(TXTNombre);
            Controls.Add(TXBId);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FRMMembresias";
            Text = "FRMMembresias";
            ((System.ComponentModel.ISupportInitialize)DgvMembresias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXBId;
        private TextBox TXTNombre;
        private TextBox TXBPrecio;
        private ComboBox CMBTipo;
        private DataGridView DgvMembresias;
        private Button BTNAgregar;
        private Button BTNEliminar;
        private Button BTNActualizar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Membresía;
        private DataGridViewTextBoxColumn Datos;
        private Button BTNCerrar;
    }
}