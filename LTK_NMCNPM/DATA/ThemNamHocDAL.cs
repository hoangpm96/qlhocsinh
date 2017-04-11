using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class ThemNamHocDAL
    {
        cConnect dp = new cConnect();
        public DataTable LoadTatCaGiaoVien()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LayGiaoVien", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stt", "2");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public void LuuNamHoc(string MaNamHoc, string TenNamHoc)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_ThemNamHoc", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", MaNamHoc);
            cmd.Parameters.AddWithValue("@TenNamHoc", TenNamHoc);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
        public void TaoLop(string MaNamHoc, string MaLop, string TenLop, string MaGV)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_ThemLop", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", MaNamHoc);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
