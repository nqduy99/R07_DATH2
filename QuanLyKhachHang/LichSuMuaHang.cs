using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R07_DATH2.QuanLyKhachHang
{
    public partial class LichSuMuaHang : Form
    {
        public LichSuMuaHang()
        {
            InitializeComponent();
        }

        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
        }

        private void btnExitToAdmin_Click(object sender, EventArgs e)
        {
            MenuKhachHang mnkh = new MenuKhachHang();
            mnkh.Activate();
            mnkh.Show();
            this.Hide();
        }
    }
}
