using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veterinaria
{
    public partial class PantallaInicioMedicos : Form
    {
        public PantallaInicioMedicos()
        {
            InitializeComponent();
        }
        private void btnCerrarSesionMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            login miLogin=new login();
            miLogin.Show();
        }

        private void PantallaInicioMedicos_Load(object sender, EventArgs e)
        {
        }
    }
}
