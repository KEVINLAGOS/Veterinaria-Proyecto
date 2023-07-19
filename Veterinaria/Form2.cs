using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnConfirmarYContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioUsuarioDueño miInicioSesionUsuarioDueño = new InicioUsuarioDueño();
            miInicioSesionUsuarioDueño.Show();
        }
    }
}
