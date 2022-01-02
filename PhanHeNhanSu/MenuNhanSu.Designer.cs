
namespace R07_DATH2.PhanHeNhanSu
{
    partial class MenuNhanSu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_doanhso = new System.Windows.Forms.Button();
            this.btn_thongkeDH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_doanhso);
            this.groupBox2.Controls.Add(this.btn_thongkeDH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vui lòng chọn chức năng muốn thực hiện!!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(487, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lương - Thưởng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_doanhso
            // 
            this.btn_doanhso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_doanhso.Location = new System.Drawing.Point(260, 212);
            this.btn_doanhso.Name = "btn_doanhso";
            this.btn_doanhso.Size = new System.Drawing.Size(169, 33);
            this.btn_doanhso.TabIndex = 2;
            this.btn_doanhso.Text = "Doanh số theo nhân viên";
            this.btn_doanhso.UseVisualStyleBackColor = false;
            this.btn_doanhso.Click += new System.EventHandler(this.btn_doanhso_Click);
            // 
            // btn_thongkeDH
            // 
            this.btn_thongkeDH.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_thongkeDH.Location = new System.Drawing.Point(45, 212);
            this.btn_thongkeDH.Name = "btn_thongkeDH";
            this.btn_thongkeDH.Size = new System.Drawing.Size(143, 33);
            this.btn_thongkeDH.TabIndex = 1;
            this.btn_thongkeDH.Text = "Thống kê đơn hàng";
            this.btn_thongkeDH.UseVisualStyleBackColor = false;
            this.btn_thongkeDH.Click += new System.EventHandler(this.btn_thongkeDH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // MenuNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuNhanSu";
            this.Text = "MenuNhanSu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_doanhso;
        private System.Windows.Forms.Button btn_thongkeDH;
        private System.Windows.Forms.Label label1;
    }
}