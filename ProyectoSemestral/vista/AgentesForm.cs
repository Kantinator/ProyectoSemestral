using System;
using System.Windows.Forms;
using ProyectoSemestral.modelo;

namespace ProyectoSemestral.vista
{
    public partial class AgentesForm : Form
    {
        public AgentesForm()
        {
            InitializeComponent();
        }

        // Evento que se dispara cuando se carga el formulario
        private void AgentesForm_Load(object sender, EventArgs e)
        {
            // Cargar datos en DataGridView
            CargarAgentes();
        }

        private void CargarAgentes()
        {
            // Lógica para cargar agentes en el DataGridView
        }

        // Evento para agregar un nuevo agente
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un agente
        }

        // Evento para actualizar un agente existente
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un agente
        }

        // Evento para eliminar un agente seleccionado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un agente
        }

        // Evento cuando se selecciona una celda en el DataGridView
        private void dataGridViewAgentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para cargar datos del agente seleccionado en los controles
        }
    }
}
