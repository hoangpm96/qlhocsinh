using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class TiepNhanDAL
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
        public DataTable LayTuoi()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_KiemTraTuoi", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public int LayMaHocSinh(string NamHoc)
        {
            dp.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand("sp_LayMaHocSinh", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNamHoc", NamHoc);
            int dl;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dl = (int)(dt.Rows[0][0]);
            dp.NgatKetNoi();
            return dl;
        }
        public void LuuHocSinh(string Masp, string TenNamHoc, string MaHS, string HoTen, DateTime NgaySinh, string Email, string GioiTinh, string DiaChi, string MaLop)// lưu học sinh vào trong table HOCSINH
        {
            dp.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand("sp_LuuHocSinh", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@TenNamHoc", TenNamHoc);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@Masp", Masp);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
        public DataTable SiSo(string NamHoc, string TenLop)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("[sp_LoadSiSo]", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NamHoc", NamHoc);
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public void LuuBangDiem(string masp, string HK1, string HK2, string MaHS, string MaLop)
        {
            dp.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand("sp_LuuBangDiem", dp.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HK1", HK1);
                cmd.Parameters.AddWithValue("@HK2", HK2);
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
