namespace APP_REGISTRO_DE_HORARIOS
{
    partial class PAG_PRIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAG_PRIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttn_BUSCAR = new System.Windows.Forms.Button();
            this.BTN_BHG = new System.Windows.Forms.Button();
            this.btn_C_H_G = new System.Windows.Forms.Button();
            this.btn_Crear_H = new System.Windows.Forms.Button();
            this.rjButton1 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.rjButton4 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.btn_Crear_H1 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.rjButton2 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.rjButton3 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.rjButton5 = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelformularios.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 82);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"INSTITUTO TECNOLOGICO DE TLAXIACO\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.panelformularios);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 425);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelformularios
            // 
            this.panelformularios.Controls.Add(this.rjButton1);
            this.panelformularios.Location = new System.Drawing.Point(148, 0);
            this.panelformularios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(830, 425);
            this.panelformularios.TabIndex = 8;
            this.panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformularios_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjButton5);
            this.panel3.Controls.Add(this.bttn_BUSCAR);
            this.panel3.Controls.Add(this.BTN_BHG);
            this.panel3.Controls.Add(this.rjButton4);
            this.panel3.Controls.Add(this.btn_Crear_H1);
            this.panel3.Controls.Add(this.btn_C_H_G);
            this.panel3.Controls.Add(this.btn_Crear_H);
            this.panel3.Controls.Add(this.rjButton2);
            this.panel3.Controls.Add(this.rjButton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 425);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bttn_BUSCAR
            // 
            this.bttn_BUSCAR.BackColor = System.Drawing.Color.White;
            this.bttn_BUSCAR.FlatAppearance.BorderSize = 0;
            this.bttn_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_BUSCAR.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_BUSCAR.ForeColor = System.Drawing.Color.Black;
            this.bttn_BUSCAR.Location = new System.Drawing.Point(11, 220);
            this.bttn_BUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_BUSCAR.Name = "bttn_BUSCAR";
            this.bttn_BUSCAR.Size = new System.Drawing.Size(123, 60);
            this.bttn_BUSCAR.TabIndex = 6;
            this.bttn_BUSCAR.Text = "BUSCAR HORARIO DE DOCENTE";
            this.bttn_BUSCAR.UseVisualStyleBackColor = false;
            this.bttn_BUSCAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_BHG
            // 
            this.BTN_BHG.BackColor = System.Drawing.Color.White;
            this.BTN_BHG.FlatAppearance.BorderSize = 0;
            this.BTN_BHG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BHG.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BHG.ForeColor = System.Drawing.Color.Black;
            this.BTN_BHG.Location = new System.Drawing.Point(2, 313);
            this.BTN_BHG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_BHG.Name = "BTN_BHG";
            this.BTN_BHG.Size = new System.Drawing.Size(135, 40);
            this.BTN_BHG.TabIndex = 0;
            this.BTN_BHG.Text = "BUSCAR HORARIO DE GRUPO";
            this.BTN_BHG.UseVisualStyleBackColor = false;
            this.BTN_BHG.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_C_H_G
            // 
            this.btn_C_H_G.BackColor = System.Drawing.Color.White;
            this.btn_C_H_G.FlatAppearance.BorderSize = 0;
            this.btn_C_H_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C_H_G.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_H_G.ForeColor = System.Drawing.Color.Black;
            this.btn_C_H_G.Location = new System.Drawing.Point(11, 140);
            this.btn_C_H_G.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_C_H_G.Name = "btn_C_H_G";
            this.btn_C_H_G.Size = new System.Drawing.Size(123, 53);
            this.btn_C_H_G.TabIndex = 7;
            this.btn_C_H_G.Text = "CREAR HORARIO PARA GRUPO";
            this.btn_C_H_G.UseVisualStyleBackColor = false;
            this.btn_C_H_G.Click += new System.EventHandler(this.btn_C_H_G_Click);
            // 
            // btn_Crear_H
            // 
            this.btn_Crear_H.BackColor = System.Drawing.Color.White;
            this.btn_Crear_H.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Crear_H.FlatAppearance.BorderSize = 0;
            this.btn_Crear_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear_H.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear_H.ForeColor = System.Drawing.Color.Black;
            this.btn_Crear_H.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Crear_H.Location = new System.Drawing.Point(11, 54);
            this.btn_Crear_H.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Crear_H.Name = "btn_Crear_H";
            this.btn_Crear_H.Size = new System.Drawing.Size(126, 49);
            this.btn_Crear_H.TabIndex = 3;
            this.btn_Crear_H.Text = "CREAR HORARIO PARA DOCENTE";
            this.btn_Crear_H.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Crear_H.UseVisualStyleBackColor = false;
            this.btn_Crear_H.Click += new System.EventHandler(this.btn_Crear_H_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.Empty;
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(127, 63);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(8);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(131, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.White;
            this.rjButton4.BackgroundColor = System.Drawing.Color.White;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.Black;
            this.rjButton4.Location = new System.Drawing.Point(0, 214);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(143, 75);
            this.rjButton4.TabIndex = 8;
            this.rjButton4.TextColor = System.Drawing.Color.Black;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // btn_Crear_H1
            // 
            this.btn_Crear_H1.BackColor = System.Drawing.Color.White;
            this.btn_Crear_H1.BackgroundColor = System.Drawing.Color.White;
            this.btn_Crear_H1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Crear_H1.BorderRadius = 20;
            this.btn_Crear_H1.BorderSize = 0;
            this.btn_Crear_H1.FlatAppearance.BorderSize = 0;
            this.btn_Crear_H1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear_H1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear_H1.ForeColor = System.Drawing.Color.Black;
            this.btn_Crear_H1.Location = new System.Drawing.Point(0, 297);
            this.btn_Crear_H1.Name = "btn_Crear_H1";
            this.btn_Crear_H1.Size = new System.Drawing.Size(143, 75);
            this.btn_Crear_H1.TabIndex = 0;
            this.btn_Crear_H1.TextColor = System.Drawing.Color.Black;
            this.btn_Crear_H1.UseVisualStyleBackColor = false;
            this.btn_Crear_H1.Click += new System.EventHandler(this.btn_Crear_H1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(0, 42);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(143, 75);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Location = new System.Drawing.Point(0, 130);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(143, 75);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.White;
            this.rjButton5.BackgroundColor = System.Drawing.Color.White;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 20;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Anja Eliane", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.Black;
            this.rjButton5.Location = new System.Drawing.Point(11, 378);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(121, 37);
            this.rjButton5.TabIndex = 2;
            this.rjButton5.Text = "CONEXION";
            this.rjButton5.TextColor = System.Drawing.Color.Black;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // PAG_PRIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PAG_PRIN";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PAG_PRIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_BUSCAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Button BTN_BHG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Resources.RJButton btn_Crear_H1;
        private System.Windows.Forms.Button btn_C_H_G;
        private System.Windows.Forms.Button btn_Crear_H;
        private Resources.RJButton rjButton2;
        private Resources.RJButton rjButton3;
        private Resources.RJButton rjButton4;
        private Resources.RJButton rjButton1;
        private Resources.RJButton rjButton5;
    }
}

