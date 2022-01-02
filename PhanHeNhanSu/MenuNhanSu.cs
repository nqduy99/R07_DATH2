using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R07_DATH2.PhanHeNhanSu
{
    public partial class MenuNhanSu : Form
    {
        public MenuNhanSu()
        {
            InitializeComponent();
        }

        private void btn_thongkeDH_Click(object sender, EventArgs e)
        {
            ThongKeDH tkhd = new ThongKeDH();
            tkhd.Activate();
            tkhd.Show();
            this.Hide();
        }

        private void btn_doanhso_Click(object sender, EventArgs e)
        {
            DoanhSo ds = new DoanhSo();
            ds.Activate();
            ds.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Luong_Thuong lt = new Luong_Thuong();
            lt.Activate();
            lt.Show();
            this.Hide();
        }

        private void MenuNhanSu_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
        }
    }
}
