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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Crear_D = new APP_REGISTRO_DE_HORARIOS.Resources.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Anja Eliane", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1240, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDOS AL SERVICIO DE NUESTRA INSTITUCION";
            // 
            // btn_Crear_D
            // 
            this.btn_Crear_D.BackColor = System.Drawing.Color.White;
            this.btn_Crear_D.BackgroundColor = System.Drawing.Color.White;
            this.btn_Crear_D.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Crear_D.BorderRadius = 20;
            this.btn_Crear_D.BorderSize = 0;
            this.btn_Crear_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Crear_D.FlatAppearance.BorderSize = 0;
            this.btn_Crear_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear_D.Font = new System.Drawing.Font("Anja Eliane", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear_D.ForeColor = System.Drawing.Color.Black;
            this.btn_Crear_D.Location = new System.Drawing.Point(593, 178);
            this.btn_Crear_D.Name = "btn_Crear_D";
            this.btn_Crear_D.Size = new System.Drawing.Size(240, 108);
            this.btn_Crear_D.TabIndex = 1;
            this.btn_Crear_D.Text = "CREAR HORARIO";
            this.btn_Crear_D.TextColor = System.Drawing.Color.Black;
            this.btn_Crear_D.UseVisualStyleBackColor = false;
            this.btn_Crear_D.Click += new System.EventHandler(this.btn_Crear_D_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Anja Eliane", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(971, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "\"INSTITUTO TECNOLOGICO DE TLAXIACO\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(577, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 306);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // PAG_PRIN
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Crear_D);
            this.Controls.Add(this.label3);
            this.Name = "PAG_PRIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Crear_H;
        private System.Windows.Forms.Label label3;
        private Resources.RJButton btn_Crear_D;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

