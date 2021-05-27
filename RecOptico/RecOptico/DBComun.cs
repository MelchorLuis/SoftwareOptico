using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecOptico
{
    class DBComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-NOLKORRR; DATABASE= ProyectoOptometria; Integrated security=true");
            Con.Open();
            return Con;
        }
    }
}
