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
    public partial class frm_Doi : Form
    {
        public frm_Doi()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_Doi_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Doi";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDoi.Text = dataGridView1.CurrentRow.Cells["MaDoi"].Value.ToString();
            txt_TenDoi.Text = dataGridView1.CurrentRow.Cells["TenDoi"].Value.ToString();
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Doi values ('" + txt_MaDoi.Text + "','" + txt_TenDoi + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Đội thành công");
            else MessageBox.Show("Thêm Đội  thất bại");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Doi SET MaDoi = '" + txt_MaDoi.Text +
                         "',TenDoi = '" + txt_TenDoi.Text +
                         "' WHERE MaDoi = '" + txt_TenDoi.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật Tên đội thành công");
            else
                MessageBox.Show("Cập nhật Tên đội thất bại");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete Doi where MaDoi = '" + txt_MaDoi.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Giải thể Đội thành công");
            else MessageBox.Show("Giải thể Đội thất bại");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
