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
using MySql.Data.MySqlClient;


namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class PAG_PRIN : Form
    {
        public PAG_PRIN()
        {
            InitializeComponent();
        }
        private string conection = "server = localhost; port=3306; uid=root;pwd=''; database = horarios";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Crear_H_Click(object sender, EventArgs e)
        {

            AbrirFormulario<DOC>();
            btn_Crear_H1.BackColor = Color.FromArgb(12, 61, 92);
        }


        private void btn_Buscar_H_Click(object sender, EventArgs e)
        {
            
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
                btn_Crear_H1.BackColor = Color.FromArgb(4, 41, 68);
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
            AbrirFormulario<BUSCARHDcs>();
            rjButton1.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btn_C_H_G_Click(object sender, EventArgs e)
        {
            AbrirFormulario<GRUPO>();
            rjButton1.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Crear_H1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<buscarhg>();
            BTN_BHG.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            string conection = " server =localhost; port = 3306 ; uid=root; pwd=''; database= horarios  ; "; // declaro un objeto el cual enlaza 
            MySqlConnection conect = new MySqlConnection(conection);
            try
            {
                conect.Open();
                MessageBox.Show(" Se ha conectado correctamente a tu base de datos");
                conect.Close();
            }
            catch
            {
                MessageBox.Show(" error en concetarse a la base de datos");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
