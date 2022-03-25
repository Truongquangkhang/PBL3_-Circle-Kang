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

        private void thêmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl TC = new TabControl();
            //TC.Dock = DockStyle.Fill;
            UserControl UC = new UserControl();
            TabPage tp = new TabPage();
            tp.Controls.Add(UC);
            tp.Text = "hung";
            TC.TabPages.Add(tp);
            //panel1.Visible = true;
            panelhóaĐơn.Controls.Add(TC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
