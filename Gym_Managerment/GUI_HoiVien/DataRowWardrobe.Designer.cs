namespace Gym_Managerment.GUI_HoiVien
{
    partial class DataRowWardrobe
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
            this.lblWardrobe = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblWardrobe
            // 
            this.lblWardrobe.AutoSize = true;
            this.lblWardrobe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardrobe.Location = new System.Drawing.Point(193, 13);
            this.lblWardrobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWardrobe.Name = "lblWardrobe";
            this.lblWardrobe.Size = new System.Drawing.Size(82, 25);
            this.lblWardrobe.TabIndex = 4;
            this.lblWardrobe.Text = "Tủ Vip_1";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIndex.Location = new System.Drawing.Point(18, 10);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(30, 31);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.TabStop = true;
            this.lblIndex.Text = "1";
            // 
            // DataRowWardrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWardrobe);
            this.Controls.Add(this.lblIndex);
            this.Name = "DataRowWardrobe";
            this.Size = new System.Drawing.Size(1593, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWardrobe;
        public System.Windows.Forms.LinkLabel lblIndex;
    }
}
