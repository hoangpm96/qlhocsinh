using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class BaoCaoTongKetDAL
    {
        cConnect dp = new cConnect();
        public DataTable LayHocSinh_SiSo(string TenNamHoc)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_LoadLop_SiSo", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNamHoc", TenNamHoc);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
        public int soluong(string MaLop, string TenMonHoc, string MaHocKy)
        {
            dp.KetNoiCSDL();
            //dat lenh
            SqlCommand cmd = new SqlCommand("sp_DemHocSinh_BCTK", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@TenMonHoc", TenMonHoc);
            cmd.Parameters.AddWithValue("@MaHocKy", MaHocKy);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            int dt2 = int.Parse(dt.Rows[0][0].ToString());
            return dt2;
        }
        public float LoadDieuKien()
        {
            dp.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand("[sp_LoadQuyDinh]", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            float dt2 = float.Parse(dt.Rows[4][1].ToString());
            return dt2;
        }
    }
}
