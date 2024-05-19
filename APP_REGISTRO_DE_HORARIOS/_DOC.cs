﻿using System;
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
using Funciones;

namespace APP_REGISTRO_DE_HORARIOS
{
    public partial class DOC : Form
    {
        private List<string> HORAS = new List<string>();
        private List<string> NOM = new List<string>();
        private List<string> rfcs = new List<string>();
        private List<string> MATER = new List<string>();
        private List<string> AULA = new List<string>();

        public DOC()
        {
            InitializeComponent();
        }

        private void TEX_ING_NOM_Click(object sender, EventArgs e)
        {
           
        }
        private void BTN_LUN_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {
                HORARIO horForm = new HORARIO();


                horForm.ShowDialog();
            });

            hiloCrearForm.Start();
        }

        private void btn_VIER_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {

                HORARIO horForm = new HORARIO();


                horForm.ShowDialog();


            });

            hiloCrearForm.Start();


        }

        private void btn_MIER_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {

                HORARIO horForm = new HORARIO();


                horForm.ShowDialog();


            });

            hiloCrearForm.Start();


        }

        private void btn_JUEVES_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {

                HORARIO horForm = new HORARIO();


                horForm.ShowDialog();


            });

            hiloCrearForm.Start();


        }

        private void btn_MARTES_Click(object sender, EventArgs e)
        {
            Thread hiloCrearForm = new Thread(() =>
            {

                HORARIO horForm = new HORARIO();


                horForm.ShowDialog();


            });

            hiloCrearForm.Start();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string texto = ING_HORA.Text;


            if (!string.IsNullOrEmpty(texto))
            {
                HORAS.Add(texto);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AÑA_MAT_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ING_HORA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ING_MAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ING_AULA_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTN_AÑA_HOR_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
            this.Close();
        }

        private void GuardarInformacion()

        {
            // Aquí puedes guardar la información en una lista o en cualquier otro lugar
            // Por ejemplo, podrías agregar la información a las listas HORAS, MATER y AULA
            // que has definido en tu formulario
        }


        private int numeroTextBox = 1;
        private void btn_AÑA_MAT1_Click(object sender, EventArgs e)
        {

        }
        private void NuevoTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string texto = textBox.Text;

        }

    }
}