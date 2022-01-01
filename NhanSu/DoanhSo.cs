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

namespace R07_DATH2.NhanSu
{
    public partial class DoanhSo : Form
    {
        public DoanhSo()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void DoanhSo_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["DoAnTH2"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();

            string sqldsnv = "select MaNV, HoTen_NV, ChucVu, NgSinh_NV, DienThoai_NV from NhanVien ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqldsnv;
            cmd.Connection = cnn;
            SqlDataReader dr_dsnv = cmd.ExecuteReader();
            DataTable dt_dsnv = new DataTable();
            dt_dsnv.Load(dr_dsnv);
            dgv_dsnv.DataSource = dt_dsnv;

            cbb_Loai.Items.Add("Ngày");
            cbb_Loai.Items.Add("Tháng");
            cbb_Loai.Items.Add("Năm");
        }

        private void DoanhSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void dgv_dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_dsnv.Rows[index];
            tb_MaNV.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void btn_xemdso_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbb_Loai.Text))
            {
                if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                {
                    string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien from DonHang group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlselect;
                    cmd.Connection = cnn;
                    SqlDataReader dr_doanhso = cmd.ExecuteReader();
                    DataTable dt_doanhso = new DataTable();
                    dt_doanhso.Load(dr_doanhso);
                    dgv_doanhso.DataSource = dt_doanhso;
                }
                else
                {
                    string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien from DonHang group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV where nv.MaNV = '" + tb_MaNV.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlselect;
                    cmd.Connection = cnn;
                    SqlDataReader dr_doanhso = cmd.ExecuteReader();
                    DataTable dt_doanhso = new DataTable();
                    dt_doanhso.Load(dr_doanhso);
                    dgv_doanhso.DataSource = dt_doanhso;
                }
            }
            else
            {
                if(cbb_Loai.SelectedIndex == 0) // ngay
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien, from DonHang where NgayLap = '"+dtp_ngay.Value.Year + "-" + dtp_ngay.Value.Month + "-" + dtp_ngay.Value.Day + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                    else
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien from DonHang where NgayLap = '" + dtp_ngay.Value.Year + "-" + dtp_ngay.Value.Month + "-" + dtp_ngay.Value.Day + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV where nv.MaNV = '" + tb_MaNV.Text + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                }
                if(cbb_Loai.SelectedIndex == 1) // thang
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien, from DonHang where month(NgayLap = '" + dtp_ngay.Value.Month + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                    else
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien from DonHang where month(NgayLap) = '" + dtp_ngay.Value.Month + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV where nv.MaNV = '" + tb_MaNV.Text + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                }
                if (cbb_Loai.SelectedIndex == 2) // nam
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien, from DonHang where year(NgayLap) = '" + dtp_ngay.Value.Year + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                    else
                    {
                        string sqlselect = "select distinct nv.MaNV, nv.HoTen_NV,s.TongTien from(select MaNV, sum(TongTien) as TongTien from DonHang where year(NgayLap) = '" + dtp_ngay.Value.Year + "' group by MaNV) as s join NhanVien nv on s.MaNV = nv.MaNV where nv.MaNV = '" + tb_MaNV.Text + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_doanhso = cmd.ExecuteReader();
                        DataTable dt_doanhso = new DataTable();
                        dt_doanhso.Load(dr_doanhso);
                        dgv_doanhso.DataSource = dt_doanhso;
                    }
                }
            }
            
        }

        private void btn_xemCT_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbb_Loai.Text))
            {
                if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_MaNV.Focus();
                }
                else
                {
                    string sqlselect = "select MaNV, MaDH, NgayLap, TongTien from DonHang where MaNV = '" + tb_MaNV.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlselect;
                    cmd.Connection = cnn;
                    SqlDataReader dr_chitiet = cmd.ExecuteReader();
                    DataTable dt_chitiet = new DataTable();
                    dt_chitiet.Load(dr_chitiet);
                    dgv_chitiet.DataSource = dt_chitiet;
                }
            }
            else
            {
                if(cbb_Loai.SelectedIndex == 0) // ngay
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_MaNV.Focus();
                    }
                    else
                    {
                        string sqlselect = "select MaNV, MaDH, NgayLap, TongTien from DonHang where MaNV = '" + tb_MaNV.Text + "' and NgayLap = '" + dtp_ngay.Value.Year + "-" + dtp_ngay.Value.Month + "-" + dtp_ngay.Value.Day + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_chitiet = cmd.ExecuteReader();
                        DataTable dt_chitiet = new DataTable();
                        dt_chitiet.Load(dr_chitiet);
                        dgv_chitiet.DataSource = dt_chitiet;
                    }
                }
                if (cbb_Loai.SelectedIndex == 1) // thang
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_MaNV.Focus();
                    }
                    else
                    {
                        string sqlselect = "select MaNV, MaDH, NgayLap, TongTien from DonHang where MaNV = '" + tb_MaNV.Text + "' and month(NgayLap) = '" + dtp_ngay.Value.Month + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_chitiet = cmd.ExecuteReader();
                        DataTable dt_chitiet = new DataTable();
                        dt_chitiet.Load(dr_chitiet);
                        dgv_chitiet.DataSource = dt_chitiet;
                    }
                }
                if (cbb_Loai.SelectedIndex == 2) // nam
                {
                    if (string.IsNullOrWhiteSpace(tb_MaNV.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_MaNV.Focus();
                    }
                    else
                    {
                        string sqlselect = "select MaNV, MaDH, NgayLap, TongTien from DonHang where MaNV = '" + tb_MaNV.Text + "' and year(NgayLap) = '" + dtp_ngay.Value.Year + "'";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = sqlselect;
                        cmd.Connection = cnn;
                        SqlDataReader dr_chitiet = cmd.ExecuteReader();
                        DataTable dt_chitiet = new DataTable();
                        dt_chitiet.Load(dr_chitiet);
                        dgv_chitiet.DataSource = dt_chitiet;
                    }
                }
            }
            
        }
    }
}
