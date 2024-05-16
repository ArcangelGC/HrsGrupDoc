using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void btn_AÑA_AULA_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string texto = ING_HORA.Text;

            
            if (!string.IsNullOrEmpty(texto))
            {
                HORAS.Add(texto);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string texto = ING_MAT.Text;


            if (!string.IsNullOrEmpty(texto))
            {
                MATER.Add(texto);
            }
        }

        private void ING_AULA_TextChanged(object sender, EventArgs e)
        {
            string texto = ING_AULA.Text;


            if (!string.IsNullOrEmpty(texto))
            {
                AULA.Add(texto);
            }
        }

        private void bTN_AÑA_HOR_Click(object sender, EventArgs e)
        {
            // Llamar a un método para guardar la información
            GuardarInformacion();
            this.Close();
        }

        private void GuardarInformacion()

        {
            // Aquí puedes guardar la información en una lista o en cualquier otro lugar
            // Por ejemplo, podrías agregar la información a las listas HORAS, MATER y AULA
            // que has definido en tu formulario
        }


        private int numeroTextBox = 1; // Variable para llevar la cuenta de los TextBox agregados

        private void btn_AÑA_MAT_Click(object sender, EventArgs e)
        {
            
            TextBox nuevoTextBoxMateria = new TextBox();
            nuevoTextBoxMateria.Name = "ING_MAT_" + numeroTextBox; 
            nuevoTextBoxMateria.Location = new Point(ING_MAT.Location.X, ING_MAT.Location.Y + (numeroTextBox * 30)); 
            nuevoTextBoxMateria.Size = ING_MAT.Size; 
            nuevoTextBoxMateria.TextChanged += NuevoTextBox_TextChanged;


            this.Controls.Add(nuevoTextBoxMateria);

           
            TextBox nuevoTextBoxHora = new TextBox();
            nuevoTextBoxHora.Name = "ING_HORA_" + numeroTextBox;
            nuevoTextBoxHora.Location = new Point(ING_HORA.Location.X, ING_HORA.Location.Y + (numeroTextBox * 30)); 
            
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

        }
    }
}
