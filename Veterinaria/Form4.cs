using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Veterinaria
{
    public partial class LoginMedicos : Form
    {
        public LoginMedicos()
        {
            InitializeComponent();
        }
        private static string CalculateSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroMedicos miRegistroMedicos = new RegistroMedicos();
            miRegistroMedicos.Show();
        }

        private void btnInicioSesionMedico_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsuarioMedico.Text) || string.IsNullOrWhiteSpace(txtContraseñaMedico.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioMedico.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtContraseñaMedico.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaMedico.Focus();
            }
            string connectionString = @"Data Source=WINDOWS\SQLSERVER;Initial Catalog=VETERINARIA;User ID=sa;Password=17112001;";

            // Consulta de inserción
            string query = "SELECT CONTRASEÑA FROM MEDICO WHERE NOMBRE_MEDICO = @NombreUsuario";


            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un comando con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar valores a los parámetros de la consulta
                    command.Parameters.AddWithValue("@NombreUsuario", txtUsuarioMedico.Text);
                    string storedHash = (string)command.ExecuteScalar();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                      
                            // Obtener la contraseña encriptada almacenada en la base de datos
                            string hashedPassword = CalculateSHA256Hash(txtContraseñaMedico.Text);
                        if (storedHash != null)
                        {

                            if (storedHash.Equals(hashedPassword))
                            {
                                this.Hide();
                                PantallaInicioMedicos miInicioSesionMedico = new PantallaInicioMedicos();
                                miInicioSesionMedico.Show();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    }
                }


               
            }
        }
    }

