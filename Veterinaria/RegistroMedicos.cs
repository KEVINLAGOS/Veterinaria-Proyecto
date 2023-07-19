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
    public partial class RegistroMedicos : Form
    {
        public RegistroMedicos()
        {
            InitializeComponent();
        }

        private void btnConfirmarYContinuarMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaInicioMedicos miInicioMedicos = new PantallaInicioMedicos();
            miInicioMedicos.Show();
        }
    }
}
