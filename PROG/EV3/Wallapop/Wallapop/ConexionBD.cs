using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Wallapop
{
    public class ConexionBD
    {
        string cadena = "Data Source=192.168.56.101\\SQLEXPRESS,1433;Initial Catalog=BD;Integrated Security=True";
        public SqlConnection conectarbd;
    }
}