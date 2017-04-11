using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class XoaHoSoHocSinhDAL
    {
        cConnect dp = new cConnect();
        public void XoaHoSo(string MaHS, string TenNamHoc, string TenLop)
        {
            dp.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand("sp_DeleteHocSinh", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.Parameters.AddWithValue("@TenNamHoc", TenNamHoc);
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.ExecuteNonQuery();
            dp.NgatKetNoi();
        }
    }
}
