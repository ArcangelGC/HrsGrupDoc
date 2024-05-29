using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class VerDatos : Form
    {
        public VerDatos(List<string> horas, List<string> materias, List<string> aulas)
        {
            InitializeComponent();

            // Llenar los DataGridView con los datos recibidos
            foreach (var hora in horas)
            {
                H1.Rows.Add(hora);
            }

            foreach (var materia in materias)
            {
                M1.Rows.Add(materia);
            }

            foreach (var aula in aulas)
            {
                A2.Rows.Add(aula);
            }
        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento de clic en la celda del DataGridView de materias
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento de clic en el label
        }

        private void VerDatos_Load(object sender, EventArgs e)
        {
            // Evento de carga del formulario VerDatos
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

