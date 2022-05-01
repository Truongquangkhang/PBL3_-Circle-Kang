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
                int id = ((CBBItemLoaiHang)cbbLoaiHangHoa_DSHH.SelectedItem).Value;
                dgvDSHH_DSHH.DataSource = BLL_HangHoa.Instance.getAllHang(id, txtSearchDSHH_DSHH.Text);
            }
        }
    }
}
