namespace DACN_NguyenTrucPhuong_QuanlydoibongChelsea
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(216, 97);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(242, 20);
            this.txt_TenDangNhap.TabIndex = 3;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(216, 142);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(242, 20);
            this.txt_MatKhau.TabIndex = 4;
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangNhap.Location = new System.Drawing.Point(85, 96);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(107, 19);
            this.lb_DangNhap.TabIndex = 5;
            this.lb_DangNhap.Text = "Tên đăng nhập";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(85, 141);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(75, 19);
            this.lb_MatKhau.TabIndex = 6;
            this.lb_MatKhau.Text = "Mật khẩu";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(170, 203);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(98, 31);
            this.btn_DangNhap.TabIndex = 7;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(309, 203);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 31);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Name = "frm_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

