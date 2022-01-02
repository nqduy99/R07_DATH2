
namespace R07_DATH2.PhanHeNhanSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.dgv_doanhso = new System.Windows.Forms.DataGridView();
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.btn_xemdoanhso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(116, 28);
            this.tb_MaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(76, 20);
            this.tb_MaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê theo:";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(291, 28);
            this.cbb_Loai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(110, 21);
            this.cbb_Loai.TabIndex = 3;
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay.Location = new System.Drawing.Point(488, 28);
            this.dtp_ngay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(89, 20);
            this.dtp_ngay.TabIndex = 5;
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(422, 28);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(68, 15);
            this.lb_ngay.TabIndex = 4;
            this.lb_ngay.Text = "Chọn ngày:";
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Location = new System.Drawing.Point(18, 17);
            this.dgv_dsnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(371, 151);
            this.dgv_dsnv.TabIndex = 6;
            this.dgv_dsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnv_CellContentClick);
            // 
            // dgv_doanhso
            // 
            this.dgv_doanhso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhso.Location = new System.Drawing.Point(18, 17);
            this.dgv_doanhso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_doanhso.Name = "dgv_doanhso";
            this.dgv_doanhso.RowHeadersWidth = 51;
            this.dgv_doanhso.RowTemplate.Height = 24;
            this.dgv_doanhso.Size = new System.Drawing.Size(371, 147);
            this.dgv_doanhso.TabIndex = 7;
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Location = new System.Drawing.Point(470, 94);
            this.dgv_chitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.RowHeadersWidth = 51;
            this.dgv_chitiet.RowTemplate.Height = 24;
            this.dgv_chitiet.Size = new System.Drawing.Size(412, 265);
            this.dgv_chitiet.TabIndex = 8;
            // 
            // btn_xemdoanhso
            // 
            this.btn_xemdoanhso.Location = new System.Drawing.Point(18, 171);
            this.btn_xemdoanhso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xemdoanhso.Name = "btn_xemdoanhso";
            this.btn_xemdoanhso.Size = new System.Drawing.Size(46, 24);
            this.btn_xemdoanhso.TabIndex = 9;
            this.btn_xemdoanhso.Text = "Xem";
            this.btn_xemdoanhso.UseVisualStyleBackColor = true;
            this.btn_xemdoanhso.Click += new System.EventHandler(this.btn_xemdoanhso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgv_dsnv);
            this.groupBox1.Location = new System.Drawing.Point(22, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 181);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btn_xemdoanhso);
            this.groupBox2.Controls.Add(this.dgv_doanhso);
            this.groupBox2.Location = new System.Drawing.Point(22, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 201);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu của nhân viên";
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Location = new System.Drawing.Point(12, 298);
            this.btn_xemchitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(46, 24);
            this.btn_xemchitiet.TabIndex = 12;
            this.btn_xemchitiet.Text = "Xem";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_xemchitiet);
            this.groupBox3.Location = new System.Drawing.Point(458, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(436, 332);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem chi tiết doanh thu của nhân viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuayLai.Location = new System.Drawing.Point(852, 436);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(61, 27);
            this.btnQuayLai.TabIndex = 14;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // DoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 471);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_chitiet);
            this.Controls.Add(this.dtp_ngay);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoanhSo";
            this.Text = "DoanhSo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoanhSo_FormClosing);
            this.Load += new System.EventHandler(this.DoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.DataGridView dgv_doanhso;
        private System.Windows.Forms.DataGridView dgv_chitiet;
        private System.Windows.Forms.Button btn_xemdoanhso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuayLai;
    }
}