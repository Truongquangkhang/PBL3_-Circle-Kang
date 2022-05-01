using PBL3__Circle_Kang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3__Circle_Kang.DAL
{
    public class DAL_Login
    {
        private static DAL_Login _Instance;

        public static DAL_Login Instance { 
            get
            {
                if( _Instance == null )
                {
                    _Instance = new DAL_Login();
                }
                return _Instance;
            }
            private set { } }
        public Account getAccount(string user,string pw)
        {
            string query = "Select * from ACCOUNT where UserName = '" + user + "'" +
                "AND PW = '" + pw + "'";
            DataRow r = Login_DBHelper.Instance.getRecord(query).Rows[0];
            return new Account {
                ID = Convert.ToInt32(r["ID"].ToString()),
                UserName = r["UserName"].ToString(),
                PW = r["PW"].ToString(),
                Loai = Convert.ToInt32(r["Loai"].ToString()),
            };
        } 
    }
}
