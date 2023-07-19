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
    public partial class LoginMedicos : Form
    {
        public LoginMedicos()
        {
            InitializeComponent();
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroMedicos miRegistroMedicos = new RegistroMedicos();
            miRegistroMedicos.Show();
        }

        private void btnInicioSesionMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaInicioMedicos miInicioSesionMedico=new PantallaInicioMedicos();
            miInicioSesionMedico.Show();
        }
    }
}
