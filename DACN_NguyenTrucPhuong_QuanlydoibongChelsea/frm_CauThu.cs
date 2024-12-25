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
    public partial class frm_CauThu : Form
    {
        public frm_CauThu()
        {
            InitializeComponent();
        }

        private void lb_NgayGiaNhap_Click(object sender, EventArgs e)
        {

        }

        private void lb_SoAo_Click(object sender, EventArgs e)
        {

        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_Them_Click(object sender, EventArgs e)
        {

            string sql = "Insert into CauThu values ('" + txt_MaCauThu.Text + "','" + txt_TenCauThu.Text + "','" + txt_SoAo.Text + "','" + txt_ViTri.Text + "','" + date_NgayGiaNhap.Text + "','" + txt_Luong.Text + "','" + txt_MaDoi.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm cầu thủ thành công");
            else MessageBox.Show("Thêm cầu thủ  thất bại");
        }

        private void frm_DanhSachCauThu_Load(object sender, EventArgs e)
        {
            string sql = "Select * from CauThu";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaCauThu.Text = dataGridView1.CurrentRow.Cells["MaCauThu"].Value.ToString();
            txt_TenCauThu.Text = dataGridView1.CurrentRow.Cells["TenCauThu"].Value.ToString();
            txt_SoAo.Text = dataGridView1.CurrentRow.Cells["SoAo"].Value.ToString();
            txt_ViTri.Text = dataGridView1.CurrentRow.Cells["ViTri"].Value.ToString();
            date_NgayGiaNhap.Text = dataGridView1.CurrentRow.Cells["NgayGiaNhap"].Value.ToString();
            txt_Luong.Text = dataGridView1.CurrentRow.Cells["Luong"].Value.ToString();
            txt_MaDoi.Text = dataGridView1.CurrentRow.Cells["MaDoi"].Value.ToString();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CauThu SET MaCauThu = '" + txt_MaCauThu.Text +
                         "',TenCauThu = '" + txt_TenCauThu.Text +
                         "', SoAo = '" + txt_SoAo.Text +
                         "', ViTri = '" + txt_ViTri.Text +
                         "', NgayGiaNhap = '" + date_NgayGiaNhap.Text +
                         "', Luong = '" + txt_Luong.Text +
                         "', MaDoi = '" + txt_MaDoi.Text +
                         "' WHERE MaCauThu = '" + txt_MaCauThu.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật cầu thủ thành công");
            else
                MessageBox.Show("Cập nhật cầu thủ thất bại");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete CauThu where MaCauThu = '" + txt_MaCauThu.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sa thải cầu thủ thành công");
            else MessageBox.Show("Sa thải cầu thủ thất bại");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
