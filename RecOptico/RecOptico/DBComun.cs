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
<<<<<<< HEAD
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-MO6T4C3\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = ProyectoOptometria");
=======
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-NOLKORRR; Integrated Security = SSPI; Initial Catalog = ProyectoOptometria");
>>>>>>> 1f49750f7c2c8ea9dbe293972c8b49106064ed6c
            Con.Open();
            return Con;
        }
    }
}
