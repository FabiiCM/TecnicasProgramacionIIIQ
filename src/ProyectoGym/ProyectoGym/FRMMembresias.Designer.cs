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
            BTNAgregar = new Button();
            BTNEliminar = new Button();
            BTNActualizar = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Membresía = new DataGridViewTextBoxColumn();
            Datos = new DataGridViewTextBoxColumn();
            BTNCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvMembresias).BeginInit();
            SuspendLayout();
            // 
            // TXBId
            // 
            TXBId.Location = new Point(30, 29);
            TXBId.Name = "TXBId";
            TXBId.Size = new Size(150, 31);
            TXBId.TabIndex = 0;
            TXBId.Text = "ID";
            // 
            // TXTNombre
            // 
            TXTNombre.Location = new Point(196, 29);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(150, 31);
            TXTNombre.TabIndex = 1;
            TXTNombre.Text = "Nombre";
            // 
            // TXBPrecio
            // 
            TXBPrecio.Location = new Point(367, 29);
            TXBPrecio.Name = "TXBPrecio";
            TXBPrecio.Size = new Size(150, 31);
            TXBPrecio.TabIndex = 2;
            TXBPrecio.Text = "Precio";
            // 
            // CMBTipo
            // 
            CMBTipo.FormattingEnabled = true;
            CMBTipo.Items.AddRange(new object[] { "Mensual", "Trimestral", "Anual" });
            CMBTipo.Location = new Point(541, 29);
            CMBTipo.Name = "CMBTipo";
            CMBTipo.Size = new Size(182, 33);
            CMBTipo.TabIndex = 3;
            CMBTipo.Text = "Tipo Membresía";
            // 
            // DgvMembresias
            // 
            DgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMembresias.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, Membresía, Datos });
            DgvMembresias.Location = new Point(46, 88);
            DgvMembresias.Name = "DgvMembresias";
            DgvMembresias.RowHeadersWidth = 62;
            DgvMembresias.Size = new Size(664, 112);
            DgvMembresias.TabIndex = 4;
            // 
            // BTNAgregar
            // 
            BTNAgregar.BackColor = SystemColors.Window;
            BTNAgregar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNAgregar.FlatStyle = FlatStyle.Flat;
            BTNAgregar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNAgregar.Location = new Point(46, 227);
            BTNAgregar.Name = "BTNAgregar";
            BTNAgregar.Size = new Size(112, 34);
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
            BTNEliminar.Location = new Point(233, 227);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(113, 34);
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
            BTNActualizar.Location = new Point(419, 227);
            BTNActualizar.Name = "BTNActualizar";
            BTNActualizar.Size = new Size(112, 34);
            BTNActualizar.TabIndex = 7;
            BTNActualizar.Text = "Actualizar";
            BTNActualizar.UseVisualStyleBackColor = false;
            BTNActualizar.Click += BTNActualizar_Click;
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
            // BTNCerrar
            // 
            BTNCerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNCerrar.FlatStyle = FlatStyle.Flat;
            BTNCerrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.Location = new Point(593, 227);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(117, 34);
            BTNCerrar.TabIndex = 8;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = true;
            BTNCerrar.Click += BTNCerrar_Click;
            // 
            // FRMMembresias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(756, 290);
            Controls.Add(BTNCerrar);
            Controls.Add(BTNActualizar);
            Controls.Add(BTNEliminar);
            Controls.Add(BTNAgregar);
            Controls.Add(DgvMembresias);
            Controls.Add(CMBTipo);
            Controls.Add(TXBPrecio);
            Controls.Add(TXTNombre);
            Controls.Add(TXBId);
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