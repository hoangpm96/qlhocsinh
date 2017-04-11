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
    public class DangNhapDAL
    {
        #region cConnect
        cConnect dp = new cConnect();
        #endregion
        public DataTable DAL_DangNhap_Select(DangNhapPublic login) //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu.
        {
            dp.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand("sp_selectlogin", dp.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DangNhapID", login.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhauID", login.MatKhau);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dp.NgatKetNoi();
            return dt;
        }
    }
}
