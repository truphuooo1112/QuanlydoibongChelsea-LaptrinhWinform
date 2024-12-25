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
    public partial class frm_AoDau : Form
    {
        public frm_AoDau()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_AoDau_Load(object sender, EventArgs e)
        {
            string sql = "Select * from AoDau";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_ThemAo_Click(object sender, EventArgs e)
        {
            string sql = "Insert into AoDau values ('" + txt_MaAo.Text + "','" + cbb_TenAo.Text + "','" + cbb_ChatLieu.Text + "','" + txt_SoLuong.Text + "','" + txt_Gia.Text + "','" + txt_MoTa.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Áo đấu thành công");
            else MessageBox.Show("Thêm Áo đấu  thất bại");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaAo.Text = dataGridView1.CurrentRow.Cells["MaAo"].Value.ToString();
            cbb_TenAo.Text = dataGridView1.CurrentRow.Cells["TenAo"].Value.ToString();
            cbb_ChatLieu.Text = dataGridView1.CurrentRow.Cells["ChatLieu"].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            txt_MoTa.Text = dataGridView1.CurrentRow.Cells["MoTa"].Value.ToString();

        }

        private void btn_SuaAo_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE AoDau SET MaAo = '" + txt_MaAo.Text +
                         "',TenAo = '" + cbb_TenAo.Text +
                         "', ChatLieu = '" + cbb_ChatLieu.Text +
                         "', SoLuong = '" + txt_SoLuong.Text +
                         "', Gia = '" + txt_Gia.Text +
                         "' , MoTa = '" + txt_MoTa.Text +
                         "'WHERE MaAo = '" + txt_MaAo.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật áo đấu thành công");
            else
                MessageBox.Show("Cập nhật áo đấu thất bại");
        }



        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string sql = "Delete AoDau where MaAo = '" + txt_MaAo.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa Áo đấu thành công");
            else MessageBox.Show("Xóa Áo đấu thất bại");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
