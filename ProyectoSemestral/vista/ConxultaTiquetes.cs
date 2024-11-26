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
    public partial class ConxultaTiquetes : Form
    {
        public ConxultaTiquetes()
        {
            InitializeComponent();
        }

        private void ConxultaTiquetes_Load(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
            }
        }
    }
}
