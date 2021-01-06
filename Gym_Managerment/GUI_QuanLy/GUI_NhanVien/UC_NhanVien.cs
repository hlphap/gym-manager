using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_NhanVien
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            UC_DataRowNhanVien uc_datarow = new UC_DataRowNhanVien();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGridNhanVien.Controls.Add(uc_datarow);
        }
    }
}
