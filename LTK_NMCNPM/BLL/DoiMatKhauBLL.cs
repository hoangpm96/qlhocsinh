using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
namespace BLL
{
   public class DoiMatKhauBLL
    {
        DoiMatKhauDAL DoiMatKhau = new DoiMatKhauDAL();
        public bool KiemTraMatKhau(string taikhoan, string matkhau)
        {
            if(DoiMatKhau.KiemTraMatKhau(taikhoan,matkhau)>=1)
            { return true; }
            else
            return false;
        }
        public void DoiMK(string TaiKhoan, string MatKhau)
        {
            DoiMatKhau.DoiMK(TaiKhoan, MatKhau);
        }
    }
}
