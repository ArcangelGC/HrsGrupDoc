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
    public partial class buscarH : Form
    {

        public buscarH(DOC doc)
        {
            InitializeComponent();
        }

        public buscarH()
        {
        }

        private void BuscD_Click(object sender, EventArgs e)
            {
            CREAR_PARA crearForm = new CREAR_PARA();


            crearForm.ShowDialog();
            
        }

        private void BGrupo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarH_Load(object sender, EventArgs e)
        {

        }

        private void BuscD_Click_1(object sender, EventArgs e)
        {

        }
    }
}
