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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void cầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhSachCauThu"] == null)
            {
                frm_CauThu dscauthu = new frm_CauThu();
                dscauthu.MdiParent = this;
                dscauthu.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lịchSửCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_LichSuCLB"] == null)
            {
                frm_LichSuCLB lsclb = new frm_LichSuCLB();
                lsclb.MdiParent = this;
                lsclb.Show();
            }
        }

        private void hLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HLV"] == null)
            {
                frm_HLV hlv = new frm_HLV();
                hlv.MdiParent = this;
                hlv.Show();
            }
        }

        private void áoĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_AoDau"] == null)
            {
                frm_AoDau aodau = new frm_AoDau();
                aodau.MdiParent = this;
                aodau.Show();
            }
        }

        private void giớiThiệuCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GioiThieu"] == null)
            {
                frm_GioiThieuCLB gth = new frm_GioiThieuCLB();
                gth.MdiParent = this;
                gth.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang kh = new frm_KhachHang();
                kh.MdiParent = this;
                kh.Show();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void lịchThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_LichThiDau"] == null)
            {
                frm_LichThiDau lich = new frm_LichThiDau();
                lich.MdiParent = this;
                lich.Show();
            }
        }

        private void vàiNétToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_VaiNet"] == null)
            {
                frm_VaiNet vainet = new frm_VaiNet();
                vainet.MdiParent = this;
                vainet.Show();
            }
        }

        private void độiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Doi"] == null)
            {
                frm_Doi doi = new frm_Doi();
                doi.MdiParent = this;
                doi.Show();
            }
        }

        private void phòngLưuNiệmCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_PhongLuuNiem"] == null)
            {
                frm_PhongLuuNiem pln = new frm_PhongLuuNiem();
                pln.MdiParent = this;
                pln.Show();
            }
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoaDonBan"] == null)
            {
                frm_HoaDonBan hdban = new frm_HoaDonBan();
                hdban.MdiParent = this;
                hdban.Show();
            }
        }

        private void tìmCầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TimCauThu"] == null)
            {
                frm_TimCauThu tct = new frm_TimCauThu();
                tct.MdiParent = this;
                tct.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchThiĐấuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_LichThiDau"] == null)
            {
                frm_LichThiDau lich = new frm_LichThiDau();
                lich.MdiParent = this;
                lich.Show();
            }
        }

        private void tìmÁoĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TimAoDau"] == null)
            {
                frm_TimAoDau tad = new frm_TimAoDau();
                tad.MdiParent = this;
                tad.Show();
            }
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
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
