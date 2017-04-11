using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Public;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace DATA
{
    public class cConnect
    {
        public SqlConnection conn; // tạo đối tượng kết nối
        public void KetNoiCSDL()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\QUANLYHOCSINH.mdf;Integrated Security=True");
//            conn = new SqlConnection(@"Data Source=HUKROCK\SQLEXPRESS;Initial Catalog=QLHS_LTK;Integrated Security=True");
            conn.Open(); // mở kết nối CSDL
        }

        public void NgatKetNoi()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
