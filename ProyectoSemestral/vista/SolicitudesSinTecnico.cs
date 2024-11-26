using ProyectoSemestral.bd;
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
    public partial class SolicitudesSinTecnico : Form
    {
        public SolicitudesSinTecnico()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Consulta SQL para solicitudes sin técnico asignado
            string query = @"
        SELECT 
            t.NumeroTiquete,
            t.NombreUsuario,
            t.AreaTrabajo,
            t.FechaTiquete,
            p.NombrePrioridad,
            e.NombreEstatus
        FROM 
            Tiquetes t
        LEFT JOIN 
            AsignacionTecnico at ON t.NumeroTiquete = at.NumeroTiquete
        INNER JOIN 
            NivelesPrioridad p ON t.ID_Prioridad = p.ID_Prioridad
        INNER JOIN 
            Estatus e ON t.ID_Estatus = e.ID_Estatus
        WHERE 
            at.ID_Asignacion IS NULL
        ORDER BY 
            t.FechaTiquete DESC;";

            using (SqlConnection conn = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Mostrar los datos en el DataGridView
                    dgvSolicitudes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las solicitudes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
