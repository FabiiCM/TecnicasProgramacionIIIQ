namespace ProyectoGym
{
    partial class FRMIngresos
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            DGVUno = new DataGridView();
            DGId = new DataGridViewTextBoxColumn();
            DGFecha = new DataGridViewTextBoxColumn();
            DGConcepto = new DataGridViewTextBoxColumn();
            DGMonto = new DataGridViewTextBoxColumn();
            DGMetodo = new DataGridViewTextBoxColumn();
            DGCliente = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            LBFechaDesde = new Label();
            LBFechaHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            LBTipoIngreso = new Label();
            LBCliente = new Label();
            LBTotalIngresos = new Label();
            Membresías = new Label();
            LBIngresoPromedio = new Label();
            BTAgregar = new Button();
            BTEditar = new Button();
            BTEliminar = new Button();
            BTGenerar = new Button();
            BTNCerrar = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUno).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // DGVUno
            // 
            DGVUno.BackgroundColor = SystemColors.Window;
            DGVUno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUno.Columns.AddRange(new DataGridViewColumn[] { DGId, DGFecha, DGConcepto, DGMonto, DGMetodo, DGCliente });
            DGVUno.GridColor = SystemColors.MenuText;
            DGVUno.Location = new Point(18, 83);
            DGVUno.Margin = new Padding(2, 2, 2, 2);
            DGVUno.Name = "DGVUno";
            DGVUno.RowHeadersWidth = 62;
            DGVUno.Size = new Size(673, 78);
            DGVUno.TabIndex = 1;
            // 
            // DGId
            // 
            DGId.HeaderText = "ID";
            DGId.MinimumWidth = 8;
            DGId.Name = "DGId";
            DGId.Width = 150;
            // 
            // DGFecha
            // 
            DGFecha.HeaderText = "Fecha";
            DGFecha.MinimumWidth = 8;
            DGFecha.Name = "DGFecha";
            DGFecha.Width = 150;
            // 
            // DGConcepto
            // 
            DGConcepto.HeaderText = "Concepto";
            DGConcepto.MinimumWidth = 8;
            DGConcepto.Name = "DGConcepto";
            DGConcepto.Width = 150;
            // 
            // DGMonto
            // 
            DGMonto.HeaderText = "Monto";
            DGMonto.MinimumWidth = 8;
            DGMonto.Name = "DGMonto";
            DGMonto.Width = 150;
            // 
            // DGMetodo
            // 
            DGMetodo.HeaderText = "Método de Pago";
            DGMetodo.MinimumWidth = 8;
            DGMetodo.Name = "DGMetodo";
            DGMetodo.Width = 150;
            // 
            // DGCliente
            // 
            DGCliente.HeaderText = "Cliente";
            DGCliente.MinimumWidth = 8;
            DGCliente.Name = "DGCliente";
            DGCliente.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 11);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 43);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 43);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 4;
            // 
            // LBFechaDesde
            // 
            LBFechaDesde.AutoSize = true;
            LBFechaDesde.Location = new Point(18, 11);
            LBFechaDesde.Margin = new Padding(2, 0, 2, 0);
            LBFechaDesde.Name = "LBFechaDesde";
            LBFechaDesde.Size = new Size(76, 15);
            LBFechaDesde.TabIndex = 5;
            LBFechaDesde.Text = "Fecha Desde:";
            // 
            // LBFechaHasta
            // 
            LBFechaHasta.AutoSize = true;
            LBFechaHasta.Location = new Point(335, 11);
            LBFechaHasta.Margin = new Padding(2, 0, 2, 0);
            LBFechaHasta.Name = "LBFechaHasta";
            LBFechaHasta.Size = new Size(74, 15);
            LBFechaHasta.TabIndex = 6;
            LBFechaHasta.Text = "Fecha Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(410, 11);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(230, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // LBTipoIngreso
            // 
            LBTipoIngreso.AutoSize = true;
            LBTipoIngreso.Location = new Point(18, 45);
            LBTipoIngreso.Margin = new Padding(2, 0, 2, 0);
            LBTipoIngreso.Name = "LBTipoIngreso";
            LBTipoIngreso.Size = new Size(91, 15);
            LBTipoIngreso.TabIndex = 8;
            LBTipoIngreso.Text = "Tipo de Ingreso:";
            // 
            // LBCliente
            // 
            LBCliente.AutoSize = true;
            LBCliente.Location = new Point(328, 43);
            LBCliente.Margin = new Padding(2, 0, 2, 0);
            LBCliente.Name = "LBCliente";
            LBCliente.Size = new Size(47, 15);
            LBCliente.TabIndex = 9;
            LBCliente.Text = "Cliente:";
            // 
            // LBTotalIngresos
            // 
            LBTotalIngresos.AutoSize = true;
            LBTotalIngresos.Location = new Point(18, 181);
            LBTotalIngresos.Margin = new Padding(2, 0, 2, 0);
            LBTotalIngresos.Name = "LBTotalIngresos";
            LBTotalIngresos.Size = new Size(82, 15);
            LBTotalIngresos.TabIndex = 10;
            LBTotalIngresos.Text = "Total Ingresos:";
            // 
            // Membresías
            // 
            Membresías.AutoSize = true;
            Membresías.Location = new Point(310, 181);
            Membresías.Margin = new Padding(2, 0, 2, 0);
            Membresías.Name = "Membresías";
            Membresías.Size = new Size(74, 15);
            Membresías.TabIndex = 11;
            Membresías.Text = "Membresías:";
            // 
            // LBIngresoPromedio
            // 
            LBIngresoPromedio.AutoSize = true;
            LBIngresoPromedio.Location = new Point(582, 181);
            LBIngresoPromedio.Margin = new Padding(2, 0, 2, 0);
            LBIngresoPromedio.Name = "LBIngresoPromedio";
            LBIngresoPromedio.Size = new Size(104, 15);
            LBIngresoPromedio.TabIndex = 12;
            LBIngresoPromedio.Text = "Ingreso Promedio:";
            // 
            // BTAgregar
            // 
            BTAgregar.BackColor = SystemColors.Window;
            BTAgregar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTAgregar.FlatStyle = FlatStyle.Flat;
            BTAgregar.ForeColor = Color.FromArgb(255, 128, 0);
            BTAgregar.Location = new Point(53, 239);
            BTAgregar.Margin = new Padding(2, 2, 2, 2);
            BTAgregar.Name = "BTAgregar";
            BTAgregar.Size = new Size(78, 20);
            BTAgregar.TabIndex = 13;
            BTAgregar.Text = "Agregar";
            BTAgregar.UseVisualStyleBackColor = false;
            BTAgregar.Click += BTAgregar_Click;
            // 
            // BTEditar
            // 
            BTEditar.BackColor = SystemColors.Window;
            BTEditar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTEditar.FlatStyle = FlatStyle.Flat;
            BTEditar.ForeColor = Color.FromArgb(255, 128, 0);
            BTEditar.Location = new Point(213, 239);
            BTEditar.Margin = new Padding(2, 2, 2, 2);
            BTEditar.Name = "BTEditar";
            BTEditar.Size = new Size(78, 20);
            BTEditar.TabIndex = 14;
            BTEditar.Text = "Editar";
            BTEditar.UseVisualStyleBackColor = false;
            // 
            // BTEliminar
            // 
            BTEliminar.BackColor = SystemColors.Window;
            BTEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTEliminar.FlatStyle = FlatStyle.Flat;
            BTEliminar.ForeColor = Color.FromArgb(255, 128, 0);
            BTEliminar.Location = new Point(381, 239);
            BTEliminar.Margin = new Padding(2, 2, 2, 2);
            BTEliminar.Name = "BTEliminar";
            BTEliminar.Size = new Size(85, 20);
            BTEliminar.TabIndex = 15;
            BTEliminar.Text = "Eliminar";
            BTEliminar.UseVisualStyleBackColor = false;
            // 
            // BTGenerar
            // 
            BTGenerar.BackColor = SystemColors.Window;
            BTGenerar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTGenerar.FlatStyle = FlatStyle.Flat;
            BTGenerar.ForeColor = Color.FromArgb(255, 128, 0);
            BTGenerar.Location = new Point(561, 239);
            BTGenerar.Margin = new Padding(2, 2, 2, 2);
            BTGenerar.Name = "BTGenerar";
            BTGenerar.Size = new Size(120, 20);
            BTGenerar.TabIndex = 16;
            BTGenerar.Text = "Generar Reporte";
            BTGenerar.UseVisualStyleBackColor = false;
            // 
            // BTNCerrar
            // 
            BTNCerrar.BackColor = SystemColors.Window;
            BTNCerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNCerrar.FlatStyle = FlatStyle.Flat;
            BTNCerrar.ForeColor = Color.FromArgb(255, 128, 0);
            BTNCerrar.Location = new Point(623, 278);
            BTNCerrar.Margin = new Padding(2, 2, 2, 2);
            BTNCerrar.Name = "BTNCerrar";
            BTNCerrar.Size = new Size(57, 23);
            BTNCerrar.TabIndex = 17;
            BTNCerrar.Text = "Cerrar";
            BTNCerrar.UseVisualStyleBackColor = false;
            BTNCerrar.Click += BTNCerrar_Click;
            // 
            // FRMIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(723, 429);
            Controls.Add(BTNCerrar);
            Controls.Add(BTGenerar);
            Controls.Add(BTEliminar);
            Controls.Add(BTEditar);
            Controls.Add(BTAgregar);
            Controls.Add(LBIngresoPromedio);
            Controls.Add(Membresías);
            Controls.Add(LBTotalIngresos);
            Controls.Add(LBCliente);
            Controls.Add(LBTipoIngreso);
            Controls.Add(dateTimePicker2);
            Controls.Add(LBFechaHasta);
            Controls.Add(LBFechaDesde);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(DGVUno);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FRMIngresos";
            Text = "Ingresos";
            Load += FRMIngresos_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridView DGVUno;
        private DataGridViewTextBoxColumn DGId;
        private DataGridViewTextBoxColumn DGFecha;
        private DataGridViewTextBoxColumn DGConcepto;
        private DataGridViewTextBoxColumn DGMonto;
        private DataGridViewTextBoxColumn DGMetodo;
        private DataGridViewTextBoxColumn DGCliente;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label LBFechaDesde;
        private Label LBFechaHasta;
        private DateTimePicker dateTimePicker2;
        private Label LBTipoIngreso;
        private Label LBCliente;
        private Label LBTotalIngresos;
        private Label Membresías;
        private Label LBIngresoPromedio;
        private Button BTAgregar;
        private Button BTEditar;
        private Button BTEliminar;
        private Button BTGenerar;
        private Button BTNCerrar;
    }
}