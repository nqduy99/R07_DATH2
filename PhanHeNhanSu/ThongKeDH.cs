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
    public partial class ThongKeDH : Form
    {
        public ThongKeDH()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void ThongKeDH_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(200, 100);
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();

            cbb_Loai.Items.Add("Ngày");
            cbb_Loai.Items.Add("Tháng");
            cbb_Loai.Items.Add("Năm");

            cbb_Thang.Items.Add("1");
            cbb_Thang.Items.Add("2");
            cbb_Thang.Items.Add("3");
            cbb_Thang.Items.Add("4");
            cbb_Thang.Items.Add("5");
            cbb_Thang.Items.Add("6");
            cbb_Thang.Items.Add("7");
            cbb_Thang.Items.Add("8");
            cbb_Thang.Items.Add("9");
            cbb_Thang.Items.Add("10");
            cbb_Thang.Items.Add("11");
            cbb_Thang.Items.Add("12");
        }

        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Loai.SelectedIndex == 0) // ngày
            {
                lb_ngay.Show();
                dtp_Ngay.Show();
                lb_thang.Hide();
                cbb_Thang.Hide();
                lb_nam.Hide();
                tb_nam.Hide();
            }
            if (cbb_Loai.SelectedIndex == 1) // tháng
            {
                lb_ngay.Hide();
                dtp_Ngay.Hide();
                lb_thang.Show();
                cbb_Thang.Show();
                lb_nam.Show();
                tb_nam.Show();
            }
            if (cbb_Loai.SelectedIndex == 2) // nam
            {
                lb_ngay.Hide();
                dtp_Ngay.Hide();
                lb_thang.Hide();
                cbb_Thang.Hide();
                lb_nam.Show();
                tb_nam.Show();
            }
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (cbb_Loai.SelectedIndex == 0) // ngày
            {
                string sqlselect_ngay = "select * from DonHang where NgayLap = '" + dtp_Ngay.Value.Year + "-" + dtp_Ngay.Value.Month + "-" + dtp_Ngay.Value.Day + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlselect_ngay;
                cmd.Connection = cnn;
                SqlDataReader dr_day = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr_day);
                dgv_thongke.DataSource = dt;
                dr_day.Close();
            }
            if (cbb_Loai.SelectedIndex == 1) // thang
            {
                string sqlselect_thang = "select * from DonHang where month(NgayLap) = '" + cbb_Thang.Text + "' and year(NgayLap) = '" + tb_nam.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlselect_thang;
                cmd.Connection = cnn;
                SqlDataReader dr_thang = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr_thang);
                dgv_thongke.DataSource = dt;
                dr_thang.Close();
            }
            if (cbb_Loai.SelectedIndex == 2)// nam
            {
                string sqlselect_nam = "select * from DonHang where year(NgayLap) = '" + tb_nam.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlselect_nam;
                cmd.Connection = cnn;
                SqlDataReader dr_nam = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr_nam);
                dgv_thongke.DataSource = dt;
                dr_nam.Close();
            } 
        }
    }
}
