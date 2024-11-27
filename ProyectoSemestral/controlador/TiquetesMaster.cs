using ProyectoSemestral.vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.controlador
{
    public class TiquetesMaster
    {
        private bd.GestorTiquetes gt;

        public TiquetesMaster()
        {
            gt = new bd.GestorTiquetes();
        }


        public void crearEstatus(frmRegistroEstatus r)
        {
            gt.registrarEstatus(new modelo.Estatus(r.txtDescripcion.Text));
        }

        public void consultarEstatus(frmRegistroEstatus r)
        {
            SqlDataReader lector = gt.consultarEstatus();
            DataTable dt = new DataTable();
            dt.Load(lector);
            r.dgvEstatus.DataSource = dt;
        }

        public void inicioTiquete(frmActualizacionEstatus r)
        {
            gt.inicioAtencion(new modelo.InicioAtencion(r.dtpFechaInicio.Value.ToShortDateString(), r.dtpHoraInicio.Value.ToShortDateString(), r.txtDiagnostico.Text), int.Parse(r.cmbNum.Text));
        }

        public void finTiquete(frmActualizacionEstatus r)
        {
            gt.finalAtencion(new modelo.FinAtencion(r.dtpTerminacion.Value.ToShortDateString(), r.dtpHoraTerminacion.Value.ToShortDateString()), int.Parse(r.cmbNum.Text));
        }

        public void listarTiquete(frmActualizacionEstatus r)
        {
            SqlDataReader lector = gt.listadoTiquete();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumeroTiquete", typeof(int));
            dt.Load(lector);
            r.cmbNum.ValueMember = "NumeroTiquete";
            r.cmbNum.DataSource = dt;
        }

        public void mayorCantidad(frmAreaAtencionMayorCantidad r)
        {
            SqlDataReader lector = gt.consultaMayorCantidad();
            DataTable dt = new DataTable();
            dt.Load(lector);
            r.dgvMayor.DataSource = dt;
        }
        public void distribucionPorcentual(frmDistribuicionPorcentual r)
        {
            SqlDataReader lector = gt.consultaDistribucion();
            DataTable dt = new DataTable();
            dt.Load(lector);
            r.dgvDistribucion.DataSource = dt;
        }
    }
}
