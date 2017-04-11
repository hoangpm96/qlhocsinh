using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class NhapDiemDAL
    {
        cConnect dp = new cConnect();
        public DataTable LayNamHoc()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LayNamHoc", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public DataTable LayDanhSachCacLop(string MaNamHoc, string Khoi)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LayTenLop", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", MaNamHoc);
            cmd.Parameters.AddWithValue("@Khoi", Khoi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public DataTable LoadDSDiem(string MaHocKy, string MaHS, string TenMonHoc)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LayDiemMon", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocKy", MaHocKy);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@TenMonHoc", TenMonHoc);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public void LuuDiem(string MaHocKy, string MaHS, string TenMonHoc, float D15, float DGK, float DCK, float DTB)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("[sp_UpdateDiemMon]", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocKy", MaHocKy);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@TenMonHoc", TenMonHoc);
            cmd.Parameters.AddWithValue("@D15", D15);
            cmd.Parameters.AddWithValue("@DGK", DGK);
            cmd.Parameters.AddWithValue("@DCK", DCK);
            cmd.Parameters.AddWithValue("@DTB", DTB);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
