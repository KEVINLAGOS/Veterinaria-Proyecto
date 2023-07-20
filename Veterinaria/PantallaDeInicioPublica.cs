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
    public partial class InicioUsuarioDueño : Form
    {
        private const string connectionString = "Data Source=localhost;Initial Catalog=VETERINARIA;Integrated Security=True";

        public InicioUsuarioDueño()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            login miLogin = new login();
            miLogin.ShowDialog();
        }

        private void btnRegistarCita_Click(object sender, EventArgs e)
        {
            

        }
    }
}
