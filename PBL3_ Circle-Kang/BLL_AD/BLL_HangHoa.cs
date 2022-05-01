using PBL3__Circle_Kang.DAL_AD;
using PBL3__Circle_Kang.DTO_AD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3__Circle_Kang.BLL_AD
{
    public class BLL_HangHoa
    {
        private static BLL_HangHoa _Instance;

        public static BLL_HangHoa Instance { 
            get
            {
                if( _Instance == null )
                {
                    _Instance = new BLL_HangHoa();
                }
                return _Instance;
            }
            private set { } }
        public List<LoaiHang> setCBBLoaiHang()
        {
            return DAL_HangHoa.Instance.GetLoaiHangs();
        }
        public List<Hang> getAllHang(int id,string msg)
        {
            return DAL_HangHoa.Instance.getAllHang(id,msg);
        }
        
    }
}
