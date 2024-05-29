namespace APP_REGISTRO_DE_HORARIOS
{
    partial class VerDatos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView H1;
        private System.Windows.Forms.DataGridView M1;
        private System.Windows.Forms.DataGridView A2;
        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.H1 = new System.Windows.Forms.DataGridView();
            this.M1 = new System.Windows.Forms.DataGridView();
            this.A2 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.H1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.BackgroundColor = System.Drawing.Color.White;
            this.H1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.H1.Location = new System.Drawing.Point(268, 185);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(240, 150);
            this.H1.TabIndex = 0;
            // 
            // M1
            // 
            this.M1.BackgroundColor = System.Drawing.Color.White;
            this.M1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.M1.Location = new System.Drawing.Point(12, 185);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(240, 150);
            this.M1.TabIndex = 1;
            this.M1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellContentClick);
            // 
            // A2
            // 
            this.A2.BackgroundColor = System.Drawing.Color.White;
            this.A2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A2.Location = new System.Drawing.Point(523, 185);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(240, 150);
            this.A2.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(688, 397);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VerDatos
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(810, 447);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.H1);
            this.Name = "VerDatos";
            this.Text = "VerDatos";
            this.Load += new System.EventHandler(this.VerDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.H1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
