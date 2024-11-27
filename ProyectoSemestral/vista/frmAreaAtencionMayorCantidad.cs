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
    public partial class frmAreaAtencionMayorCantidad : Form
    {
        controlador.TiquetesMaster tm;
        public frmAreaAtencionMayorCantidad()
        {
            InitializeComponent();
            tm = new controlador.TiquetesMaster();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            tm.mayorCantidad(this);
        }

        private void frmAreaAtencionMayorCantidad_Load(object sender, EventArgs e)
        {

        }
    }
}
