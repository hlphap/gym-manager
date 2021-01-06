namespace Gym_Managerment.GUI_QuanLy.GUI_TuDo
{
    partial class UC_TuDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TuDo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bt_Them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lb_ChaoMung = new System.Windows.Forms.Label();
            this.dataGidTuDo = new System.Windows.Forms.Panel();
            this.uC_DataRowTuDo1 = new Gym_Managerment.GUI_QuanLy.GUI_TuDo.UC_DataRowTuDo();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.dataGidTuDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 674);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGidTuDo);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(22, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 590);
            this.panel2.TabIndex = 175;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.linkLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1192, 45);
            this.panel6.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên tủ đồ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(377, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mô tả";
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bt_Them.CustomizableEdges = borderEdges2;
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
            stateProperties3.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties3.BorderRadius = 30;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 2;
            stateProperties3.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bt_Them.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties4.BorderRadius = 30;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 2;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bt_Them.OnPressedState = stateProperties4;
            this.bt_Them.Size = new System.Drawing.Size(127, 41);
            this.bt_Them.TabIndex = 174;
            this.bt_Them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Them.TextMarginLeft = 0;
            this.bt_Them.UseDefaultRadiusAndThickness = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // lb_ChaoMung
            // 
            this.lb_ChaoMung.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChaoMung.ForeColor = System.Drawing.Color.Black;
            this.lb_ChaoMung.Location = new System.Drawing.Point(17, 3);
            this.lb_ChaoMung.Name = "lb_ChaoMung";
            this.lb_ChaoMung.Size = new System.Drawing.Size(281, 45);
            this.lb_ChaoMung.TabIndex = 10;
            this.lb_ChaoMung.Text = "Danh sách tủ đồ";
            this.lb_ChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGidTuDo
            // 
            this.dataGidTuDo.Controls.Add(this.uC_DataRowTuDo1);
            this.dataGidTuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGidTuDo.Location = new System.Drawing.Point(0, 45);
            this.dataGidTuDo.Name = "dataGidTuDo";
            this.dataGidTuDo.Size = new System.Drawing.Size(1192, 545);
            this.dataGidTuDo.TabIndex = 23;
            // 
            // uC_DataRowTuDo1
            // 
            this.uC_DataRowTuDo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DataRowTuDo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_DataRowTuDo1.Location = new System.Drawing.Point(0, 0);
            this.uC_DataRowTuDo1.Name = "uC_DataRowTuDo1";
            this.uC_DataRowTuDo1.Size = new System.Drawing.Size(1192, 45);
            this.uC_DataRowTuDo1.TabIndex = 0;
            // 
            // UC_TuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_ChaoMung);
            this.Name = "UC_TuDo";
            this.Size = new System.Drawing.Size(1237, 731);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.dataGidTuDo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bt_Them;
        private System.Windows.Forms.Label lb_ChaoMung;
        private System.Windows.Forms.Panel dataGidTuDo;
        private UC_DataRowTuDo uC_DataRowTuDo1;
    }
}
