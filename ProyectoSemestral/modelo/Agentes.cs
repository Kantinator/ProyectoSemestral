using ProyectoSemestral.bd;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoSemestral.modelo
{
    public class Agentes
    {
        private Conexion conexion = new Conexion();

        public DataTable ObtenerAgentes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = conexion.Conectar())
            {
                try
                {
                    string query = "SELECT * FROM Agentes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los agentes: " + ex.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
            return dt;
        }

        public bool InsertarAgente(string nombreAgente, int idAreaAtencion, int idSupervisor)
        {
            using (SqlConnection con = conexion.Conectar())
            {
                try
                {
                    string query = @"
                        INSERT INTO Agentes (NombreAgente, ID_AreaAtencion, ID_Supervisor)
                        VALUES (@NombreAgente, @ID_AreaAtencion, @ID_Supervisor)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreAgente", nombreAgente);
                    cmd.Parameters.AddWithValue("@ID_AreaAtencion", idAreaAtencion);
                    cmd.Parameters.AddWithValue("@ID_Supervisor", idSupervisor);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el agente: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }

        public bool ActualizarAgente(int idAgente, string nombreAgente, int idAreaAtencion, int idSupervisor)
        {
            using (SqlConnection con = conexion.Conectar())
            {
                try
                {
                    string query = @"
                        UPDATE Agentes 
                        SET NombreAgente = @NombreAgente, 
                            ID_AreaAtencion = @ID_AreaAtencion,
                            ID_Supervisor = @ID_Supervisor
                        WHERE ID_Agente = @ID_Agente";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID_Agente", idAgente);
                    cmd.Parameters.AddWithValue("@NombreAgente", nombreAgente);
                    cmd.Parameters.AddWithValue("@ID_AreaAtencion", idAreaAtencion);
                    cmd.Parameters.AddWithValue("@ID_Supervisor", idSupervisor);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el agente: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }

        public bool EliminarAgente(int idAgente)
        {
            using (SqlConnection con = conexion.Conectar())
            {
                try
                {
                    string query = "DELETE FROM Agentes WHERE ID_Agente = @ID_Agente";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID_Agente", idAgente);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el agente: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }
    }
}
