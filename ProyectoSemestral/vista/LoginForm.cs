using System;
using System.Windows.Forms;
using ProyectoSemestral.modelo;

namespace ProyectoSemestral.vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Crear una instancia de la clase Autenticacion
            Autenticacion autenticacion = new Autenticacion();

            if (autenticacion.IniciarSesion(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir la ventana principal de la aplicación
                this.Hide();
                MainForm mainForm = new MainForm(); // Asegúrate de tener un formulario principal
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
