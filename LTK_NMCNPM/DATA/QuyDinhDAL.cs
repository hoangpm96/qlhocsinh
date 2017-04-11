using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class QuyDinhDAL
    {
        cConnect dp = new cConnect();
        public DataTable LoadQuyDinh()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LoadQuyDinh", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public string LoadTenTruong()
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LoadTenTruong", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            string dt2 = dt.Rows[0][0].ToString();
            return dt2;
        }
        public void LuuDuLieu(string TenTruong, int TuoiToiDa, int TuoiToiThieu, int SiSoToiDa, int SiSoToiThieu, float DiemQuaMon)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LuuQuyDinh", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenTruong", TenTruong);
            cmd.Parameters.AddWithValue("@TuoiToiDa", TuoiToiDa);
            cmd.Parameters.AddWithValue("@TuoiToiThieu", TuoiToiThieu);
            cmd.Parameters.AddWithValue("@SiSoToiDa", SiSoToiDa);
            cmd.Parameters.AddWithValue("@SiSoToiThieu", SiSoToiThieu);
            cmd.Parameters.AddWithValue("@DiemQuaMon", DiemQuaMon);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
