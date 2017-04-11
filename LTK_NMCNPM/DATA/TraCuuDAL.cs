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
    public class TraCuuDAL
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
        public DataTable TimKiemCoLop(string NamHoc, string Khoi, string Lop, string MaHS, string HoTen, string GioiTinh, int NamSinh)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_TimKiem", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NamHoc", NamHoc);
            cmd.Parameters.AddWithValue("@Khoi", Khoi);
            cmd.Parameters.AddWithValue("@Lop", Lop);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
    }
}
