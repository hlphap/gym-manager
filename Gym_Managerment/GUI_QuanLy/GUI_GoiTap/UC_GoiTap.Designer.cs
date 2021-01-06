namespace Gym_Managerment.GUI_QuanLy.GUI_GoiTap
{
    partial class UC_GoiTap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GoiTap));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lb_ChaoMung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridGoiTap = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bt_Them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.uC_DataRowGoiTap1 = new Gym_Managerment.GUI_QuanLy.GUI_GoiTap.UC_DataRowGoiTap();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dataGridGoiTap.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ChaoMung
            // 
            this.lb_ChaoMung.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChaoMung.ForeColor = System.Drawing.Color.Black;
            this.lb_ChaoMung.Location = new System.Drawing.Point(17, 15);
            this.lb_ChaoMung.Name = "lb_ChaoMung";
            this.lb_ChaoMung.Size = new System.Drawing.Size(281, 45);
            this.lb_ChaoMung.TabIndex = 6;
            this.lb_ChaoMung.Text = "Danh sách gói tập";
            this.lb_ChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 674);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridGoiTap);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(22, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 590);
            this.panel2.TabIndex = 175;
            // 
            // dataGridGoiTap
            // 
            this.dataGridGoiTap.AutoScroll = true;
            this.dataGridGoiTap.Controls.Add(this.uC_DataRowGoiTap1);
            this.dataGridGoiTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGoiTap.Location = new System.Drawing.Point(0, 45);
            this.dataGridGoiTap.Name = "dataGridGoiTap";
            this.dataGridGoiTap.Size = new System.Drawing.Size(1192, 545);
            this.dataGridGoiTap.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.linkLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1192, 45);
            this.panel6.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(741, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(104, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên gói tập";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(12, 10);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 25);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "stt";
            // 
            // bt_Them
            // 
            this.bt_Them.AllowToggling = false;
            this.bt_Them.AnimationSpeed = 200;
            this.bt_Them.AutoGenerateColors = false;
            this.bt_Them.BackColor = System.Drawing.Color.Transparent;
            this.bt_Them.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.bt_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Them.BackgroundImage")));
            this.bt_Them.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bt_Them.ButtonText = "Thêm mới";
            this.bt_Them.ButtonTextMarginLeft = 0;
            this.bt_Them.ColorContrastOnClick = 45;
            this.bt_Them.ColorContrastOnHover = 45;
            this.bt_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bt_Them.CustomizableEdges = borderEdges3;
            this.bt_Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_Them.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bt_Them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_Them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_Them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bt_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bt_Them.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Them.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Them.IconMarginLeft = 11;
            this.bt_Them.IconPadding = 10;
            this.bt_Them.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Them.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.bt_Them.IdleBorderRadius = 30;
            this.bt_Them.IdleBorderThickness = 2;
            this.bt_Them.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.bt_Them.IdleIconLeftImage = null;
            this.bt_Them.IdleIconRightImage = null;
            this.bt_Them.IndicateFocus = false;
            this.bt_Them.Location = new System.Drawing.Point(1087, 3);
            this.bt_Them.Name = "bt_Them";
            stateProperties5.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties5.BorderRadius = 30;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 2;
            stateProperties5.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bt_Them.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties6.BorderRadius = 30;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 2;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bt_Them.OnPressedState = stateProperties6;
            this.bt_Them.Size = new System.Drawing.Size(127, 41);
            this.bt_Them.TabIndex = 174;
            this.bt_Them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Them.TextMarginLeft = 0;
            this.bt_Them.UseDefaultRadiusAndThickness = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // uC_DataRowGoiTap1
            // 
            this.uC_DataRowGoiTap1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.uC_DataRowGoiTap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DataRowGoiTap1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_DataRowGoiTap1.Location = new System.Drawing.Point(0, 0);
            this.uC_DataRowGoiTap1.Name = "uC_DataRowGoiTap1";
            this.uC_DataRowGoiTap1.Size = new System.Drawing.Size(1192, 47);
            this.uC_DataRowGoiTap1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Giá";
            // 
            // UC_GoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_ChaoMung);
            this.Name = "UC_GoiTap";
            this.Size = new System.Drawing.Size(1237, 731);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dataGridGoiTap.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ChaoMung;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bt_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel dataGridGoiTap;
        private UC_DataRowGoiTap uC_DataRowGoiTap1;
        private System.Windows.Forms.Label label1;
    }
}
