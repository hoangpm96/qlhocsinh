using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DATA;
using Public;

namespace BLL
{
    public class TraCuuBLL
    {
        TraCuuDAL TraCuu = new TraCuuDAL();
        XemDiemLopBLL XemDiem = new XemDiemLopBLL();
        public DataTable LayNamHoc()
        {
            return TraCuu.LayNamHoc();
        }
        public DataTable LayDSLopHoc(string TenNamHoc, string Khoi)
        {
            TenNamHoc = "NH" + TenNamHoc.Substring(0, 4);
            return TraCuu.LayDanhSachCacLop(TenNamHoc, Khoi);
        }
        public DataTable TimKiem(string NamHoc, string Khoi, string Lop, string MaHS, string HoTen, string GioiTinh, string NamSinh)
        {
            DataTable dt = new DataTable();
            int NSinh = 0;
            if (NamSinh != "")
            {
                NSinh = int.Parse(NamSinh);
            }
            if (NamHoc != "")
            {
                NamHoc = NamHoc.Substring(2, 2);
            }
            return TraCuu.TimKiemCoLop(NamHoc, Khoi, Lop, MaHS, HoTen, GioiTinh, NSinh);
        }
        public float DTB(string MaHS, string TenNamHoc, string HK)
        {
            string TenHocKy = TenNamHoc.Substring(0, 4) + HK;
            float dtb = 0;
            DataTable Diem = XemDiem.LoadDiemMon(TenHocKy, TenNamHoc, MaHS); // danh sách điểm của 1 học sinh
            for (int j = 1; j < 14; j++)
            {
                dtb += float.Parse(Diem.Rows[0][j].ToString()); // tính tổng các điểm của hs đó
            }
            dtb = dtb / 13;
            return dtb;
        }
    }
}
