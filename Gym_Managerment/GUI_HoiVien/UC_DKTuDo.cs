using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_HoiVien
{
    public partial class UC_DKTuDo : UserControl
    {
        public UC_DKTuDo()
        {
            InitializeComponent();
        }

        private void dataRowWardrobe_Click(object sender, EventArgs e)
        {
            txtName.Text = dataRowWardrobe.lblWardrobe.Text;
            txtDescription.Text = "Data From Database";
            txtNote.Text = "Data from Datebase";
        }
    }
}
