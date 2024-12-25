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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            string sql = "Select * from KhachHang";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Text = dataGridView1.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            txt_TenKhachHang.Text = dataGridView1.CurrentRow.Cells["TenKhachHang"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KhachHang values ('" + txt_MaKhachHang.Text + "','" + txt_TenKhachHang.Text + "','" + txt_DiaChi.Text + "'," + txt_SDT.Text + ")";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Khách hàng thành công");
            else MessageBox.Show("Thêm Khách hàng thất bại");
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE KhachHang SET MaKhachHang = '" + txt_MaKhachHang.Text +
                         "',TenKhachHang = '" + txt_TenKhachHang.Text +
                         "', DiaChi = '" + txt_DiaChi.Text +
                         "', DienThoai = '" + txt_SDT.Text +
                         "'WHERE MaKhachHang = '" + txt_MaKhachHang.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật Khách hàng thành công");
            else
                MessageBox.Show("Cập nhật Khách hàng thất bại");
        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            string sql = "Delete KhachHang where MaKhachHang = '" + txt_MaKhachHang.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa Khách hàng thành công");
            else MessageBox.Show("Xóa Khách hàng thất bại");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
