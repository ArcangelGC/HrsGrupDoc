using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_REGISTRO_DE_HORARIOS.Resources;
using Funciones;

namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class DOC : Form
    {
        private List<string> HORAS = new List<string>();
        private List<string> NOM = new List<string>();
        private List<string> rfcs = new List<string>();

        public object ING_HORA { get; private set; }
        public object ING_MAT { get; private set; }

        public DOC()
        {
            InitializeComponent();
        }

        private void TEX_ING_NOM_Click(object sender, EventArgs e)
        {

        }
        private void BTN_LUN_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            BTN_LUN.BackColor = Color.FromArgb(12, 61, 92);
            
        }

        private void btn_VIER_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            BTN_LUN.BackColor = Color.FromArgb(12, 61, 92);


        }

        private void btn_MIER_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            BTN_LUN.BackColor = Color.FromArgb(12, 61, 92);


        }

        private void btn_JUEVES_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            BTN_LUN.BackColor = Color.FromArgb(12, 61, 92);


        }

        private void btn_MARTES_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            BTN_LUN.BackColor = Color.FromArgb(12, 61, 92);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ING_NOM_DOC_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLAVE_DOC_TextChanged(object sender, EventArgs e)
        {
        }

        public List<string> ObtenerNombres()
        {
            return NOM;
        }

        public List<string> ObtenerRFCs()
        {
            return rfcs;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AÑA_MAT_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelf2.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                            //si el formulario/instancia existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelf2.Controls.Add(formulario);
                panelf2.Tag = formulario;
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
                BTN_LUN.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btn_MARTES.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form1"] == null)
                btn_MIER.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form1"] == null)
                btn_JUEVES.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form1"] == null)
                btn_VIER.BackColor = Color.FromArgb(4, 41, 68);
        }
    }
}