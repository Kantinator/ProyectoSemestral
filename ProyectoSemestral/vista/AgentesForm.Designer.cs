namespace ProyectoSemestral.vista
{
    partial class AgentesForm
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
            this.dataGridViewAgentes = new System.Windows.Forms.DataGridView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelAreaAtencion = new System.Windows.Forms.Label();
            this.comboBoxAreaAtencion = new System.Windows.Forms.ComboBox();
            this.labelSupervisor = new System.Windows.Forms.Label();
            this.comboBoxSupervisor = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentes)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewAgentes
            // 
            this.dataGridViewAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgentes.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewAgentes.Name = "dataGridViewAgentes";
            this.dataGridViewAgentes.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewAgentes.TabIndex = 0;
            this.dataGridViewAgentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgentes_CellClick);

            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";

            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(100, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 2;

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
            this.comboBoxAreaAtencion.Location = new System.Drawing.Point(100, 47);
            this.comboBoxAreaAtencion.Name = "comboBoxAreaAtencion";
            this.comboBoxAreaAtencion.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAreaAtencion.TabIndex = 4;

            // 
            // labelSupervisor
            // 
            this.labelSupervisor.AutoSize = true;
            this.labelSupervisor.Location = new System.Drawing.Point(12, 85);
            this.labelSupervisor.Name = "labelSupervisor";
            this.labelSupervisor.Size = new System.Drawing.Size(61, 13);
            this.labelSupervisor.TabIndex = 5;
            this.labelSupervisor.Text = "Supervisor:";

            // 
            // comboBoxSupervisor
            // 
            this.comboBoxSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisor.FormattingEnabled = true;
            this.comboBoxSupervisor.Location = new System.Drawing.Point(100, 82);
            this.comboBoxSupervisor.Name = "comboBoxSupervisor";
            this.comboBoxSupervisor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSupervisor.TabIndex = 6;

            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(350, 10);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);

            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(350, 45);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 8;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);

            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(350, 80);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);

            // 
            // AgentesForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxSupervisor);
            this.Controls.Add(this.labelSupervisor);
            this.Controls.Add(this.comboBoxAreaAtencion);
            this.Controls.Add(this.labelAreaAtencion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dataGridViewAgentes);
            this.Name = "AgentesForm";
            this.Text = "Gestión de Agentes";
            this.Load += new System.EventHandler(this.AgentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgentes;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelAreaAtencion;
        private System.Windows.Forms.ComboBox comboBoxAreaAtencion;
        private System.Windows.Forms.Label labelSupervisor;
        private System.Windows.Forms.ComboBox comboBoxSupervisor;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}
