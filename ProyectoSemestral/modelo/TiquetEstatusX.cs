using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    public class TiquetEstatusX
    {
        public List<AperturaTiquete> ObtenerTiquetesPorEstatus(int idEstatus)
        {
            List<AperturaTiquete> tiquetes = new List<AperturaTiquete>();

            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
                connection.Open();
                string query = "SELECT * FROM Tiquetes WHERE ID_Estatus = @IdEstatus";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdEstatus", idEstatus);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AperturaTiquete tiquete = new AperturaTiquete(
                        (int)reader["ID_TipoSolicitud"],
                        (string)reader["DescripcionSolicitud"],
                        (int)reader["ID_Prioridad"],
                        (string)reader["NombreUsuario"],
                        (string)reader["AreaTrabajo"],
                        (int)reader["ID_Estatus"]
                    );
                    tiquetes.Add(tiquete);
                }
            }
            return tiquetes;
        }
    }
}
