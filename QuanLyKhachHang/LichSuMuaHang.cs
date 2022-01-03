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
    public partial class LichSuMuaHang : Form
    {
        public LichSuMuaHang()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonHang d", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Donhang");
            dgvLichSuMuaHang.DataSource = ds.Tables["Donhang"].DefaultView;

        }

        private void btnExitToAdmin_Click(object sender, EventArgs e)
        {
            MenuKhachHang mnkh = new MenuKhachHang();
            mnkh.Activate();
            mnkh.Show();
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "select * from DonHang d where d.MaKH = '" + txtTimKiemTen.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlTimKiem;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvLichSuMuaHang.DataSource = dt;
        }
    }
}
