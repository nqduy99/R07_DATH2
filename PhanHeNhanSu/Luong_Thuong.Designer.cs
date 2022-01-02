
namespace R07_DATH2.PhanHeNhanSu
{
    partial class Luong_Thuong
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
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Luong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_thuong = new System.Windows.Forms.DataGridView();
            this.btn_xemLuong = new System.Windows.Forms.Button();
            this.btn_xemthuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(145, 34);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(100, 22);
            this.tb_MaNV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Location = new System.Drawing.Point(20, 21);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(946, 89);
            this.dgv_dsnv.TabIndex = 4;
            this.dgv_dsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgv_dsnv);
            this.groupBox1.Location = new System.Drawing.Point(40, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên và lương hiện tại";
            // 
            // dgv_Luong
            // 
            this.dgv_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luong.Location = new System.Drawing.Point(22, 18);
            this.dgv_Luong.Name = "dgv_Luong";
            this.dgv_Luong.RowHeadersWidth = 51;
            this.dgv_Luong.RowTemplate.Height = 24;
            this.dgv_Luong.Size = new System.Drawing.Size(446, 220);
            this.dgv_Luong.TabIndex = 6;
            this.dgv_Luong.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btn_xemLuong);
            this.groupBox2.Controls.Add(this.dgv_Luong);
            this.groupBox2.Location = new System.Drawing.Point(38, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 289);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử lương";
            this.groupBox2.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_xemthuong);
            this.groupBox3.Controls.Add(this.dgv_thuong);
            this.groupBox3.Location = new System.Drawing.Point(536, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 289);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch sử thưởng";
            this.groupBox3.UseWaitCursor = true;
            // 
            // dgv_thuong
            // 
            this.dgv_thuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thuong.Location = new System.Drawing.Point(22, 18);
            this.dgv_thuong.Name = "dgv_thuong";
            this.dgv_thuong.RowHeadersWidth = 51;
            this.dgv_thuong.RowTemplate.Height = 24;
            this.dgv_thuong.Size = new System.Drawing.Size(446, 220);
            this.dgv_thuong.TabIndex = 6;
            this.dgv_thuong.UseWaitCursor = true;
            // 
            // btn_xemLuong
            // 
            this.btn_xemLuong.Location = new System.Drawing.Point(22, 244);
            this.btn_xemLuong.Name = "btn_xemLuong";
            this.btn_xemLuong.Size = new System.Drawing.Size(75, 39);
            this.btn_xemLuong.TabIndex = 7;
            this.btn_xemLuong.Text = "Xem";
            this.btn_xemLuong.UseVisualStyleBackColor = true;
            this.btn_xemLuong.Click += new System.EventHandler(this.btn_xemLuong_Click);
            // 
            // btn_xemthuong
            // 
            this.btn_xemthuong.Location = new System.Drawing.Point(22, 244);
            this.btn_xemthuong.Name = "btn_xemthuong";
            this.btn_xemthuong.Size = new System.Drawing.Size(75, 39);
            this.btn_xemthuong.TabIndex = 8;
            this.btn_xemthuong.Text = "Xem";
            this.btn_xemthuong.UseVisualStyleBackColor = true;
            this.btn_xemthuong.Click += new System.EventHandler(this.btn_xemthuong_Click);
            // 
            // Luong_Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.label1);
            this.Name = "Luong_Thuong";
            this.Text = "Luong_Thuong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Luong_Thuong_FormClosing);
            this.Load += new System.EventHandler(this.Luong_Thuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Luong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_thuong;
        private System.Windows.Forms.Button btn_xemLuong;
        private System.Windows.Forms.Button btn_xemthuong;
    }
}