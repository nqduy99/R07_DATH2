using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R07_DATH2.EcommerceWebsite;

namespace R07_DATH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JU9AFGI;Initial Catalog=DATH2;Integrated Security=True");
                            
            try
            {
                con.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from Account where Username = '" + tk + "' and Password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    AdminDashboard addb = new AdminDashboard();
                    addb.Activate();
                    addb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lối kết nối");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
