﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.bd
{
    internal class Conexion
    {
        private static SqlConnection conexion;

        public static SqlConnection getConexion()
        {
            if (conexion != null)
            {
                return conexion;

            }
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-6EBHSTK;Initial Catalog=GestionTiquetes;Integrated Security=True";
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de Conexion" + ex.Message);
                return null;
            }
        }
        public static void cerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
