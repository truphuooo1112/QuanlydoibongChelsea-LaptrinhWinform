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
    public partial class frm_HLV : Form
    {
        public frm_HLV()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_ThemHLV_Click(object sender, EventArgs e)
        {
            string sql = "Insert into HLV values ('" + txt_MaHLV.Text + "','" + txt_TenHLV.Text + "','" + txt_BoPhan.Text + "','" + date_NgayHLVGiaNhap.Text + "','" + txt_Luong.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm HLV thành công");
            else MessageBox.Show("Thêm HLV  thất bại");
        }

        private void frm_HLV_Load(object sender, EventArgs e)
        {
            string sql = "Select * from HLV";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_SuaHLV_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HLV SET MaHLV = '" + txt_MaHLV.Text +
                         "',TenHLV = '" + txt_TenHLV.Text +
                         "', BoPhan = '" + txt_BoPhan.Text +
                         "', NgayGiaNhap = '" + date_NgayHLVGiaNhap.Text +
                         "', Luong = '" + txt_Luong.Text +
                         "' WHERE MaHLV = '" + txt_MaHLV.Text + "'";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật HLV thành công");
            else
                MessageBox.Show("Cập nhật HLV thất bại");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHLV.Text = dataGridView1.CurrentRow.Cells["MaHLV"].Value.ToString();
            txt_TenHLV.Text = dataGridView1.CurrentRow.Cells["TenHLV"].Value.ToString();
            txt_BoPhan.Text = dataGridView1.CurrentRow.Cells["BoPhan"].Value.ToString();
            date_NgayHLVGiaNhap.Text = dataGridView1.CurrentRow.Cells["NgayGiaNhap"].Value.ToString();
            txt_Luong.Text = dataGridView1.CurrentRow.Cells["Luong"].Value.ToString();

        }

        private void btn_XoaHLV_Click(object sender, EventArgs e)
        {
            string sql = "Delete HLV where MaHLV = '" + txt_MaHLV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sa thải HLV thành công");
            else MessageBox.Show("Sa thải HLV thất bại");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HLV where TenHLV LIKE '%" + txt_TenHLV.Text + "%',MaHLV LIKE '%" + txt_MaHLV.Text + "%'";
            DataTable dt = lopchung.LoadDL(sql);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy Aó đấu phù hợp!");
            }

        }
    }
}
