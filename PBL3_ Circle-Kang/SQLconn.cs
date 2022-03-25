using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBL3__Circle_Kang
{
    internal class SQLconn
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\NHATHUNG;Initial Catalog=CircleKang;Integrated Security=True");
    }
}
