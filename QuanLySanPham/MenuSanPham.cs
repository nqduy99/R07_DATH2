using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R07_DATH2.PhanHeNhanSu;

namespace R07_DATH2.QuanLySanPham
{
    public partial class MenuSanPham : Form
    {
        public MenuSanPham()
        {
            InitializeComponent();
        }

        private void QLSP_Click(object sender, EventArgs e)
        {
            MenuSanPham mnsp = new MenuSanPham();
            mnsp.Activate();
            mnsp.Show();
            this.Hide();
        }

        private void QLNhanSu_Click(object sender, EventArgs e)
        {
            MenuNhanSu mnns = new MenuNhanSu();
            mnns.Activate();
            mnns.Show();
            this.Hide();
        }

        private void btn_XemDSSP_Click(object sender, EventArgs e)
        {
            AdminDashboard addb = new AdminDashboard();
            addb.Activate();
            addb.Show();
            this.Hide();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ThemSanPham themsp = new ThemSanPham();
            themsp.Activate();
            themsp.Show();
            this.Hide();
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            CapNhatSanPham cnsp = new CapNhatSanPham();
            cnsp.Activate();
            cnsp.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login Thoat = new Login();
            Thoat.Activate();
            Thoat.Show();
            this.Hide();
        }

        private void MenuSanPham_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
        }
    }
}
