namespace ProyectoSemestral.vista
{
    partial class frmActualizacionEstatus
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.dtpHoraTerminacion = new System.Windows.Forms.DateTimePicker();
            this.dtpTerminacion = new System.Windows.Forms.DateTimePicker();
            this.btnInicioAtencion = new System.Windows.Forms.Button();
            this.btnTerminacion = new System.Windows.Forms.Button();
            this.cmbNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTiquetes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(157, 169);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(157, 216);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraInicio.TabIndex = 1;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(157, 269);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(200, 76);
            this.txtDiagnostico.TabIndex = 2;
            // 
            // dtpHoraTerminacion
            // 
            this.dtpHoraTerminacion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraTerminacion.Location = new System.Drawing.Point(537, 211);
            this.dtpHoraTerminacion.Name = "dtpHoraTerminacion";
            this.dtpHoraTerminacion.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraTerminacion.TabIndex = 4;
            // 
            // dtpTerminacion
            // 
            this.dtpTerminacion.Location = new System.Drawing.Point(537, 164);
            this.dtpTerminacion.Name = "dtpTerminacion";
            this.dtpTerminacion.Size = new System.Drawing.Size(200, 20);
            this.dtpTerminacion.TabIndex = 3;
            // 
            // btnInicioAtencion
            // 
            this.btnInicioAtencion.Location = new System.Drawing.Point(179, 367);
            this.btnInicioAtencion.Name = "btnInicioAtencion";
            this.btnInicioAtencion.Size = new System.Drawing.Size(152, 23);
            this.btnInicioAtencion.TabIndex = 5;
            this.btnInicioAtencion.Text = "Iniciar atencion del tiquete";
            this.btnInicioAtencion.UseVisualStyleBackColor = true;
            this.btnInicioAtencion.Click += new System.EventHandler(this.btnInicioAtencion_Click);
            // 
            // btnTerminacion
            // 
            this.btnTerminacion.Location = new System.Drawing.Point(563, 262);
            this.btnTerminacion.Name = "btnTerminacion";
            this.btnTerminacion.Size = new System.Drawing.Size(154, 23);
            this.btnTerminacion.TabIndex = 6;
            this.btnTerminacion.Text = "Terminar atencion del tiquete";
            this.btnTerminacion.UseVisualStyleBackColor = true;
            this.btnTerminacion.Click += new System.EventHandler(this.btnTerminacion_Click);
            // 
            // cmbNum
            // 
            this.cmbNum.FormattingEnabled = true;
            this.cmbNum.Location = new System.Drawing.Point(352, 75);
            this.cmbNum.Name = "cmbNum";
            this.cmbNum.Size = new System.Drawing.Size(121, 21);
            this.cmbNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de inicio de atencion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora de inicio de atencion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Diagnostico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de terminacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora de terminacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiquete";
            // 
            // dgvTiquetes
            // 
            this.dgvTiquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiquetes.Location = new System.Drawing.Point(9, 410);
            this.dgvTiquetes.Name = "dgvTiquetes";
            this.dgvTiquetes.RowHeadersWidth = 47;
            this.dgvTiquetes.Size = new System.Drawing.Size(779, 163);
            this.dgvTiquetes.TabIndex = 14;
            // 
            // frmActualizacionEstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.dgvTiquetes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNum);
            this.Controls.Add(this.btnTerminacion);
            this.Controls.Add(this.btnInicioAtencion);
            this.Controls.Add(this.dtpHoraTerminacion);
            this.Controls.Add(this.dtpTerminacion);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "frmActualizacionEstatus";
            this.Text = "frmActualizacionEstatus";
            this.Load += new System.EventHandler(this.frmActualizacionEstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnInicioAtencion;
        public System.Windows.Forms.Button btnTerminacion;
        public System.Windows.Forms.ComboBox cmbNum;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.DateTimePicker dtpHoraInicio;
        public System.Windows.Forms.TextBox txtDiagnostico;
        public System.Windows.Forms.DateTimePicker dtpHoraTerminacion;
        public System.Windows.Forms.DateTimePicker dtpTerminacion;
        private System.Windows.Forms.DataGridView dgvTiquetes;
    }
}