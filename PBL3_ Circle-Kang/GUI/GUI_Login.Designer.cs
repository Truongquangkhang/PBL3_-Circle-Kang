namespace PBL3__Circle_Kang.GUI
{
    partial class GUI_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vbbtnDangNhap = new PBL3__Circle_Kang.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau_Login = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap_Login = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vbbtnDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbNhoMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMatKhau_Login);
            this.panel1.Controls.Add(this.txtTenDangNhap_Login);
            this.panel1.Location = new System.Drawing.Point(604, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 620);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(279, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // vbbtnDangNhap
            // 
            this.vbbtnDangNhap.BackColor = System.Drawing.Color.SeaGreen;
            this.vbbtnDangNhap.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.vbbtnDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbbtnDangNhap.BorderRadius = 40;
            this.vbbtnDangNhap.BorderSize = 0;
            this.vbbtnDangNhap.FlatAppearance.BorderSize = 0;
            this.vbbtnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbbtnDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbbtnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vbbtnDangNhap.Location = new System.Drawing.Point(259, 429);
            this.vbbtnDangNhap.Name = "vbbtnDangNhap";
            this.vbbtnDangNhap.Size = new System.Drawing.Size(302, 105);
            this.vbbtnDangNhap.TabIndex = 8;
            this.vbbtnDangNhap.Text = "Đăng nhập";
            this.vbbtnDangNhap.TextColor = System.Drawing.SystemColors.ButtonFace;
            this.vbbtnDangNhap.UseVisualStyleBackColor = false;
            this.vbbtnDangNhap.Click += new System.EventHandler(this.vbbtnDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(106, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // cbNhoMatKhau
            // 
            this.cbNhoMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.cbNhoMatKhau.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhoMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNhoMatKhau.Location = new System.Drawing.Point(113, 333);
            this.cbNhoMatKhau.Name = "cbNhoMatKhau";
            this.cbNhoMatKhau.Size = new System.Drawing.Size(282, 37);
            this.cbNhoMatKhau.TabIndex = 5;
            this.cbNhoMatKhau.Text = "Nhớ mật khẩu";
            this.cbNhoMatKhau.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(106, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatKhau_Login
            // 
            this.txtMatKhau_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau_Login.Location = new System.Drawing.Point(395, 262);
            this.txtMatKhau_Login.MaxLength = 20;
            this.txtMatKhau_Login.Multiline = true;
            this.txtMatKhau_Login.Name = "txtMatKhau_Login";
            this.txtMatKhau_Login.PasswordChar = '*';
            this.txtMatKhau_Login.Size = new System.Drawing.Size(344, 35);
            this.txtMatKhau_Login.TabIndex = 4;
            // 
            // txtTenDangNhap_Login
            // 
            this.txtTenDangNhap_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenDangNhap_Login.Location = new System.Drawing.Point(395, 181);
            this.txtTenDangNhap_Login.Multiline = true;
            this.txtTenDangNhap_Login.Name = "txtTenDangNhap_Login";
            this.txtTenDangNhap_Login.Size = new System.Drawing.Size(344, 35);
            this.txtTenDangNhap_Login.TabIndex = 3;
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1924, 1032);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Login";
            this.Text = "GUI_Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private VBButton vbbtnDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNhoMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau_Login;
        private System.Windows.Forms.TextBox txtTenDangNhap_Login;
    }
}