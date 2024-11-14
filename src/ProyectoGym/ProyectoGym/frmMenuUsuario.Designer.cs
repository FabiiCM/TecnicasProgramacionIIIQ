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
            MnuClasesReservas = new ToolStripMenuItem();
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
            mnsMenuUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuUsuario
            // 
            mnsMenuUsuario.Items.AddRange(new ToolStripItem[] { muCaptura, mnuFacturacion, mnuInformacion, mnuAyuda, mnuSalir });
            mnsMenuUsuario.Location = new Point(0, 0);
            mnsMenuUsuario.Name = "mnsMenuUsuario";
            mnsMenuUsuario.Size = new Size(352, 24);
            mnsMenuUsuario.TabIndex = 0;
            mnsMenuUsuario.Text = "menuStrip1";
            // 
            // muCaptura
            // 
            muCaptura.DropDownItems.AddRange(new ToolStripItem[] { MnuClasesReservas, mnuInstructores });
            muCaptura.Name = "muCaptura";
            muCaptura.Size = new Size(66, 20);
            muCaptura.Text = "Capturas";
            muCaptura.Click += clasesToolStripMenuItem_Click;
            // 
            // MnuClasesReservas
            // 
            MnuClasesReservas.Name = "MnuClasesReservas";
            MnuClasesReservas.Size = new Size(180, 22);
            MnuClasesReservas.Text = "Clases y Reservas ";
            // 
            // mnuInstructores
            // 
            mnuInstructores.Name = "mnuInstructores";
            mnuInstructores.Size = new Size(180, 22);
            mnuInstructores.Text = "Instructores";
            // 
            // mnuFacturacion
            // 
            mnuFacturacion.DropDownItems.AddRange(new ToolStripItem[] { mnuPagos });
            mnuFacturacion.Name = "mnuFacturacion";
            mnuFacturacion.Size = new Size(81, 20);
            mnuFacturacion.Text = "Facturación";
            // 
            // mnuPagos
            // 
            mnuPagos.Name = "mnuPagos";
            mnuPagos.Size = new Size(109, 22);
            mnuPagos.Text = "Pagos ";
            // 
            // mnuInformacion
            // 
            mnuInformacion.DropDownItems.AddRange(new ToolStripItem[] { mnuInfoClases, mnuInfoInstructores, mnuInfoSucursales, mnuInfoMaquinas });
            mnuInformacion.Name = "mnuInformacion";
            mnuInformacion.Size = new Size(84, 20);
            mnuInformacion.Text = "Información";
            mnuInformacion.Click += ayudaToolStripMenuItem_Click;
            // 
            // mnuInfoClases
            // 
            mnuInfoClases.Name = "mnuInfoClases";
            mnuInfoClases.Size = new Size(136, 22);
            mnuInfoClases.Text = "Clases";
            // 
            // mnuInfoInstructores
            // 
            mnuInfoInstructores.Name = "mnuInfoInstructores";
            mnuInfoInstructores.Size = new Size(136, 22);
            mnuInfoInstructores.Text = "Instructores";
            // 
            // mnuInfoSucursales
            // 
            mnuInfoSucursales.Name = "mnuInfoSucursales";
            mnuInfoSucursales.Size = new Size(136, 22);
            mnuInfoSucursales.Text = "Sucursales";
            // 
            // mnuInfoMaquinas
            // 
            mnuInfoMaquinas.Name = "mnuInfoMaquinas";
            mnuInfoMaquinas.Size = new Size(136, 22);
            mnuInfoMaquinas.Text = "Maquinas";
            // 
            // mnuAyuda
            // 
            mnuAyuda.DropDownItems.AddRange(new ToolStripItem[] { mnuSoporteTecnico });
            mnuAyuda.Name = "mnuAyuda";
            mnuAyuda.Size = new Size(53, 20);
            mnuAyuda.Text = "Ayuda";
            // 
            // mnuSoporteTecnico
            // 
            mnuSoporteTecnico.Name = "mnuSoporteTecnico";
            mnuSoporteTecnico.Size = new Size(158, 22);
            mnuSoporteTecnico.Text = "Soporte Tecnico";
            // 
            // mnuSalir
            // 
            mnuSalir.DropDownItems.AddRange(new ToolStripItem[] { mnuCerrarSesion });
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(41, 20);
            mnuSalir.Text = "Salir";
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(143, 22);
            mnuCerrarSesion.Text = "Cerrar Sesión";
            // 
            // frmMenuUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 248);
            Controls.Add(mnsMenuUsuario);
            MainMenuStrip = mnsMenuUsuario;
            Name = "frmMenuUsuario";
            Text = "Menu";
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
        private ToolStripMenuItem MnuClasesReservas;
        private ToolStripMenuItem mnuInstructores;
        private ToolStripMenuItem mnuPagos;
        private ToolStripMenuItem mnuInfoClases;
        private ToolStripMenuItem mnuInfoInstructores;
        private ToolStripMenuItem mnuInfoSucursales;
        private ToolStripMenuItem mnuInfoMaquinas;
        private ToolStripMenuItem mnuSoporteTecnico;
        private ToolStripMenuItem mnuCerrarSesion;
    }
}