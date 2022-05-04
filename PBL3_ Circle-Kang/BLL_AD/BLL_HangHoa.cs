using PBL3__Circle_Kang.DAL_AD;
using PBL3__Circle_Kang.DTO_AD;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable getAllHang(int id_LHH,int id_NSX,string msg)
        {
            return DAL_HangHoa.Instance.getAllHang(id_LHH,id_NSX,msg);
        }
        public List<NhaSanXuat> getAllNSX()
        {
            return DAL_HangHoa.Instance.GetAllNhaSanXuat();
        }
        public List<string> getNSXByIDLoaiHang(int id)
        {
            return DAL_HangHoa.Instance.getNSXByIDLoaiHang(id);
        }
        public Hang getHangByID(int id)
        {
            return DAL_HangHoa.Instance.getHangByID(id);
        }
        public List<MaGiamGia> GetMaGiamGias()
        {
            return DAL_HangHoa.Instance.GetMaGiamGias();
        }
        public void AddUpdateHang(Hang h)
        {
            bool add = true;
            foreach(DataRow i in getAllHang(0, 0, "").Rows)
            {
                if(h.ID == DAL_HangHoa.Instance.getHangByDataRow(i).ID)
                {
                    add = false;
                    break;
                }
            }
            if(add)
            {
                AddHang(h);
            }else
            {
                UpdateHang(h);
            }

        }
        public void AddHang(Hang h)
        {
            DAL_HangHoa.Instance.AddHangHoa(h);
        }
        public void UpdateHang(Hang h)
        {
            DAL_HangHoa.Instance.UpdateHangHoa(h);
        }
        public void DeleteHang(Hang h)
        {
            DAL_HangHoa.Instance.DeleteHangHoa(h);
        }
        public DataTable SortHangByYeuCau(string msg)
        {
            return DAL_HangHoa.Instance.SortHangHoa(msg);
        }
        
    }
}
