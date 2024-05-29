namespace APP_REGISTRO_DE_HORARIOS
{
    partial class HORARIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ING_HORA = new System.Windows.Forms.TextBox();
            this.ING_MAT = new System.Windows.Forms.TextBox();
            this.ING_AULA = new System.Windows.Forms.TextBox();
            this.bTN_AÑA_HOR = new System.Windows.Forms.Button();
            this.btn_AÑA_MAT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HORA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATERIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(392, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "AULA:";
            // 
            // ING_HORA
            // 
            this.ING_HORA.Location = new System.Drawing.Point(20, 49);
            this.ING_HORA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ING_HORA.Name = "ING_HORA";
            this.ING_HORA.Size = new System.Drawing.Size(117, 22);
            this.ING_HORA.TabIndex = 3;
            this.ING_HORA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ING_MAT
            // 
            this.ING_MAT.Location = new System.Drawing.Point(189, 49);
            this.ING_MAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ING_MAT.Name = "ING_MAT";
            this.ING_MAT.Size = new System.Drawing.Size(132, 22);
            this.ING_MAT.TabIndex = 4;
            this.ING_MAT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ING_AULA
            // 
            this.ING_AULA.Location = new System.Drawing.Point(373, 49);
            this.ING_AULA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ING_AULA.Name = "ING_AULA";
            this.ING_AULA.Size = new System.Drawing.Size(100, 22);
            this.ING_AULA.TabIndex = 5;
            this.ING_AULA.TextChanged += new System.EventHandler(this.ING_AULA_TextChanged);
            // 
            // bTN_AÑA_HOR
            // 
            this.bTN_AÑA_HOR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTN_AÑA_HOR.FlatAppearance.BorderSize = 0;
            this.bTN_AÑA_HOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTN_AÑA_HOR.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN_AÑA_HOR.ForeColor = System.Drawing.Color.Black;
            this.bTN_AÑA_HOR.Location = new System.Drawing.Point(504, 102);
            this.bTN_AÑA_HOR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTN_AÑA_HOR.Name = "bTN_AÑA_HOR";
            this.bTN_AÑA_HOR.Size = new System.Drawing.Size(123, 50);
            this.bTN_AÑA_HOR.TabIndex = 6;
            this.bTN_AÑA_HOR.Text = "GUARDAR";
            this.bTN_AÑA_HOR.UseVisualStyleBackColor = false;
            this.bTN_AÑA_HOR.Click += new System.EventHandler(this.bTN_AÑA_HOR_Click);
            // 
            // btn_AÑA_MAT
            // 
            this.btn_AÑA_MAT.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AÑA_MAT.Location = new System.Drawing.Point(523, 49);
            this.btn_AÑA_MAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AÑA_MAT.Name = "btn_AÑA_MAT";
            this.btn_AÑA_MAT.Size = new System.Drawing.Size(49, 30);
            this.btn_AÑA_MAT.TabIndex = 7;
            this.btn_AÑA_MAT.Text = "+";
            this.btn_AÑA_MAT.UseVisualStyleBackColor = true;
            this.btn_AÑA_MAT.Click += new System.EventHandler(this.btn_AÑA_MAT_Click);
            // 
            // HORARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(649, 345);
            this.Controls.Add(this.btn_AÑA_MAT);
            this.Controls.Add(this.bTN_AÑA_HOR);
            this.Controls.Add(this.ING_AULA);
            this.Controls.Add(this.ING_MAT);
            this.Controls.Add(this.ING_HORA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HORARIO";
            this.Text = "Registro de clases";
            this.Load += new System.EventHandler(this.HORARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ING_HORA;
        private System.Windows.Forms.TextBox ING_MAT;
        private System.Windows.Forms.TextBox ING_AULA;
        private System.Windows.Forms.Button bTN_AÑA_HOR;
        private System.Windows.Forms.Button btn_AÑA_MAT;
    }
}