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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelđặtHàng.Visible = true;
            panelNewKhachhang.Visible = false;
            panelBaocao.Visible = false;
        }

        private void báoCáoKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelđặtHàng.Visible = false;
            panelNewKhachhang.Visible = false;
            panelBaocao.Visible = true;
        }

        private void tạoKháchHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelđặtHàng.Visible = false;
            panelNewKhachhang.Visible = true;
            panelBaocao.Visible = false;
        }
    }
}
