﻿namespace APP_REGISTRO_DE_HORARIOS
{
    partial class DOC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NOMDOC = new System.Windows.Forms.TextBox();
            this.TEX_ING_NOM = new System.Windows.Forms.Label();
            this.CLAVDOC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_LUN = new System.Windows.Forms.Button();
            this.btn_JUEVES = new System.Windows.Forms.Button();
            this.btn_VIER = new System.Windows.Forms.Button();
            this.btn_MIER = new System.Windows.Forms.Button();
            this.btn_MARTES = new System.Windows.Forms.Button();
            this.panel_DIAS = new System.Windows.Forms.Panel();
            this.btn_AÑA_MAT = new System.Windows.Forms.Button();
            this.panel_DIAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // NOMDOC
            // 
            this.NOMDOC.Location = new System.Drawing.Point(392, 7);
            this.NOMDOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NOMDOC.Name = "NOMDOC";
            this.NOMDOC.Size = new System.Drawing.Size(104, 20);
            this.NOMDOC.TabIndex = 4;
            this.NOMDOC.TextChanged += new System.EventHandler(this.ING_NOM_DOC_TextChanged);
            // 
            // TEX_ING_NOM
            // 
            this.TEX_ING_NOM.AutoSize = true;
            this.TEX_ING_NOM.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEX_ING_NOM.ForeColor = System.Drawing.Color.White;
            this.TEX_ING_NOM.Location = new System.Drawing.Point(298, 7);
            this.TEX_ING_NOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TEX_ING_NOM.Name = "TEX_ING_NOM";
            this.TEX_ING_NOM.Size = new System.Drawing.Size(86, 30);
            this.TEX_ING_NOM.TabIndex = 3;
            this.TEX_ING_NOM.Text = "INGRESA EL \r\nNOMBRE: ";
            this.TEX_ING_NOM.Click += new System.EventHandler(this.TEX_ING_NOM_Click);
            // 
            // CLAVDOC
            // 
            this.CLAVDOC.Location = new System.Drawing.Point(165, 10);
            this.CLAVDOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLAVDOC.Name = "CLAVDOC";
            this.CLAVDOC.Size = new System.Drawing.Size(104, 20);
            this.CLAVDOC.TabIndex = 2;
            this.CLAVDOC.TextChanged += new System.EventHandler(this.CLAVE_DOC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA LA CLAVE\r\n DEL DOCENTE:\r\n";
            // 
            // BTN_LUN
            // 
            this.BTN_LUN.BackColor = System.Drawing.Color.MidnightBlue;
            this.BTN_LUN.FlatAppearance.BorderSize = 0;
            this.BTN_LUN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LUN.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LUN.ForeColor = System.Drawing.Color.White;
            this.BTN_LUN.Location = new System.Drawing.Point(35, 64);
            this.BTN_LUN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_LUN.Name = "BTN_LUN";
            this.BTN_LUN.Size = new System.Drawing.Size(64, 42);
            this.BTN_LUN.TabIndex = 1;
            this.BTN_LUN.Text = "LUNES";
            this.BTN_LUN.UseVisualStyleBackColor = false;
            this.BTN_LUN.Click += new System.EventHandler(this.BTN_LUN_Click);
            // 
            // btn_JUEVES
            // 
            this.btn_JUEVES.FlatAppearance.BorderSize = 0;
            this.btn_JUEVES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JUEVES.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JUEVES.ForeColor = System.Drawing.Color.White;
            this.btn_JUEVES.Location = new System.Drawing.Point(301, 64);
            this.btn_JUEVES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_JUEVES.Name = "btn_JUEVES";
            this.btn_JUEVES.Size = new System.Drawing.Size(80, 42);
            this.btn_JUEVES.TabIndex = 2;
            this.btn_JUEVES.Text = "JUEVES";
            this.btn_JUEVES.UseVisualStyleBackColor = true;
            this.btn_JUEVES.Click += new System.EventHandler(this.btn_JUEVES_Click);
            // 
            // btn_VIER
            // 
            this.btn_VIER.FlatAppearance.BorderSize = 0;
            this.btn_VIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VIER.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VIER.ForeColor = System.Drawing.Color.White;
            this.btn_VIER.Location = new System.Drawing.Point(392, 64);
            this.btn_VIER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VIER.Name = "btn_VIER";
            this.btn_VIER.Size = new System.Drawing.Size(76, 42);
            this.btn_VIER.TabIndex = 3;
            this.btn_VIER.Text = "VIERNES";
            this.btn_VIER.UseVisualStyleBackColor = true;
            this.btn_VIER.Click += new System.EventHandler(this.btn_VIER_Click);
            // 
            // btn_MIER
            // 
            this.btn_MIER.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MIER.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_MIER.FlatAppearance.BorderSize = 0;
            this.btn_MIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MIER.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MIER.ForeColor = System.Drawing.Color.White;
            this.btn_MIER.Location = new System.Drawing.Point(190, 64);
            this.btn_MIER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_MIER.Name = "btn_MIER";
            this.btn_MIER.Size = new System.Drawing.Size(94, 42);
            this.btn_MIER.TabIndex = 4;
            this.btn_MIER.Text = "MIERCOLES";
            this.btn_MIER.UseVisualStyleBackColor = false;
            this.btn_MIER.Click += new System.EventHandler(this.btn_MIER_Click);
            // 
            // btn_MARTES
            // 
            this.btn_MARTES.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MARTES.FlatAppearance.BorderSize = 0;
            this.btn_MARTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MARTES.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MARTES.ForeColor = System.Drawing.Color.White;
            this.btn_MARTES.Location = new System.Drawing.Point(112, 64);
            this.btn_MARTES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_MARTES.Name = "btn_MARTES";
            this.btn_MARTES.Size = new System.Drawing.Size(74, 42);
            this.btn_MARTES.TabIndex = 5;
            this.btn_MARTES.Text = "MARTES";
            this.btn_MARTES.UseVisualStyleBackColor = false;
            this.btn_MARTES.Click += new System.EventHandler(this.btn_MARTES_Click);
            // 
            // panel_DIAS
            // 
            this.panel_DIAS.Controls.Add(this.label1);
            this.panel_DIAS.Controls.Add(this.CLAVDOC);
            this.panel_DIAS.Controls.Add(this.NOMDOC);
            this.panel_DIAS.Controls.Add(this.TEX_ING_NOM);
            this.panel_DIAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DIAS.Location = new System.Drawing.Point(0, 0);
            this.panel_DIAS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_DIAS.Name = "panel_DIAS";
            this.panel_DIAS.Size = new System.Drawing.Size(1000, 42);
            this.panel_DIAS.TabIndex = 6;
            // 
            // btn_AÑA_MAT
            // 
            this.btn_AÑA_MAT.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AÑA_MAT.Location = new System.Drawing.Point(954, 42);
            this.btn_AÑA_MAT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AÑA_MAT.Name = "btn_AÑA_MAT";
            this.btn_AÑA_MAT.Size = new System.Drawing.Size(27, 24);
            this.btn_AÑA_MAT.TabIndex = 10;
            this.btn_AÑA_MAT.Text = "+";
            this.btn_AÑA_MAT.UseVisualStyleBackColor = true;
            this.btn_AÑA_MAT.Click += new System.EventHandler(this.btn_AÑA_MAT_Click);
            // 
            // DOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.btn_AÑA_MAT);
            this.Controls.Add(this.btn_VIER);
            this.Controls.Add(this.BTN_LUN);
            this.Controls.Add(this.btn_JUEVES);
            this.Controls.Add(this.btn_MIER);
            this.Controls.Add(this.panel_DIAS);
            this.Controls.Add(this.btn_MARTES);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DOC";
            this.Text = "Registro para docente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_DIAS.ResumeLayout(false);
            this.panel_DIAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox CLAVDOC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TEX_ING_NOM;
        private System.Windows.Forms.TextBox NOMDOC;
        private System.Windows.Forms.Button BTN_LUN;
        private System.Windows.Forms.Button btn_JUEVES;
        private System.Windows.Forms.Button btn_VIER;
        private System.Windows.Forms.Button btn_MIER;
        private System.Windows.Forms.Button btn_MARTES;
        private System.Windows.Forms.Panel panel_DIAS;
        private System.Windows.Forms.Button btn_AÑA_MAT;
    }
}