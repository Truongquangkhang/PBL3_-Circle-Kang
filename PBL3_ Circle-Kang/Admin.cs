using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3__Circle_Kang
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = true;
            panelLuong.Visible = false;
        }     

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnHoaDon.Visible = true;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void DSHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnHoaDon.Visible = false;
            pnDSHH.Visible = true;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = true;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void ThongtinKHtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = true;
            panelNewKhachhang.Visible = false;
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }

        private void tạoKháchHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = true;
            panelNewKhachhang.Visible = true;
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }
        private void DSNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = true;
            panelTongQuan.Visible = false;
            panelLuong.Visible = false;
        }
        private void tổngQuantoolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = true;
            panelLuong.Visible = false;
        }

        private void panelDSNhanvien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTongQuan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLuong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            pnHoaDon.Visible = false;
            pnDSHH.Visible = false;
            panelNhapHang.Visible = false;
            panelDSNhanvien.Visible = false;
            panelTongQuan.Visible = false;
            panelLuong.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelNhapHang_Layout(object sender, LayoutEventArgs e)
        {
            
        }
    }
}
