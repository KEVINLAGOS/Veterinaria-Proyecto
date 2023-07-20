using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Veterinaria
{
    public class ConexionBD
    {
        private static string connectionString = "Data Source=192.168.1.117;Initial Catalog=VETERINARIA;Integrated Security=True;";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void AbrirConexion()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CerrarConexion()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            return connection;
        }
    }

}