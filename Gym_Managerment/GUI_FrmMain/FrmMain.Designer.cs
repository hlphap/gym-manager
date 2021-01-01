namespace Gym_Managerment.GUI_FrmMain
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pn_SubHT = new System.Windows.Forms.Panel();
            this.bt_QuanLy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_ThongTinTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_HT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_SubBC = new System.Windows.Forms.Panel();
            this.bt_GoiTap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_BCDoanhThu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_BC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_BanHangHoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_SubHV = new System.Windows.Forms.Panel();
            this.bt_DangKyTuDo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_DangKyHLV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_DangKyGoiTap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_DangKyMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_HV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_SubDS = new System.Windows.Forms.Panel();
            this.bt_HLV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_HoiVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_DS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_CC = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.KeoTha = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pn_SubHT.SuspendLayout();
            this.pn_SubBC.SuspendLayout();
            this.pn_SubHV.SuspendLayout();
            this.pn_SubDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pn_CC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 831);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 611);
            this.panel5.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.SidePanel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 611);
            this.panel7.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(1, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 70);
            this.SidePanel.TabIndex = 3;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.pn_SubHT);
            this.panel6.Controls.Add(this.bt_HT);
            this.panel6.Controls.Add(this.pn_SubBC);
            this.panel6.Controls.Add(this.bt_BC);
            this.panel6.Controls.Add(this.bt_BanHangHoa);
            this.panel6.Controls.Add(this.pn_SubHV);
            this.panel6.Controls.Add(this.bt_HV);
            this.panel6.Controls.Add(this.pn_SubDS);
            this.panel6.Controls.Add(this.bt_DS);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(12, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 611);
            this.panel6.TabIndex = 0;
            // 
            // pn_SubHT
            // 
            this.pn_SubHT.Controls.Add(this.bt_QuanLy);
            this.pn_SubHT.Controls.Add(this.bt_ThongTinTaiKhoan);
            this.pn_SubHT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_SubHT.Location = new System.Drawing.Point(0, 698);
            this.pn_SubHT.Name = "pn_SubHT";
            this.pn_SubHT.Size = new System.Drawing.Size(237, 90);
            this.pn_SubHT.TabIndex = 15;
            // 
            // bt_QuanLy
            // 
            this.bt_QuanLy.Active = false;
            this.bt_QuanLy.Activecolor = System.Drawing.Color.Transparent;
            this.bt_QuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_QuanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_QuanLy.BorderRadius = 0;
            this.bt_QuanLy.ButtonText = "                 Quản lý";
            this.bt_QuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_QuanLy.DisabledColor = System.Drawing.Color.Gray;
            this.bt_QuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_QuanLy.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_QuanLy.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_QuanLy.Iconimage = null;
            this.bt_QuanLy.Iconimage_right = null;
            this.bt_QuanLy.Iconimage_right_Selected = null;
            this.bt_QuanLy.Iconimage_Selected = null;
            this.bt_QuanLy.IconMarginLeft = 0;
            this.bt_QuanLy.IconMarginRight = 0;
            this.bt_QuanLy.IconRightVisible = true;
            this.bt_QuanLy.IconRightZoom = 0D;
            this.bt_QuanLy.IconVisible = true;
            this.bt_QuanLy.IconZoom = 35D;
            this.bt_QuanLy.IsTab = false;
            this.bt_QuanLy.Location = new System.Drawing.Point(0, 41);
            this.bt_QuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_QuanLy.Name = "bt_QuanLy";
            this.bt_QuanLy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_QuanLy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_QuanLy.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_QuanLy.selected = false;
            this.bt_QuanLy.Size = new System.Drawing.Size(237, 41);
            this.bt_QuanLy.TabIndex = 8;
            this.bt_QuanLy.Text = "                 Quản lý";
            this.bt_QuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_QuanLy.Textcolor = System.Drawing.Color.White;
            this.bt_QuanLy.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_QuanLy.Click += new System.EventHandler(this.bt_QuanLy_Click);
            // 
            // bt_ThongTinTaiKhoan
            // 
            this.bt_ThongTinTaiKhoan.Active = false;
            this.bt_ThongTinTaiKhoan.Activecolor = System.Drawing.Color.Transparent;
            this.bt_ThongTinTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_ThongTinTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ThongTinTaiKhoan.BorderRadius = 0;
            this.bt_ThongTinTaiKhoan.ButtonText = "                 Tài khoản";
            this.bt_ThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ThongTinTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.bt_ThongTinTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongTinTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_ThongTinTaiKhoan.Iconimage = null;
            this.bt_ThongTinTaiKhoan.Iconimage_right = null;
            this.bt_ThongTinTaiKhoan.Iconimage_right_Selected = null;
            this.bt_ThongTinTaiKhoan.Iconimage_Selected = null;
            this.bt_ThongTinTaiKhoan.IconMarginLeft = 0;
            this.bt_ThongTinTaiKhoan.IconMarginRight = 0;
            this.bt_ThongTinTaiKhoan.IconRightVisible = true;
            this.bt_ThongTinTaiKhoan.IconRightZoom = 0D;
            this.bt_ThongTinTaiKhoan.IconVisible = true;
            this.bt_ThongTinTaiKhoan.IconZoom = 35D;
            this.bt_ThongTinTaiKhoan.IsTab = false;
            this.bt_ThongTinTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.bt_ThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ThongTinTaiKhoan.Name = "bt_ThongTinTaiKhoan";
            this.bt_ThongTinTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_ThongTinTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_ThongTinTaiKhoan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_ThongTinTaiKhoan.selected = false;
            this.bt_ThongTinTaiKhoan.Size = new System.Drawing.Size(237, 41);
            this.bt_ThongTinTaiKhoan.TabIndex = 7;
            this.bt_ThongTinTaiKhoan.Text = "                 Tài khoản";
            this.bt_ThongTinTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ThongTinTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.bt_ThongTinTaiKhoan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongTinTaiKhoan.Click += new System.EventHandler(this.bt_ThongTinTaiKhoan_Click);
            // 
            // bt_HT
            // 
            this.bt_HT.Active = false;
            this.bt_HT.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HT.BorderRadius = 0;
            this.bt_HT.ButtonText = "      Hệ thống";
            this.bt_HT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HT.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HT.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HT.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HT.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HT.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_HT.Iconimage")));
            this.bt_HT.Iconimage_right = null;
            this.bt_HT.Iconimage_right_Selected = null;
            this.bt_HT.Iconimage_Selected = null;
            this.bt_HT.IconMarginLeft = 0;
            this.bt_HT.IconMarginRight = 0;
            this.bt_HT.IconRightVisible = true;
            this.bt_HT.IconRightZoom = 0D;
            this.bt_HT.IconVisible = true;
            this.bt_HT.IconZoom = 35D;
            this.bt_HT.IsTab = false;
            this.bt_HT.Location = new System.Drawing.Point(0, 628);
            this.bt_HT.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HT.Name = "bt_HT";
            this.bt_HT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HT.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HT.selected = false;
            this.bt_HT.Size = new System.Drawing.Size(237, 70);
            this.bt_HT.TabIndex = 14;
            this.bt_HT.Text = "      Hệ thống";
            this.bt_HT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HT.Textcolor = System.Drawing.Color.White;
            this.bt_HT.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HT.Click += new System.EventHandler(this.bt_HT_Click);
            // 
            // pn_SubBC
            // 
            this.pn_SubBC.Controls.Add(this.bt_GoiTap);
            this.pn_SubBC.Controls.Add(this.bt_BCDoanhThu);
            this.pn_SubBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_SubBC.Location = new System.Drawing.Point(0, 538);
            this.pn_SubBC.Name = "pn_SubBC";
            this.pn_SubBC.Size = new System.Drawing.Size(237, 90);
            this.pn_SubBC.TabIndex = 13;
            // 
            // bt_GoiTap
            // 
            this.bt_GoiTap.Active = false;
            this.bt_GoiTap.Activecolor = System.Drawing.Color.Transparent;
            this.bt_GoiTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoiTap.BorderRadius = 0;
            this.bt_GoiTap.ButtonText = "                 Gói tập";
            this.bt_GoiTap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GoiTap.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_GoiTap.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoiTap.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_GoiTap.Iconimage = null;
            this.bt_GoiTap.Iconimage_right = null;
            this.bt_GoiTap.Iconimage_right_Selected = null;
            this.bt_GoiTap.Iconimage_Selected = null;
            this.bt_GoiTap.IconMarginLeft = 0;
            this.bt_GoiTap.IconMarginRight = 0;
            this.bt_GoiTap.IconRightVisible = true;
            this.bt_GoiTap.IconRightZoom = 0D;
            this.bt_GoiTap.IconVisible = true;
            this.bt_GoiTap.IconZoom = 35D;
            this.bt_GoiTap.IsTab = false;
            this.bt_GoiTap.Location = new System.Drawing.Point(0, 41);
            this.bt_GoiTap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_GoiTap.Name = "bt_GoiTap";
            this.bt_GoiTap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_GoiTap.selected = false;
            this.bt_GoiTap.Size = new System.Drawing.Size(237, 41);
            this.bt_GoiTap.TabIndex = 8;
            this.bt_GoiTap.Text = "                 Gói tập";
            this.bt_GoiTap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GoiTap.Textcolor = System.Drawing.Color.White;
            this.bt_GoiTap.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoiTap.Click += new System.EventHandler(this.bt_GoiTap_Click);
            // 
            // bt_BCDoanhThu
            // 
            this.bt_BCDoanhThu.Active = false;
            this.bt_BCDoanhThu.Activecolor = System.Drawing.Color.Transparent;
            this.bt_BCDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BCDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_BCDoanhThu.BorderRadius = 0;
            this.bt_BCDoanhThu.ButtonText = "                 Doanh thu";
            this.bt_BCDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_BCDoanhThu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BCDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_BCDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BCDoanhThu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_BCDoanhThu.Iconimage = null;
            this.bt_BCDoanhThu.Iconimage_right = null;
            this.bt_BCDoanhThu.Iconimage_right_Selected = null;
            this.bt_BCDoanhThu.Iconimage_Selected = null;
            this.bt_BCDoanhThu.IconMarginLeft = 0;
            this.bt_BCDoanhThu.IconMarginRight = 0;
            this.bt_BCDoanhThu.IconRightVisible = true;
            this.bt_BCDoanhThu.IconRightZoom = 0D;
            this.bt_BCDoanhThu.IconVisible = true;
            this.bt_BCDoanhThu.IconZoom = 35D;
            this.bt_BCDoanhThu.IsTab = false;
            this.bt_BCDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.bt_BCDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_BCDoanhThu.Name = "bt_BCDoanhThu";
            this.bt_BCDoanhThu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BCDoanhThu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BCDoanhThu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_BCDoanhThu.selected = false;
            this.bt_BCDoanhThu.Size = new System.Drawing.Size(237, 41);
            this.bt_BCDoanhThu.TabIndex = 7;
            this.bt_BCDoanhThu.Text = "                 Doanh thu";
            this.bt_BCDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_BCDoanhThu.Textcolor = System.Drawing.Color.White;
            this.bt_BCDoanhThu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BCDoanhThu.Click += new System.EventHandler(this.bt_BCDoanhThu_Click);
            // 
            // bt_BC
            // 
            this.bt_BC.Active = false;
            this.bt_BC.Activecolor = System.Drawing.Color.Transparent;
            this.bt_BC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_BC.BorderRadius = 0;
            this.bt_BC.ButtonText = "      Báo cáo";
            this.bt_BC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_BC.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BC.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_BC.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BC.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_BC.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_BC.Iconimage")));
            this.bt_BC.Iconimage_right = null;
            this.bt_BC.Iconimage_right_Selected = null;
            this.bt_BC.Iconimage_Selected = null;
            this.bt_BC.IconMarginLeft = 0;
            this.bt_BC.IconMarginRight = 0;
            this.bt_BC.IconRightVisible = true;
            this.bt_BC.IconRightZoom = 0D;
            this.bt_BC.IconVisible = true;
            this.bt_BC.IconZoom = 35D;
            this.bt_BC.IsTab = false;
            this.bt_BC.Location = new System.Drawing.Point(0, 468);
            this.bt_BC.Margin = new System.Windows.Forms.Padding(4);
            this.bt_BC.Name = "bt_BC";
            this.bt_BC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BC.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_BC.selected = false;
            this.bt_BC.Size = new System.Drawing.Size(237, 70);
            this.bt_BC.TabIndex = 12;
            this.bt_BC.Text = "      Báo cáo";
            this.bt_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_BC.Textcolor = System.Drawing.Color.White;
            this.bt_BC.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BC.Click += new System.EventHandler(this.bt_BC_Click);
            // 
            // bt_BanHangHoa
            // 
            this.bt_BanHangHoa.Active = false;
            this.bt_BanHangHoa.Activecolor = System.Drawing.Color.Transparent;
            this.bt_BanHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BanHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_BanHangHoa.BorderRadius = 0;
            this.bt_BanHangHoa.ButtonText = "      Bán hàng";
            this.bt_BanHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_BanHangHoa.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BanHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_BanHangHoa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BanHangHoa.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_BanHangHoa.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_BanHangHoa.Iconimage")));
            this.bt_BanHangHoa.Iconimage_right = null;
            this.bt_BanHangHoa.Iconimage_right_Selected = null;
            this.bt_BanHangHoa.Iconimage_Selected = null;
            this.bt_BanHangHoa.IconMarginLeft = 0;
            this.bt_BanHangHoa.IconMarginRight = 0;
            this.bt_BanHangHoa.IconRightVisible = true;
            this.bt_BanHangHoa.IconRightZoom = 0D;
            this.bt_BanHangHoa.IconVisible = true;
            this.bt_BanHangHoa.IconZoom = 35D;
            this.bt_BanHangHoa.IsTab = false;
            this.bt_BanHangHoa.Location = new System.Drawing.Point(0, 398);
            this.bt_BanHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_BanHangHoa.Name = "bt_BanHangHoa";
            this.bt_BanHangHoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BanHangHoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_BanHangHoa.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_BanHangHoa.selected = false;
            this.bt_BanHangHoa.Size = new System.Drawing.Size(237, 70);
            this.bt_BanHangHoa.TabIndex = 10;
            this.bt_BanHangHoa.Text = "      Bán hàng";
            this.bt_BanHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_BanHangHoa.Textcolor = System.Drawing.Color.White;
            this.bt_BanHangHoa.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BanHangHoa.Click += new System.EventHandler(this.bt_DV_Click);
            // 
            // pn_SubHV
            // 
            this.pn_SubHV.Controls.Add(this.bt_DangKyTuDo);
            this.pn_SubHV.Controls.Add(this.bt_DangKyHLV);
            this.pn_SubHV.Controls.Add(this.bt_DangKyGoiTap);
            this.pn_SubHV.Controls.Add(this.bt_DangKyMoi);
            this.pn_SubHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_SubHV.Location = new System.Drawing.Point(0, 227);
            this.pn_SubHV.Name = "pn_SubHV";
            this.pn_SubHV.Size = new System.Drawing.Size(237, 171);
            this.pn_SubHV.TabIndex = 9;
            // 
            // bt_DangKyTuDo
            // 
            this.bt_DangKyTuDo.Active = false;
            this.bt_DangKyTuDo.Activecolor = System.Drawing.Color.Transparent;
            this.bt_DangKyTuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyTuDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_DangKyTuDo.BorderRadius = 0;
            this.bt_DangKyTuDo.ButtonText = "                 Đăng ký mượn đồ";
            this.bt_DangKyTuDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DangKyTuDo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyTuDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DangKyTuDo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyTuDo.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_DangKyTuDo.Iconimage = null;
            this.bt_DangKyTuDo.Iconimage_right = null;
            this.bt_DangKyTuDo.Iconimage_right_Selected = null;
            this.bt_DangKyTuDo.Iconimage_Selected = null;
            this.bt_DangKyTuDo.IconMarginLeft = 0;
            this.bt_DangKyTuDo.IconMarginRight = 0;
            this.bt_DangKyTuDo.IconRightVisible = true;
            this.bt_DangKyTuDo.IconRightZoom = 0D;
            this.bt_DangKyTuDo.IconVisible = true;
            this.bt_DangKyTuDo.IconZoom = 35D;
            this.bt_DangKyTuDo.IsTab = false;
            this.bt_DangKyTuDo.Location = new System.Drawing.Point(0, 123);
            this.bt_DangKyTuDo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangKyTuDo.Name = "bt_DangKyTuDo";
            this.bt_DangKyTuDo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyTuDo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyTuDo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_DangKyTuDo.selected = false;
            this.bt_DangKyTuDo.Size = new System.Drawing.Size(237, 41);
            this.bt_DangKyTuDo.TabIndex = 10;
            this.bt_DangKyTuDo.Text = "                 Đăng ký mượn đồ";
            this.bt_DangKyTuDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DangKyTuDo.Textcolor = System.Drawing.Color.White;
            this.bt_DangKyTuDo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyTuDo.Click += new System.EventHandler(this.bt_DangKyTuDo_Click);
            // 
            // bt_DangKyHLV
            // 
            this.bt_DangKyHLV.Active = false;
            this.bt_DangKyHLV.Activecolor = System.Drawing.Color.Transparent;
            this.bt_DangKyHLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyHLV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_DangKyHLV.BorderRadius = 0;
            this.bt_DangKyHLV.ButtonText = "                 Đăng ký HLV";
            this.bt_DangKyHLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DangKyHLV.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyHLV.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DangKyHLV.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyHLV.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_DangKyHLV.Iconimage = null;
            this.bt_DangKyHLV.Iconimage_right = null;
            this.bt_DangKyHLV.Iconimage_right_Selected = null;
            this.bt_DangKyHLV.Iconimage_Selected = null;
            this.bt_DangKyHLV.IconMarginLeft = 0;
            this.bt_DangKyHLV.IconMarginRight = 0;
            this.bt_DangKyHLV.IconRightVisible = true;
            this.bt_DangKyHLV.IconRightZoom = 0D;
            this.bt_DangKyHLV.IconVisible = true;
            this.bt_DangKyHLV.IconZoom = 35D;
            this.bt_DangKyHLV.IsTab = false;
            this.bt_DangKyHLV.Location = new System.Drawing.Point(0, 82);
            this.bt_DangKyHLV.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangKyHLV.Name = "bt_DangKyHLV";
            this.bt_DangKyHLV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyHLV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyHLV.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_DangKyHLV.selected = false;
            this.bt_DangKyHLV.Size = new System.Drawing.Size(237, 41);
            this.bt_DangKyHLV.TabIndex = 9;
            this.bt_DangKyHLV.Text = "                 Đăng ký HLV";
            this.bt_DangKyHLV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DangKyHLV.Textcolor = System.Drawing.Color.White;
            this.bt_DangKyHLV.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyHLV.Click += new System.EventHandler(this.bt_DangKyHLV_Click);
            // 
            // bt_DangKyGoiTap
            // 
            this.bt_DangKyGoiTap.Active = false;
            this.bt_DangKyGoiTap.Activecolor = System.Drawing.Color.Transparent;
            this.bt_DangKyGoiTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyGoiTap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_DangKyGoiTap.BorderRadius = 0;
            this.bt_DangKyGoiTap.ButtonText = "                 Đăng ký gói tập";
            this.bt_DangKyGoiTap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DangKyGoiTap.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyGoiTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DangKyGoiTap.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyGoiTap.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_DangKyGoiTap.Iconimage = null;
            this.bt_DangKyGoiTap.Iconimage_right = null;
            this.bt_DangKyGoiTap.Iconimage_right_Selected = null;
            this.bt_DangKyGoiTap.Iconimage_Selected = null;
            this.bt_DangKyGoiTap.IconMarginLeft = 0;
            this.bt_DangKyGoiTap.IconMarginRight = 0;
            this.bt_DangKyGoiTap.IconRightVisible = true;
            this.bt_DangKyGoiTap.IconRightZoom = 0D;
            this.bt_DangKyGoiTap.IconVisible = true;
            this.bt_DangKyGoiTap.IconZoom = 35D;
            this.bt_DangKyGoiTap.IsTab = false;
            this.bt_DangKyGoiTap.Location = new System.Drawing.Point(0, 41);
            this.bt_DangKyGoiTap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangKyGoiTap.Name = "bt_DangKyGoiTap";
            this.bt_DangKyGoiTap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyGoiTap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyGoiTap.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_DangKyGoiTap.selected = false;
            this.bt_DangKyGoiTap.Size = new System.Drawing.Size(237, 41);
            this.bt_DangKyGoiTap.TabIndex = 8;
            this.bt_DangKyGoiTap.Text = "                 Đăng ký gói tập";
            this.bt_DangKyGoiTap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DangKyGoiTap.Textcolor = System.Drawing.Color.White;
            this.bt_DangKyGoiTap.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyGoiTap.Click += new System.EventHandler(this.bt_DangKyGoiTap_Click);
            // 
            // bt_DangKyMoi
            // 
            this.bt_DangKyMoi.Active = false;
            this.bt_DangKyMoi.Activecolor = System.Drawing.Color.Transparent;
            this.bt_DangKyMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_DangKyMoi.BorderRadius = 0;
            this.bt_DangKyMoi.ButtonText = "                 Đăng ký mới";
            this.bt_DangKyMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DangKyMoi.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DangKyMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyMoi.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_DangKyMoi.Iconimage = null;
            this.bt_DangKyMoi.Iconimage_right = null;
            this.bt_DangKyMoi.Iconimage_right_Selected = null;
            this.bt_DangKyMoi.Iconimage_Selected = null;
            this.bt_DangKyMoi.IconMarginLeft = 0;
            this.bt_DangKyMoi.IconMarginRight = 0;
            this.bt_DangKyMoi.IconRightVisible = true;
            this.bt_DangKyMoi.IconRightZoom = 0D;
            this.bt_DangKyMoi.IconVisible = true;
            this.bt_DangKyMoi.IconZoom = 35D;
            this.bt_DangKyMoi.IsTab = false;
            this.bt_DangKyMoi.Location = new System.Drawing.Point(0, 0);
            this.bt_DangKyMoi.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangKyMoi.Name = "bt_DangKyMoi";
            this.bt_DangKyMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DangKyMoi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_DangKyMoi.selected = false;
            this.bt_DangKyMoi.Size = new System.Drawing.Size(237, 41);
            this.bt_DangKyMoi.TabIndex = 7;
            this.bt_DangKyMoi.Text = "                 Đăng ký mới";
            this.bt_DangKyMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DangKyMoi.Textcolor = System.Drawing.Color.White;
            this.bt_DangKyMoi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKyMoi.Click += new System.EventHandler(this.bt_DangKyMoi_Click);
            // 
            // bt_HV
            // 
            this.bt_HV.Active = false;
            this.bt_HV.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HV.BorderRadius = 0;
            this.bt_HV.ButtonText = "      Hội viên";
            this.bt_HV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HV.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HV.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HV.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HV.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_HV.Iconimage")));
            this.bt_HV.Iconimage_right = null;
            this.bt_HV.Iconimage_right_Selected = null;
            this.bt_HV.Iconimage_Selected = null;
            this.bt_HV.IconMarginLeft = 0;
            this.bt_HV.IconMarginRight = 0;
            this.bt_HV.IconRightVisible = true;
            this.bt_HV.IconRightZoom = 0D;
            this.bt_HV.IconVisible = true;
            this.bt_HV.IconZoom = 35D;
            this.bt_HV.IsTab = false;
            this.bt_HV.Location = new System.Drawing.Point(0, 157);
            this.bt_HV.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HV.Name = "bt_HV";
            this.bt_HV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HV.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HV.selected = false;
            this.bt_HV.Size = new System.Drawing.Size(237, 70);
            this.bt_HV.TabIndex = 8;
            this.bt_HV.Text = "      Hội viên";
            this.bt_HV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HV.Textcolor = System.Drawing.Color.White;
            this.bt_HV.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HV.Click += new System.EventHandler(this.bt_HV_Click);
            // 
            // pn_SubDS
            // 
            this.pn_SubDS.Controls.Add(this.bt_HLV);
            this.pn_SubDS.Controls.Add(this.bt_HoiVien);
            this.pn_SubDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_SubDS.Location = new System.Drawing.Point(0, 70);
            this.pn_SubDS.Name = "pn_SubDS";
            this.pn_SubDS.Size = new System.Drawing.Size(237, 87);
            this.pn_SubDS.TabIndex = 7;
            // 
            // bt_HLV
            // 
            this.bt_HLV.Active = false;
            this.bt_HLV.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HLV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HLV.BorderRadius = 0;
            this.bt_HLV.ButtonText = "                 Huấn luyện viên";
            this.bt_HLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HLV.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HLV.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HLV.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HLV.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HLV.Iconimage = null;
            this.bt_HLV.Iconimage_right = null;
            this.bt_HLV.Iconimage_right_Selected = null;
            this.bt_HLV.Iconimage_Selected = null;
            this.bt_HLV.IconMarginLeft = 0;
            this.bt_HLV.IconMarginRight = 0;
            this.bt_HLV.IconRightVisible = true;
            this.bt_HLV.IconRightZoom = 0D;
            this.bt_HLV.IconVisible = true;
            this.bt_HLV.IconZoom = 35D;
            this.bt_HLV.IsTab = false;
            this.bt_HLV.Location = new System.Drawing.Point(0, 41);
            this.bt_HLV.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HLV.Name = "bt_HLV";
            this.bt_HLV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HLV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HLV.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HLV.selected = false;
            this.bt_HLV.Size = new System.Drawing.Size(237, 41);
            this.bt_HLV.TabIndex = 7;
            this.bt_HLV.Text = "                 Huấn luyện viên";
            this.bt_HLV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HLV.Textcolor = System.Drawing.Color.White;
            this.bt_HLV.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HLV.Click += new System.EventHandler(this.bt_HLV_Click);
            // 
            // bt_HoiVien
            // 
            this.bt_HoiVien.Active = false;
            this.bt_HoiVien.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HoiVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HoiVien.BorderRadius = 0;
            this.bt_HoiVien.ButtonText = "                 Hội viên";
            this.bt_HoiVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HoiVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HoiVien.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HoiVien.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HoiVien.Iconimage = null;
            this.bt_HoiVien.Iconimage_right = null;
            this.bt_HoiVien.Iconimage_right_Selected = null;
            this.bt_HoiVien.Iconimage_Selected = null;
            this.bt_HoiVien.IconMarginLeft = 0;
            this.bt_HoiVien.IconMarginRight = 0;
            this.bt_HoiVien.IconRightVisible = true;
            this.bt_HoiVien.IconRightZoom = 0D;
            this.bt_HoiVien.IconVisible = true;
            this.bt_HoiVien.IconZoom = 35D;
            this.bt_HoiVien.IsTab = false;
            this.bt_HoiVien.Location = new System.Drawing.Point(0, 0);
            this.bt_HoiVien.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HoiVien.Name = "bt_HoiVien";
            this.bt_HoiVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HoiVien.selected = false;
            this.bt_HoiVien.Size = new System.Drawing.Size(237, 41);
            this.bt_HoiVien.TabIndex = 6;
            this.bt_HoiVien.Text = "                 Hội viên";
            this.bt_HoiVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HoiVien.Textcolor = System.Drawing.Color.White;
            this.bt_HoiVien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HoiVien.Click += new System.EventHandler(this.bt_HoiVien_Click);
            // 
            // bt_DS
            // 
            this.bt_DS.Active = false;
            this.bt_DS.Activecolor = System.Drawing.Color.Transparent;
            this.bt_DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_DS.BorderRadius = 0;
            this.bt_DS.ButtonText = "      Danh sách";
            this.bt_DS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DS.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DS.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DS.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_DS.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_DS.Iconimage")));
            this.bt_DS.Iconimage_right = null;
            this.bt_DS.Iconimage_right_Selected = null;
            this.bt_DS.Iconimage_Selected = null;
            this.bt_DS.IconMarginLeft = 0;
            this.bt_DS.IconMarginRight = 0;
            this.bt_DS.IconRightVisible = true;
            this.bt_DS.IconRightZoom = 0D;
            this.bt_DS.IconVisible = true;
            this.bt_DS.IconZoom = 35D;
            this.bt_DS.IsTab = false;
            this.bt_DS.Location = new System.Drawing.Point(0, 0);
            this.bt_DS.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DS.Name = "bt_DS";
            this.bt_DS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_DS.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_DS.selected = false;
            this.bt_DS.Size = new System.Drawing.Size(237, 70);
            this.bt_DS.TabIndex = 4;
            this.bt_DS.Text = "      Danh sách";
            this.bt_DS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DS.Textcolor = System.Drawing.Color.White;
            this.bt_DS.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DS.Click += new System.EventHandler(this.bt_DS_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(61, 23);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(132, 127);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pn_CC
            // 
            this.pn_CC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.pn_CC.Controls.Add(this.bunifuImageButton2);
            this.pn_CC.Controls.Add(this.bt_Exit);
            this.pn_CC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_CC.Location = new System.Drawing.Point(266, 0);
            this.pn_CC.Name = "pn_CC";
            this.pn_CC.Size = new System.Drawing.Size(1253, 61);
            this.pn_CC.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1157, 17);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 16;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 0;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Exit.Image")));
            this.bt_Exit.ImageActive = null;
            this.bt_Exit.Location = new System.Drawing.Point(1200, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(41, 39);
            this.bt_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Exit.TabIndex = 15;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.Zoom = 10;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click_1);
            // 
            // KeoTha
            // 
            this.KeoTha.Fixed = true;
            this.KeoTha.Horizontal = true;
            this.KeoTha.TargetControl = this.pn_CC;
            this.KeoTha.Vertical = true;
            // 
            // pn_Content
            // 
            this.pn_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Content.Location = new System.Drawing.Point(266, 61);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(1253, 770);
            this.pn_Content.TabIndex = 2;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 831);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.pn_CC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.Text = "Gym Managerment";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pn_SubHT.ResumeLayout(false);
            this.pn_SubBC.ResumeLayout(false);
            this.pn_SubHV.ResumeLayout(false);
            this.pn_SubDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pn_CC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_CC;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bt_Exit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton bt_DS;
        private System.Windows.Forms.Panel pn_SubDS;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HLV;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HoiVien;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HV;
        private System.Windows.Forms.Panel pn_SubHV;
        private Bunifu.Framework.UI.BunifuFlatButton bt_DangKyMoi;
        private Bunifu.Framework.UI.BunifuFlatButton bt_DangKyTuDo;
        private Bunifu.Framework.UI.BunifuFlatButton bt_DangKyHLV;
        private Bunifu.Framework.UI.BunifuFlatButton bt_DangKyGoiTap;
        private Bunifu.Framework.UI.BunifuFlatButton bt_BanHangHoa;
        private Bunifu.Framework.UI.BunifuFlatButton bt_BC;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HT;
        private System.Windows.Forms.Panel pn_SubBC;
        private Bunifu.Framework.UI.BunifuFlatButton bt_GoiTap;
        private Bunifu.Framework.UI.BunifuFlatButton bt_BCDoanhThu;
        private System.Windows.Forms.Panel pn_SubHT;
        private Bunifu.Framework.UI.BunifuFlatButton bt_QuanLy;
        private Bunifu.Framework.UI.BunifuFlatButton bt_ThongTinTaiKhoan;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuDragControl KeoTha;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel pn_Content;
    }
}