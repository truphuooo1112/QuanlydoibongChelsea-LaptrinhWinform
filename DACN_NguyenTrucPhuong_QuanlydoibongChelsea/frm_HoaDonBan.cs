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
    public partial class frm_HoaDonBan : Form
    {
        public frm_HoaDonBan()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            string sql = "Select * from HoaDon";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHoaDon.Text = dataGridView1.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            txt_MaAo.Text = dataGridView1.CurrentRow.Cells["MaAo"].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            txt_GiamGia.Text = dataGridView1.CurrentRow.Cells["GiamGia"].Value.ToString();
            txt_ThanhTien.Text = dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();

        }

        private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into HoaDon values ('" + txt_MaHoaDon.Text + "','" + txt_MaAo.Text + "','" + txt_SoLuong.Text + "','" + txt_Gia.Text + "','" + txt_GiamGia.Text + "','" + txt_ThanhTien.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Hóa đơn thành công");
            else MessageBox.Show("Thêm Hóa đơn  thất bại");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HoaDon SET MaHoaDon = '" + txt_MaHoaDon.Text +
                         "',MaAo = '" + txt_MaAo.Text +
                         "',SoLuong = '" + txt_SoLuong.Text +
                         "', Gia = '" + txt_Gia.Text +
                         "',GiamGia = '" + txt_GiamGia.Text +
                         "',ThanhTien = '" + txt_ThanhTien.Text +
                         "'  WHERE MaHoaDon = '" + txt_MaHoaDon.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật Hóa Đơn thành công");
            else
                MessageBox.Show("Cập nhật Hóa đơn thất bại");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Delete HoaDon where MaHoaDon = '" + txt_MaHoaDon.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa Hóa đơn thành công");
            else MessageBox.Show("Xóa hóa đơn thất bại");
        }

    }
}
