using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace Veterinaria
{
    public partial class RegistroMedicos : Form
    {
        public string contraseñaencriptada;
        public RegistroMedicos()
        {
            InitializeComponent();
        }

        private void btnConfirmarYContinuarMedico_Click(object sender, EventArgs e)
        {
            string Nombre, ApellidoP, ApellidoM, Especialidad, Direccion, Correo, Contraseña, Telefono;
            DateTime Nacimiento, HorarioInicio, HorarioFin;
            


            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMedico.Focus(); // Colocar el foco en el TextBox
                return ;
            }
            else if (!txtNombreMedico.Text.All(char.IsLetter))
            {
                // El campo contiene caracteres que no son letras
                MessageBox.Show("El campo solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMedico.Focus();
                return;
            }
            else if (txtNombreMedico.Text.Length > 50)
            {
                // El campo excede la longitud máxima permitida
                MessageBox.Show("El campo no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMedico.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoPaternoMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoPaternoMedico.Focus(); // Colocar el foco en el TextBox
                return;
            }
            else if (!txtApellidoPaternoMedico.Text.All(char.IsLetter))
            {
                // El campo contiene caracteres que no son letras
                MessageBox.Show("El campo solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoPaternoMedico.Focus();
                return;
            }
            else if (txtApellidoPaternoMedico.Text.Length > 50)
            {
                // El campo excede la longitud máxima permitida
                MessageBox.Show("El campo no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoPaternoMedico.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(txtApellidoMaternoMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoMaternoMedico.Focus(); // Colocar el foco en el TextBox
                return;

            }
            else if (!txtApellidoMaternoMedico.Text.All(char.IsLetter))
            {
                // El campo contiene caracteres que no son letras
                MessageBox.Show("El campo solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoMaternoMedico.Focus();
                return;

            }
            else if (txtApellidoMaternoMedico.Text.Length > 50)
            {
                // El campo excede la longitud máxima permitida
                MessageBox.Show("El campo no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoMaternoMedico.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEspecialidad.Focus(); // Colocar el foco en el TextBox
                return;

            }
            else if (!txtEspecialidad.Text.All(char.IsLetter))
            {
                // El campo contiene caracteres que no son letras
                MessageBox.Show("El campo solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEspecialidad.Focus();
                return;

            }
            else if (txtEspecialidad.Text.Length > 20)
            {
                // El campo excede la longitud máxima permitida
                MessageBox.Show("El campo no puede tener más de 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoMaternoMedico.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEspecialidad.Focus(); // Colocar el foco en el TextBox
                return;

            }


            if (string.IsNullOrWhiteSpace(txtTelefonoMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoMedico.Focus();
                return;

            }
            else if (!EsNumeroTelefonoValido(txtTelefonoMedico.Text))
            {
                // El campo contiene caracteres que no son números
                MessageBox.Show("El número de teléfono debe contener solo dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoMedico.Focus();
                return;


            }
            else if (txtTelefonoMedico.Text.Length != 10)
            {
                // El campo no tiene 10 dígitos
                MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoMedico.Focus();
                return;


            }


            if (string.IsNullOrWhiteSpace(txtCorreoElectronicoMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreoElectronicoMedico.Focus();
                return;

            }
            else if (!EsCorreoElectronicoValido(txtCorreoElectronicoMedico.Text))
            {
                // El campo no tiene un formato válido de correo electrónico
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            bool EsCorreoElectronicoValido(string correoElectronico)
            {
                string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(correoElectronico, patron);
            }



            bool EsNumeroTelefonoValido(string numeroTelefono)
            {
                return numeroTelefono.All(char.IsDigit);
            }
          
            if (dtpFechaNacimientoMedico.Value >= DateTime.Now)
            {
                // La fecha de nacimiento es inválida (en el futuro o igual a la fecha actual)
                // Realiza las acciones adecuadas, como mostrar un mensaje de error.
                MessageBox.Show("La fecha de nacimiento es inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtmHorarioDeInicio.Value <= DateTime.Now.Date)
            {
                
                MessageBox.Show("Horario esta fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (string.IsNullOrWhiteSpace(txtContraseñaRegistroMedico.Text))
            {
                // El campo está en blanco
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaRegistroMedico.Focus();
                return;
            }



            // La validación pasó, puedes guardar el valor en una variable
            Nombre = txtNombreMedico.Text;
            ApellidoP = txtApellidoMaternoMedico.Text;
            ApellidoM = txtApellidoMaternoMedico.Text;
            Especialidad = txtEspecialidad.Text;
            Direccion = txtDireccion.Text;
            Telefono = txtTelefonoMedico.Text;
            Correo = txtCorreoElectronicoMedico.Text;
            Nacimiento = dtpFechaNacimientoMedico.Value;
            HorarioInicio = dtmHorarioDeInicio.Value;
           
            Contraseña = txtContraseñaRegistroMedico.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la contraseña en un arreglo de bytes
                byte[] bytesContraseña = Encoding.UTF8.GetBytes(Contraseña);

                // Calcular el hash de la contraseña
                byte[] hashContraseña = sha256Hash.ComputeHash(bytesContraseña);


                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashContraseña.Length; i++)
                {
                    sb.Append(hashContraseña[i].ToString("x2"));
                }


                contraseñaencriptada = sb.ToString();

            }
            string connectionString = @"Data Source=WINDOWS\SQLSERVER;Initial Catalog=VETERINARIA;User ID=sa;Password=17112001;";

            // Consulta de inserción
            string query = "INSERT INTO MEDICO (NOMBRE_MEDICO,APELLIDO_MATERNO,APELLIDO_PATERNO,ESPECIALIDAD,DIRECCION,TELEFONO ,CORREO,HORARIO_TRABAJO,CONTRASEÑA)" +
                "VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6, @Valor7, @Valor8,@Valor9)";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un comando con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar valores a los parámetros de la consulta
                    command.Parameters.AddWithValue("@Valor1", Nombre); // Reemplaza "valor1" con el valor real a insertar
                    command.Parameters.AddWithValue("@Valor2", ApellidoM); // Reemplaza "valor2" con el valor real a insertar
                    command.Parameters.AddWithValue("@Valor3", ApellidoP); // Reemplaza "valor3" con el valor real a insertar
                    command.Parameters.AddWithValue("@Valor4", Especialidad);
                    command.Parameters.AddWithValue("@Valor5", Direccion);
                    command.Parameters.AddWithValue("@Valor6", Telefono);
                    command.Parameters.AddWithValue("@Valor7", Correo);
                    command.Parameters.AddWithValue("@Valor8", HorarioInicio);
                    command.Parameters.AddWithValue("@Valor9",contraseñaencriptada);


                    // Ejecutar la consulta de inserción
                    command.ExecuteNonQuery();
                }
            }



            
           
        


            MessageBox.Show("¡Registro exitoso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            PantallaInicioMedicos miInicioMedicos = new PantallaInicioMedicos();
            miInicioMedicos.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistroMedicos_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WINDOWS\SQLSERVER;Initial Catalog=VETERINARIA;User ID=sa;Password=17112001;";
            int nuevoId=0 ;

            // Consulta de selección
            string query = "SELECT MAX(ID_MEDICO) FROM MEDICO";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un comando con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int ultimoId = Convert.ToInt32(result);
                        nuevoId = ultimoId + 1;
                    }
                }
            }

            // Asignar el valor del ID al label
            lblid.Text = nuevoId.ToString();

        }
    }
}
