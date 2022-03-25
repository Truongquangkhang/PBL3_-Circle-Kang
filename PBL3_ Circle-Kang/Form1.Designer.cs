namespace PBL3__Circle_Kang
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tổngQuantoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelhóaĐơn = new System.Windows.Forms.Panel();
            this.panelđặtHàng = new System.Windows.Forms.Panel();
            this.searchButton = new PBL3__Circle_Kang.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton1 = new PBL3__Circle_Kang.VBButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kháchTrảlabel = new System.Windows.Forms.Label();
            this.cầnTrảlabel = new System.Windows.Forms.Label();
            this.phụThulabel = new System.Windows.Forms.Label();
            this.giảmGiálabel = new System.Windows.Forms.Label();
            this.tổngTiềnlabel = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelnhậpHàng = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip1.SuspendLayout();
            this.panelđặtHàng.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngQuantoolStripMenuItem,
            this.hàngHóatoolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1409, 70);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tổngQuantoolStripMenuItem
            // 
            this.tổngQuantoolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tổngQuantoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tổngQuantoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tổngQuantoolStripMenuItem.Image")));
            this.tổngQuantoolStripMenuItem.Name = "tổngQuantoolStripMenuItem";
            this.tổngQuantoolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.tổngQuantoolStripMenuItem.Size = new System.Drawing.Size(208, 62);
            this.tổngQuantoolStripMenuItem.Text = "Tổng quan";
            // 
            // hàngHóatoolStripMenuItem
            // 
            this.hàngHóatoolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.hàngHóatoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem});
            this.hàngHóatoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hàngHóatoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hàngHóatoolStripMenuItem.Image")));
            this.hàngHóatoolStripMenuItem.Name = "hàngHóatoolStripMenuItem";
            this.hàngHóatoolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.hàngHóatoolStripMenuItem.Size = new System.Drawing.Size(1400, 42);
            this.hàngHóatoolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóatoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // thêmHàngToolStripMenuItem
            // 
            this.thêmHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmHàngToolStripMenuItem.Name = "thêmHàngToolStripMenuItem";
            this.thêmHàngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 1);
            this.thêmHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 39);
            this.thêmHàngToolStripMenuItem.Text = "Danh sách";
            this.thêmHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.nhậpHàngToolStripMenuItem.Text = "Thiết lập giá";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoĐơnHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem1,
            this.hủyĐơnToolStripMenuItem});
            this.giaoDịchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.giaoDịchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giaoDịchToolStripMenuItem.Image")));
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(1400, 42);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            // 
            // tạoĐơnHàngToolStripMenuItem
            // 
            this.tạoĐơnHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tạoĐơnHàngToolStripMenuItem.Name = "tạoĐơnHàngToolStripMenuItem";
            this.tạoĐơnHàngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tạoĐơnHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tạoĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(255, 38);
            this.tạoĐơnHàngToolStripMenuItem.Text = "Đặt hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.hóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(255, 38);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // nhậpHàngToolStripMenuItem1
            // 
            this.nhậpHàngToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpHàngToolStripMenuItem1.Name = "nhậpHàngToolStripMenuItem1";
            this.nhậpHàngToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.nhậpHàngToolStripMenuItem1.Size = new System.Drawing.Size(255, 38);
            this.nhậpHàngToolStripMenuItem1.Text = "Nhập hàng";
            // 
            // hủyĐơnToolStripMenuItem
            // 
            this.hủyĐơnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hủyĐơnToolStripMenuItem.Name = "hủyĐơnToolStripMenuItem";
            this.hủyĐơnToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.hủyĐơnToolStripMenuItem.Size = new System.Drawing.Size(255, 38);
            this.hủyĐơnToolStripMenuItem.Text = "Hủy đơn";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(1400, 42);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.càiĐặtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(1400, 42);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thôngTinToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(1400, 42);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "242656854_840547839953238_20704000910118392_n.jpg");
            // 
            // panelhóaĐơn
            // 
            this.panelhóaĐơn.Location = new System.Drawing.Point(0, 92);
            this.panelhóaĐơn.Name = "panelhóaĐơn";
            this.panelhóaĐơn.Size = new System.Drawing.Size(1100, 575);
            this.panelhóaĐơn.TabIndex = 1;
            // 
            // panelđặtHàng
            // 
            this.panelđặtHàng.Controls.Add(this.searchButton);
            this.panelđặtHàng.Controls.Add(this.panel1);
            this.panelđặtHàng.Controls.Add(this.textBox1);
            this.panelđặtHàng.Location = new System.Drawing.Point(12, 83);
            this.panelđặtHàng.Name = "panelđặtHàng";
            this.panelđặtHàng.Size = new System.Drawing.Size(1376, 979);
            this.panelđặtHàng.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchButton.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 10;
            this.searchButton.BorderSize = 0;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(342, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(157, 47);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Tìm";
            this.searchButton.TextColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.kháchTrảlabel);
            this.panel1.Controls.Add(this.cầnTrảlabel);
            this.panel1.Controls.Add(this.phụThulabel);
            this.panel1.Controls.Add(this.giảmGiálabel);
            this.panel1.Controls.Add(this.tổngTiềnlabel);
            this.panel1.Controls.Add(this.cashierLabel);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Location = new System.Drawing.Point(657, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 975);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.vbButton1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(214, 632);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(189, 104);
            this.vbButton1.TabIndex = 3;
            this.vbButton1.Text = "Thanh toán";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(214, 492);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(189, 22);
            this.textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 413);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 22);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 2;
            // 
            // kháchTrảlabel
            // 
            this.kháchTrảlabel.AutoSize = true;
            this.kháchTrảlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kháchTrảlabel.Location = new System.Drawing.Point(55, 488);
            this.kháchTrảlabel.Name = "kháchTrảlabel";
            this.kháchTrảlabel.Size = new System.Drawing.Size(123, 25);
            this.kháchTrảlabel.TabIndex = 1;
            this.kháchTrảlabel.Text = "Khách đã trả";
            // 
            // cầnTrảlabel
            // 
            this.cầnTrảlabel.AutoSize = true;
            this.cầnTrảlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cầnTrảlabel.Location = new System.Drawing.Point(55, 409);
            this.cầnTrảlabel.Name = "cầnTrảlabel";
            this.cầnTrảlabel.Size = new System.Drawing.Size(133, 25);
            this.cầnTrảlabel.TabIndex = 1;
            this.cầnTrảlabel.Text = "Khách cần trả";
            // 
            // phụThulabel
            // 
            this.phụThulabel.AutoSize = true;
            this.phụThulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phụThulabel.Location = new System.Drawing.Point(55, 331);
            this.phụThulabel.Name = "phụThulabel";
            this.phụThulabel.Size = new System.Drawing.Size(79, 25);
            this.phụThulabel.TabIndex = 1;
            this.phụThulabel.Text = "Phụ thu";
            // 
            // giảmGiálabel
            // 
            this.giảmGiálabel.AutoSize = true;
            this.giảmGiálabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giảmGiálabel.Location = new System.Drawing.Point(55, 246);
            this.giảmGiálabel.Name = "giảmGiálabel";
            this.giảmGiálabel.Size = new System.Drawing.Size(89, 25);
            this.giảmGiálabel.TabIndex = 1;
            this.giảmGiálabel.Text = "Giảm giá";
            // 
            // tổngTiềnlabel
            // 
            this.tổngTiềnlabel.AutoSize = true;
            this.tổngTiềnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tổngTiềnlabel.Location = new System.Drawing.Point(51, 159);
            this.tổngTiềnlabel.Name = "tổngTiềnlabel";
            this.tổngTiềnlabel.Size = new System.Drawing.Size(94, 25);
            this.tổngTiềnlabel.TabIndex = 1;
            this.tổngTiềnlabel.Text = "Tổng tiền";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLabel.Location = new System.Drawing.Point(51, 75);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(100, 25);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Nhân viên";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(214, 76);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(189, 24);
            this.comboBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panelnhậpHàng
            // 
            this.panelnhậpHàng.Location = new System.Drawing.Point(0, 0);
            this.panelnhậpHàng.Name = "panelnhậpHàng";
            this.panelnhậpHàng.Size = new System.Drawing.Size(1100, 530);
            this.panelnhậpHàng.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Admin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 1046);
            this.Controls.Add(this.panelđặtHàng);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelnhậpHàng);
            this.Controls.Add(this.panelhóaĐơn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelđặtHàng.ResumeLayout(false);
            this.panelđặtHàng.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tổngQuantoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Panel panelhóaĐơn;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hủyĐơnToolStripMenuItem;
        private System.Windows.Forms.Panel panelđặtHàng;
        private System.Windows.Forms.Panel panelnhậpHàng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tổngTiềnlabel;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label kháchTrảlabel;
        private System.Windows.Forms.Label cầnTrảlabel;
        private System.Windows.Forms.Label phụThulabel;
        private System.Windows.Forms.Label giảmGiálabel;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private VBButton searchButton;
        private VBButton vbButton1;
    }
}