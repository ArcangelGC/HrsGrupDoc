namespace APP_REGISTRO_DE_HORARIOS
{
    partial class buscarH
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
            this.BuscD = new System.Windows.Forms.Button();
            this.BGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuscD
            // 
            this.BuscD.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscD.Location = new System.Drawing.Point(223, 197);
            this.BuscD.Name = "BuscD";
            this.BuscD.Size = new System.Drawing.Size(106, 48);
            this.BuscD.TabIndex = 0;
            this.BuscD.Text = "Docente";
            this.BuscD.UseVisualStyleBackColor = true;
            this.BuscD.Click += new System.EventHandler(this.BuscD_Click);
            // 
            // BGrupo
            // 
            this.BGrupo.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGrupo.Location = new System.Drawing.Point(440, 197);
            this.BGrupo.Name = "BGrupo";
            this.BGrupo.Size = new System.Drawing.Size(88, 48);
            this.BGrupo.TabIndex = 1;
            this.BGrupo.Text = "Grupo";
            this.BGrupo.UseVisualStyleBackColor = true;
            this.BGrupo.Click += new System.EventHandler(this.BGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR HORARIO DE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGrupo);
            this.Controls.Add(this.BuscD);
            this.Name = "buscarH";
            this.Text = "Buscar Horario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscD;
        private System.Windows.Forms.Button BGrupo;
        private System.Windows.Forms.Label label1;
    }
}