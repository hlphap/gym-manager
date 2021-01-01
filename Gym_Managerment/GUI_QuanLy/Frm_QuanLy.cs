using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Managerment.GUI_QuanLy.GUI_GoiTap;
using Gym_Managerment.GUI_QuanLy.GUI_HoiVien;
using Gym_Managerment.GUI_QuanLy.GUI_HuanLuyenVien;
using Gym_Managerment.GUI_QuanLy.GUI_SanPham;
using Gym_Managerment.GUI_QuanLy.GUI_TuDo;
using Gym_Managerment.GUI_QuanLy.GUI_NhanVien;

namespace Gym_Managerment.GUI_QuanLy
{
    public partial class Frm_QuanLy : Form
    {
        public Form frmMain;
        UC_GoiTap uc_GoiTap = new UC_GoiTap();
        UC_HoiVien uc_HoiVien = new UC_HoiVien();
        UC_HuanLuyenVien uc_HuanLuyenVien = new UC_HuanLuyenVien();
        UC_SanPham uc_SanPham = new UC_SanPham();
        UC_TuDo uc_TuDo = new UC_TuDo();
        UC_NhanVien uc_NhanVien = new UC_NhanVien();
        public Frm_QuanLy()
        {
            InitializeComponent();
            LoadDataPanel();
        }
        private void LoadDataPanel()
        {
            pn_Content.Controls.Add(uc_GoiTap);
            pn_Content.Controls.Add(uc_HoiVien);
            pn_Content.Controls.Add(uc_HuanLuyenVien);
            pn_Content.Controls.Add(uc_SanPham);
            pn_Content.Controls.Add(uc_TuDo);
            pn_Content.Controls.Add(uc_NhanVien);
        }
        private void bt_HuanLuyenVien_Click(object sender, EventArgs e)
        {
            uc_HuanLuyenVien.BringToFront();
            SidePanel.Height = bt_HuanLuyenVien.Height;
            SidePanel.Top = bt_HuanLuyenVien.Top;
        }

        private void bt_GoiTap_Click(object sender, EventArgs e)
        {
            uc_GoiTap.BringToFront();
            SidePanel.Height = bt_GoiTap.Height;
            SidePanel.Top = bt_GoiTap.Top;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {

            frmMain.Show();
            this.Close();
        }

        private void bt_SanPham_Click(object sender, EventArgs e)
        {
            uc_SanPham.BringToFront();
            SidePanel.Height = bt_SanPham.Height;
            SidePanel.Top = bt_SanPham.Top;
        }

        private void bt_TuDo_Click(object sender, EventArgs e)
        {
            uc_TuDo.BringToFront();
            SidePanel.Height = bt_TuDo.Height;
            SidePanel.Top = bt_TuDo.Top;
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            uc_NhanVien.BringToFront();

            SidePanel.Height = bt_NhanVien.Height;
            SidePanel.Top = bt_NhanVien.Top;
        }

        private void bt_HoiVien_Click(object sender, EventArgs e)
        {
            uc_HoiVien.BringToFront();
            SidePanel.Height = bt_HoiVien.Height;
            SidePanel.Top = bt_HoiVien.Top;
        }
    }
}
