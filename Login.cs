using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using R07_DATH2.QuanLySanPham;

namespace R07_DATH2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection cnn;

        private void Login_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            if(tk == "" || mk == "")
            {
                MessageBox.Show("Vui lòng Tên đăng nhập hoặc mật khẩu!");
            }
            string sqlcheckAccountNV = "select MaNV from Account_NV where Username_NV = '" + tk + "' and Password_NV = '" + mk + "'";
            string sqlcheckAccountKH = "select MaKH from Account_KH where Username = '" + tk + "' and Password = '" + mk + "'";
            SqlCommand checkAccountNV = new SqlCommand();
            checkAccountNV.CommandText = sqlcheckAccountNV;
            checkAccountNV.Connection = cnn;
            SqlDataReader dataNV = checkAccountNV.ExecuteReader();  

            if (tk=="Admin" && mk=="123456")
            {
                string sqlcheck = "select acc.Vaitro from NhanVien nv, Account_NV acc where nv.MaNV = acc.MaNV and acc.MaNV = '" + dataNV.ToString() + "'";
                MessageBox.Show("Đăng nhập thành công");
                MenuSanPham mnsp = new MenuSanPham();
                mnsp.Activate();
                mnsp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
