using System;
using System.Data.SqlClient;

namespace ProyectoSemestral.modelo
{
    public class AsignacionTecnico
    {
        public int ID_Asignacion { get; set; }
        public int ID_Tecnico { get; set; }
        public int NumeroTiquete { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public TimeSpan HoraAsignacion { get; set; }

        // Constructor por defecto
        public AsignacionTecnico() { }

        // Constructor con parámetros
        public AsignacionTecnico(int idAsignacion, int idTecnico, int numeroTiquete, DateTime fechaAsignacion, TimeSpan horaAsignacion)
        {
            ID_Asignacion = idAsignacion;
            ID_Tecnico = idTecnico;
            NumeroTiquete = numeroTiquete;
            FechaAsignacion = fechaAsignacion;
            HoraAsignacion = horaAsignacion;
        }

        // Método para asignar un técnico
        public bool AsignarTecnico(int numeroTiquete, int idTecnico)
        {
            try
            {
                using (SqlConnection conn = Conexion.GetConexion())
                {
                    conn.Open();
                    string query = "UPDATE Tiquetes SET ID_Tecnico = @idTecnico, FechaAsignacion = @fecha, HoraAsignacion = @hora WHERE NumeroTiquete = @numeroTiquete";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idTecnico", idTecnico);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@hora", DateTime.Now.TimeOfDay);
                        cmd.Parameters.AddWithValue("@numeroTiquete", numeroTiquete);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al asignar técnico: " + ex.Message);
                return false;
            }
        }
    }
}
