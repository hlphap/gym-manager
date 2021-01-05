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
    public partial class DataRow : UserControl
    {
        bool status = false;
        public DataRow()
        {
            InitializeComponent();
        }

        private void DataRow_Load(object sender, EventArgs e)
        {
            if (status)
            {
                btnDiemDanh.Text = "Đã điểm danh";
                btnDiemDanh.ForeColor = ColorTranslator.FromHtml("#1EDB4C");
                btnDiemDanh.IdleFillColor = Color.Transparent;
                btnDiemDanh.IdleBorderColor = Color.Transparent;
            }
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            this.status = !this.status;
            if (status)
            {
                btnDiemDanh.Text = "Đã điểm danh";
                btnDiemDanh.ForeColor = ColorTranslator.FromHtml("#1EDB4C");
                btnDiemDanh.IdleFillColor = Color.White;
                btnDiemDanh.IdleBorderColor = Color.White;
            }
            else if (!status)
            {
                btnDiemDanh.Text = "Điểm danh";
                btnDiemDanh.ForeColor = Color.White;
                btnDiemDanh.IdleFillColor = Color.FromArgb(0, 144, 196);
                btnDiemDanh.IdleBorderColor = Color.FromArgb(0, 144, 196);
            }
            
        }
    }
}
