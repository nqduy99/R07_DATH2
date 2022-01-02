
namespace R07_DATH2.QuanLyKhachHang
{
    partial class LichSuMuaHang
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
            this.btnExitToAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitToAdmin
            // 
            this.btnExitToAdmin.Location = new System.Drawing.Point(452, 261);
            this.btnExitToAdmin.Name = "btnExitToAdmin";
            this.btnExitToAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnExitToAdmin.TabIndex = 10;
            this.btnExitToAdmin.Text = "Quay Lại";
            this.btnExitToAdmin.UseVisualStyleBackColor = true;
            this.btnExitToAdmin.Click += new System.EventHandler(this.btnExitToAdmin_Click);
            // 
            // LichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExitToAdmin);
            this.Name = "LichSuMuaHang";
            this.Text = "LichSuMuaHang";
            this.Load += new System.EventHandler(this.LichSuMuaHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitToAdmin;
    }
}