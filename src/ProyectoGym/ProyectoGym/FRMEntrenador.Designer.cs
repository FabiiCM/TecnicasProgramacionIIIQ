namespace ProyectoGym
{
    partial class FRMEntrenador
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
            MSInventario = new ToolStripMenuItem();
            MSAgregar = new ToolStripMenuItem();
            MSEditar = new ToolStripMenuItem();
            MSEliminar = new ToolStripMenuItem();
            MSMembresias = new ToolStripMenuItem();
            MSAgregarMembresia = new ToolStripMenuItem();
            MSRenovarMembresia = new ToolStripMenuItem();
            MSEliminarMembresia = new ToolStripMenuItem();
            MSReservas = new ToolStripMenuItem();
            MSAgregarReserva = new ToolStripMenuItem();
            MSEditarReserva = new ToolStripMenuItem();
            MSEliminarReserva = new ToolStripMenuItem();
            MSReportes = new ToolStripMenuItem();
            MSIngresos = new ToolStripMenuItem();
            MSMembresiasR = new ToolStripMenuItem();
            MSReservasR = new ToolStripMenuItem();
            BTNSalir = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSInventario, MSMembresias, MSReservas, MSReportes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(439, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSInventario
            // 
            MSInventario.BackColor = SystemColors.Window;
            MSInventario.DropDownItems.AddRange(new ToolStripItem[] { MSAgregar, MSEditar, MSEliminar });
            MSInventario.Name = "MSInventario";
            MSInventario.Size = new Size(107, 29);
            MSInventario.Text = "Inventario";
            MSInventario.Click += MSInventario_Click;
            // 
            // MSAgregar
            // 
            MSAgregar.Name = "MSAgregar";
            MSAgregar.Size = new Size(270, 34);
            MSAgregar.Text = "Agregar";
            // 
            // MSEditar
            // 
            MSEditar.Name = "MSEditar";
            MSEditar.Size = new Size(270, 34);
            MSEditar.Text = "Editar";
            // 
            // MSEliminar
            // 
            MSEliminar.Name = "MSEliminar";
            MSEliminar.Size = new Size(270, 34);
            MSEliminar.Text = "Eliminar";
            // 
            // MSMembresias
            // 
            MSMembresias.BackColor = SystemColors.Window;
            MSMembresias.DropDownItems.AddRange(new ToolStripItem[] { MSAgregarMembresia, MSRenovarMembresia, MSEliminarMembresia });
            MSMembresias.Name = "MSMembresias";
            MSMembresias.Size = new Size(124, 29);
            MSMembresias.Text = "Membresías";
            MSMembresias.Click += MSMembresias_Click;
            // 
            // MSAgregarMembresia
            // 
            MSAgregarMembresia.Name = "MSAgregarMembresia";
            MSAgregarMembresia.Size = new Size(270, 34);
            MSAgregarMembresia.Text = "Agregar";
            // 
            // MSRenovarMembresia
            // 
            MSRenovarMembresia.Name = "MSRenovarMembresia";
            MSRenovarMembresia.Size = new Size(270, 34);
            MSRenovarMembresia.Text = "Renovar";
            // 
            // MSEliminarMembresia
            // 
            MSEliminarMembresia.Name = "MSEliminarMembresia";
            MSEliminarMembresia.Size = new Size(270, 34);
            MSEliminarMembresia.Text = "Eliminar";
            // 
            // MSReservas
            // 
            MSReservas.BackColor = SystemColors.Window;
            MSReservas.DropDownItems.AddRange(new ToolStripItem[] { MSAgregarReserva, MSEditarReserva, MSEliminarReserva });
            MSReservas.Name = "MSReservas";
            MSReservas.Size = new Size(96, 29);
            MSReservas.Text = "Reservas";
            MSReservas.Click += MSReservas_Click;
            // 
            // MSAgregarReserva
            // 
            MSAgregarReserva.Name = "MSAgregarReserva";
            MSAgregarReserva.Size = new Size(270, 34);
            MSAgregarReserva.Text = "Agregar Reserva";
            // 
            // MSEditarReserva
            // 
            MSEditarReserva.Name = "MSEditarReserva";
            MSEditarReserva.Size = new Size(270, 34);
            MSEditarReserva.Text = "Editar Reserva";
            // 
            // MSEliminarReserva
            // 
            MSEliminarReserva.Name = "MSEliminarReserva";
            MSEliminarReserva.Size = new Size(270, 34);
            MSEliminarReserva.Text = "Eliminar Reserva";
            // 
            // MSReportes
            // 
            MSReportes.BackColor = SystemColors.Window;
            MSReportes.DropDownItems.AddRange(new ToolStripItem[] { MSIngresos, MSMembresiasR, MSReservasR });
            MSReportes.Name = "MSReportes";
            MSReportes.Size = new Size(98, 29);
            MSReportes.Text = "Reportes";
            MSReportes.Click += MSReportes_Click;
            // 
            // MSIngresos
            // 
            MSIngresos.Name = "MSIngresos";
            MSIngresos.Size = new Size(270, 34);
            MSIngresos.Text = "Ingresos";
            MSIngresos.Click += MSIngresos_Click;
            // 
            // MSMembresiasR
            // 
            MSMembresiasR.Name = "MSMembresiasR";
            MSMembresiasR.Size = new Size(270, 34);
            MSMembresiasR.Text = "Membresías";
            // 
            // MSReservasR
            // 
            MSReservasR.Name = "MSReservasR";
            MSReservasR.Size = new Size(270, 34);
            MSReservasR.Text = "Reservas";
            // 
            // BTNSalir
            // 
            BTNSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNSalir.FlatStyle = FlatStyle.Flat;
            BTNSalir.ForeColor = Color.FromArgb(255, 128, 0);
            BTNSalir.Location = new Point(161, 249);
            BTNSalir.Name = "BTNSalir";
            BTNSalir.Size = new Size(112, 34);
            BTNSalir.TabIndex = 1;
            BTNSalir.Text = "Salir";
            BTNSalir.UseVisualStyleBackColor = true;
            BTNSalir.Click += BTNSalir_Click;
            // 
            // FRMEntrenador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(439, 295);
            Controls.Add(BTNSalir);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FRMEntrenador";
            Text = "Entrenador";
            Load += FRMEntrenador_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSInventario;
        private ToolStripMenuItem MSAgregar;
        private ToolStripMenuItem MSEditar;
        private ToolStripMenuItem MSEliminar;
        private ToolStripMenuItem MSMembresias;
        private ToolStripMenuItem MSAgregarMembresia;
        private ToolStripMenuItem MSRenovarMembresia;
        private ToolStripMenuItem MSEliminarMembresia;
        private ToolStripMenuItem MSReservas;
        private ToolStripMenuItem MSAgregarReserva;
        private ToolStripMenuItem MSEditarReserva;
        private ToolStripMenuItem MSEliminarReserva;
        private ToolStripMenuItem MSReportes;
        private ToolStripMenuItem MSIngresos;
        private ToolStripMenuItem MSMembresiasR;
        private ToolStripMenuItem MSReservasR;
        private Button BTNSalir;
    }
}