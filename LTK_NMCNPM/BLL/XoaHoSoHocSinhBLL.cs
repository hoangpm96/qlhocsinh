using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data;
namespace BLL
{
    public class XoaHoSoHocSinhBLL
    {
        XoaHoSoHocSinhDAL XoaHoSoHS = new XoaHoSoHocSinhDAL();
        public void XoaHoSo(string MaHS, string TenNamHoc, string TenLop)
        {
            XoaHoSoHS.XoaHoSo(MaHS,TenNamHoc,TenLop);
        }
    }
}
