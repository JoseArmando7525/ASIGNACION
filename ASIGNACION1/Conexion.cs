using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ASIGNACION1
{
    internal class Conexion
    {
        public static SqlConnection getConexion()
        {
            SqlConnection conn = new SqlConnection("SERVER=DESKTOP-IDPOS9V;database=ASIGNACION;INTEGRATED SECURITY=TRUE");
            return conn;
        }
    }
}
