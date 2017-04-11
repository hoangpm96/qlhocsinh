using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA;
namespace BLL
{
    public class TaoTaiKhoanBLL
    {
        TaoTaiKhoanDAL TaiKhoan = new TaoTaiKhoanDAL();
        public DataTable LayGiaoVien()
        {
            return TaiKhoan.LayGiaoVien();
        }
        public bool KiemTraTaiKhoan(string ID)
        {
            return TaiKhoan.KiemTraTonTai(ID);
        }
        public void LuuTaiKhoan(string tk, string mk, string ma, string pq)
        {
            TaiKhoan.LuuTaiKhoan(tk, mk, ma, pq);
        }
    }
}
