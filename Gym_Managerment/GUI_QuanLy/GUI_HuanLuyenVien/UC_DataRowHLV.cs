using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_HuanLuyenVien
{
    public partial class UC_DataRowHLV : UserControl
    {
        public UC_DataRowHLV()
        {
            InitializeComponent();
            ShowPanel();
        }

        public void ShowPanel()
        {
            if (pn_DetailGT.Visible == true)
            {
                pn_DetailGT.Visible = false;
                this.Size = new Size(910, 45);
                Image img = pictureShow.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureShow.Image = img;
            }
            else
            {
                pn_DetailGT.Visible = true;
                this.Size = new Size(910, 219);
                Image img = pictureShow.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureShow.Image = img;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();
           

        }
    }
}
