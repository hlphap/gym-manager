using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_HoiVien
{
    public partial class UC_HoiVien : UserControl
    {
        public UC_HoiVien()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UC_DataRowHoiVien uc_datarow = new UC_DataRowHoiVien();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGridHoiVien.Controls.Add(uc_datarow);
        }
    }
}
