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
    public partial class UC_HLV : UserControl
    {
        public UC_HLV()
        {
            InitializeComponent();
        }

        private void bt_DiemDanh_Click(object sender, EventArgs e)
        {
            bt_DiemDanh.Visible = false;
        }
    }
}
