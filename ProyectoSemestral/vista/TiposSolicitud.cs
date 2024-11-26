using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSemestral.vista
{
    public partial class TiposSolicitud : Form
    {
        public TiposSolicitud()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TiposSolicitud_Load(object sender, EventArgs e)
        {

        }
        private void CargarTiposSolicitud()
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
            MessageBox.Show("Tipo de solicitud agregado.");
            CargarTiposSolicitud();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
            MessageBox.Show("Tipo de solicitud actualizado.");
            CargarTiposSolicitud();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
            MessageBox.Show("Tipo de solicitud eliminado.");
            CargarTiposSolicitud();
        }

    }
}
