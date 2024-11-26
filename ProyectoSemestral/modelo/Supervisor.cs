using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoSemestral.modelo
{
    public class Supervisor
    {
        // Propiedades del Supervisor
        public int ID_Supervisor { get; set; }
        public string Nombre { get; set; }
        public int ID_AreaAtencion { get; set; }

        // Constructor sin parámetros
        public Supervisor() { }

        // Constructor con parámetros
        public Supervisor(int idSupervisor, string nombre, int idAreaAtencion)
        {
            this.ID_Supervisor = idSupervisor;
            this.Nombre = nombre;
            this.ID_AreaAtencion = idAreaAtencion;
        }

        // Método para cargar todos los supervisores
        public static DataTable ObtenerSupervisores()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT s.ID_Supervisor, s.Nombre, a.Nombre AS AreaAtencion FROM Supervisores s JOIN AreaAtencion a ON s.ID_AreaAtencion = a.ID_AreaAtencion";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener supervisores: " + ex.Message);
            }
            return dataTable;
        }

        // Método para agregar un nuevo supervisor
        public bool AgregarSupervisor()
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO Supervisores (Nombre, ID_AreaAtencion) VALUES (@Nombre, @ID_AreaAtencion)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                    comando.Parameters.AddWithValue("@ID_AreaAtencion", this.ID_AreaAtencion);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    conexion.Close();

                    resultado = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el supervisor: " + ex.Message);
            }
            return resultado;
        }

        // Método para actualizar un supervisor existente
        public bool ActualizarSupervisor()
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE Supervisores SET Nombre = @Nombre, ID_AreaAtencion = @ID_AreaAtencion WHERE ID_Supervisor = @ID_Supervisor";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                    comando.Parameters.AddWithValue("@ID_AreaAtencion", this.ID_AreaAtencion);
                    comando.Parameters.AddWithValue("@ID_Supervisor", this.ID_Supervisor);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    conexion.Close();

                    resultado = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el supervisor: " + ex.Message);
            }
            return resultado;
        }

        // Método para eliminar un supervisor
        public bool EliminarSupervisor(int idSupervisor)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Supervisores WHERE ID_Supervisor = @ID_Supervisor";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ID_Supervisor", idSupervisor);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    conexion.Close();

                    resultado = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el supervisor: " + ex.Message);
            }
            return resultado;
        }
    }
}
