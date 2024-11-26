using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProyectoSemestral.modelo
{
    public class AreaAtencion
    {
        private Conexion _conexion;

        public AreaAtencion()
        {
            _conexion = new Conexion();
        }

        // Método para obtener las áreas con más tiquetes sin cerrar
        public List<AreaTiquetes> ObtenerAreasConTiquetesSinCerrar()
        {
            List<AreaTiquetes> areas = new List<AreaTiquetes>();

            try
            {
                using (SqlConnection conn = _conexion.Conectar())
                {
                    string query = @"
                        SELECT a.NombreArea, COUNT(t.NumeroTiquete) AS TiquetesPendientes
                        FROM AreaAtencion a
                        INNER JOIN Tecnicos t ON t.ID_AreaAtencion = a.ID_AreaAtencion
                        INNER JOIN Tiquetes ti ON ti.ID_AreaAtencion = a.ID_AreaAtencion
                        WHERE ti.ID_Estatus != 3  -- 3 es el estatus de 'Cerrado'
                        GROUP BY a.NombreArea
                        ORDER BY TiquetesPendientes DESC;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AreaTiquetes area = new AreaTiquetes
                        {
                            NombreArea = reader["NombreArea"].ToString(),
                            TiquetesPendientes = Convert.ToInt32(reader["TiquetesPendientes"])
                        };

                        areas.Add(area);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las áreas con tiquetes sin cerrar: " + ex.Message);
            }

            return areas;
        }
    }

    // Clase que representa cada área con su cantidad de tiquetes pendientes
    public class AreaTiquetes
    {
        public string NombreArea { get; set; }
        public int TiquetesPendientes { get; set; }
    }
}
