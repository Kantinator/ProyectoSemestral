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
    public partial class frmDistribuicionPorcentual : Form
    {
        controlador.TiquetesMaster tm;
        public frmDistribuicionPorcentual()
        {
            InitializeComponent();
            tm = new controlador.TiquetesMaster();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            tm.distribucionPorcentual(this);
        }

        private void frmDistribuicionPorcentual_Load(object sender, EventArgs e)
        {

        }
    }
}
