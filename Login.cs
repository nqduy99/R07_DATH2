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
            try
            {
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string sqlcheckAccountNV = "select MaNV from Account_NV where Username = '" + tk + "' and Password = '" + mk + "'";
                string sqlcheckAccountKH = "select MaKH from Account_KH where Username = '" + tk + "' and Password = '" + mk + "'";
                SqlCommand checkAccountNV = new SqlCommand();
                checkAccountNV.CommandText = sqlcheckAccountNV;
                checkAccountNV.Connection = cnn;
                SqlDataReader dataNV = checkAccountNV.ExecuteReader();

                SqlCommand checkAccountKH = new SqlCommand();
                checkAccountKH.CommandText = sqlcheckAccountKH;
                checkAccountKH.Connection = cnn;
                SqlDataReader dataKH = checkAccountKH.ExecuteReader();
                if(dataKH.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                if (dataNV.Read() == true)
                {
                    string sqlcheck = "select nv.ChucVu from NhanVien nv, Account_NV acc where nv.MaNV = acc.MaNV and acc.MaNV = '" + dataNV.ToString() + "'";
                    SqlCommand checkChucVu = new SqlCommand();
                    checkChucVu.CommandText = sqlcheck;
                    checkChucVu.Connection = cnn;
                    SqlDataReader dataCV = checkChucVu.ExecuteReader();
                    if(dataCV.ToString() == "Quản trị")
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        AdminDashboard addb = new AdminDashboard();
                        addb.Activate();
                        addb.Show();
                        this.Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lối kết nối");
            }
        }
    }
}
