using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN_NguyenTrucPhuong_QuanlydoibongChelsea
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from DangNhap where TenDangNhap = '" + txt_TenDangNhap.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.LayGT(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_TrangChu trangchu = new frm_TrangChu();
                trangchu.Show();
            }
            else MessageBox.Show("Đăng nhập thất bại, sai tên hoặc mật khẩu");

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
