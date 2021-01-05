﻿namespace Gym_Managerment.GUI_DanhSach
{
    partial class UC_HLV
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
            this.lb_ChaoMung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_List = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Coach_Data_Row_1 = new Gym_Managerment.GUI_DanhSach.DataRow();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSex = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pn_List.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ChaoMung
            // 
            this.lb_ChaoMung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChaoMung.ForeColor = System.Drawing.Color.Black;
            this.lb_ChaoMung.Location = new System.Drawing.Point(17, 15);
            this.lb_ChaoMung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ChaoMung.Name = "lb_ChaoMung";
            this.lb_ChaoMung.Size = new System.Drawing.Size(375, 55);
            this.lb_ChaoMung.TabIndex = 3;
            this.lb_ChaoMung.Text = "Danh sách huấn luyện viên";
            this.lb_ChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_List
            // 
            this.pn_List.Controls.Add(this.panel2);
            this.pn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_List.Location = new System.Drawing.Point(0, 280);
            this.pn_List.Margin = new System.Windows.Forms.Padding(4);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(1671, 668);
            this.pn_List.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(40, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1631, 668);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Coach_Data_Row_1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1631, 668);
            this.panel3.TabIndex = 5;
            // 
            // Coach_Data_Row_1
            // 
            this.Coach_Data_Row_1.Location = new System.Drawing.Point(3, 74);
            this.Coach_Data_Row_1.Name = "Coach_Data_Row_1";
            this.Coach_Data_Row_1.Size = new System.Drawing.Size(1631, 53);
            this.Coach_Data_Row_1.TabIndex = 22;
            this.Coach_Data_Row_1.Load += new System.EventHandler(this.Coach_Data_Row_1_Load);
            this.Coach_Data_Row_1.Click += new System.EventHandler(this.Coach_Data_Row_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Controls.Add(this.lblOperation);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.linkLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1631, 55);
            this.panel6.TabIndex = 21;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(1235, 17);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(104, 25);
            this.lblOperation.TabIndex = 23;
            this.lblOperation.Text = "Hoạt động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(921, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên huấn luyện viên";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel2.Location = new System.Drawing.Point(16, 12);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 31);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "stt";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(591, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 55);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(591, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 55);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số điện thoại: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtName.HintText = "0 VND";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtName.LineThickness = 1;
            this.txtName.Location = new System.Drawing.Point(156, 108);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtName.Size = new System.Drawing.Size(221, 33);
            this.txtName.TabIndex = 155;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSex
            // 
            this.txtSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSex.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.Enabled = false;
            this.txtSex.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtSex.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtSex.HintText = "0 VND";
            this.txtSex.isPassword = false;
            this.txtSex.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtSex.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSex.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtSex.LineThickness = 1;
            this.txtSex.Location = new System.Drawing.Point(156, 176);
            this.txtSex.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSex.MaxLength = 32767;
            this.txtSex.Name = "txtSex";
            this.txtSex.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtSex.Size = new System.Drawing.Size(221, 33);
            this.txtSex.TabIndex = 155;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.HintText = "0 VND";
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.LineThickness = 1;
            this.txtPhoneNumber.Location = new System.Drawing.Point(775, 108);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtPhoneNumber.Size = new System.Drawing.Size(221, 33);
            this.txtPhoneNumber.TabIndex = 155;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtEmail.HintText = "0 VND";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            this.txtEmail.LineThickness = 1;
            this.txtEmail.Location = new System.Drawing.Point(775, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtEmail.Size = new System.Drawing.Size(221, 33);
            this.txtEmail.TabIndex = 155;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UC_HLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_ChaoMung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HLV";
            this.Size = new System.Drawing.Size(1671, 948);
            this.pn_List.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ChaoMung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOperation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private DataRow Coach_Data_Row_1;
    }
}