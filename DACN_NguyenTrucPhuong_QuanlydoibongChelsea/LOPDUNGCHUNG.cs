using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DACN_NguyenTrucPhuong_QuanlydoibongChelsea
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\laptrinhungdung\DACN_NguyenTrucPhuong_QuanlydoibongChelsea\DACN_NguyenTrucPhuong_QuanlydoibongChelsea\QuanLyClbChelsea.mdf;Integrated Security=True";
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
