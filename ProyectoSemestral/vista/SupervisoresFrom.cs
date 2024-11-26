using System;
using System.Windows.Forms;
using ProyectoSemestral.modelo;

namespace ProyectoSemestral.vista
{
    public partial class SupervisoresForm : Form
    {
        public SupervisoresForm()
        {
            InitializeComponent();
        }

        // Evento que se dispara cuando se carga el formulario
        private void SupervisoresForm_Load(object sender, EventArgs e)
        {
            // Cargar datos en DataGridView
            CargarSupervisores();
        }

        private void CargarSupervisores()
        {
            // Lógica para cargar supervisores en el DataGridView
        }

        // Evento para agregar un nuevo supervisor
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un supervisor
        }

        // Evento para actualizar un supervisor existente
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un supervisor
        }

        // Evento para eliminar un supervisor seleccionado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un supervisor
        }

        // Evento cuando se selecciona una celda en el DataGridView
        private void dataGridViewSupervisores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para cargar datos del supervisor seleccionado en los controles
        }
    }
}
