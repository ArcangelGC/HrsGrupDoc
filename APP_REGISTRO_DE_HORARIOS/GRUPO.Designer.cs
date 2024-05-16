namespace APP_REGISTRO_DE_HORARIOS
{
    partial class GRUPO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CLVG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MAR_A = new System.Windows.Forms.Button();
            this.btn_JUE_A = new System.Windows.Forms.Button();
            this.btn_VIE_A = new System.Windows.Forms.Button();
            this.btn_MIE_A = new System.Windows.Forms.Button();
            this.btn_LUN_A = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CLVG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "INGENIERIA EN SISTEMAS",
            "INGENIERIA EN GESTION EMPRESARIAL",
            "INGENIERIA EN CIVL",
            "INGENIERIA INDUSTRIAL",
            "LICENCIATURA EN ADMINISTRACION",
            "LICENCIATURA EN ARQUITECTURA"});
            this.comboBox1.Location = new System.Drawing.Point(594, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECCIONE LA \r\nCARRERA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CLVG
            // 
            this.CLVG.Location = new System.Drawing.Point(245, 16);
            this.CLVG.Name = "CLVG";
            this.CLVG.Size = new System.Drawing.Size(154, 22);
            this.CLVG.TabIndex = 2;
            this.CLVG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE LA CLAVE \r\nDEL GRUPO:";
            // 
            // btn_MAR_A
            // 
            this.btn_MAR_A.FlatAppearance.BorderSize = 0;
            this.btn_MAR_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MAR_A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MAR_A.ForeColor = System.Drawing.Color.White;
            this.btn_MAR_A.Location = new System.Drawing.Point(193, 106);
            this.btn_MAR_A.Name = "btn_MAR_A";
            this.btn_MAR_A.Size = new System.Drawing.Size(135, 39);
            this.btn_MAR_A.TabIndex = 2;
            this.btn_MAR_A.Text = "MARTES";
            this.btn_MAR_A.UseVisualStyleBackColor = true;
            this.btn_MAR_A.Click += new System.EventHandler(this.btn_MAR_A_Click);
            // 
            // btn_JUE_A
            // 
            this.btn_JUE_A.FlatAppearance.BorderSize = 0;
            this.btn_JUE_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JUE_A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JUE_A.ForeColor = System.Drawing.Color.White;
            this.btn_JUE_A.Location = new System.Drawing.Point(481, 106);
            this.btn_JUE_A.Name = "btn_JUE_A";
            this.btn_JUE_A.Size = new System.Drawing.Size(135, 39);
            this.btn_JUE_A.TabIndex = 3;
            this.btn_JUE_A.Text = "JUEVES";
            this.btn_JUE_A.UseVisualStyleBackColor = true;
            this.btn_JUE_A.Click += new System.EventHandler(this.btn_JUE_A_Click);
            // 
            // btn_VIE_A
            // 
            this.btn_VIE_A.FlatAppearance.BorderSize = 0;
            this.btn_VIE_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VIE_A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VIE_A.ForeColor = System.Drawing.Color.White;
            this.btn_VIE_A.Location = new System.Drawing.Point(622, 106);
            this.btn_VIE_A.Name = "btn_VIE_A";
            this.btn_VIE_A.Size = new System.Drawing.Size(135, 39);
            this.btn_VIE_A.TabIndex = 4;
            this.btn_VIE_A.Text = "VIERNES";
            this.btn_VIE_A.UseVisualStyleBackColor = true;
            this.btn_VIE_A.Click += new System.EventHandler(this.btn_VIE_A_Click);
            // 
            // btn_MIE_A
            // 
            this.btn_MIE_A.FlatAppearance.BorderSize = 0;
            this.btn_MIE_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MIE_A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MIE_A.ForeColor = System.Drawing.Color.White;
            this.btn_MIE_A.Location = new System.Drawing.Point(355, 106);
            this.btn_MIE_A.Name = "btn_MIE_A";
            this.btn_MIE_A.Size = new System.Drawing.Size(135, 39);
            this.btn_MIE_A.TabIndex = 5;
            this.btn_MIE_A.Text = "MIERCOLES";
            this.btn_MIE_A.UseVisualStyleBackColor = true;
            this.btn_MIE_A.Click += new System.EventHandler(this.btn_MIE_A_Click);
            // 
            // btn_LUN_A
            // 
            this.btn_LUN_A.FlatAppearance.BorderSize = 0;
            this.btn_LUN_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LUN_A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LUN_A.ForeColor = System.Drawing.Color.White;
            this.btn_LUN_A.Location = new System.Drawing.Point(33, 106);
            this.btn_LUN_A.Name = "btn_LUN_A";
            this.btn_LUN_A.Size = new System.Drawing.Size(135, 39);
            this.btn_LUN_A.TabIndex = 1;
            this.btn_LUN_A.Text = "LUNES";
            this.btn_LUN_A.UseVisualStyleBackColor = true;
            this.btn_LUN_A.Click += new System.EventHandler(this.btn_LUN_A_Click);
            // 
            // GRUPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(843, 171);
            this.Controls.Add(this.btn_LUN_A);
            this.Controls.Add(this.btn_MAR_A);
            this.Controls.Add(this.btn_MIE_A);
            this.Controls.Add(this.btn_VIE_A);
            this.Controls.Add(this.btn_JUE_A);
            this.Controls.Add(this.panel1);
            this.Name = "GRUPO";
            this.Text = "Registro para grupo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CLVG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_MAR_A;
        private System.Windows.Forms.Button btn_JUE_A;
        private System.Windows.Forms.Button btn_VIE_A;
        private System.Windows.Forms.Button btn_MIE_A;
        private System.Windows.Forms.Button btn_LUN_A;
    }
}