using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DATA
{
    public class XemDiemLopDAL
    {
        cConnect dp = new cConnect();
        public DataTable LoadDiem(string MaHocKy, string MaHS)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_Diem", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocKy", MaHocKy);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
    }
}
