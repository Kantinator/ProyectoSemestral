using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSemestral.vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tiposDeSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nivelesDePrioridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEstatus frm = new frmRegistroEstatus();
            frm.ShowDialog();
        }

        private void areaDeAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supervisoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aperturaDeTiqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignacionDelTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizacionDeEstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizacionEstatus frm = new frmActualizacionEstatus();
            frm.ShowDialog();
        }

        private void tiquetesDeAcuerdoAUnEstatusXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void distribuciónPorcentualDeTiquetesSinCerrarPorÁreaDeAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistribuicionPorcentual frm = new frmDistribuicionPorcentual();
            frm.ShowDialog();
        }

        private void áreaDeAtenciónConMayorCantidadDeTiquetesSinCerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAreaAtencionMayorCantidad frm = new frmAreaAtencionMayorCantidad();
            frm.ShowDialog();
        }

        private void técnicoConElMayorNúmeroDeTiquetesAtendidosEnUnPeriodoDeTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historialDeSeguimientoDeUnaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesSinCerrarConMásDeXCantidadDeDíasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesSinTécnicosAsignadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
