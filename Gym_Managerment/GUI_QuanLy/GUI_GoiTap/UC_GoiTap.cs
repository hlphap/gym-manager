using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_GoiTap
{
    public partial class UC_GoiTap : UserControl
    {
        public UC_GoiTap()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            UC_DataRowGoiTap uc_datarow = new UC_DataRowGoiTap();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGridGoiTap.Controls.Add(uc_datarow);

        }
    }
}
