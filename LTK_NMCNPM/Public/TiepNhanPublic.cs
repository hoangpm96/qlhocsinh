using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TiepNhanPublic
    {
        private string strMaNamHoc = "";
        public string MaNamHoc
        {
            get { return strMaNamHoc; }
            set { strMaNamHoc = value; }
        }

        private string strTenNamHoc = "";
        public string TenNamHoc
        {
            get { return strTenNamHoc; }
            set { strTenNamHoc = value; }
        }
    }
}
