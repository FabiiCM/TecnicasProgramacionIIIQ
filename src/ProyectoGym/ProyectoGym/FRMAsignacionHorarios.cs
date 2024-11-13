using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGym
{
    public partial class FRMAsignacionHorarios : Form
    {
        // Lista para almacenar las asignaciones
        private List<string> asignaciones = new List<string>();
        public FRMAsignacionHorarios()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Rellenar ComboBox de especialidades
            cmbEspecialidad.Items.AddRange(new string[] {
                "Personal",
                "Funcionales",
                "Zumba",
                "Cardio"
            });

            // Rellenar ComboBox de horarios
            cmbHorario.Items.AddRange(new string[] {
                "08:00 - 10:00",
                "10:00 - 12:00",
                "14:00 - 16:00",
                "16:00 - 18:00"
            });

            // Rellenar ComboBox de niveles de dificultad
            cmbDificultad.Items.AddRange(new string[] { "Bajo", "Medio", "Alto" });


            // Seleccionar primer elemento por defecto
            if (cmbEspecialidad.Items.Count > 0) cmbEspecialidad.SelectedIndex = 0;
            if (cmbHorario.Items.Count > 0) cmbHorario.SelectedIndex = 0;
        }


        private void FRMAsignacionHorarios_Load(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            // Obtener valores seleccionados
            string especialidad = cmbEspecialidad.SelectedItem?.ToString() ?? string.Empty;
            string horario = cmbHorario.SelectedItem?.ToString() ?? string.Empty;
            string descripcion = txtDescripcion.Text;
            string dificultad = cmbDificultad.SelectedItem?.ToString() ?? string.Empty;

            // Validar que todos los campos estén llenos
            if (!string.IsNullOrEmpty(especialidad) && !string.IsNullOrEmpty(horario) &&
                !string.IsNullOrEmpty(descripcion) && !string.IsNullOrEmpty(dificultad))
            {
                // Formatear y agregar la asignación a la lista
                string asignacion = $"Especialidad: {especialidad} - Horario: {horario} - Descripción: {descripcion} - Dificultad: {dificultad}";
                asignaciones.Add(asignacion);

                // Mostrar asignaciones en ListBox
                lstAsignaciones.Items.Clear();
                lstAsignaciones.Items.AddRange(asignaciones.ToArray());

                MessageBox.Show("Asignación realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void BTNSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaSesion = new FRMInicio();
            ventanaSesion.Show();
        }
    }
}


