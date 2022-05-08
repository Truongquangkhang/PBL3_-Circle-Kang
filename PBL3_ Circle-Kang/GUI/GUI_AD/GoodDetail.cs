using PBL3__Circle_Kang.BLL_AD;
using PBL3__Circle_Kang.DTO_AD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3__Circle_Kang.GUI_AD
{
    public partial class GoodDetail : Form
    {
        private int IDHH;
        public delegate void MyDel(int id_LHH, int id_NSX, string msg);
        public MyDel d;
        public GoodDetail(int d)
        {
            InitializeComponent();
            IDHH = d;
            txtID.Enabled = false;
            txtTrangThai.Enabled = false;
            setCBB();
            setGUI();
        }
        public List<CBBItemNhaSanXuat> listNSX()
        {
            List<CBBItemNhaSanXuat> data = new List<CBBItemNhaSanXuat>();
            foreach (NhaSanXuat i in BLL_HangHoa.Instance.getAllNSX())
            {
                data.Add(new CBBItemNhaSanXuat
                {
                    Value = i.ID,
                    Text = i.TenNhaSX
                });
            }
            return data;
        }
        public void setCBB()
        {
            if (cbbLoaiHang.Items.Count > 0)
            {
                cbbLoaiHang.Items.Clear();
            }
            foreach (LoaiHang i in BLL_HangHoa.Instance.setCBBLoaiHang())
            {
                cbbLoaiHang.Items.Add(new CBBItemLoaiHang
                {
                    Value = i.ID,
                    Text = i.TenLoaiHang
                });
            }
            
            if (cbbMaGiamGia.Items.Count > 0)
            {
                cbbMaGiamGia.Items.Clear();
            }
            foreach (MaGiamGia i in BLL_HangHoa.Instance.GetMaGiamGias())
            {
                cbbMaGiamGia.Items.Add(new CBBItemMaGiamGia
                {
                    Value = i.ID,
                    Text = i.DiscountPerPro*100 + ""
                });
            }
        }
        public void setGUI()
        {
            if(IDHH > 0)
            {
                txtID.Text = BLL_HangHoa.Instance.getHangByID(IDHH).ID+"";
                txtID.Enabled = false;
                txtTenMatHang.Text = BLL_HangHoa.Instance.getHangByID(IDHH).TenMatHang;
                foreach(CBBItemLoaiHang i in cbbLoaiHang.Items)
                {
                    if(i.Value == BLL_HangHoa.Instance.getHangByID(IDHH).IDLoaiHang)
                    {
                        cbbLoaiHang.SelectedItem = i;
                        break;
                    }
                }
                foreach(CBBItemNhaSanXuat i in cbbNhaSanXuat.Items)
                {
                    if(i.Value == BLL_HangHoa.Instance.getHangByID(IDHH).IDNhaSX)
                    {
                        cbbNhaSanXuat.SelectedItem = i;
                        break;
                    }
                }
                foreach(CBBItemMaGiamGia i in cbbMaGiamGia.Items)
                {
                    if(i.Value == BLL_HangHoa.Instance.getHangByID(IDHH).IDMaGG)
                    {
                        cbbMaGiamGia.SelectedItem = i;
                        break;
                    }
                }
                txtGia.Text = BLL_HangHoa.Instance.getHangByID(IDHH).Gia + "";
                dateTimePickerHSD.Text = BLL_HangHoa.Instance.getHangByID(IDHH).HSD + "";
                txtSoLuong.Text = BLL_HangHoa.Instance.getHangByID(IDHH).SoLuong + "";
                txtTrangThai.Text = BLL_HangHoa.Instance.getHangByID(IDHH).trangThai + "";
                txtTrangThai.Enabled = false;
            }
        }
        

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            Hang h = new Hang();
            if(txtID.Text != "")
            {
                h.ID = Convert.ToInt32(txtID.Text.ToString());
            }
            h.TenMatHang = txtTenMatHang.Text;
            h.IDLoaiHang = ((CBBItemLoaiHang)cbbLoaiHang.SelectedItem).Value;
            h.IDNhaSX = ((CBBItemNhaSanXuat)cbbNhaSanXuat.SelectedItem).Value; ;
            h.IDMaGG = ((CBBItemMaGiamGia)cbbMaGiamGia.SelectedItem).Value;
            h.Gia = Convert.ToInt32(txtGia.Text.ToString());
            h.HSD = DateTime.Parse(dateTimePickerHSD.Value.ToString());
            h.SoLuong = Convert.ToInt32(txtSoLuong.Text.ToString());
            h.trangThai = true;
            //MessageBox.Show(h.ID+" "+ h.TenMatHang+" "+ h.IDLoaiHang+
                //" "+h.IDNhaSX+" "+" "+h.IDMaGG+" "+h.Gia+" "+" "+h.HSD+" "+h.SoLuong+" "+h.trangThai+"");
            BLL_HangHoa.Instance.AddUpdateHang(h);
            d(0, 0, "");
            this.Close();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiHang.SelectedIndex != -1)
            {
                int id = ((CBBItemLoaiHang)cbbLoaiHang.SelectedItem).Value;
                List<string> nsx = BLL_HangHoa.Instance.getNSXByIDLoaiHang(id);
                if (cbbNhaSanXuat.Items.Count > 0)
                {
                    cbbNhaSanXuat.Items.Clear();
                }
                foreach (string s in nsx)
                {
                    foreach (CBBItemNhaSanXuat i in listNSX())
                    {
                        if (s == i.Text)
                        {
                            cbbNhaSanXuat.Items.Add(new CBBItemNhaSanXuat
                            {
                                Value = i.Value,
                                Text = i.Text,
                            });
                            break;
                        }
                    }
                }
            }
        }
    }
}
