﻿namespace ProyectoGym
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
            BTNSalir = new Button();
            SuspendLayout();
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(31, 27);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(183, 33);
            cmbEspecialidad.TabIndex = 0;
            cmbEspecialidad.Text = "Clases";
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(236, 27);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(183, 33);
            cmbHorario.TabIndex = 1;
            cmbHorario.Text = "Horario";
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = SystemColors.Window;
            btnAsignar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnAsignar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.ForeColor = Color.FromArgb(255, 128, 0);
            btnAsignar.Location = new Point(236, 155);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(176, 53);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar Horario";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click_1;
            // 
            // lstAsignaciones
            // 
            lstAsignaciones.FormattingEnabled = true;
            lstAsignaciones.ItemHeight = 25;
            lstAsignaciones.Location = new Point(31, 232);
            lstAsignaciones.Name = "lstAsignaciones";
            lstAsignaciones.Size = new Size(588, 129);
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
            cmbDificultad.Location = new Point(450, 27);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(183, 33);
            cmbDificultad.TabIndex = 5;
            cmbDificultad.Text = "Intensidad";
            // 
            // BTNSalir
            // 
            BTNSalir.BackColor = SystemColors.Window;
            BTNSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BTNSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            BTNSalir.FlatStyle = FlatStyle.Flat;
            BTNSalir.ForeColor = Color.FromArgb(255, 128, 0);
            BTNSalir.Location = new Point(531, 403);
            BTNSalir.Name = "BTNSalir";
            BTNSalir.Size = new Size(111, 53);
            BTNSalir.TabIndex = 6;
            BTNSalir.Text = "Salir";
            BTNSalir.UseVisualStyleBackColor = false;
            BTNSalir.Click += BTNSalir_Click_1;
            // 
            // FRMAsignacionHorarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(686, 500);
            Controls.Add(BTNSalir);
            Controls.Add(cmbDificultad);
            Controls.Add(txtDescripcion);
            Controls.Add(lstAsignaciones);
            Controls.Add(btnAsignar);
            Controls.Add(cmbHorario);
            Controls.Add(cmbEspecialidad);
            Name = "FRMAsignacionHorarios";
            Text = "Asignación Horarios";
            Load += FRMAsignacionHorarios_Load_1;
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
        private Button BTNSalir;
    }
}