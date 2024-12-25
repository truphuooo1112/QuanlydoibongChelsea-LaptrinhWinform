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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVien";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }
        private string LayGioiTinh()
        {
            if (cbx_Nam.Checked) return "Nam";
            else if (cbx_Nu.Checked) return "Nữ";
            else if (cbx_Khac.Checked) return "Khác";
            return "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhanVien.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_TenNhanVien.Text = dataGridView1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            cbx_Nam.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cbx_Nu.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cbx_Khac.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
            date_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhanVien values ('" + txt_MaNhanVien.Text + "','" + txt_TenNhanVien.Text + "','" + LayGioiTinh() + "','" + txt_DiaChi.Text + "','" + txt_SDT.Text + "','" + date_NgaySinh.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Nhân viên thành công");
            else MessageBox.Show("Thêm Nhân viên  thất bại");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NhanVien SET MaNhanVien = '" + txt_MaNhanVien.Text +
                         "',TenNhanVien = '" + txt_TenNhanVien.Text +
                         "', GioiTinh = '" + LayGioiTinh() +
                         "', DiaChi = '" + txt_DiaChi.Text +
                         "', DienThoai = '" + txt_SDT.Text +
                         "' , NgaySinh = '" + date_NgaySinh.Text +
                         "'WHERE MaNhanVien = '" + txt_MaNhanVien.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật Nhân viên thành công");
            else
                MessageBox.Show("Cập nhật Nhân viên thất bại");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NhanVien where MaNhanVien = '" + txt_MaNhanVien.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa Nhân viên thành công");
            else MessageBox.Show("Xóa Nhân viên thất bại");
        }
    }
}
