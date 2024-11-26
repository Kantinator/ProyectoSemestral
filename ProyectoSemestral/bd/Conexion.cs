using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoSemestral
{
    public class Conexion
    {
        private SqlConnection conexion;

        // Constructor que inicializa la conexión
        public Conexion()
        {
            // Asegúrate de que la cadena de conexión esté correcta
            string cadenaConexion = "Data Source = LAPTOP-G27EGHNJ;Initial Catalog=GestionTiquetes;Integrated Security = True";
            conexion = new SqlConnection(cadenaConexion);
        }

        internal static SqlConnection GetConexion()
        {
            throw new NotImplementedException();
        }

        // Método para abrir la conexión
        public SqlConnection Conectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return conexion;
        }
        public DataTable ObtenerAreaConMasTiquetesSinCerrar()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = GetConexion())
                {
                    conn.Open();
                    string query = @"
                                        SELECT 
                            a.NombreArea AS 'Área de Atención', 
                            COUNT(t.NumeroTiquete) AS 'Cantidad de Tiquetes Sin Cerrar'
                        FROM 
                            Tiquetes t
                        INNER JOIN 
                            AreaAtencion a ON t.ID_AreaAtencion = a.ID_AreaAtencion
                        INNER JOIN 
                            Estatus e ON t.ID_Estatus = e.ID_Estatus
                        WHERE 
                            e.NombreEstatus != 'Cerrado'  -- Filtra los tiquetes cuyo estatus no es 'Cerrado'
                        GROUP BY 
                            a.NombreArea
                        ORDER BY 
                            COUNT(t.NumeroTiquete) DESC;
                        ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el área con más tiquetes sin cerrar: " + ex.Message);
            }
            return dt;
        }

        // Método para cerrar la conexión
        public void Desconectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar la base de datos: " + ex.Message);
            }
        }
    }
}
