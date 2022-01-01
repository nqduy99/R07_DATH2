using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R07_DATH2.NhanSu
{
    public partial class NhanSu : Form
    {
        public NhanSu()
        {
            InitializeComponent();
        }

        private void btn_thongkeDH_Click(object sender, EventArgs e)
        {
            ThongKeDH dh = new ThongKeDH();
            dh.Activate();
            dh.Show();
            this.Hide();
        }

        private void btn_doanhso_Click(object sender, EventArgs e)
        {
            DoanhSo ds = new DoanhSo();
            ds.Activate();
            ds.Show();
            this.Hide();
        }
    }
}
