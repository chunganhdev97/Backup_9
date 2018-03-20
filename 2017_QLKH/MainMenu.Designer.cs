namespace _2017_QLKH
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lbx_title = new System.Windows.Forms.Label();
            this.btn_nhanv = new System.Windows.Forms.Button();
            this.btn_xuatnhap = new System.Windows.Forms.Button();
            this.btn_hethong = new System.Windows.Forms.Button();
            this.btn_luong = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_danhmuc = new System.Windows.Forms.Button();
            this.btn_nhacc = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.userNamemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pc_User = new System.Windows.Forms.PictureBox();
            this.btn_khohang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_title
            // 
            this.lbx_title.AutoSize = true;
            this.lbx_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_title.Location = new System.Drawing.Point(165, 41);
            this.lbx_title.Name = "lbx_title";
            this.lbx_title.Size = new System.Drawing.Size(622, 31);
            this.lbx_title.TabIndex = 0;
            this.lbx_title.Text = "Quản Lý Kho Hàng (Nhà Phân Phối Sản Phẩm)";
            // 
            // btn_nhanv
            // 
            this.btn_nhanv.BackColor = System.Drawing.Color.Green;
            this.btn_nhanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanv.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanv.Image")));
            this.btn_nhanv.Location = new System.Drawing.Point(304, 110);
            this.btn_nhanv.Name = "btn_nhanv";
            this.btn_nhanv.Size = new System.Drawing.Size(167, 115);
            this.btn_nhanv.TabIndex = 1;
            this.btn_nhanv.Text = "Nhân Viên";
            this.btn_nhanv.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_nhanv.UseVisualStyleBackColor = false;
            this.btn_nhanv.Click += new System.EventHandler(this.btn_nhanv_Click);
            // 
            // btn_xuatnhap
            // 
            this.btn_xuatnhap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_xuatnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatnhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_xuatnhap.Image")));
            this.btn_xuatnhap.Location = new System.Drawing.Point(304, 244);
            this.btn_xuatnhap.Name = "btn_xuatnhap";
            this.btn_xuatnhap.Size = new System.Drawing.Size(167, 115);
            this.btn_xuatnhap.TabIndex = 2;
            this.btn_xuatnhap.Text = "Xuất - Nhập";
            this.btn_xuatnhap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_xuatnhap.UseVisualStyleBackColor = false;
            this.btn_xuatnhap.Click += new System.EventHandler(this.btn_xuatnhap_Click);
            // 
            // btn_hethong
            // 
            this.btn_hethong.BackColor = System.Drawing.Color.Crimson;
            this.btn_hethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hethong.Image = ((System.Drawing.Image)(resources.GetObject("btn_hethong.Image")));
            this.btn_hethong.Location = new System.Drawing.Point(120, 110);
            this.btn_hethong.Name = "btn_hethong";
            this.btn_hethong.Size = new System.Drawing.Size(167, 115);
            this.btn_hethong.TabIndex = 3;
            this.btn_hethong.Text = "Hệ Thống";
            this.btn_hethong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_hethong.UseVisualStyleBackColor = false;
            this.btn_hethong.Click += new System.EventHandler(this.btn_hethong_Click);
            // 
            // btn_luong
            // 
            this.btn_luong.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luong.Image = ((System.Drawing.Image)(resources.GetObject("btn_luong.Image")));
            this.btn_luong.Location = new System.Drawing.Point(120, 244);
            this.btn_luong.Name = "btn_luong";
            this.btn_luong.Size = new System.Drawing.Size(167, 115);
            this.btn_luong.TabIndex = 5;
            this.btn_luong.Text = "Bộ Phận";
            this.btn_luong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_luong.UseVisualStyleBackColor = false;
            this.btn_luong.Click += new System.EventHandler(this.btn_luong_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.Image")));
            this.btn_khachhang.Location = new System.Drawing.Point(538, 110);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(167, 115);
            this.btn_khachhang.TabIndex = 6;
            this.btn_khachhang.Text = "Khách Hàng";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_khachhang.UseVisualStyleBackColor = false;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_danhmuc
            // 
            this.btn_danhmuc.BackColor = System.Drawing.Color.Teal;
            this.btn_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhmuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhmuc.Image")));
            this.btn_danhmuc.Location = new System.Drawing.Point(120, 374);
            this.btn_danhmuc.Name = "btn_danhmuc";
            this.btn_danhmuc.Size = new System.Drawing.Size(351, 115);
            this.btn_danhmuc.TabIndex = 7;
            this.btn_danhmuc.Text = "Danh Mục Sản Phẩm";
            this.btn_danhmuc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_danhmuc.UseVisualStyleBackColor = false;
            this.btn_danhmuc.Click += new System.EventHandler(this.btn_danhmuc_Click);
            // 
            // btn_nhacc
            // 
            this.btn_nhacc.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_nhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhacc.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhacc.Image")));
            this.btn_nhacc.Location = new System.Drawing.Point(723, 110);
            this.btn_nhacc.Name = "btn_nhacc";
            this.btn_nhacc.Size = new System.Drawing.Size(167, 249);
            this.btn_nhacc.TabIndex = 8;
            this.btn_nhacc.Text = "Nhà Cung Cấp";
            this.btn_nhacc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_nhacc.UseVisualStyleBackColor = false;
            this.btn_nhacc.Click += new System.EventHandler(this.btn_nhacc_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.BackColor = System.Drawing.Color.Green;
            this.btn_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocao.Image = ((System.Drawing.Image)(resources.GetObject("btn_baocao.Image")));
            this.btn_baocao.Location = new System.Drawing.Point(538, 374);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(352, 115);
            this.btn_baocao.TabIndex = 9;
            this.btn_baocao.Text = "Báo Cáo";
            this.btn_baocao.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_baocao.UseVisualStyleBackColor = false;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuUser);
            this.panel1.Location = new System.Drawing.Point(862, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 38);
            this.panel1.TabIndex = 10;
            // 
            // menuUser
            // 
            this.menuUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNamemenu,
            this.cToolStripMenuItem});
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(144, 24);
            this.menuUser.TabIndex = 1;
            this.menuUser.Text = "menuStrip1";
            // 
            // userNamemenu
            // 
            this.userNamemenu.Name = "userNamemenu";
            this.userNamemenu.Size = new System.Drawing.Size(60, 20);
            this.userNamemenu.Text = "ADMIN";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.cToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cToolStripMenuItem.Image")));
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ngườiDùngToolStripMenuItem.Image")));
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ngườiDùngToolStripMenuItem.Text = "Người Dùng";
            this.ngườiDùngToolStripMenuItem.Click += new System.EventHandler(this.ngườiDùngToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pc_User
            // 
            this.pc_User.Image = ((System.Drawing.Image)(resources.GetObject("pc_User.Image")));
            this.pc_User.Location = new System.Drawing.Point(822, 23);
            this.pc_User.Name = "pc_User";
            this.pc_User.Size = new System.Drawing.Size(34, 38);
            this.pc_User.TabIndex = 0;
            this.pc_User.TabStop = false;
            // 
            // btn_khohang
            // 
            this.btn_khohang.BackColor = System.Drawing.Color.Crimson;
            this.btn_khohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khohang.Location = new System.Drawing.Point(538, 244);
            this.btn_khohang.Name = "btn_khohang";
            this.btn_khohang.Size = new System.Drawing.Size(167, 115);
            this.btn_khohang.TabIndex = 11;
            this.btn_khohang.Text = "Kho Hàng";
            this.btn_khohang.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_khohang.UseVisualStyleBackColor = false;
            this.btn_khohang.Click += new System.EventHandler(this.btn_khohang_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 526);
            this.Controls.Add(this.btn_khohang);
            this.Controls.Add(this.pc_User);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_baocao);
            this.Controls.Add(this.btn_nhacc);
            this.Controls.Add(this.btn_danhmuc);
            this.Controls.Add(this.btn_khachhang);
            this.Controls.Add(this.btn_luong);
            this.Controls.Add(this.btn_hethong);
            this.Controls.Add(this.btn_xuatnhap);
            this.Controls.Add(this.btn_nhanv);
            this.Controls.Add(this.lbx_title);
            this.MainMenuStrip = this.menuUser;
            this.Name = "MainMenu";
            this.Text = "Lương";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbx_title;
        private System.Windows.Forms.Button btn_nhanv;
        private System.Windows.Forms.Button btn_xuatnhap;
        private System.Windows.Forms.Button btn_hethong;
        private System.Windows.Forms.Button btn_luong;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_danhmuc;
        private System.Windows.Forms.Button btn_nhacc;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem userNamemenu;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pc_User;
        private System.Windows.Forms.Button btn_khohang;
    }
}