using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class DangNhapPublic
    {
        private string strTaiKhoan = "";
        public string TaiKhoan
        {
            get { return strTaiKhoan; }
            set { strTaiKhoan = value; }
        }

        private string strMatKhau = "";
        public string MatKhau
        {
            get { return strMatKhau; }
            set { strMatKhau = value; }
        }

        private string strMaLoaiND = "";
        public string MaLoaiND
        {
            get { return strMaLoaiND; }
            set { strMaLoaiND = value; }
        }

        private string strMaND = "";
        public string ND
        {
            get { return strMaND; }
            set { strMaND = value; }
        }
    }
}
