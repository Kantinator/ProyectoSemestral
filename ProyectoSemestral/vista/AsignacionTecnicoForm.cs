using System;
using System.Windows.Forms;
using ProyectoSemestral.modelo;

namespace ProyectoSemestral.vista
{
    public partial class AsignacionTecnicoForm : Form
    {
        public AsignacionTecnicoForm()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                // Supongamos que tienes controles de interfaz para ingresar los datos necesarios
                int numeroTiquete = int.Parse(txtNumeroTiquete.Text);
                int idTecnico = int.Parse(txtIDTecnico.Text);

                // Crear una instancia de AsignacionTecnico
                AsignacionTecnico asignacion = new AsignacionTecnico();

                // Llamar al método AsignarTecnico
                bool asignado = asignacion.AsignarTecnico(numeroTiquete, idTecnico);

                if (asignado)
                {
                    MessageBox.Show("Técnico asignado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al asignar el técnico.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

