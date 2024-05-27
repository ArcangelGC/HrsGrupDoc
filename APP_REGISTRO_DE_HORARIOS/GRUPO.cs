using APP_REGISTRO_DE_HORARIOS.Resources;
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
    public partial class GRUPO : Form
    {
        private List<string> nombresGrupo = new List<string>();
        public GRUPO()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();


            comboBox1.Items.Add("Ingenieria en Sistemas Computacionales");
            comboBox1.Items.Add("Licenciatura en Administracion de Empresas");
            comboBox1.Items.Add("Licenciatura en Gestion Empresarial");
            comboBox1.Items.Add("Ingenieria Industrial");
            comboBox1.Items.Add("Ingenieria Mecatronica");
            comboBox1.Items.Add("Ingenieria civil");

            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_MIE_A_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            btn_MIE_A.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void btn_VIE_A_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            btn_VIE_A.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btn_LUN_A_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            btn_LUN_A.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btn_MAR_A_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HORARIO>();
            btn_MAR_A.BackColor = Color.FromArgb(12, 61, 92);
        }
        private void btn_JUE_A_Click(object sender, EventArgs e)
        {

            AbrirFormulario<HORARIO>();
            btn_JUE_A.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreGrupo = CLVG.Text;


            nombresGrupo.Add(nombreGrupo);


            CLVG.Text = "";
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel2.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                           //si el formulario/instancia existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel2.Controls.Add(formulario);
                panel2.Tag = formulario;
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
                btn_LUN_A.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btn_MAR_A.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btn_MIE_A.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btn_JUE_A.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btn_VIE_A.BackColor = Color.FromArgb(4, 41, 68);
        }

    }
}