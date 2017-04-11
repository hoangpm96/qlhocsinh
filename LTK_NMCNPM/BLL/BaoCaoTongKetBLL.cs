using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DATA;

namespace BLL
{
    public class BaoCaoTongKetBLL
    {
        BaoCaoTongKetDAL BaoCao = new BaoCaoTongKetDAL();
        XemDSLopDAL XemDS = new XemDSLopDAL();
        XemDiemLopBLL XemDiem = new XemDiemLopBLL();
        public DataTable LayNamHoc()
        {
            return XemDS.LayNamHoc();
        }
        public DataTable BaoCaoTongKetMon()
        {
            DataTable dt = new DataTable();
            return dt;
        }
        public DataTable BaoCaoTongKet()
        {
            DataTable dt = new DataTable();
            return dt;
        }
        public DataTable LoadLop(string TenNamHoc)
        {
            return BaoCao.LayHocSinh_SiSo(TenNamHoc);
        }
        public int Dem(string MaLop, string TenMonHoc, string TenHocKy,string NamHoc)
        {
            string MaHocKy = "NH" + NamHoc.Substring(0, 4) + TenHocKy.Substring(7,1);//Học kỳ 1
            return BaoCao.soluong(MaLop, TenMonHoc, MaHocKy);
        }
        public int Dem2(string MaLop, string TenHocKy, string TenNamHoc)
        {
            int kiemtra = 0;
            float dieukien = BaoCao.LoadDieuKien(); //load điều kiện kiểm tra coi thử đủ điều kiện đậu hay không
            DataTable HS = XemDS.LayDuLieu(MaLop);
            for (int i=0;i<HS.Rows.Count;i++)
            {
                float dtb = 0;
                DataTable Diem = XemDiem.LoadDiemMon(TenHocKy, TenNamHoc, HS.Rows[i][0].ToString()); // danh sách điểm của 1 học sinh
                for (int j=1;j<14;j++)
                {
                    dtb += float.Parse(Diem.Rows[0][j].ToString()); // tính tổng các điểm của hs đó
                }
                dtb = dtb / 13;
                if (dtb>dieukien)
                {
                    kiemtra++;//cứ điểm trung bình > điểm qua lớp thì đạt.
                }

            }
            return kiemtra;
        }
    }
}
