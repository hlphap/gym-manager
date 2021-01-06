using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_SanPham
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            UC_DataRowSanPham uc_datarow = new UC_DataRowSanPham();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGridSanPham.Controls.Add(uc_datarow);
        }
    }
}
