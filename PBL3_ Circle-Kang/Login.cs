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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        public Boolean Check(string s)
        {
            if (s == "")
            {
                return false;
            }
            return true;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu của bạn", "Warning", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
            else if(textBox1.Text == "admin" || textBox2.Text == "123")
            {
                //Form f1 = new Form();
                //this.Hide();
                //f1.Height = f1.Width = 500;
                //f1.StartPosition = FormStartPosition.CenterScreen;
                //f1.Text = "Nam Anh La Nhất";

                //ListBox lst = new ListBox();
                //lst.Dock = DockStyle.Fill;
                //f1.Controls.Add(lst);
                //Label lb = new Label();
                //lb.Text = "lùi thịnh ngựa mà ngáo";
                //lb.AutoSize = !true;
                //lb.Font = new Font(this.Font.FontFamily, 18);
                //lst.Controls.Add(lb);
                //f1.Show();
                //this.Show();
                this.Hide();
                Admin am = new Admin();
                am.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form Admin = new Form();
            this.Hide();
            Admin.Height = 555;
            Admin.Width = 785;
            Admin.ShowDialog();
            Admin.StartPosition = FormStartPosition.CenterScreen;
            
            Label Admin_user = new Label();
            Admin_user.Text = "LOGIN";
            
        }

        
    }
}
