using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class PAG_PRIN : Form
    {
        public PAG_PRIN()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Crear_H_Click(object sender, EventArgs e)
        {

            AbrirFormulario<DOC>();
            btn_Crear_H.BackColor = Color.FromArgb(12, 61, 92);
        }


        private void btn_Buscar_H_Click(object sender, EventArgs e)
        {
            // Crear un nuevo hilo para abrir el formulario de búsqueda.
            Thread hiloBuscarForm = new Thread(() =>
            {
                buscarH crearForm = new buscarH();
                crearForm.ShowDialog();
            });

            hiloBuscarForm.Start();
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btn_Crear_H.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                bttn_BUSCAR.BackColor = Color.FromArgb(4, 41, 68);
            
        }

private void btn_PAG_PRIN_Click(object sender, EventArgs e)
        {

        }

        private void PAG_PRIN_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
