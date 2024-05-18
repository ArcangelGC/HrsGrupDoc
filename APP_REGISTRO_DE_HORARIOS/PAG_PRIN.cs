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
using System.Drawing;
using System.Drawing.Drawing2D;


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

            Thread hiloCrearForm = new Thread(() =>
            {
                CREAR_PARA crearForm = new CREAR_PARA();
                crearForm.ShowDialog();


            });
            hiloCrearForm.Start();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}