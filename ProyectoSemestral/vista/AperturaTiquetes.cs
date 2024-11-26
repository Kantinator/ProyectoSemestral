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
    public partial class AperturaTiquetes : Form
    {
        public AperturaTiquetes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AperturaTiquetes_Load(object sender, EventArgs e)
        {

        }

        private void CargarTiposSolicitud()
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
        }

        private void CargarNivelesPrioridad()
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {

            }
            MessageBox.Show("Tiquete registrado.");
        }

    }
}
