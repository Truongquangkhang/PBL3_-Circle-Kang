using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PBL3__Circle_Kang.DAL
{
    public class Login_DBHelper
    {
        SqlConnection cnn = null;
        private static Login_DBHelper _Instance;

        public static Login_DBHelper Instance { 
            get
            {
                if(_Instance == null)
                {
                    string s = @"Data Source =LAPTOP-DRKNK4BU\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new Login_DBHelper(s);
                }
                return _Instance;
            }
            private set { } }

        private Login_DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable getRecord(string query)
        {
            DataTable dt = new DataTable(); 
            try
            {
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
                adapter.Fill(dt);
                cnn.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
