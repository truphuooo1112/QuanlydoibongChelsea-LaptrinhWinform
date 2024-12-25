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
    public partial class frm_LichThiDau : Form
    {
        public frm_LichThiDau()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_LichThiDau_Load(object sender, EventArgs e)
        {
            string sql = "Select * from LichThiDau";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLich.Text = dataGridView1.CurrentRow.Cells["MaLich"].Value.ToString();
            txt_DoiNha.Text = dataGridView1.CurrentRow.Cells["DoiNha"].Value.ToString();
            txt_DoiKhach.Text = dataGridView1.CurrentRow.Cells["DoiKhach"].Value.ToString();
            date_NgayThiDau.Text = dataGridView1.CurrentRow.Cells["NgayThiDau"].Value.ToString();
            txt_SanThiDau.Text = dataGridView1.CurrentRow.Cells["SanThiDau"].Value.ToString();
            cbb_GiaiDau.Text = dataGridView1.CurrentRow.Cells["GiaiThiDau"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into LichThiDau values ('" + txt_MaLich.Text + "','" + txt_DoiNha.Text + "','" + txt_DoiKhach.Text + "','" + date_NgayThiDau.Text + "','" + txt_SanThiDau.Text + "','" + cbb_GiaiDau.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Áo đấu thành công");
            else MessageBox.Show("Thêm Áo đấu  thất bại");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE LichThiDau SET MaLich = '" + txt_MaLich.Text +
                         "',DoiNha = '" + txt_DoiNha.Text +
                         "', DoiKhach = '" + txt_DoiKhach.Text +
                         "', NgayThiDau = '" + date_NgayThiDau.Text +
                         "', SanThiDau = '" + txt_SanThiDau.Text +
                         "' , GiaiThiDau = '" + cbb_GiaiDau.Text +
                         "'WHERE MaLich = '" + txt_MaLich.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật Lịch thi đấu thành công");
            else
                MessageBox.Show("Cập nhật Lịch thi đấu thất bại");
        }

        private void date_NgayThiDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
