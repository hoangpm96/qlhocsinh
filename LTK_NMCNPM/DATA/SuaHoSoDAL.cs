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
    public class SuaHoSoDAL
    {
        cConnect dp = new cConnect();
        public void SuaHoSo(string MaHS, string Ten, DateTime NgaySinh, string GioiTinh, string Mail, string DiaChi)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_UpdateHS", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@Ten", Ten);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@Mail", Mail);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.ExecuteNonQuery();
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
    }
}
