using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DATA
{
    public class TaoTaiKhoanDAL
    {
        cConnect dp = new cConnect();
        public DataTable LayGiaoVien()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LayGiaoVien", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stt", "1");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public bool KiemTraTonTai(string TaiKhoan)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_KiemTraTonTai", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LuuTaiKhoan(string TaiKhoan, string MatKhau,string MaGV, string PhanQuyen)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LuuTaiKhoan", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.Parameters.AddWithValue("@PhanQuyen", PhanQuyen);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
