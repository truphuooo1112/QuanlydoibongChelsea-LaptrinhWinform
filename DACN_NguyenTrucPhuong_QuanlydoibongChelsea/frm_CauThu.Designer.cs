namespace DACN_NguyenTrucPhuong_QuanlydoibongChelsea
{
    partial class frm_CauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CauThu));
            this.lb_MaCauThu = new System.Windows.Forms.Label();
            this.lb_TenCauThu = new System.Windows.Forms.Label();
            this.lb_SoAo = new System.Windows.Forms.Label();
            this.lb_ViTri = new System.Windows.Forms.Label();
            this.lb_NgayGiaNhap = new System.Windows.Forms.Label();
            this.lb_Luong = new System.Windows.Forms.Label();
            this.lb_MaDoi = new System.Windows.Forms.Label();
            this.txt_MaCauThu = new System.Windows.Forms.TextBox();
            this.txt_TenCauThu = new System.Windows.Forms.TextBox();
            this.txt_SoAo = new System.Windows.Forms.TextBox();
            this.txt_MaDoi = new System.Windows.Forms.MaskedTextBox();
            this.txt_ViTri = new System.Windows.Forms.MaskedTextBox();
            this.txt_Luong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.date_NgayGiaNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaCauThu
            // 
            this.lb_MaCauThu.AutoSize = true;
            this.lb_MaCauThu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_MaCauThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaCauThu.Location = new System.Drawing.Point(52, 26);
            this.lb_MaCauThu.Name = "lb_MaCauThu";
            this.lb_MaCauThu.Size = new System.Drawing.Size(94, 19);
            this.lb_MaCauThu.TabIndex = 0;
            this.lb_MaCauThu.Text = "Mã Cầu Thủ";
            // 
            // lb_TenCauThu
            // 
            this.lb_TenCauThu.AutoSize = true;
            this.lb_TenCauThu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_TenCauThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCauThu.Location = new System.Drawing.Point(50, 87);
            this.lb_TenCauThu.Name = "lb_TenCauThu";
            this.lb_TenCauThu.Size = new System.Drawing.Size(96, 19);
            this.lb_TenCauThu.TabIndex = 7;
            this.lb_TenCauThu.Text = "Tên Cầu Thủ";
            // 
            // lb_SoAo
            // 
            this.lb_SoAo.AutoSize = true;
            this.lb_SoAo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_SoAo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoAo.Location = new System.Drawing.Point(52, 159);
            this.lb_SoAo.Name = "lb_SoAo";
            this.lb_SoAo.Size = new System.Drawing.Size(49, 19);
            this.lb_SoAo.TabIndex = 8;
            this.lb_SoAo.Text = "Số Áo";
            this.lb_SoAo.Click += new System.EventHandler(this.lb_SoAo_Click);
            // 
            // lb_ViTri
            // 
            this.lb_ViTri.AutoSize = true;
            this.lb_ViTri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_ViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ViTri.Location = new System.Drawing.Point(569, 26);
            this.lb_ViTri.Name = "lb_ViTri";
            this.lb_ViTri.Size = new System.Drawing.Size(47, 19);
            this.lb_ViTri.TabIndex = 9;
            this.lb_ViTri.Text = "Vị Trí";
            // 
            // lb_NgayGiaNhap
            // 
            this.lb_NgayGiaNhap.AutoSize = true;
            this.lb_NgayGiaNhap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_NgayGiaNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayGiaNhap.Location = new System.Drawing.Point(396, 156);
            this.lb_NgayGiaNhap.Name = "lb_NgayGiaNhap";
            this.lb_NgayGiaNhap.Size = new System.Drawing.Size(113, 19);
            this.lb_NgayGiaNhap.TabIndex = 10;
            this.lb_NgayGiaNhap.Text = "Ngày Gia Nhập";
            this.lb_NgayGiaNhap.Click += new System.EventHandler(this.lb_NgayGiaNhap_Click);
            // 
            // lb_Luong
            // 
            this.lb_Luong.AutoSize = true;
            this.lb_Luong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_Luong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Luong.Location = new System.Drawing.Point(403, 89);
            this.lb_Luong.Name = "lb_Luong";
            this.lb_Luong.Size = new System.Drawing.Size(54, 19);
            this.lb_Luong.TabIndex = 11;
            this.lb_Luong.Text = "Lương";
            // 
            // lb_MaDoi
            // 
            this.lb_MaDoi.AutoSize = true;
            this.lb_MaDoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_MaDoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDoi.Location = new System.Drawing.Point(396, 26);
            this.lb_MaDoi.Name = "lb_MaDoi";
            this.lb_MaDoi.Size = new System.Drawing.Size(61, 19);
            this.lb_MaDoi.TabIndex = 12;
            this.lb_MaDoi.Text = "Mã Đội";
            // 
            // txt_MaCauThu
            // 
            this.txt_MaCauThu.Location = new System.Drawing.Point(152, 25);
            this.txt_MaCauThu.Name = "txt_MaCauThu";
            this.txt_MaCauThu.Size = new System.Drawing.Size(238, 20);
            this.txt_MaCauThu.TabIndex = 13;
            // 
            // txt_TenCauThu
            // 
            this.txt_TenCauThu.Location = new System.Drawing.Point(152, 87);
            this.txt_TenCauThu.Name = "txt_TenCauThu";
            this.txt_TenCauThu.Size = new System.Drawing.Size(238, 20);
            this.txt_TenCauThu.TabIndex = 14;
            // 
            // txt_SoAo
            // 
            this.txt_SoAo.Location = new System.Drawing.Point(152, 158);
            this.txt_SoAo.Name = "txt_SoAo";
            this.txt_SoAo.Size = new System.Drawing.Size(238, 20);
            this.txt_SoAo.TabIndex = 15;
            // 
            // txt_MaDoi
            // 
            this.txt_MaDoi.Location = new System.Drawing.Point(463, 25);
            this.txt_MaDoi.Name = "txt_MaDoi";
            this.txt_MaDoi.Size = new System.Drawing.Size(100, 20);
            this.txt_MaDoi.TabIndex = 16;
            // 
            // txt_ViTri
            // 
            this.txt_ViTri.Location = new System.Drawing.Point(622, 25);
            this.txt_ViTri.Name = "txt_ViTri";
            this.txt_ViTri.Size = new System.Drawing.Size(100, 20);
            this.txt_ViTri.TabIndex = 17;
            // 
            // txt_Luong
            // 
            this.txt_Luong.Location = new System.Drawing.Point(463, 88);
            this.txt_Luong.Name = "txt_Luong";
            this.txt_Luong.Size = new System.Drawing.Size(259, 20);
            this.txt_Luong.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 136);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(88, 194);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 35);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm Cầu Thủ";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(259, 194);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 35);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa Cầu Thủ";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(432, 194);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 35);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Sa thải cầu thủ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // date_NgayGiaNhap
            // 
            this.date_NgayGiaNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayGiaNhap.Location = new System.Drawing.Point(518, 157);
            this.date_NgayGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.date_NgayGiaNhap.Name = "date_NgayGiaNhap";
            this.date_NgayGiaNhap.Size = new System.Drawing.Size(204, 20);
            this.date_NgayGiaNhap.TabIndex = 24;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(594, 194);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(115, 35);
            this.btn_Dong.TabIndex = 25;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_CauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(748, 377);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.date_NgayGiaNhap);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Luong);
            this.Controls.Add(this.txt_ViTri);
            this.Controls.Add(this.txt_MaDoi);
            this.Controls.Add(this.txt_SoAo);
            this.Controls.Add(this.txt_TenCauThu);
            this.Controls.Add(this.txt_MaCauThu);
            this.Controls.Add(this.lb_MaDoi);
            this.Controls.Add(this.lb_Luong);
            this.Controls.Add(this.lb_NgayGiaNhap);
            this.Controls.Add(this.lb_ViTri);
            this.Controls.Add(this.lb_SoAo);
            this.Controls.Add(this.lb_TenCauThu);
            this.Controls.Add(this.lb_MaCauThu);
            this.Name = "frm_CauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Cầu Thủ";
            this.Load += new System.EventHandler(this.frm_DanhSachCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaCauThu;
        private System.Windows.Forms.Label lb_TenCauThu;
        private System.Windows.Forms.Label lb_SoAo;
        private System.Windows.Forms.Label lb_ViTri;
        private System.Windows.Forms.Label lb_NgayGiaNhap;
        private System.Windows.Forms.Label lb_Luong;
        private System.Windows.Forms.Label lb_MaDoi;
        private System.Windows.Forms.TextBox txt_MaCauThu;
        private System.Windows.Forms.TextBox txt_TenCauThu;
        private System.Windows.Forms.TextBox txt_SoAo;
        private System.Windows.Forms.MaskedTextBox txt_MaDoi;
        private System.Windows.Forms.MaskedTextBox txt_ViTri;
        private System.Windows.Forms.TextBox txt_Luong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DateTimePicker date_NgayGiaNhap;
        private System.Windows.Forms.Button btn_Dong;
    }
}