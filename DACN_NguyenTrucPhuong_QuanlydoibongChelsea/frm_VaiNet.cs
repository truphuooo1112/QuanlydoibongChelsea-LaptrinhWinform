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
    public partial class frm_VaiNet : Form
    {
        public frm_VaiNet()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TroGiup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TroGiup"] == null)
            {
                frm_TroGiup giup = new frm_TroGiup();
                giup.MdiParent = this;
                giup.Show();
            }
        }
    }
}
