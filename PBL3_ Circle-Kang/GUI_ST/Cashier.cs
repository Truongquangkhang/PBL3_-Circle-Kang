using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3__Circle_Kang.GUI_ST
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void DatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDatHang.Visible = true;
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = false;
        }

        private void BaoCaoKhoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDatHang.Visible = false;
            panelBaocao.Visible = true;
            panelDSKhachhang.Visible = false;
        }

        private void DanhSachKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDatHang.Visible = false;
            panelBaocao.Visible = false;
            panelDSKhachhang.Visible = true;
        }
    }
}
