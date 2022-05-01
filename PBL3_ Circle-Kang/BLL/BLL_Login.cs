using PBL3__Circle_Kang.DAL;
using PBL3__Circle_Kang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3__Circle_Kang.BLL
{
    public class BLL_Login
    {
        private static BLL_Login _Instance;

        public static BLL_Login Instance { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
            private set { } }
        public Account GetAccountLogin(string user,string pw)
        {
            return DAL_Login.Instance.getAccount(user, pw);
        }
    }
}
