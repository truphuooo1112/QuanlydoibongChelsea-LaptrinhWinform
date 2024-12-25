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
    public partial class frm_TimCauThu : Form
    {
        public frm_TimCauThu()
        {
            InitializeComponent();
        }

        private void Tìm_Kiếm_Cầu_Thủ_Load(object sender, EventArgs e)
        {
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CauThu WHERE 1=1";

            if (!string.IsNullOrEmpty(txt_MaCauThu.Text))
            {
                sql += " AND MaCauThu LIKE '%" + txt_MaCauThu.Text + "%'";
            }

            if (!string.IsNullOrEmpty(txt_TenCauThu.Text))
            {
                sql += " AND TenCauThu LIKE '%" + txt_TenCauThu.Text + "%'";
            }

            if (!string.IsNullOrEmpty(txt_SoAo.Text))
            {
                sql += " AND SoAo LIKE '%" + txt_SoAo.Text + "%'";
            }

            if (!string.IsNullOrEmpty(txt_ViTri.Text))
            {
                sql += " AND ViTri LIKE '%" + txt_ViTri.Text + "%'";
            }

            DataTable dt = lopchung.LoadDL(sql);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cầu thủ phù hợp!");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
