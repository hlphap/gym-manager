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
    public partial class UC_DKGoiTap : UserControl
    {
        public UC_DKGoiTap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataRowMember_Click(object sender, EventArgs e)
        {
            txtPackage.Text = dataRowMember.lblPackage.Text;
            txtQuantity.Text = dataRowMember.lblQuantity.Text;
            // Date Start, Date End ??? What type??
        }

        private void dataRowMember_Load(object sender, EventArgs e)
        {

        }
    }
}
