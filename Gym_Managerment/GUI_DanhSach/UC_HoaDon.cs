using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_DanhSach
{
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_DangKyGoiTap_Click(object sender, EventArgs e)
        {
            page_HD.SetPage(0);
        }

        private void bt_DangKyHLV_Click(object sender, EventArgs e)
        {
            page_HD.SetPage(1);
        }

        private void bt_DangKyTuDo_Click(object sender, EventArgs e)
        {
            page_HD.SetPage(2);
        }
    }
}
