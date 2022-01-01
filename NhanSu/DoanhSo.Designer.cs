
namespace R07_DATH2.NhanSu
{
    partial class DoanhSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.dgv_doanhso = new System.Windows.Forms.DataGridView();
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.btn_xemdso = new System.Windows.Forms.Button();
            this.gbox_doanhso = new System.Windows.Forms.GroupBox();
            this.gbox_dsnv = new System.Windows.Forms.GroupBox();
            this.btn_xemCT = new System.Windows.Forms.Button();
            this.gbox_ct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            this.gbox_doanhso.SuspendLayout();
            this.gbox_ct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Location = new System.Drawing.Point(62, 33);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(97, 17);
            this.lb_MaNV.TabIndex = 0;
            this.lb_MaNV.Text = "Mã nhân viên:";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(161, 33);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(100, 22);
            this.tb_MaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê theo:";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(397, 33);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(146, 24);
            this.cbb_Loai.TabIndex = 3;
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Location = new System.Drawing.Point(62, 95);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(628, 124);
            this.dgv_dsnv.TabIndex = 4;
            this.dgv_dsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnv_CellContentClick);
            // 
            // dgv_doanhso
            // 
            this.dgv_doanhso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhso.Location = new System.Drawing.Point(24, 21);
            this.dgv_doanhso.Name = "dgv_doanhso";
            this.dgv_doanhso.RowHeadersWidth = 51;
            this.dgv_doanhso.RowTemplate.Height = 24;
            this.dgv_doanhso.Size = new System.Drawing.Size(481, 173);
            this.dgv_doanhso.TabIndex = 5;
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Location = new System.Drawing.Point(28, 26);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.RowHeadersWidth = 51;
            this.dgv_chitiet.RowTemplate.Height = 24;
            this.dgv_chitiet.Size = new System.Drawing.Size(545, 334);
            this.dgv_chitiet.TabIndex = 6;
            // 
            // btn_xemdso
            // 
            this.btn_xemdso.Location = new System.Drawing.Point(16, 200);
            this.btn_xemdso.Name = "btn_xemdso";
            this.btn_xemdso.Size = new System.Drawing.Size(72, 32);
            this.btn_xemdso.TabIndex = 8;
            this.btn_xemdso.Text = "Xem";
            this.btn_xemdso.UseVisualStyleBackColor = true;
            this.btn_xemdso.Click += new System.EventHandler(this.btn_xemdso_Click);
            // 
            // gbox_doanhso
            // 
            this.gbox_doanhso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_doanhso.Controls.Add(this.btn_xemdso);
            this.gbox_doanhso.Controls.Add(this.dgv_doanhso);
            this.gbox_doanhso.Location = new System.Drawing.Point(38, 235);
            this.gbox_doanhso.Name = "gbox_doanhso";
            this.gbox_doanhso.Size = new System.Drawing.Size(526, 242);
            this.gbox_doanhso.TabIndex = 9;
            this.gbox_doanhso.TabStop = false;
            this.gbox_doanhso.Text = "Doanh số bán hàng của nhân viên";
            // 
            // gbox_dsnv
            // 
            this.gbox_dsnv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_dsnv.Location = new System.Drawing.Point(38, 68);
            this.gbox_dsnv.Name = "gbox_dsnv";
            this.gbox_dsnv.Size = new System.Drawing.Size(671, 161);
            this.gbox_dsnv.TabIndex = 10;
            this.gbox_dsnv.TabStop = false;
            this.gbox_dsnv.Text = "Danh sách nhân viên";
            // 
            // btn_xemCT
            // 
            this.btn_xemCT.Location = new System.Drawing.Point(10, 367);
            this.btn_xemCT.Name = "btn_xemCT";
            this.btn_xemCT.Size = new System.Drawing.Size(72, 32);
            this.btn_xemCT.TabIndex = 11;
            this.btn_xemCT.Text = "Xem";
            this.btn_xemCT.UseVisualStyleBackColor = true;
            this.btn_xemCT.Click += new System.EventHandler(this.btn_xemCT_Click);
            // 
            // gbox_ct
            // 
            this.gbox_ct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_ct.Controls.Add(this.btn_xemCT);
            this.gbox_ct.Controls.Add(this.dgv_chitiet);
            this.gbox_ct.Location = new System.Drawing.Point(715, 69);
            this.gbox_ct.Name = "gbox_ct";
            this.gbox_ct.Size = new System.Drawing.Size(593, 408);
            this.gbox_ct.TabIndex = 12;
            this.gbox_ct.TabStop = false;
            this.gbox_ct.Text = "Xem chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn ngày:";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay.Location = new System.Drawing.Point(676, 33);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(121, 22);
            this.dtp_ngay.TabIndex = 14;
            this.dtp_ngay.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            // 
            // DoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 550);
            this.Controls.Add(this.dtp_ngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbox_ct);
            this.Controls.Add(this.gbox_doanhso);
            this.Controls.Add(this.dgv_dsnv);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.lb_MaNV);
            this.Controls.Add(this.gbox_dsnv);
            this.Name = "DoanhSo";
            this.Text = "DoanhSo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoanhSo_FormClosing);
            this.Load += new System.EventHandler(this.DoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            this.gbox_doanhso.ResumeLayout(false);
            this.gbox_ct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.DataGridView dgv_doanhso;
        private System.Windows.Forms.DataGridView dgv_chitiet;
        private System.Windows.Forms.Button btn_xemdso;
        private System.Windows.Forms.GroupBox gbox_doanhso;
        private System.Windows.Forms.GroupBox gbox_dsnv;
        private System.Windows.Forms.Button btn_xemCT;
        private System.Windows.Forms.GroupBox gbox_ct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
    }
}