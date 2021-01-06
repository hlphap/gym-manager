using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Managerment.GUI_DanhSach;
using Gym_Managerment.GUI_HoiVien;
using Gym_Managerment.GUI_DicchVu;
using Gym_Managerment.GUI_BaoCao;
using Gym_Managerment.GUI_ThongTinTaiKhoan;
using Gym_Managerment.GUI_QuanLy;
namespace Gym_Managerment.GUI_FrmMain
{
    public partial class frm_Main : Form
    {
        UC_HLV gui_DSHLV = new UC_HLV();
        UC_HoiVien gui_HV = new UC_HoiVien();
        UC_DKGoiTap gui_DKGT = new UC_DKGoiTap();
        UC_DKHuanLuyenVien gui_DKHLV = new UC_DKHuanLuyenVien();
        UC_DKTuDo gui_DKTD = new UC_DKTuDo();
        UC_DKThanhVien gui_DKTV = new UC_DKThanhVien();
        UC_DichVu gui_DV = new UC_DichVu();
        UC_BCDoanhThu gui_BCDT = new UC_BCDoanhThu();
        UC_BCGoiTap gui_BCGT = new UC_BCGoiTap();
        UC_HoaDon gui_HD = new UC_HoaDon();

        

        public frm_Main()
        {
            InitializeComponent();
            HideSubPanel();
            LoadDataPanel();
        }

        private void LoadDataPanel()
        {
            pn_Content.Controls.Add(gui_DSHLV);
            pn_Content.Controls.Add(gui_HV);
            pn_Content.Controls.Add(gui_DKGT);
            pn_Content.Controls.Add(gui_DKTV);
            pn_Content.Controls.Add(gui_DKTD);
            pn_Content.Controls.Add(gui_DKHLV);
            pn_Content.Controls.Add(gui_DV);
            pn_Content.Controls.Add(gui_BCDT);
            pn_Content.Controls.Add(gui_BCGT);
            pn_Content.Controls.Add(gui_HD);
        }

        private void HideSubPanel()
        {
            pn_SubDS.Visible = false;
            pn_SubBC.Visible = false;
            pn_SubHV.Visible = false;
            pn_SubHT.Visible = false;
        }

        private void ShowPanel(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubPanel();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSubMenuNVP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_DS_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_SubDS);
            SidePanel.Height = bt_DS.Height;
            SidePanel.Top = bt_DS.Top;
        }

        private void bt_HV_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_SubHV);
            SidePanel.Height = bt_HV.Height;
            SidePanel.Top = bt_HV.Top;
        }

        private void bt_DV_Click(object sender, EventArgs e)
        {
            gui_DV.BringToFront();
            SidePanel.Height = bt_BanHangHoa.Height;
            SidePanel.Top = bt_BanHangHoa.Top;
        }

        private void bt_BC_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_SubBC);
            SidePanel.Height = bt_BC.Height;
            SidePanel.Top = bt_BC.Top;
        }

        private void bt_HT_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_SubHT);
            SidePanel.Height = bt_HT.Height;
            SidePanel.Top = bt_HT.Top;
        }

        private void bt_HLV_Click(object sender, EventArgs e)
        {
            gui_DSHLV.BringToFront();
        }

        private void bt_HoiVien_Click(object sender, EventArgs e)
        {
            gui_HV.BringToFront();
        }

        private void bt_DangKyMoi_Click(object sender, EventArgs e)
        {
            gui_DKTV.BringToFront();
        }

        private void bt_DangKyGoiTap_Click(object sender, EventArgs e)
        {
            gui_DKGT.BringToFront();
        }

        private void bt_DangKyHLV_Click(object sender, EventArgs e)
        {
            gui_DKHLV.BringToFront();
        }

        private void bt_DangKyTuDo_Click(object sender, EventArgs e)
        {
            gui_DKTD.BringToFront();
        }

        private void bt_BCDoanhThu_Click(object sender, EventArgs e)
        {
            gui_BCDT.BringToFront();
        }

        private void bt_GoiTap_Click(object sender, EventArgs e)
        {
            gui_BCGT.BringToFront();
        }

        private void bt_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_ThongTinTK frm_TTTK = new Frm_ThongTinTK();
            this.Enabled = false;
            frm_TTTK.frmMain = this;
            frm_TTTK.ShowDialog();
           // this.Hide();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_QuanLy_Click(object sender, EventArgs e)
        {
            Frm_QuanLy frm_QuanLy = new Frm_QuanLy();
            this.Hide();
            frm_QuanLy.frmMain = this;
            frm_QuanLy.ShowDialog();
        }

        private void bt_HD_Click(object sender, EventArgs e)
        {
            gui_HD.BringToFront();
        }
    }
}
