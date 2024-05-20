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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttn_BUSCAR = new System.Windows.Forms.Button();
            this.btn_Crear_H = new System.Windows.Forms.Button();
            this.btn_C_H_G = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 101);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(244, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTITUTO TECNOLOGICO DE TLAXIACO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.panelformularios);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 523);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelformularios
            // 
            this.panelformularios.Location = new System.Drawing.Point(201, 0);
            this.panelformularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(1103, 523);
            this.panelformularios.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_C_H_G);
            this.panel3.Controls.Add(this.bttn_BUSCAR);
            this.panel3.Controls.Add(this.btn_Crear_H);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 523);
            this.panel3.TabIndex = 7;
            // 
            // bttn_BUSCAR
            // 
            this.bttn_BUSCAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttn_BUSCAR.FlatAppearance.BorderSize = 0;
            this.bttn_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_BUSCAR.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_BUSCAR.ForeColor = System.Drawing.Color.White;
            this.bttn_BUSCAR.Location = new System.Drawing.Point(0, 60);
            this.bttn_BUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_BUSCAR.Name = "bttn_BUSCAR";
            this.bttn_BUSCAR.Size = new System.Drawing.Size(200, 64);
            this.bttn_BUSCAR.TabIndex = 6;
            this.bttn_BUSCAR.Text = "BUSCAR HORARIO DE DOCENTE";
            this.bttn_BUSCAR.UseVisualStyleBackColor = true;
            this.bttn_BUSCAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Crear_H
            // 
            this.btn_Crear_H.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Crear_H.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Crear_H.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Crear_H.FlatAppearance.BorderSize = 0;
            this.btn_Crear_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear_H.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear_H.ForeColor = System.Drawing.Color.White;
            this.btn_Crear_H.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Crear_H.Location = new System.Drawing.Point(0, 0);
            this.btn_Crear_H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Crear_H.Name = "btn_Crear_H";
            this.btn_Crear_H.Size = new System.Drawing.Size(200, 60);
            this.btn_Crear_H.TabIndex = 3;
            this.btn_Crear_H.Text = "CREAR HORARIO PARA DOCENTE";
            this.btn_Crear_H.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Crear_H.UseVisualStyleBackColor = false;
            this.btn_Crear_H.Click += new System.EventHandler(this.btn_Crear_H_Click);
            // 
            // btn_C_H_G
            // 
            this.btn_C_H_G.Location = new System.Drawing.Point(87, 191);
            this.btn_C_H_G.Name = "btn_C_H_G";
            this.btn_C_H_G.Size = new System.Drawing.Size(108, 75);
            this.btn_C_H_G.TabIndex = 7;
            this.btn_C_H_G.Text = "CREAR HORARIO PARA GRUPO";
            this.btn_C_H_G.UseVisualStyleBackColor = true;
            // 
            // PAG_PRIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PAG_PRIN";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PAG_PRIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Crear_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_BUSCAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Button btn_C_H_G;
    }
}

