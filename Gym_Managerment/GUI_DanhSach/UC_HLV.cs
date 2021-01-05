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
        private void Coach_Data_Row_Click_1(object sender, EventArgs e)
        {
            txtName.Text = Coach_Data_Row_1.lblName.Text;
            txtSex.Text = Coach_Data_Row_1.lblSex.Text;
            txtPhoneNumber.Text = Coach_Data_Row_1.lblPhoneNumber.Text;
            txtEmail.Text = Coach_Data_Row_1.lblEmail.Text;
        }

        private void Coach_Data_Row_1_Load(object sender, EventArgs e)
        {
        }
        public void DiemDanh_Handle_Click(object obj, EventArgs ea)
        {
            DataRow dataRow = (DataRow)obj;
            //dataRow.lblStatus.Text = "Đã điểm danh";
            //dataRow.lblStatus.ForeColor = ColorTranslator.FromHtml("#1EDB4");
        }
    }
}
