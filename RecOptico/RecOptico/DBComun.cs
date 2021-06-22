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
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-VCFFGU0; Integrated Security = SSPI; Initial Catalog = ProyectoOptometria");
            Con.Open();
            return Con;
        }
    }
}
