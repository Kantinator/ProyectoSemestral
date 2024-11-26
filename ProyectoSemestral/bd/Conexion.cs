using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.bd
{
    internal class Conexion
    {
        private static string cadenaConexion = "Server=DESKTOP-2PNP6F6\\SQLBRIEF;Database=GestionTiquetes;Integrated Security=True;";

        // Propiedad para acceder a la cadena de conexión
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }

        // Método para obtener una conexión abierta
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        // Método para abrir la conexión
        public static SqlConnection AbrirConexion()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión a la base de datos: " + ex.Message);
            }
            return conn;
        }

        // Método para cerrar la conexión
        public static void CerrarConexion(SqlConnection conn)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión a la base de datos: " + ex.Message);
            }
        }
    }
}
