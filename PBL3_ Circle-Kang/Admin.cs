﻿using System;
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
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
        }     

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelhóaĐơn.Visible = true;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
        }

        private void DSHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = true;
            panelNhapHang.Visible = false;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = true;
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
        }

        private void ThongtinKHtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = true;
            panelNewKhachhang.Visible = false;
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = false;
        }

        private void tạoKháchHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = true;
            panelNewKhachhang.Visible = true;
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = false;
        }

        private void tổngQuantoolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIThongtinKH.Visible = false;
            panelNewKhachhang.Visible = false;
            panelhóaĐơn.Visible = false;
            panelDanhsáchHH.Visible = false;
            panelNhapHang.Visible = false;
        }
    }
}