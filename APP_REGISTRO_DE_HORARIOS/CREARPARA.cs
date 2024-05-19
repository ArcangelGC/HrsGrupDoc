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
            // Este evento está vacío, asegúrate de que esté vinculado correctamente en el diseñador si es necesario.
        }

        private void btn_DOC1_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {
                DOC docForm = new DOC();
                docForm.ShowDialog();
            });
            hiloCrearForm.Start();
        }

        private void btn_GRUP1_Click(object sender, EventArgs e)
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
            // Este evento está vacío, asegúrate de que esté vinculado correctamente en el diseñador si es necesario.
        }

        private void btn_GRUP1_Click_1(object sender, EventArgs e)
        {
            // Este evento parece ser un duplicado de btn_GRUP1_Click
        }
    }
}
