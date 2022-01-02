using R07_DATH2.PhanHeNhanSu;
using R07_DATH2.QuanLySanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R07_DATH2.QuanLyKhachHang
{
    public partial class MenuKhachHang : Form
    {
        public MenuKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }

        private void QLNhanSu_Click(object sender, EventArgs e)
        {
            MenuNhanSu mnns = new MenuNhanSu();
            mnns.Activate();
            mnns.Show();
            this.Hide();
        }

        private void QLSP_Click(object sender, EventArgs e)
        {
            MenuSanPham mnsp = new MenuSanPham();
            mnsp.Activate();
            mnsp.Show();
            this.Hide();
        }

        private void btn_TimkiemKH_Click(object sender, EventArgs e)
        {
            TimkiemKhachHang tkkh = new TimkiemKhachHang();
            tkkh.Activate();
            tkkh.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login Thoat = new Login();
            Thoat.Activate();
            Thoat.Show();
            this.Hide();
        }

        private void MenuKhachHang_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
        }

        private void btn_LSMH_Click(object sender, EventArgs e)
        {
            LichSuMuaHang lsmh = new LichSuMuaHang();
            lsmh.Activate();
            lsmh.Show();
            this.Hide();
        }
    }
}
