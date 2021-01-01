using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managerment.GUI_ThongTinTaiKhoan
{
    public partial class Frm_ThongTinTK : Form
    {
        public Form frmMain;

        public Frm_ThongTinTK()
        {
            InitializeComponent();
        }


        private void bt_Exit_Click_1(object sender, EventArgs e)
        {
            frmMain.Enabled = true;
            this.Close();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = true;
            bt_Sua.Visible = false;
            txb_TaiKhoan.Enabled = true;
                txb_MatKhau.Enabled = true;
      
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = false;
            bt_Sua.Visible = true;
            txb_TaiKhoan.Enabled = false;
            txb_MatKhau.Enabled = false;
        }
    }
}
