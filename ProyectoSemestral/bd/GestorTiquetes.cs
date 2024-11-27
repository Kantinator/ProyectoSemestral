using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.bd
{
    internal class GestorTiquetes
    {
        SqlConnection conexion;

        public GestorTiquetes()
        {
            conexion = bd.Conexion.getConexion();
        }


        public void registrarEstatus(modelo.Estatus e)
        {
            string query = "Insert into Estatus (NombreEstatus) values (@Estatus)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Estatus", e.Descripcion);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Estatus registrado exitosamente.");
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void inicioAtencion(modelo.InicioAtencion t, int NumTiquete)
        {
            string query = "UPDATE Tiquetes SET FechaInicio = @FechaInicio, HoraInicio = @HoraInicio, Diagnostico = @Diagnostico, ID_Estatus = 2 WHERE NumeroTiquete = @Num";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@FechaInicio", t.FechaInicio);
            cmd.Parameters.AddWithValue("@HoraInicio", t.HoraInicio);
            cmd.Parameters.AddWithValue("@Diagnostico", t.Diagnostico);
            cmd.Parameters.AddWithValue("@Num", NumTiquete);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Estatus actualizado y atencion del tiquete iniciada exitosamente.");
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void finalAtencion(modelo.FinAtencion t, int NumTiquete)
        {
            string query = "UPDATE Tiquetes SET FechaTerminacion = @FechaTerminacion, HoraTerminacion = @HoraTerminacion, ID_Estatus = 3 WHERE NumeroTiquete = @Num";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@FechaTerminacion", t.FechaFin);
            cmd.Parameters.AddWithValue("@HoraTerminacion", t.HoraFin);
            cmd.Parameters.AddWithValue("@Num", NumTiquete);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Atencion del tiquete terminada exitosamente.");
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        public SqlDataReader consultarEstatus()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select * FROM Estatus";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader consultarTiquetesSinCerrar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select * FROM Estatus";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader listadoTiquete()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Select NumeroTiquete from Tiquetes Order by NumeroTiquete";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }

        public SqlDataReader consultaMayorCantidad()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "select*from vista_mayor_cantidad_sin_cerrar";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
        public SqlDataReader consultaDistribucion()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "select*from vista_distribucion_porcentual";
            SqlDataReader consulta = cmd.ExecuteReader();
            return consulta;
        }
    }
}
