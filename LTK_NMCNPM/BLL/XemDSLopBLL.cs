using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DATA;
namespace BLL
{
    public class XemDSLopBLL
    {
        XemDSLopDAL DS = new XemDSLopDAL();
        public DataTable LayNamHoc()
        {
            DataTable namhoctable = DS.LayNamHoc();
            return namhoctable;
        }
        public DataTable LayDSLopHoc(string TenNamHoc, string Khoi)
        {
            TenNamHoc = "NH" + TenNamHoc.Substring(0, 4);
            return DS.LayDanhSachCacLop(TenNamHoc, Khoi);
        }
        public DataTable LayDuLieu(string TenNamHoc, string Lop)
        {
            string MaLop = "LP"+ TenNamHoc.Substring(2, 2)+Lop;
            return DS.LayDuLieu(MaLop);
        }
    }
}
