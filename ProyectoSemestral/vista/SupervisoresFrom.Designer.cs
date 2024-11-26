namespace ProyectoSemestral.vista
{
    partial class SupervisoresForm
    {
        private System.ComponentModel.IContainer components = null;

        // Método Dispose para limpiar los componentes utilizados.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        // Este método es necesario para la compatibilidad con el Diseñador.
        private void InitializeComponent()
        {
            this.dataGridViewSupervisores = new System.Windows.Forms.DataGridView();
            this.labelNombreSupervisor = new System.Windows.Forms.Label();
            this.textBoxNombreSupervisor = new System.Windows.Forms.TextBox();
            this.labelAreaAtencion = new System.Windows.Forms.Label();
            this.comboBoxAreaAtencion = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupervisores)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewSupervisores
            // 
            this.dataGridViewSupervisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupervisores.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewSupervisores.Name = "dataGridViewSupervisores";
            this.dataGridViewSupervisores.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewSupervisores.TabIndex = 0;
            this.dataGridViewSupervisores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupervisores_CellClick);

            // 
            // labelNombreSupervisor
            // 
            this.labelNombreSupervisor.AutoSize = true;
            this.labelNombreSupervisor.Location = new System.Drawing.Point(12, 15);
            this.labelNombreSupervisor.Name = "labelNombreSupervisor";
            this.labelNombreSupervisor.Size = new System.Drawing.Size(100, 13);
            this.labelNombreSupervisor.TabIndex = 1;
            this.labelNombreSupervisor.Text = "Nombre del Supervisor:";

            // 
            // textBoxNombreSupervisor
            // 
            this.textBoxNombreSupervisor.Location = new System.Drawing.Point(130, 12);
            this.textBoxNombreSupervisor.Name = "textBoxNombreSupervisor";
            this.textBoxNombreSupervisor.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreSupervisor.TabIndex = 2;

            // 
            // labelAreaAtencion
            // 
            this.labelAreaAtencion.AutoSize = true;
            this.labelAreaAtencion.Location = new System.Drawing.Point(12, 50);
            this.labelAreaAtencion.Name = "labelAreaAtencion";
            this.labelAreaAtencion.Size = new System.Drawing.Size(82, 13);
            this.labelAreaAtencion.TabIndex = 3;
            this.labelAreaAtencion.Text = "Área de Atención:";

            // 
            // comboBoxAreaAtencion
            // 
            this.comboBoxAreaAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAreaAtencion.FormattingEnabled = true;
            this.comboBoxAreaAtencion.Location = new System.Drawing.Point(130, 47);
            this.comboBoxAreaAtencion.Name = "comboBoxAreaAtencion";
            this.comboBoxAreaAtencion.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAreaAtencion.TabIndex = 4;

            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(350, 10);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);

            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(350, 45);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 6;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);

            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(350, 80);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);

            // 
            // SupervisoresForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 391);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxAreaAtencion);
            this.Controls.Add(this.labelAreaAtencion);
            this.Controls.Add(this.textBoxNombreSupervisor);
            this.Controls.Add(this.labelNombreSupervisor);
            this.Controls.Add(this.dataGridViewSupervisores);
            this.Name = "SupervisoresForm";
            this.Text = "Gestión de Supervisores";
            this.Load += new System.EventHandler(this.SupervisoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupervisores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupervisores;
        private System.Windows.Forms.Label labelNombreSupervisor;
        private System.Windows.Forms.TextBox textBoxNombreSupervisor;
        private System.Windows.Forms.Label labelAreaAtencion;
        private System.Windows.Forms.ComboBox comboBoxAreaAtencion;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}
