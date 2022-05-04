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
        public List<NhaSanXuat> GetAllNhaSanXuat()
        {
            List<NhaSanXuat> data = new List<NhaSanXuat>();
            string query = "Select * from NHA_SAN_XUAT";
            foreach(DataRow r in DBHelper_AD.Instance.getRecords(query).Rows)
            {
                data.Add(getNSXByDataRow(r));
            }
            return data;
        }
        public NhaSanXuat getNSXByDataRow (DataRow i)
        {
            return new NhaSanXuat { 
                ID = Convert.ToInt32(i["ID"].ToString()),
                TenNhaSX = i["TenNhaSX"].ToString()
            };
        }
        public List<string> getNSXByIDLoaiHang(int id)
        {
            List<string> data = new List<string>();
            string query = "SELECT  DISTINCT NSX.TenNhaSX  FROM (HANG INNER JOIN NHA_SAN_XUAT as NSX "
                + "on HANG.IDNhaSX = NSX.ID) where HANG.IDLoaiHang = '" + id + "'";
            foreach(DataRow r in DBHelper_AD.Instance.getRecords(query).Rows)
            {
                data.Add((string)r[0].ToString());
            }
            return data;
        }
        public DataTable getAllHang(int id,int nsx,string msg)
        {
            DataTable data = new DataTable();
            string query = "";
            if(id == 0 && nsx == 0 && msg == "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID";
            }else if(id == 0 && nsx == 0&& msg != "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND TenMatHang LIKE N'%" + msg + "%'";
            }else if(id == 0 && nsx!= 0 && msg == "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDNhaSX = '" + nsx + "'";
            }else if(id == 0 && nsx !=0 && msg != "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDNhaSX = '" + nsx + "'" +
                    "AND TenMatHang LIKE N'%" + msg + "%'";
            }else if(id != 0 && nsx == 0 && msg == "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDLoaiHang  = '" + id + "'";
            }else if(id != 0 && nsx ==0 && msg != "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDLoaiHang ='" + id+"' " +
                    "AND TenMatHang LIKE N'%" + msg + "%'";
            }else if(id != 0 && nsx != 0 && msg == "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDLoaiHang ='" + id + "' " +
                    "AND IDNhaSX = '" + nsx + "'";
            }else if(id != 0 && nsx != 0 && msg != "")
            {
                query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID AND IDLoaiHang ='" + id + "' " +
                    "AND IDNhaSX = '"+nsx+"' AND TenMatHang LIKE N'%" + msg + "%'";
            }
            return DBHelper_AD.Instance.getRecords(query);
        }
        public Hang getHangByID(int id)
        {
            Hang h = new Hang();
            string query = "Select * from HANG where ID = '" + id + "'";
            DataRow r = DBHelper_AD.Instance.getRecords(query).Rows[0];
            return getHangByDataRow(r);
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
        public List<MaGiamGia> GetMaGiamGias()
        {
            List<MaGiamGia> data = new List<MaGiamGia>();
            string query = "Select * from MA_GIAM_GIA";
            foreach(DataRow r in DBHelper_AD.Instance.getRecords(query).Rows)
            {
                data.Add(new MaGiamGia
                {
                    ID = Convert.ToInt32(r["ID"].ToString()),
                    DiscountPerPro = float.Parse(r["DiscountPerPro"].ToString())
                });
            }
            return data;
        }
        public void AddHangHoa(Hang h)
        {
            string query = string.Format("insert into HANG values(N'{0}'," +
                "'{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                h.TenMatHang,h.IDLoaiHang,h.IDNhaSX,h.IDMaGG,h.Gia,h.HSD,
                h.SoLuong,h.trangThai);
            DBHelper_AD.Instance.ExecuteDB(query);
        }
        public void UpdateHangHoa(Hang h)
        {
            string query = "Update HANG set " +
                "TenMatHang = N'"+h.TenMatHang+"',IDLoaiHang = '"+h.IDLoaiHang+"'," +
                "IDNhaSX = '"+h.IDNhaSX+"'," +
                "IDMaGG = '"+h.IDMaGG+"',Gia = '"+h.Gia+"',HSD = '"+h.HSD+"'," +
                "SoLuong = '"+h.SoLuong+"',trangThai ='"+h.trangThai+"'" +
                "Where ID = '" + h.ID + "'";
            DBHelper_AD.Instance.ExecuteDB(query);
        }
        public void DeleteHangHoa(Hang h)
        {
            string query = "Delete from HANG where ID = '"+h.ID+"'";
            DBHelper_AD.Instance.ExecuteDB(query);
        }
        public DataTable SortHangHoa(string msg)
        {
            string query = "SELECT HANG.ID,TenMatHang,IDLoaiHang,LOAI_HANG.TenLoaiHang,IDNhaSX, NSX.TenNhaSX," +
                    "IDMaGG,Gia,HSD,SoLuong,trangThai FROM HANG, NHA_SAN_XUAT as NSX,LOAI_HANG " +
                    "where HANG.IDNhaSX = NSX.ID AND HANG.IDLoaiHang = LOAI_HANG.ID " +
                    "ORDER BY '"+msg+"'";
            return DBHelper_AD.Instance.getRecords(query);
        }
    }
}
