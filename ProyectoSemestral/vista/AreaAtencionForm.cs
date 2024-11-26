using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;
using ProyectoSemestral.modelo;

namespace ProyectoSemestral.vista
{
    public partial class AreaAtencionForm : Form
    {
        public AreaAtencionForm()
        {
            InitializeComponent();
        }

        private void AreaAtencionForm_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase AreaAtencion
            AreaAtencion areaAtencion = new AreaAtencion();

            // Obtener las áreas con los tiquetes pendientes
            var areas = areaAtencion.ObtenerAreasConTiquetesSinCerrar();

            // Asignar la lista de áreas al DataGridView
            dataGridView1.DataSource = areas;
        }
    }
}