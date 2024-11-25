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
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUno).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // DGVUno
            // 
            DGVUno.BackgroundColor = SystemColors.Window;
            DGVUno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUno.Columns.AddRange(new DataGridViewColumn[] { DGId, DGFecha, DGConcepto, DGMonto, DGMetodo, DGCliente });
            DGVUno.GridColor = SystemColors.MenuText;
            DGVUno.Location = new Point(26, 139);
            DGVUno.Name = "DGVUno";
            DGVUno.RowHeadersWidth = 62;
            DGVUno.Size = new Size(961, 130);
            DGVUno.TabIndex = 1;
            DGVUno.CellContentClick += dataGridView1_CellContentClick;
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
            dateTimePicker1.Location = new Point(148, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 33);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 31);
            textBox1.TabIndex = 4;
            // 
            // LBFechaDesde
            // 
            LBFechaDesde.AutoSize = true;
            LBFechaDesde.Location = new Point(26, 19);
            LBFechaDesde.Name = "LBFechaDesde";
            LBFechaDesde.Size = new Size(116, 25);
            LBFechaDesde.TabIndex = 5;
            LBFechaDesde.Text = "Fecha Desde:";
            // 
            // LBFechaHasta
            // 
            LBFechaHasta.AutoSize = true;
            LBFechaHasta.Location = new Point(469, 24);
            LBFechaHasta.Name = "LBFechaHasta";
            LBFechaHasta.Size = new Size(111, 25);
            LBFechaHasta.TabIndex = 6;
            LBFechaHasta.Text = "Fecha Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(586, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 7;
            // 
            // LBTipoIngreso
            // 
            LBTipoIngreso.AutoSize = true;
            LBTipoIngreso.Location = new Point(26, 75);
            LBTipoIngreso.Name = "LBTipoIngreso";
            LBTipoIngreso.Size = new Size(141, 25);
            LBTipoIngreso.TabIndex = 8;
            LBTipoIngreso.Text = "Tipo de Ingreso:";
            // 
            // LBCliente
            // 
            LBCliente.AutoSize = true;
            LBCliente.Location = new Point(469, 72);
            LBCliente.Name = "LBCliente";
            LBCliente.Size = new Size(69, 25);
            LBCliente.TabIndex = 9;
            LBCliente.Text = "Cliente:";
            // 
            // LBTotalIngresos
            // 
            LBTotalIngresos.AutoSize = true;
            LBTotalIngresos.Location = new Point(26, 302);
            LBTotalIngresos.Name = "LBTotalIngresos";
            LBTotalIngresos.Size = new Size(126, 25);
            LBTotalIngresos.TabIndex = 10;
            LBTotalIngresos.Text = "Total Ingresos:";
            // 
            // Membresías
            // 
            Membresías.AutoSize = true;
            Membresías.Location = new Point(443, 302);
            Membresías.Name = "Membresías";
            Membresías.Size = new Size(112, 25);
            Membresías.TabIndex = 11;
            Membresías.Text = "Membresías:";
            // 
            // LBIngresoPromedio
            // 
            LBIngresoPromedio.AutoSize = true;
            LBIngresoPromedio.Location = new Point(832, 302);
            LBIngresoPromedio.Name = "LBIngresoPromedio";
            LBIngresoPromedio.Size = new Size(159, 25);
            LBIngresoPromedio.TabIndex = 12;
            LBIngresoPromedio.Text = "Ingreso Promedio:";
            // 
            // BTAgregar
            // 
            BTAgregar.Location = new Point(76, 399);
            BTAgregar.Name = "BTAgregar";
            BTAgregar.Size = new Size(112, 34);
            BTAgregar.TabIndex = 13;
            BTAgregar.Text = "Agregar";
            BTAgregar.UseVisualStyleBackColor = true;
            BTAgregar.Click += BTAgregar_Click;
            // 
            // BTEditar
            // 
            BTEditar.Location = new Point(304, 399);
            BTEditar.Name = "BTEditar";
            BTEditar.Size = new Size(112, 34);
            BTEditar.TabIndex = 14;
            BTEditar.Text = "Editar";
            BTEditar.UseVisualStyleBackColor = true;
            // 
            // BTEliminar
            // 
            BTEliminar.Location = new Point(544, 399);
            BTEliminar.Name = "BTEliminar";
            BTEliminar.Size = new Size(121, 34);
            BTEliminar.TabIndex = 15;
            BTEliminar.Text = "Eliminar";
            BTEliminar.UseVisualStyleBackColor = true;
            // 
            // BTGenerar
            // 
            BTGenerar.Location = new Point(801, 399);
            BTGenerar.Name = "BTGenerar";
            BTGenerar.Size = new Size(171, 34);
            BTGenerar.TabIndex = 16;
            BTGenerar.Text = "Generar Reporte";
            BTGenerar.UseVisualStyleBackColor = true;
            // 
            // FRMIngresos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 456);
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
    }
}