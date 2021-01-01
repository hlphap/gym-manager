namespace Gym_Managerment.GUI_QuanLy
{
    partial class Frm_QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLy));
            this.pn_CC = new System.Windows.Forms.Panel();
            this.lb_ChaoMung = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_HuanLuyenVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_NhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_TuDo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_SanPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_GoiTap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KeoTha = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_Content = new System.Windows.Forms.Panel();
            this.bt_HoiVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_CC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_CC
            // 
            this.pn_CC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.pn_CC.Controls.Add(this.lb_ChaoMung);
            this.pn_CC.Controls.Add(this.bunifuImageButton2);
            this.pn_CC.Controls.Add(this.bt_Exit);
            this.pn_CC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_CC.Location = new System.Drawing.Point(0, 0);
            this.pn_CC.Name = "pn_CC";
            this.pn_CC.Size = new System.Drawing.Size(1503, 61);
            this.pn_CC.TabIndex = 2;
            // 
            // lb_ChaoMung
            // 
            this.lb_ChaoMung.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChaoMung.ForeColor = System.Drawing.Color.White;
            this.lb_ChaoMung.Location = new System.Drawing.Point(12, 9);
            this.lb_ChaoMung.Name = "lb_ChaoMung";
            this.lb_ChaoMung.Size = new System.Drawing.Size(281, 45);
            this.lb_ChaoMung.TabIndex = 17;
            this.lb_ChaoMung.Text = "Quản lý";
            this.lb_ChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1407, 17);
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
            this.bt_Exit.Location = new System.Drawing.Point(1450, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(41, 39);
            this.bt_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Exit.TabIndex = 15;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.Zoom = 10;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 731);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 731);
            this.panel5.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.SidePanel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 731);
            this.panel7.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(1, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 70);
            this.SidePanel.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.bt_HoiVien);
            this.panel6.Controls.Add(this.bt_HuanLuyenVien);
            this.panel6.Controls.Add(this.bt_NhanVien);
            this.panel6.Controls.Add(this.bt_TuDo);
            this.panel6.Controls.Add(this.bt_SanPham);
            this.panel6.Controls.Add(this.bt_GoiTap);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(12, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 731);
            this.panel6.TabIndex = 0;
            // 
            // bt_HuanLuyenVien
            // 
            this.bt_HuanLuyenVien.Active = false;
            this.bt_HuanLuyenVien.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HuanLuyenVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HuanLuyenVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HuanLuyenVien.BorderRadius = 0;
            this.bt_HuanLuyenVien.ButtonText = "      Huấn luyện viên";
            this.bt_HuanLuyenVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HuanLuyenVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HuanLuyenVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HuanLuyenVien.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HuanLuyenVien.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HuanLuyenVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_HuanLuyenVien.Iconimage")));
            this.bt_HuanLuyenVien.Iconimage_right = null;
            this.bt_HuanLuyenVien.Iconimage_right_Selected = null;
            this.bt_HuanLuyenVien.Iconimage_Selected = null;
            this.bt_HuanLuyenVien.IconMarginLeft = 0;
            this.bt_HuanLuyenVien.IconMarginRight = 0;
            this.bt_HuanLuyenVien.IconRightVisible = true;
            this.bt_HuanLuyenVien.IconRightZoom = 0D;
            this.bt_HuanLuyenVien.IconVisible = true;
            this.bt_HuanLuyenVien.IconZoom = 35D;
            this.bt_HuanLuyenVien.IsTab = false;
            this.bt_HuanLuyenVien.Location = new System.Drawing.Point(0, 280);
            this.bt_HuanLuyenVien.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HuanLuyenVien.Name = "bt_HuanLuyenVien";
            this.bt_HuanLuyenVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HuanLuyenVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HuanLuyenVien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HuanLuyenVien.selected = false;
            this.bt_HuanLuyenVien.Size = new System.Drawing.Size(254, 70);
            this.bt_HuanLuyenVien.TabIndex = 18;
            this.bt_HuanLuyenVien.Text = "      Huấn luyện viên";
            this.bt_HuanLuyenVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HuanLuyenVien.Textcolor = System.Drawing.Color.White;
            this.bt_HuanLuyenVien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HuanLuyenVien.Click += new System.EventHandler(this.bt_HuanLuyenVien_Click);
            // 
            // bt_NhanVien
            // 
            this.bt_NhanVien.Active = false;
            this.bt_NhanVien.Activecolor = System.Drawing.Color.Transparent;
            this.bt_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_NhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_NhanVien.BorderRadius = 0;
            this.bt_NhanVien.ButtonText = "      Nhân viên";
            this.bt_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_NhanVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_NhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_NhanVien.Iconimage")));
            this.bt_NhanVien.Iconimage_right = null;
            this.bt_NhanVien.Iconimage_right_Selected = null;
            this.bt_NhanVien.Iconimage_Selected = null;
            this.bt_NhanVien.IconMarginLeft = 0;
            this.bt_NhanVien.IconMarginRight = 0;
            this.bt_NhanVien.IconRightVisible = true;
            this.bt_NhanVien.IconRightZoom = 0D;
            this.bt_NhanVien.IconVisible = true;
            this.bt_NhanVien.IconZoom = 35D;
            this.bt_NhanVien.IsTab = false;
            this.bt_NhanVien.Location = new System.Drawing.Point(0, 210);
            this.bt_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.bt_NhanVien.Name = "bt_NhanVien";
            this.bt_NhanVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_NhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_NhanVien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_NhanVien.selected = false;
            this.bt_NhanVien.Size = new System.Drawing.Size(254, 70);
            this.bt_NhanVien.TabIndex = 17;
            this.bt_NhanVien.Text = "      Nhân viên";
            this.bt_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_NhanVien.Textcolor = System.Drawing.Color.White;
            this.bt_NhanVien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhanVien.Click += new System.EventHandler(this.bt_NhanVien_Click);
            // 
            // bt_TuDo
            // 
            this.bt_TuDo.Active = false;
            this.bt_TuDo.Activecolor = System.Drawing.Color.Transparent;
            this.bt_TuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_TuDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_TuDo.BorderRadius = 0;
            this.bt_TuDo.ButtonText = "      Tủ đồ";
            this.bt_TuDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_TuDo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_TuDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_TuDo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TuDo.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_TuDo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_TuDo.Iconimage")));
            this.bt_TuDo.Iconimage_right = null;
            this.bt_TuDo.Iconimage_right_Selected = null;
            this.bt_TuDo.Iconimage_Selected = null;
            this.bt_TuDo.IconMarginLeft = 0;
            this.bt_TuDo.IconMarginRight = 0;
            this.bt_TuDo.IconRightVisible = true;
            this.bt_TuDo.IconRightZoom = 0D;
            this.bt_TuDo.IconVisible = true;
            this.bt_TuDo.IconZoom = 35D;
            this.bt_TuDo.IsTab = false;
            this.bt_TuDo.Location = new System.Drawing.Point(0, 140);
            this.bt_TuDo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TuDo.Name = "bt_TuDo";
            this.bt_TuDo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_TuDo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_TuDo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_TuDo.selected = false;
            this.bt_TuDo.Size = new System.Drawing.Size(254, 70);
            this.bt_TuDo.TabIndex = 16;
            this.bt_TuDo.Text = "      Tủ đồ";
            this.bt_TuDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_TuDo.Textcolor = System.Drawing.Color.White;
            this.bt_TuDo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TuDo.Click += new System.EventHandler(this.bt_TuDo_Click);
            // 
            // bt_SanPham
            // 
            this.bt_SanPham.Active = false;
            this.bt_SanPham.Activecolor = System.Drawing.Color.Transparent;
            this.bt_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SanPham.BorderRadius = 0;
            this.bt_SanPham.ButtonText = "      Sản phẩm ";
            this.bt_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_SanPham.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_SanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SanPham.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_SanPham.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_SanPham.Iconimage")));
            this.bt_SanPham.Iconimage_right = null;
            this.bt_SanPham.Iconimage_right_Selected = null;
            this.bt_SanPham.Iconimage_Selected = null;
            this.bt_SanPham.IconMarginLeft = 0;
            this.bt_SanPham.IconMarginRight = 0;
            this.bt_SanPham.IconRightVisible = true;
            this.bt_SanPham.IconRightZoom = 0D;
            this.bt_SanPham.IconVisible = true;
            this.bt_SanPham.IconZoom = 35D;
            this.bt_SanPham.IsTab = false;
            this.bt_SanPham.Location = new System.Drawing.Point(0, 70);
            this.bt_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SanPham.Name = "bt_SanPham";
            this.bt_SanPham.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_SanPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_SanPham.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_SanPham.selected = false;
            this.bt_SanPham.Size = new System.Drawing.Size(254, 70);
            this.bt_SanPham.TabIndex = 15;
            this.bt_SanPham.Text = "      Sản phẩm ";
            this.bt_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SanPham.Textcolor = System.Drawing.Color.White;
            this.bt_SanPham.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SanPham.Click += new System.EventHandler(this.bt_SanPham_Click);
            // 
            // bt_GoiTap
            // 
            this.bt_GoiTap.Active = false;
            this.bt_GoiTap.Activecolor = System.Drawing.Color.Transparent;
            this.bt_GoiTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoiTap.BorderRadius = 0;
            this.bt_GoiTap.ButtonText = "      Gói tập";
            this.bt_GoiTap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GoiTap.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_GoiTap.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoiTap.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_GoiTap.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_GoiTap.Iconimage")));
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
            this.bt_GoiTap.Location = new System.Drawing.Point(0, 0);
            this.bt_GoiTap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_GoiTap.Name = "bt_GoiTap";
            this.bt_GoiTap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_GoiTap.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_GoiTap.selected = false;
            this.bt_GoiTap.Size = new System.Drawing.Size(254, 70);
            this.bt_GoiTap.TabIndex = 14;
            this.bt_GoiTap.Text = "      Gói tập";
            this.bt_GoiTap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GoiTap.Textcolor = System.Drawing.Color.White;
            this.bt_GoiTap.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoiTap.Click += new System.EventHandler(this.bt_GoiTap_Click);
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
            this.pn_Content.Size = new System.Drawing.Size(1237, 731);
            this.pn_Content.TabIndex = 4;
            // 
            // bt_HoiVien
            // 
            this.bt_HoiVien.Active = false;
            this.bt_HoiVien.Activecolor = System.Drawing.Color.Transparent;
            this.bt_HoiVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_HoiVien.BorderRadius = 0;
            this.bt_HoiVien.ButtonText = "      Hội viên";
            this.bt_HoiVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_HoiVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HoiVien.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HoiVien.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_HoiVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_HoiVien.Iconimage")));
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
            this.bt_HoiVien.Location = new System.Drawing.Point(0, 350);
            this.bt_HoiVien.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HoiVien.Name = "bt_HoiVien";
            this.bt_HoiVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.bt_HoiVien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.bt_HoiVien.selected = false;
            this.bt_HoiVien.Size = new System.Drawing.Size(254, 70);
            this.bt_HoiVien.TabIndex = 19;
            this.bt_HoiVien.Text = "      Hội viên";
            this.bt_HoiVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HoiVien.Textcolor = System.Drawing.Color.White;
            this.bt_HoiVien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HoiVien.Click += new System.EventHandler(this.bt_HoiVien_Click);
            // 
            // Frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 792);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_CC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QuanLy";
            this.pn_CC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_CC;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bt_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HuanLuyenVien;
        private Bunifu.Framework.UI.BunifuFlatButton bt_NhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton bt_TuDo;
        private Bunifu.Framework.UI.BunifuFlatButton bt_SanPham;
        private Bunifu.Framework.UI.BunifuFlatButton bt_GoiTap;
        private System.Windows.Forms.Label lb_ChaoMung;
        private Bunifu.Framework.UI.BunifuDragControl KeoTha;
        private System.Windows.Forms.Panel pn_Content;
        private Bunifu.Framework.UI.BunifuFlatButton bt_HoiVien;
    }
}