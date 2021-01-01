using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Managerment.GUI_FrmMain;

namespace Gym_Managerment.GUI_SignIn
{
    public partial class frm_SignIn : Form
    {
        private  frm_Main frmMain = new frm_Main();
        public frm_SignIn()
        {
            InitializeComponent();
        }

        private void lb_ChaoMung_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void DangKy_Click(object sender, EventArgs e)
        {

        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void pageSignIn_Click(object sender, EventArgs e)
        {

        }

        private void bt_GoPageSignIn_Click(object sender, EventArgs e)
        {
            pageLogin.SetPage(0);
        }

        private void bt_GoPageReg_Click(object sender, EventArgs e)
        {
            pageLogin.SetPage(1);
        }

        private void bt_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.Show();
        }
    }
}
