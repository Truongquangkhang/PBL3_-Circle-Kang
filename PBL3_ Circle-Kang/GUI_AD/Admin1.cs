using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3__Circle_Kang.BLL_AD;
using PBL3__Circle_Kang.DTO_AD;

namespace PBL3__Circle_Kang.GUI_AD
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public List<CBBItemNhaSanXuat> listNSX () 
        {
            List<CBBItemNhaSanXuat> data = new List<CBBItemNhaSanXuat>();
            foreach(NhaSanXuat i in BLL_HangHoa.Instance.getAllNSX())
            {
                data.Add(new CBBItemNhaSanXuat
                {
                    Value = i.ID,
                    Text = i.TenNhaSX
                });
            }
            return data;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            panelHoaDon.Visible = false;
            panelDanhsachHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = true;
            panelLuong.Visible = false;
        }

        private void DSHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = false;
            panelDanhsachHH.Visible = true;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;

            if(cbbLoaiHangHoa_DSHH.Items.Count > 0)
            {
                cbbLoaiHangHoa_DSHH.Items.Clear();
            }
            cbbLoaiHangHoa_DSHH.Items.Add(new CBBItemLoaiHang
            {
                Value = 0,
                Text = "All"
            });
            foreach(LoaiHang i in BLL_HangHoa.Instance.setCBBLoaiHang())
            {
                cbbLoaiHangHoa_DSHH.Items.Add(new CBBItemLoaiHang
                {
                    Value = i.ID,
                    Text = i.TenLoaiHang
                });
            }
        }

        private void NhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = false;
            panelDanhsachHH.Visible = false;
            panelNhapHang.Visible = true;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = true;
            panelDanhsachHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void DSNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelHoaDon.Visible = false;
            panelDanhsachHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = true;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void DSKHtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = true;
            panelNewKhachhang.Visible = false;
            panelHoaDon.Visible = false;
            panelDanhsachHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void btnSearch_DSHH_Click(object sender, EventArgs e)
        {
            if(cbbLoaiHangHoa_DSHH.SelectedIndex != -1)
            {
                int id_LHH = ((CBBItemLoaiHang)cbbLoaiHangHoa_DSHH.SelectedItem).Value;
                int id_NSX = ((CBBItemNhaSanXuat)cbbNhaSanXuat_DSHH.SelectedItem).Value;
                dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.getAllHang(id_LHH,id_NSX, txtSearchDSHH_DSHH.Text);
            }
        }
        private void ShowDGVDSHH(int id_LHH,int id_NSX,string msg)
        {
            dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.getAllHang(id_LHH, id_NSX, msg);

        }

        private void cbbLoaiHangHoa_DSHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbLoaiHangHoa_DSHH.SelectedIndex != -1)
            {
                int id = ((CBBItemLoaiHang)cbbLoaiHangHoa_DSHH.SelectedItem).Value;
                List<string> TenNSX = BLL_HangHoa.Instance.getNSXByIDLoaiHang(id);
                if(cbbNhaSanXuat_DSHH.Items.Count > 0)
                {
                    cbbNhaSanXuat_DSHH.Items.Clear();
                }
                cbbNhaSanXuat_DSHH.Items.Add(new CBBItemNhaSanXuat
                {
                    Value = 0,
                    Text = "All"
                });
                foreach(string s in TenNSX)
                {
                    foreach(CBBItemNhaSanXuat i in listNSX())
                    {
                        if(s == i.Text)
                        {
                            cbbNhaSanXuat_DSHH.Items.Add(new CBBItemNhaSanXuat
                            {
                                Value = i.Value,
                                Text = i.Text,
                            });
                            break;
                        }
                    }
                }
                cbbNhaSanXuat_DSHH.SelectedIndex = 0;
            }
        }

        private void btnThem_DSHH_Click(object sender, EventArgs e)
        {
            GoodDetail f = new GoodDetail(0);
            f.d += new GoodDetail.MyDel(ShowDGVDSHH);
            f.Show();
            
        }

        private void btnCapNhat_DSHH_Click(object sender, EventArgs e)
        {
            if(dgvDSHH_DSHH.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDSHH_DSHH.SelectedRows[0].Cells[0].Value.ToString());
                GoodDetail f = new GoodDetail(id);
                f.d += new GoodDetail.MyDel(ShowDGVDSHH);
                f.Show();
                
            }
        }

        private void btnXoa_DSHH_Click(object sender, EventArgs e)
        {
            if(dgvDSHH_DSHH.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvDSHH_DSHH.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Hang h = BLL_HangHoa.Instance.getHangByID(id);
                    BLL_HangHoa.Instance.DeleteHang(h);
                }
                ShowDGVDSHH(0,0,"");
            }
        }

        private void btnSapXep_DSHH_Click(object sender, EventArgs e)
        {
            if(cbbSapxep_DSHH.SelectedIndex != -1)
            {
                string msg = cbbSapxep_DSHH.SelectedItem.ToString();
                dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.SortHangByYeuCau(msg);
            }
        }
    }
}
