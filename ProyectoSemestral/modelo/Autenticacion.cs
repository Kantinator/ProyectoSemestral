using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoSemestral.modelo
{
    public class Autenticacion
    {
        private Conexion _conexion;

        public Autenticacion()
        {
            _conexion = new Conexion();
        }

        // Método para verificar si las credenciales son válidas
        public bool IniciarSesion(string nombreUsuario, string contrasena)
        {
            bool autenticado = false;

            try
            {
                using (SqlConnection conn = _conexion.Conectar())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    int result = (int)cmd.ExecuteScalar();
                    autenticado = result > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la autenticación: " + ex.Message);
            }

            return autenticado;
        }
    }
}
