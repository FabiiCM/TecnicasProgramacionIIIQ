namespace ProyectoGym
{
    partial class FRMAsignacionHorarios
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
            cmbEspecialidad = new ComboBox();
            cmbHorario = new ComboBox();
            btnAsignar = new Button();
            lstAsignaciones = new ListBox();
            txtDescripcion = new TextBox();
            cmbDificultad = new ComboBox();
            SuspendLayout();
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(31, 26);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(182, 33);
            cmbEspecialidad.TabIndex = 0;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(236, 26);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(182, 33);
            cmbHorario.TabIndex = 1;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(257, 172);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(176, 34);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar Horario";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lstAsignaciones
            // 
            lstAsignaciones.FormattingEnabled = true;
            lstAsignaciones.ItemHeight = 25;
            lstAsignaciones.Location = new Point(153, 232);
            lstAsignaciones.Name = "lstAsignaciones";
            lstAsignaciones.Size = new Size(368, 129);
            lstAsignaciones.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(31, 88);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(601, 31);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.Text = "Descripción";
            // 
            // cmbDificultad
            // 
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Location = new Point(450, 26);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(182, 33);
            cmbDificultad.TabIndex = 5;
            // 
            // FRMAsignacionHorarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDificultad);
            Controls.Add(txtDescripcion);
            Controls.Add(lstAsignaciones);
            Controls.Add(btnAsignar);
            Controls.Add(cmbHorario);
            Controls.Add(cmbEspecialidad);
            Name = "FRMAsignacionHorarios";
            Text = "Asignación Horarios";
            Load += FRMAsignacionHorarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHorario;
        private ComboBox cmbEspecialidad;
        private Button btnAsignar;
        private ListBox lstAsignaciones;
        private TextBox txtDescripcion;
        private ComboBox cmbDificultad;
    }
}