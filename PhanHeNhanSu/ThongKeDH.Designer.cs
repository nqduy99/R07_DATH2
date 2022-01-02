
namespace R07_DATH2.PhanHeNhanSu
{
    partial class ThongKeDH
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
            this.btn_xem = new System.Windows.Forms.Button();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_nam = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.cbb_Thang = new System.Windows.Forms.ComboBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xem.Location = new System.Drawing.Point(317, 334);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(61, 27);
            this.btn_xem.TabIndex = 7;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(36, 30);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.Size = new System.Drawing.Size(535, 187);
            this.dgv_thongke.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tb_nam);
            this.groupBox1.Controls.Add(this.lb_nam);
            this.groupBox1.Controls.Add(this.cbb_Thang);
            this.groupBox1.Controls.Add(this.lb_thang);
            this.groupBox1.Controls.Add(this.dtp_Ngay);
            this.groupBox1.Controls.Add(this.lb_ngay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_Loai);
            this.groupBox1.Location = new System.Drawing.Point(36, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(237, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tb_nam
            // 
            this.tb_nam.Location = new System.Drawing.Point(100, 113);
            this.tb_nam.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(76, 20);
            this.tb_nam.TabIndex = 7;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(5, 113);
            this.lb_nam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(66, 15);
            this.lb_nam.TabIndex = 6;
            this.lb_nam.Text = "Chọn năm:";
            // 
            // cbb_Thang
            // 
            this.cbb_Thang.FormattingEnabled = true;
            this.cbb_Thang.Location = new System.Drawing.Point(100, 84);
            this.cbb_Thang.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Thang.Name = "cbb_Thang";
            this.cbb_Thang.Size = new System.Drawing.Size(110, 21);
            this.cbb_Thang.TabIndex = 5;
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.Location = new System.Drawing.Point(5, 84);
            this.lb_thang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(73, 15);
            this.lb_thang.TabIndex = 4;
            this.lb_thang.Text = "Chọn tháng:";
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(100, 53);
            this.dtp_Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(110, 20);
            this.dtp_Ngay.TabIndex = 3;
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(5, 53);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(68, 15);
            this.lb_ngay.TabIndex = 2;
            this.lb_ngay.Text = "Chọn ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo:";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(100, 22);
            this.cbb_Loai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(110, 21);
            this.cbb_Loai.TabIndex = 0;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuayLai.Location = new System.Drawing.Point(499, 334);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(61, 27);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ThongKeDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKeDH";
            this.Text = "ThongKeDH";
            this.Load += new System.EventHandler(this.ThongKeDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nam;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.ComboBox cbb_Thang;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.Button btnQuayLai;
    }
}