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

        //crear una conexion
        class conexion
        {
            public static SqlConnection conectar()
            {
                SqlConnection cn = new SqlConnection("SERVER=DESKTOP-9GCKMTO\\SQLEXPRESS;DATABASE=VETERINARIA;integrated security=true");
                cn.Open();
                return cn;
            }
        }
        private void btnCerrarSesionMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            login miLogin=new login();
            miLogin.Show();
        }

        private void PantallaInicioMedicos_Load(object sender, EventArgs e)
        {
            conexion.conectar();
        }

        //estableciendo la conexion para poder traer los datos de la tabla de sql "CITA"
        public DataTable llenar_dgv()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "select*from CITA";
            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
    }
}
