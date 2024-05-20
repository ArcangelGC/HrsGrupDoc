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
    public partial class CREAR_PARA : Form
    {
        public CREAR_PARA()
        {
            InitializeComponent();
        }

        private void PARA_Click(object sender, EventArgs e)
        {

        }

        private void btn_DOC_Click(object sender, EventArgs e)
            {
                Thread hiloCrearForm = new Thread(() =>
                {
                    DOC docForm = new DOC();
                    docForm.ShowDialog();


                });
                hiloCrearForm.Start();
            }

            
        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {
                GRUPO GRForm = new GRUPO();
                GRForm.ShowDialog();

            });
            hiloCrearForm.Start();
            
        }

        private void CREAR_PARA_Load(object sender, EventArgs e)
        {

        }
    }
}
