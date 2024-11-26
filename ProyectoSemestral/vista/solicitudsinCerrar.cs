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
    public partial class solicitudsinCerrar : Form
    {
        public solicitudsinCerrar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dias = (int)nudDias.Value;

            string query = @"
        SELECT 
            t.NumeroTiquete,
            t.NombreUsuario,
            t.AreaTrabajo,
            t.FechaTiquete,
            DATEDIFF(DAY, t.FechaTiquete, GETDATE()) AS DiasAbiertos,
            p.NombrePrioridad,
            e.NombreEstatus
        FROM 
            Tiquetes t
        INNER JOIN 
            NivelesPrioridad p ON t.ID_Prioridad = p.ID_Prioridad
        INNER JOIN 
            Estatus e ON t.ID_Estatus = e.ID_Estatus
        WHERE 
           e.NombreEstatus = 'Abierto' AND DATEDIFF(DAY, t.FechaTiquete, GETDATE()) > @Dias ORDER BY DiasAbiertos DESC; ";

    using (SqlConnection conn = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Dias", dias);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSolicitudes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar solicitudes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
