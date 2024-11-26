namespace ProyectoSemestral.vista
{
    partial class AsignacionTecnicoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumeroTiquete;
        private System.Windows.Forms.Label lblIDTecnico;
        private System.Windows.Forms.TextBox txtNumeroTiquete;
        private System.Windows.Forms.TextBox txtIDTecnico;
        private System.Windows.Forms.Button btnAsignar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblNumeroTiquete = new System.Windows.Forms.Label();
            this.lblIDTecnico = new System.Windows.Forms.Label();
            this.txtNumeroTiquete = new System.Windows.Forms.TextBox();
            this.txtIDTecnico = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblNumeroTiquete
            // 
            this.lblNumeroTiquete.AutoSize = true;
            this.lblNumeroTiquete.Location = new System.Drawing.Point(30, 30);
            this.lblNumeroTiquete.Name = "lblNumeroTiquete";
            this.lblNumeroTiquete.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroTiquete.TabIndex = 0;
            this.lblNumeroTiquete.Text = "Número de Tiquete:";

            // 
            // lblIDTecnico
            // 
            this.lblIDTecnico.AutoSize = true;
            this.lblIDTecnico.Location = new System.Drawing.Point(30, 70);
            this.lblIDTecnico.Name = "lblIDTecnico";
            this.lblIDTecnico.Size = new System.Drawing.Size(65, 13);
            this.lblIDTecnico.TabIndex = 1;
            this.lblIDTecnico.Text = "ID del Técnico:";

            // 
            // txtNumeroTiquete
            // 
            this.txtNumeroTiquete.Location = new System.Drawing.Point(150, 27);
            this.txtNumeroTiquete.Name = "txtNumeroTiquete";
            this.txtNumeroTiquete.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroTiquete.TabIndex = 2;

            // 
            // txtIDTecnico
            // 
            this.txtIDTecnico.Location = new System.Drawing.Point(150, 67);
            this.txtIDTecnico.Name = "txtIDTecnico";
            this.txtIDTecnico.Size = new System.Drawing.Size(200, 20);
            this.txtIDTecnico.TabIndex = 3;

            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(150, 110);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 30);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar Técnico";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);

            // 
            // AsignacionTecnicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtIDTecnico);
            this.Controls.Add(this.txtNumeroTiquete);
            this.Controls.Add(this.lblIDTecnico);
            this.Controls.Add(this.lblNumeroTiquete);
            this.Name = "AsignacionTecnicoForm";
            this.Text = "Asignación de Técnico";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
