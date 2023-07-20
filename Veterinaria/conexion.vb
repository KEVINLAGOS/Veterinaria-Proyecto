using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class conexion
    {
    Protected Function conectado()
            Try
                cnn = New SqlConnection("data source=192.168.1.170,1433;initial catalog=VETERINARIA;user Prueba;password=12345;")
                cnn.Open()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False


            End Try
        End Function
    }
    }
}
