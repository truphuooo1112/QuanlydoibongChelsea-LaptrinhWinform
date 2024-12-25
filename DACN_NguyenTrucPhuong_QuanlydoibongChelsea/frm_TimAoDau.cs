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
    public partial class frm_TimAoDau : Form
    {
        public frm_TimAoDau()
        {
            InitializeComponent();
        }

        private void frm_TimAoDau_Load(object sender, EventArgs e)
        {

        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM AoDau WHERE 1=1";

            if (!string.IsNullOrEmpty(txt_MaAo.Text))
            {
                sql += " AND MaAo LIKE '%" + txt_MaAo.Text + "%'";
            }

            if (!string.IsNullOrEmpty(cbb_TenAo.Text))
            {
                sql += " AND TenAo LIKE '%" + cbb_TenAo.Text + "%'";
            }

            if (!string.IsNullOrEmpty(cbb_ChatLieu.Text))
            {
                sql += " AND ChatLieu LIKE '%" + cbb_ChatLieu.Text + "%'";
            }

            DataTable dt = lopchung.LoadDL(sql);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy Aó đấu phù hợp!");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
