using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class login : Form
    {
        private string connectionString = "data source=192.168.1.170,1433;initial catalog=VETERINARIA;user Prueba;password=12345;";


        public login()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasena = txtContraseña.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuario WHERE Nombre_usuario = @NombreUsuario AND Contraseña = @Contrasena";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            this.Hide();
                            InicioUsuarioDueño miInicioSesionUsuarioDueño = new InicioUsuarioDueño();
                            miInicioSesionUsuarioDueño.Show();
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registro miRegistro=new Registro();
            miRegistro.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClaveParaMedicos miClaveParaMedicos=new ClaveParaMedicos();
            miClaveParaMedicos.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
