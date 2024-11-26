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
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de fechas
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Consulta SQL
            string query = @"
        SELECT 
            t.NombreTecnico,
            COUNT(a.NumeroTiquete) AS TotalTiquetes
        FROM 
            AsignacionTecnico a
        INNER JOIN 
            Tecnicos t ON a.ID_Tecnico = t.ID_Tecnico
        INNER JOIN 
            ActualizacionEstatus ae ON a.NumeroTiquete = ae.NumeroTiquete
        WHERE 
            ae.FechaTerminacion BETWEEN @FechaInicio AND @FechaFin
        GROUP BY 
            t.NombreTecnico
        ORDER BY 
            TotalTiquetes DESC;
    ";

            try
            {
                using (SqlConnection conn = Conexion.AbrirConexion()) // Usando tu clase `conexion`
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Vincular resultados al DataGridView
                    dgvResultados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
