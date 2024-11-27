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
    public partial class frmActualizacionEstatus : Form
    {
        ProyectoSemestral.controlador.TiquetesMaster tm;
        public frmActualizacionEstatus()
        {
            InitializeComponent();
            tm = new controlador.TiquetesMaster();
        }

        private void btnInicioAtencion_Click(object sender, EventArgs e)
        {
            tm.inicioTiquete(this);
        }

        private void btnTerminacion_Click(object sender, EventArgs e)
        {
            tm.finTiquete(this);
        }

        private void frmActualizacionEstatus_Load(object sender, EventArgs e)
        {
            tm.listarTiquete(this);
        }
    }
}
