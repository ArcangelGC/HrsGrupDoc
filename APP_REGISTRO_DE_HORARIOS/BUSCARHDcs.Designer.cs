namespace APP_REGISTRO_DE_HORARIOS
{
    partial class BUSCARHDcs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_BD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCENTE A BUSCAR:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 1;
            // 
            // bttn_BD
            // 
            this.bttn_BD.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_BD.Location = new System.Drawing.Point(381, 28);
            this.bttn_BD.Name = "bttn_BD";
            this.bttn_BD.Size = new System.Drawing.Size(99, 33);
            this.bttn_BD.TabIndex = 2;
            this.bttn_BD.Text = "BUSCAR";
            this.bttn_BD.UseVisualStyleBackColor = true;
            // 
            // BUSCARHDcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1089, 308);
            this.Controls.Add(this.bttn_BD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BUSCARHDcs";
            this.Text = "BUSCARHDcs";
            this.Load += new System.EventHandler(this.BUSCARHDcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_BD;
    }
}