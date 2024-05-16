namespace APP_REGISTRO_DE_HORARIOS
{
    partial class CREAR_PARA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREAR_PARA));
            this.PARA = new System.Windows.Forms.Label();
            this.btn_DOC = new System.Windows.Forms.Button();
            this.btn_GRUP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PARA
            // 
            this.PARA.AutoSize = true;
            this.PARA.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PARA.ForeColor = System.Drawing.Color.White;
            this.PARA.Location = new System.Drawing.Point(104, 28);
            this.PARA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PARA.Name = "PARA";
            this.PARA.Size = new System.Drawing.Size(298, 31);
            this.PARA.TabIndex = 0;
            this.PARA.Text = "CREAR HORARIO PARA:";
            this.PARA.Click += new System.EventHandler(this.PARA_Click);
            // 
            // btn_DOC
            // 
            this.btn_DOC.BackColor = System.Drawing.Color.White;
            this.btn_DOC.FlatAppearance.BorderSize = 0;
            this.btn_DOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DOC.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DOC.ForeColor = System.Drawing.Color.Black;
            this.btn_DOC.Location = new System.Drawing.Point(119, 78);
            this.btn_DOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DOC.Name = "btn_DOC";
            this.btn_DOC.Size = new System.Drawing.Size(88, 38);
            this.btn_DOC.TabIndex = 1;
            this.btn_DOC.Text = "Docente";
            this.btn_DOC.UseVisualStyleBackColor = false;
            this.btn_DOC.Click += new System.EventHandler(this.btn_DOC_Click);
            // 
            // btn_GRUP
            // 
            this.btn_GRUP.BackColor = System.Drawing.Color.White;
            this.btn_GRUP.FlatAppearance.BorderSize = 0;
            this.btn_GRUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GRUP.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GRUP.ForeColor = System.Drawing.Color.Black;
            this.btn_GRUP.Location = new System.Drawing.Point(277, 78);
            this.btn_GRUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GRUP.Name = "btn_GRUP";
            this.btn_GRUP.Size = new System.Drawing.Size(94, 38);
            this.btn_GRUP.TabIndex = 2;
            this.btn_GRUP.Text = "Grupo";
            this.btn_GRUP.UseVisualStyleBackColor = false;
            this.btn_GRUP.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(302, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CREAR_PARA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(495, 240);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_GRUP);
            this.Controls.Add(this.btn_DOC);
            this.Controls.Add(this.PARA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CREAR_PARA";
            this.Text = "Crear";
            this.Load += new System.EventHandler(this.CREAR_PARA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PARA;
        private System.Windows.Forms.Button btn_DOC;
        private System.Windows.Forms.Button btn_GRUP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}