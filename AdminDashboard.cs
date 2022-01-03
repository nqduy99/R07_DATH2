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
using R07_DATH2.QuanLySanPham;
using R07_DATH2.PhanHeNhanSu;

namespace R07_DATH2
{
    public partial class AdminDashboard : Form
    {
        
        public AdminDashboard()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "SanPham");
            dgvSanPham.DataSource = ds.Tables["SanPham"].DefaultView;
        }

        //private void btnXemSanPham_Click(object sender, EventArgs e)
        //{
        //    string sqlXemSP = "select * from SanPham";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = sqlXemSP;
        //    cmd.Connection = cnn;

        //    cmd.CommandType = CommandType.Text;
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);

        //    dgvSanPham.DataSource = dt;
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            MenuSanPham mnsp = new MenuSanPham();
            mnsp.Activate();
            mnsp.Show();
            this.Hide();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ThemSanPham themsp = new ThemSanPham();
            themsp.Activate();
            themsp.Show();
            this.Hide();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            string sqlXoaSP = "delete from SanPham where TenSP = '" + txtTenSP.Text + "' or MaSP = '" + txtTenSP.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlXoaSP;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvSanPham.DataSource = dt;
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "select * from SanPham where TenSP = '"+txtTenSP.Text+"' or MaSP = '"+ txtTenSP.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlTimKiem;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvSanPham.DataSource = dt;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuSanPham mnsp = new MenuSanPham();
            mnsp.Activate();
            mnsp.Show();
            this.Hide();
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            CapNhatSanPham cnsp = new CapNhatSanPham();
            cnsp.Activate();
            cnsp.Show();
            this.Hide();
        }

        private void QLNhanSu_Click(object sender, EventArgs e)
        {
            MenuNhanSu mnns = new MenuNhanSu();
            mnns.Activate();
            mnns.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AdminDashboard addb = new AdminDashboard();
            addb.Activate();
            addb.Show();
            this.Hide();
        }
    }
}
