namespace ProyectoSemestral.vista
{
    partial class frmDistribuicionPorcentual
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
            this.dgvDistribucion = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDistribucion
            // 
            this.dgvDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribucion.Location = new System.Drawing.Point(12, 189);
            this.dgvDistribucion.Name = "dgvDistribucion";
            this.dgvDistribucion.RowHeadersWidth = 47;
            this.dgvDistribucion.Size = new System.Drawing.Size(632, 155);
            this.dgvDistribucion.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(238, 129);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(169, 41);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Distribucion Porcentual";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 108);
            this.label1.TabIndex = 5;
            this.label1.Text = "Distribucion Porcentual de Tiquetes sin Cerrar por Area de Atencion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDistribuicionPorcentual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvDistribucion);
            this.Name = "frmDistribuicionPorcentual";
            this.Text = "frmDistribuicionPorcentual";
            this.Load += new System.EventHandler(this.frmDistribuicionPorcentual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.DataGridView dgvDistribucion;
        private System.Windows.Forms.Label label1;
    }
}