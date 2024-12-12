namespace ProyectoGym
{
    partial class frmMenuUsuario
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
            mnsMenuUsuario = new MenuStrip();
            muCaptura = new ToolStripMenuItem();
            mnuClasesReservas = new ToolStripMenuItem();
            mnuInstructores = new ToolStripMenuItem();
            mnuFacturacion = new ToolStripMenuItem();
            mnuPagos = new ToolStripMenuItem();
            mnuInformacion = new ToolStripMenuItem();
            mnuInfoClases = new ToolStripMenuItem();
            mnuInfoInstructores = new ToolStripMenuItem();
            mnuInfoSucursales = new ToolStripMenuItem();
            mnuInfoMaquinas = new ToolStripMenuItem();
            mnuAyuda = new ToolStripMenuItem();
            mnuSoporteTecnico = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            BTSalir = new Button();
            mnsMenuUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuUsuario
            // 
            mnsMenuUsuario.ImageScalingSize = new Size(24, 24);
            mnsMenuUsuario.Items.AddRange(new ToolStripItem[] { muCaptura, mnuFacturacion, mnuInformacion, mnuAyuda, mnuSalir });
            mnsMenuUsuario.Location = new Point(0, 0);
            mnsMenuUsuario.Name = "mnsMenuUsuario";
            mnsMenuUsuario.Padding = new Padding(9, 3, 0, 3);
            mnsMenuUsuario.Size = new Size(503, 35);
            mnsMenuUsuario.TabIndex = 0;
            mnsMenuUsuario.Text = "menuStrip1";
            // 
            // muCaptura
            // 
            muCaptura.DropDownItems.AddRange(new ToolStripItem[] { mnuClasesReservas, mnuInstructores });
            muCaptura.Name = "muCaptura";
            muCaptura.Size = new Size(98, 29);
            muCaptura.Text = "Capturas";
            // 
            // mnuClasesReservas
            // 
            mnuClasesReservas.Name = "mnuClasesReservas";
            mnuClasesReservas.Size = new Size(255, 34);
            mnuClasesReservas.Text = "Clases y Reservas ";
            mnuClasesReservas.Click += mnuClasesReservas_Click;
            // 
            // mnuInstructores
            // 
            mnuInstructores.Name = "mnuInstructores";
            mnuInstructores.Size = new Size(255, 34);
            mnuInstructores.Text = "Instructores";
            // 
            // mnuFacturacion
            // 
            mnuFacturacion.DropDownItems.AddRange(new ToolStripItem[] { mnuPagos });
            mnuFacturacion.Name = "mnuFacturacion";
            mnuFacturacion.Size = new Size(117, 29);
            mnuFacturacion.Text = "Facturación";
            mnuFacturacion.Click += mnuFacturacion_Click;
            // 
            // mnuPagos
            // 
            mnuPagos.Name = "mnuPagos";
            mnuPagos.Size = new Size(270, 34);
            mnuPagos.Text = "Pagos ";
            mnuPagos.Click += mnuPagos_Click_1;
            // 
            // mnuInformacion
            // 
            mnuInformacion.DropDownItems.AddRange(new ToolStripItem[] { mnuInfoClases, mnuInfoInstructores, mnuInfoSucursales, mnuInfoMaquinas });
            mnuInformacion.Name = "mnuInformacion";
            mnuInformacion.Size = new Size(124, 29);
            mnuInformacion.Text = "Información";
            // 
            // mnuInfoClases
            // 
            mnuInfoClases.Name = "mnuInfoClases";
            mnuInfoClases.Size = new Size(207, 34);
            mnuInfoClases.Text = "Clases";
            // 
            // mnuInfoInstructores
            // 
            mnuInfoInstructores.Name = "mnuInfoInstructores";
            mnuInfoInstructores.Size = new Size(207, 34);
            mnuInfoInstructores.Text = "Instructores";
            // 
            // mnuInfoSucursales
            // 
            mnuInfoSucursales.Name = "mnuInfoSucursales";
            mnuInfoSucursales.Size = new Size(207, 34);
            mnuInfoSucursales.Text = "Sucursales";
            // 
            // mnuInfoMaquinas
            // 
            mnuInfoMaquinas.Name = "mnuInfoMaquinas";
            mnuInfoMaquinas.Size = new Size(207, 34);
            mnuInfoMaquinas.Text = "Maquinas";
            // 
            // mnuAyuda
            // 
            mnuAyuda.DropDownItems.AddRange(new ToolStripItem[] { mnuSoporteTecnico });
            mnuAyuda.Name = "mnuAyuda";
            mnuAyuda.Size = new Size(79, 29);
            mnuAyuda.Text = "Ayuda";
            // 
            // mnuSoporteTecnico
            // 
            mnuSoporteTecnico.Name = "mnuSoporteTecnico";
            mnuSoporteTecnico.Size = new Size(240, 34);
            mnuSoporteTecnico.Text = "Soporte Tecnico";
            // 
            // mnuSalir
            // 
            mnuSalir.DropDownItems.AddRange(new ToolStripItem[] { mnuCerrarSesion });
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(61, 29);
            mnuSalir.Text = "Salir";
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(218, 34);
            mnuCerrarSesion.Text = "Cerrar Sesión";
            mnuCerrarSesion.Click += mnuCerrarSesion_Click;
            // 
            // BTSalir
            // 
            BTSalir.Location = new Point(379, 367);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(112, 34);
            BTSalir.TabIndex = 1;
            BTSalir.Text = "Salir";
            BTSalir.UseVisualStyleBackColor = true;
            BTSalir.Click += BTSalir_Click;
            // 
            // frmMenuUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 413);
            Controls.Add(BTSalir);
            Controls.Add(mnsMenuUsuario);
            MainMenuStrip = mnsMenuUsuario;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenuUsuario";
            Text = "Menu";
            Load += frmMenuUsuario_Load;
            mnsMenuUsuario.ResumeLayout(false);
            mnsMenuUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenuUsuario;
        private ToolStripMenuItem muCaptura;
        private ToolStripMenuItem mnuFacturacion;
        private ToolStripMenuItem mnuInformacion;
        private ToolStripMenuItem mnuAyuda;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuClasesReservas;
        private ToolStripMenuItem mnuInstructores;
        private ToolStripMenuItem mnuPagos;
        private ToolStripMenuItem mnuInfoClases;
        private ToolStripMenuItem mnuInfoInstructores;
        private ToolStripMenuItem mnuInfoSucursales;
        private ToolStripMenuItem mnuInfoMaquinas;
        private ToolStripMenuItem mnuSoporteTecnico;
        private ToolStripMenuItem mnuCerrarSesion;
        private Button BTSalir;
    }
}