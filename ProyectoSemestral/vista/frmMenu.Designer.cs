namespace ProyectoSemestral.vista
{
    partial class frmMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesDePrioridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaDeAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperturaDeTiqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDelTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionDeEstatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeSolicitudToolStripMenuItem,
            this.nivelesDePrioridadToolStripMenuItem,
            this.estatusToolStripMenuItem,
            this.areaDeAtencionToolStripMenuItem,
            this.agentesToolStripMenuItem,
            this.supervisoresToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aperturaDeTiqueteToolStripMenuItem,
            this.asignacionDelTecnicoToolStripMenuItem,
            this.actualizacionDeEstatusToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem,
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem,
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem,
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem,
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem,
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem,
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // tiposDeSolicitudToolStripMenuItem
            // 
            this.tiposDeSolicitudToolStripMenuItem.Name = "tiposDeSolicitudToolStripMenuItem";
            this.tiposDeSolicitudToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.tiposDeSolicitudToolStripMenuItem.Text = "Tipos de solicitud";
            this.tiposDeSolicitudToolStripMenuItem.Click += new System.EventHandler(this.tiposDeSolicitudToolStripMenuItem_Click);
            // 
            // nivelesDePrioridadToolStripMenuItem
            // 
            this.nivelesDePrioridadToolStripMenuItem.Name = "nivelesDePrioridadToolStripMenuItem";
            this.nivelesDePrioridadToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.nivelesDePrioridadToolStripMenuItem.Text = "Niveles de prioridad";
            this.nivelesDePrioridadToolStripMenuItem.Click += new System.EventHandler(this.nivelesDePrioridadToolStripMenuItem_Click);
            // 
            // estatusToolStripMenuItem
            // 
            this.estatusToolStripMenuItem.Name = "estatusToolStripMenuItem";
            this.estatusToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.estatusToolStripMenuItem.Text = "Estatus";
            this.estatusToolStripMenuItem.Click += new System.EventHandler(this.estatusToolStripMenuItem_Click);
            // 
            // areaDeAtencionToolStripMenuItem
            // 
            this.areaDeAtencionToolStripMenuItem.Name = "areaDeAtencionToolStripMenuItem";
            this.areaDeAtencionToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.areaDeAtencionToolStripMenuItem.Text = "Area de atencion";
            this.areaDeAtencionToolStripMenuItem.Click += new System.EventHandler(this.areaDeAtencionToolStripMenuItem_Click);
            // 
            // agentesToolStripMenuItem
            // 
            this.agentesToolStripMenuItem.Name = "agentesToolStripMenuItem";
            this.agentesToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.agentesToolStripMenuItem.Text = "Agentes";
            this.agentesToolStripMenuItem.Click += new System.EventHandler(this.agentesToolStripMenuItem_Click);
            // 
            // supervisoresToolStripMenuItem
            // 
            this.supervisoresToolStripMenuItem.Name = "supervisoresToolStripMenuItem";
            this.supervisoresToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.supervisoresToolStripMenuItem.Text = "Supervisores";
            this.supervisoresToolStripMenuItem.Click += new System.EventHandler(this.supervisoresToolStripMenuItem_Click);
            // 
            // aperturaDeTiqueteToolStripMenuItem
            // 
            this.aperturaDeTiqueteToolStripMenuItem.Name = "aperturaDeTiqueteToolStripMenuItem";
            this.aperturaDeTiqueteToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aperturaDeTiqueteToolStripMenuItem.Text = "Apertura de tiquete";
            this.aperturaDeTiqueteToolStripMenuItem.Click += new System.EventHandler(this.aperturaDeTiqueteToolStripMenuItem_Click);
            // 
            // asignacionDelTecnicoToolStripMenuItem
            // 
            this.asignacionDelTecnicoToolStripMenuItem.Name = "asignacionDelTecnicoToolStripMenuItem";
            this.asignacionDelTecnicoToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.asignacionDelTecnicoToolStripMenuItem.Text = "Asignacion del tecnico";
            this.asignacionDelTecnicoToolStripMenuItem.Click += new System.EventHandler(this.asignacionDelTecnicoToolStripMenuItem_Click);
            // 
            // actualizacionDeEstatusToolStripMenuItem
            // 
            this.actualizacionDeEstatusToolStripMenuItem.Name = "actualizacionDeEstatusToolStripMenuItem";
            this.actualizacionDeEstatusToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.actualizacionDeEstatusToolStripMenuItem.Text = "Actualizacion de estatus";
            this.actualizacionDeEstatusToolStripMenuItem.Click += new System.EventHandler(this.actualizacionDeEstatusToolStripMenuItem_Click);
            // 
            // tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem
            // 
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem.Name = "tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem";
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem.Text = "Tiquetes de acuerdo a un estatus X";
            this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem.Click += new System.EventHandler(this.tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem_Click);
            // 
            // distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem
            // 
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem.Name = "distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem";
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem.Text = "Distribución Porcentual de Tiquetes sin Cerrar por Área de Atención";
            this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem.Click += new System.EventHandler(this.distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem_Click);
            // 
            // áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem
            // 
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem.Name = "áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem";
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem.Text = "Área de Atención con mayor cantidad de tiquetes sin Cerrar";
            this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem.Click += new System.EventHandler(this.áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem_Click);
            // 
            // técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem
            // 
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem.Name = "técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem";
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem.Text = "Técnico con el mayor número de tiquetes atendidos en un periodo de tiempo";
            this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem.Click += new System.EventHandler(this.técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem_Click);
            // 
            // historialDeSeguimientoDeUnaSolicitudToolStripMenuItem
            // 
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem.Name = "historialDeSeguimientoDeUnaSolicitudToolStripMenuItem";
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem.Text = "Historial de Seguimiento de una Solicitud";
            this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem.Click += new System.EventHandler(this.historialDeSeguimientoDeUnaSolicitudToolStripMenuItem_Click);
            // 
            // solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem
            // 
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem.Name = "solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem";
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem.Text = "Solicitudes sin cerrar con más de X cantidad de días";
            this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem.Click += new System.EventHandler(this.solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem_Click);
            // 
            // solicitudesSinTécnicosAsignadoToolStripMenuItem
            // 
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem.Name = "solicitudesSinTécnicosAsignadoToolStripMenuItem";
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem.Size = new System.Drawing.Size(557, 24);
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem.Text = "Solicitudes sin técnicos asignado";
            this.solicitudesSinTécnicosAsignadoToolStripMenuItem.Click += new System.EventHandler(this.solicitudesSinTécnicosAsignadoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesDePrioridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaDeAtencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperturaDeTiqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDelTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionDeEstatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeSeguimientoDeUnaSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesSinTécnicosAsignadoToolStripMenuItem;
    }
}