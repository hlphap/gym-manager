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
    public partial class UC_HuanLuyenVien : UserControl
    {
        public UC_HuanLuyenVien()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            UC_DataRowHLV uc_datarow = new UC_DataRowHLV();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGridHLV.Controls.Add(uc_datarow);
        }
    }
}
