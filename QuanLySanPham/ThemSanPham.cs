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
    public partial class ThemSanPham : Form
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }

        private void btnXemDSLSP_Click(object sender, EventArgs e)
        {
            string sqlDoanhThu = "select * from LoaiSanPham";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlDoanhThu;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvLoaiSanPham.DataSource = dt;
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            if (isValidInputLSP())
            {
                    string sqlInsert = "insert into LoaiSanPham values(@MaLSP,@TenLSP)";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlInsert;
                    cmd.Connection = cnn;
                    cmd.Parameters.AddWithValue("MaLSP", txtMaLSP.Text);
                    cmd.Parameters.AddWithValue("TenLSP", txtTenLSP.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Loại sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Không thêm được");
            }
        }
        private bool isValidInputLSP()
        {
            if (string.IsNullOrEmpty(this.txtMaLSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Loại Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtTenLSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Loại Sản Phẩm");
                return false;
            }
            return true;
        }

        private bool isValidInputThemSP()
        {
            if (string.IsNullOrEmpty(this.txtThemMaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtThemTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Sản Phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtThemSoLuongSP.Text))
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
            if (string.IsNullOrEmpty(this.txtMaLSPThemSP.Text))
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (isValidInputThemSP())
            {
                string sqlInsert = "insert into SanPham values(@MaSP,@TenSP,@SoLuongTon,@MoTa,@Gia,@HanSuDung,@MaLSP)";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlInsert;
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("MaSP", txtThemMaSP.Text);
                cmd.Parameters.AddWithValue("TenSP", txtThemTenSP.Text);
                cmd.Parameters.AddWithValue("SoLuongTon", txtThemSoLuongSP.Text);
                cmd.Parameters.AddWithValue("MoTa", txtMoTaSP.Text);
                cmd.Parameters.AddWithValue("Gia", txtDonGiaSP.Text);
                cmd.Parameters.AddWithValue("HanSuDung", dtpHanSuDungSP.Value);
                cmd.Parameters.AddWithValue("MaLSP", txtMaLSPThemSP.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Sản Phẩm thành công");
            }
            else
            {
                MessageBox.Show("Không thêm được");
            }
        }
    }
}
