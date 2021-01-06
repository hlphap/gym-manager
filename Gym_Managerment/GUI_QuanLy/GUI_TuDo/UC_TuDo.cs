using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_QuanLy.GUI_TuDo
{
    public partial class UC_TuDo : UserControl
    {
        public UC_TuDo()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            UC_DataRowTuDo uc_datarow = new UC_DataRowTuDo();
            uc_datarow.Dock = DockStyle.Top;
            uc_datarow.ShowPanel();
            dataGidTuDo.Controls.Add(uc_datarow);
        }
    }
}
