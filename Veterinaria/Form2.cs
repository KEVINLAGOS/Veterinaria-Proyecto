using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Registro : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=VETERINARIA;Integrated Security=True";
        public Registro()
        {
            InitializeComponent();
        }

        private void btnConfirmarYContinuar_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreoElectronico.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string genero = cbGenero.SelectedItem.ToString();
            string contrasena = txtContraseñaRegistro.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Usuario (Nombre_usuario, Apellido_Paterno, Apellido_Materno, Direccion, Telefono, Correo, Fecha_nacimiento, Genero, Contraseña) " +
                                   "VALUES (@NombreUsuario, @ApellidoMaterno, @ApellidoPaterno, @Direccion, @Telefono, @Correo, @FechaNacimiento, @Genero, @Contrasena)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                        command.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@Genero", genero);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente.");

                            this.Hide();
                            InicioUsuarioDueño miInicioSesionUsuarioDueño = new InicioUsuarioDueño();
                            miInicioSesionUsuarioDueño.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
