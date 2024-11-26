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
    public partial class HistorialSegumiento : Form
    {
        public HistorialSegumiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que se ingresó un número de solicitud
            if (string.IsNullOrWhiteSpace(txtNumeroSolicitud.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de solicitud.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el texto del TextBox a número
            if (!int.TryParse(txtNumeroSolicitud.Text, out int numeroSolicitud))
            {
                MessageBox.Show("El número de solicitud debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Consulta SQL
            string query = @"
    SELECT 
        ae.NumeroTiquete AS NumeroSolicitud,
        t.NombreTecnico AS Tecnico,
        ar.NombreArea AS Area,
        ae.FechaInicio,
        ae.HoraInicio,
        ae.Diagnostico,
        ae.FechaTerminacion,
        ae.HoraTerminacion,
        e.NombreEstatus AS Estatus
    FROM 
        ActualizacionEstatus ae
    INNER JOIN 
        AsignacionTecnico at ON ae.NumeroTiquete = at.NumeroTiquete AND ae.ID_Tecnico = at.ID_Tecnico
    INNER JOIN 
        Tecnicos t ON at.ID_Tecnico = t.ID_Tecnico
    INNER JOIN 
        AreaAtencion ar ON t.ID_AreaAtencion = ar.ID_AreaAtencion
    INNER JOIN 
        Estatus e ON ae.ID_Estatus = e.ID_Estatus
    WHERE 
        ae.NumeroTiquete = @NumeroTiquete
    ORDER BY 
        ae.FechaInicio, ae.HoraInicio;";


            try
            {
                using (SqlConnection conn = Conexion.AbrirConexion()) // Usando tu clase `conexion`
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NumeroTiquete", numeroSolicitud);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvHistorial.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron actualizaciones para el número de solicitud ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvHistorial.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
