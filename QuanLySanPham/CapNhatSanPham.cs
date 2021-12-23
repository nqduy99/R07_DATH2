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

namespace R07_DATH2.QuanLySanPham
{
    public partial class CapNhatSanPham : Form
    {
        public CapNhatSanPham()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void CapNhatSanPham_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }
        private bool isValidInputCapNhatSP()
        {
            if (string.IsNullOrEmpty(this.txtCapNhatMaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtCapNhatTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtCapNhatSoLuongSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Số Lượng Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtMoTaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mô Tả Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDonGiaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn Giá Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.dtpHanSuDungSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Hạn Sử Dụng Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtMaLSPCapNhatSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Loại Sản Phẩm");
                return false;
            }
            return true;
        }


        private void btnExitToAdmin_Click(object sender, EventArgs e)
        {
            AdminDashboard addb = new AdminDashboard();
            addb.Activate();
            addb.Show();
            this.Hide();
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            if (isValidInputCapNhatSP())
            {
                string sqlInsert = "update SanPham set TenSP = '"+txtCapNhatTenSP.Text+"',SoLuongTon = '"+txtCapNhatSoLuongSP.Text+"',MoTa = '"+txtMoTaSP.Text+"',Gia = '"+txtDonGiaSP.Text+"',HanSuDung = '"+dtpHanSuDungSP.Text+"',MaLSP = '"+txtMaLSPCapNhatSP.Text+"' where MaSP = '"+txtCapNhatMaSP.Text+"'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlInsert;
                cmd.Connection = cnn;
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập Nhật Sản Phẩm thành công");
            }
            else
            {
                MessageBox.Show("Không cập nhật thành công");
            }
        }
    }
}
