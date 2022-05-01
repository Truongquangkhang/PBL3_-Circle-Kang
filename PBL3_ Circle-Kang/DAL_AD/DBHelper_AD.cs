using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PBL3__Circle_Kang.DAL_AD
{
    public class DBHelper_AD
    {
        SqlConnection cnn = null;
        private static DBHelper_AD _Instance;

        public static DBHelper_AD Instance { 
            get
            {
                if(_Instance == null)
                {
                    string s = @"Data Source =LAPTOP-DRKNK4BU\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new DBHelper_AD(s);
                }
                return _Instance;
            }
            private set { } }
        private DBHelper_AD(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DataTable getRecords(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query,cnn);
                cnn.Open();
                adapter.Fill(dt);
                cnn.Close();
                return dt;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
