
namespace R07_DATH2.QuanLySanPham
{
    partial class MenuSanPham
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btn_XemDSSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLSP,
            this.QLNhanSu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QLSP
            // 
            this.QLSP.Name = "QLSP";
            this.QLSP.Size = new System.Drawing.Size(116, 20);
            this.QLSP.Text = "Quản lý Sản Phẩm";
            this.QLSP.Click += new System.EventHandler(this.QLSP_Click);
            // 
            // QLNhanSu
            // 
            this.QLNhanSu.Name = "QLNhanSu";
            this.QLNhanSu.Size = new System.Drawing.Size(107, 20);
            this.QLNhanSu.Text = "Quản lý Nhân sự";
            this.QLNhanSu.Click += new System.EventHandler(this.QLNhanSu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(545, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCapNhatSP);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.btn_XemDSSP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(501, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThoat.Location = new System.Drawing.Point(298, 194);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 27);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vui lòng chọn chức năng muốn thực hiện!!";
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCapNhatSP.Location = new System.Drawing.Point(105, 194);
            this.btnCapNhatSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(147, 27);
            this.btnCapNhatSP.TabIndex = 3;
            this.btnCapNhatSP.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSP.UseVisualStyleBackColor = false;
            this.btnCapNhatSP.Click += new System.EventHandler(this.btnCapNhatSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThemSP.Location = new System.Drawing.Point(267, 151);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(141, 27);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btn_XemDSSP
            // 
            this.btn_XemDSSP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_XemDSSP.Location = new System.Drawing.Point(105, 151);
            this.btn_XemDSSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XemDSSP.Name = "btn_XemDSSP";
            this.btn_XemDSSP.Size = new System.Drawing.Size(147, 27);
            this.btn_XemDSSP.TabIndex = 1;
            this.btn_XemDSSP.Text = "Xem danh sách sản phẩm";
            this.btn_XemDSSP.UseVisualStyleBackColor = false;
            this.btn_XemDSSP.Click += new System.EventHandler(this.btn_XemDSSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Sản phẩm";
            // 
            // MenuSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuSanPham";
            this.Text = "MenuSanPham";
            this.Load += new System.EventHandler(this.MenuSanPham_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QLSP;
        private System.Windows.Forms.ToolStripMenuItem QLNhanSu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btn_XemDSSP;
        private System.Windows.Forms.Label label1;
    }
}