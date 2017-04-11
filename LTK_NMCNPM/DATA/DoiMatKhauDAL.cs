using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class DoiMatKhauDAL
    {
        cConnect dp = new cConnect();
        public int KiemTraMatKhau(string TaiKhoan, string MatKhau)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_KiemtraMK", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            int dt2 = dt.Rows.Count;
            return dt2;
        }
        public void DoiMK(string TaiKhoan, string MatKhau)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_DoiMK", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
