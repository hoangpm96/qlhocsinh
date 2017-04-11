using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data;
namespace BLL
{
    public class NhapDiemBLL
    {
        NhapDiemDAL NhapDiem = new NhapDiemDAL();
        public DataTable LayNamHoc()
        {
            return NhapDiem.LayNamHoc();
        }
        public DataTable LayDSLopHoc(string TenNamHoc, string Khoi)
        {
            TenNamHoc = "NH" + TenNamHoc.Substring(0, 4);
            return NhapDiem.LayDanhSachCacLop(TenNamHoc, Khoi);
        }
        public DataTable LayDSDiem(string MaHS, string TenNamHoc, string TenMonHoc, string HocKy)
        {
            string MaHocKy = "";
            if (HocKy == "Học kỳ 1")
            {
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "1";
            }
            else
            {
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "2";

            }
            return NhapDiem.LoadDSDiem(MaHocKy, MaHS, TenMonHoc);
        }
        public void LuuDiem(string MaHS, string TenNamHoc, string TenMonHoc, string HocKy, float D15, float DGK, float DCK, float DTB)
        {
            string MaHocKy = "";
            if (HocKy == "Học kỳ 1")
            {
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "1";
            }
            else
            {
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "2";

            }
            NhapDiem.LuuDiem(MaHocKy, MaHS, TenMonHoc, D15, DGK, DCK, DTB);
        }
    }
}
