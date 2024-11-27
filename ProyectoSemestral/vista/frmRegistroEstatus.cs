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
    public partial class frmRegistroEstatus : Form
    {
        ProyectoSemestral.controlador.TiquetesMaster tm;
        public frmRegistroEstatus()
        {
            InitializeComponent();
            tm = new ProyectoSemestral.controlador.TiquetesMaster();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tm.crearEstatus(this);
            tm.consultarEstatus(this);
        }

        private void frmRegistroEstatus_Load(object sender, EventArgs e)
        {
            tm.consultarEstatus(this);
        }
    }
}
