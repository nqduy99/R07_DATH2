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

namespace R07_DATH2.PhanHeNhanSu
{
    public partial class Luong_Thuong : Form
    {
        public Luong_Thuong()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void Luong_Thuong_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();

            string sqldsnv = "select MaNV, HoTen_NV,ChucVu, NgSinh_NV, Luong as LuongHienTai from NhanVien ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqldsnv;
            cmd.Connection = cnn;
            SqlDataReader dr_dsnv = cmd.ExecuteReader();
            DataTable dt_dsnv = new DataTable();
            dt_dsnv.Load(dr_dsnv);
            dgv_dsnv.DataSource = dt_dsnv;
        }

        private void Luong_Thuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void dgv_dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_dsnv.Rows[index];
            tb_MaNV.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void btn_xemLuong_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tb_MaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaNV.Focus();
            }
            else
            {
                string sqlluong = "select * from LSLuong where MaNV = '" + tb_MaNV.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlluong;
                cmd.Connection = cnn;
                SqlDataReader dr_luong = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr_luong);
                dgv_Luong.DataSource = dt;
            }
        }

        private void btn_xemthuong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaNV.Focus();
            }
            else
            {
                string sqlluong = "select * from LSThuong where MaNV = '" + tb_MaNV.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlluong;
                cmd.Connection = cnn;
                SqlDataReader dr_thuong = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr_thuong);
                dgv_thuong.DataSource = dt;
            }
        }
    }
}
