using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3__Circle_Kang.DTO;
using PBL3__Circle_Kang.BLL;

namespace PBL3__Circle_Kang.GUI
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void vbbtnDangNhap_Click(object sender, EventArgs e)
        {
            Account acc = BLL_Login.Instance.GetAccountLogin(txtTenDangNhap_Login.Text, txtMatKhau_Login.Text);
            if (acc.Loai == 1)
            {
                GUI_AD.Admin f = new GUI_AD.Admin();
                f.ShowDialog();
            }
            else
            {
                GUI_ST.Cashier f = new GUI_ST.Cashier();
                f.ShowDialog();
            }
            txtTenDangNhap_Login.Text = "";
            txtMatKhau_Login.Text = "";
        }
    }
}
