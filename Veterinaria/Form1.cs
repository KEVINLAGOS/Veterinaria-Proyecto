using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public login()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioUsuarioDueño miInicioSesionUsuarioDueño = new InicioUsuarioDueño();
            miInicioSesionUsuarioDueño.Show();
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
