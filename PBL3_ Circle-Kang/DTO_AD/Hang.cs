using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3__Circle_Kang.DTO_AD
{
    public class Hang
    {
        public int ID { get; set; }
        public string TenMatHang { get; set; }
        public int IDLoaiHang { get; set; }
        public int IDNhaSX { get; set; }
        public int IDMaGG { get; set; }
        public int Gia { get; set; }
        public DateTime HSD { get; set; }
        public int SoLuong { get; set; }
        public bool trangThai { get; set; }

    }
}
