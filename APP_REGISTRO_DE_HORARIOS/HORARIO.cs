using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class HORARIO : Form
    {
        private List<string> HORAS = new List<string>();
        private List<string> MATER = new List<string>();
        private List<string> AULA = new List<string>();

        public HORARIO()
        {
            InitializeComponent();
        }

        private void HORARIO_Load(object sender, EventArgs e)
        {
            // Cualquier código de inicialización que necesites
        }

        private void btn_AÑA_AULA_Click(object sender, EventArgs e)
        {
            // Código para el botón "Agregar Aula"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Código del evento TextChanged para el TextBox ING_HORA
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Código del evento TextChanged para el TextBox ING_MAT
        }

        private void ING_AULA_TextChanged(object sender, EventArgs e)
        {
            // Código del evento TextChanged para el TextBox ING_AULA
        }

        private void bTN_AÑA_HOR_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
            this.Close();
        }

        private void GuardarInformacion()
        {
            // Recoger los valores de los TextBox principales
            string hora = ING_HORA.Text;
            string materia = ING_MAT.Text;
            string aula = ING_AULA.Text;

            // Verificar si los campos no están vacíos y agregar a las listas
            if (!string.IsNullOrEmpty(hora))
            {
                HORAS.Add(hora);
            }

            if (!string.IsNullOrEmpty(materia))
            {
                MATER.Add(materia);
            }

            if (!string.IsNullOrEmpty(aula))
            {
                AULA.Add(aula);
            }

            // Recoger los valores de los TextBox dinámicos agregados
            for (int i = 1; i < numeroTextBox; i++)
            {
                Control[] controlesHora = this.Controls.Find("ING_HORA_" + i, true);
                Control[] controlesMateria = this.Controls.Find("ING_MAT_" + i, true);
                Control[] controlesAula = this.Controls.Find("ING_AULA_" + i, true);

                if (controlesHora.Length > 0 && controlesMateria.Length > 0 && controlesAula.Length > 0)
                {
                    TextBox textBoxHora = controlesHora[0] as TextBox;
                    TextBox textBoxMateria = controlesMateria[0] as TextBox;
                    TextBox textBoxAula = controlesAula[0] as TextBox;

                    if (!string.IsNullOrEmpty(textBoxHora.Text))
                    {
                        HORAS.Add(textBoxHora.Text);
                    }

                    if (!string.IsNullOrEmpty(textBoxMateria.Text))
                    {
                        MATER.Add(textBoxMateria.Text);
                    }

                    if (!string.IsNullOrEmpty(textBoxAula.Text))
                    {
                        AULA.Add(textBoxAula.Text);
                    }
                }
            }

            // Aquí puedes hacer algo con las listas HORAS, MATER y AULA, por ejemplo guardarlas en un archivo o mostrarlas en un cuadro de mensaje
            MessageBox.Show("Datos guardados correctamente.");
        }

        private int numeroTextBox = 1; // Variable para llevar la cuenta de los TextBox agregados

        private void btn_AÑA_MAT_Click(object sender, EventArgs e)
        {
            // Crear y configurar los nuevos TextBox
            TextBox nuevoTextBoxMateria = new TextBox();
            nuevoTextBoxMateria.Name = "ING_MAT_" + numeroTextBox;
            nuevoTextBoxMateria.Location = new Point(ING_MAT.Location.X, ING_MAT.Location.Y + (numeroTextBox * 30));
            nuevoTextBoxMateria.Size = ING_MAT.Size;
            nuevoTextBoxMateria.TextChanged += NuevoTextBox_TextChanged;
            this.Controls.Add(nuevoTextBoxMateria);

            TextBox nuevoTextBoxHora = new TextBox();
            nuevoTextBoxHora.Name = "ING_HORA_" + numeroTextBox;
            nuevoTextBoxHora.Location = new Point(ING_HORA.Location.X, ING_HORA.Location.Y + (numeroTextBox * 30));
            nuevoTextBoxHora.Size = ING_HORA.Size;
            nuevoTextBoxHora.TextChanged += NuevoTextBox_TextChanged;
            this.Controls.Add(nuevoTextBoxHora);

            TextBox nuevoTextBoxAula = new TextBox();
            nuevoTextBoxAula.Name = "ING_AULA_" + numeroTextBox;
            nuevoTextBoxAula.Location = new Point(ING_AULA.Location.X, ING_AULA.Location.Y + (numeroTextBox * 30));
            nuevoTextBoxAula.Size = ING_AULA.Size;
            nuevoTextBoxAula.TextChanged += NuevoTextBox_TextChanged;
            this.Controls.Add(nuevoTextBoxAula);

            numeroTextBox++;
        }

        private void NuevoTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string texto = textBox.Text;

            // Aquí puedes guardar la información en una lista o realizar cualquier otra acción
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código para el evento Click del label1
        }
    }
}
