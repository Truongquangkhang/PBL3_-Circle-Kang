using PBL3__Circle_Kang.DTO_AD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3__Circle_Kang.DAL_AD
{
    public class DAL_HangHoa
    {
        private static DAL_HangHoa _Instance;

        public static DAL_HangHoa Instance { 
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HangHoa();
                }
                return _Instance;
            }
            private set { } }
        public List<LoaiHang> GetLoaiHangs()
        {
            List<LoaiHang> data = new List<LoaiHang>();
            string query = "Select * from LOAI_HANG";
            foreach(DataRow r in DBHelper_AD.Instance.getRecords(query).Rows)
            {
                data.Add(getLoaiHangByDataRow(r));
            }
            return data;
        }
        public LoaiHang getLoaiHangByDataRow(DataRow i)
        {
            return new LoaiHang { 
                ID = Convert.ToInt32(i["ID"].ToString()),
                TenLoaiHang = i["TenLoaiHang"].ToString(),
            };
        }
        public List<Hang> getAllHang(int id,string msg)
        {
            List<Hang> data = new List<Hang>();
            string query = "";
            if(id == 0 && msg == "")
            {
                query = "Select * from HANG";
            }else if(id == 0 && msg != "")
            {
                query = "Select * from HANG WHERE TenMatHang LIKE N'%" + msg + "%'";
            }else if(id != 0 && msg == "")
            {
                query = "Select * from HANG WHERE IDLoaiHang = '" + id + "'";
            }else if(id != 0 && msg != "")
            {
                query = "Select * from HANG WHERE IDLoaiHang = '" + id + "'" +
                    "AND TenMatHang LIKE N'%" + msg + "%'";
            }
            foreach(DataRow r in DBHelper_AD.Instance.getRecords(query).Rows)
            {
                data.Add(getHangByDataRow(r));
            }
            return data;
        }
        public Hang getHangByDataRow(DataRow i)
        {
            return new Hang { 
                ID = Convert.ToInt32(i["ID"].ToString()),
                TenMatHang = i["TenMatHang"].ToString(),
                IDLoaiHang = Convert.ToInt32(i["IDLoaiHang"].ToString()),
                IDNhaSX = Convert.ToInt32(i["IDNhaSX"].ToString()),
                IDMaGG = Convert.ToInt32(i["IDMaGG"].ToString()),
                Gia = Convert.ToInt32(i["Gia"].ToString()),
                HSD = DateTime.Parse(i["HSD"].ToString()),
                SoLuong = Convert.ToInt32(i["SoLuong"].ToString()),
                trangThai = bool.Parse(i["trangThai"].ToString()),
            };
        }
    }
}
