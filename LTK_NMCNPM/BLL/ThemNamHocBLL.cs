using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data;

namespace BLL
{
    public class ThemNamHocBLL
    {
        NhapDiemDAL NamHoc = new NhapDiemDAL();
        QuyDinhDAL Truong = new QuyDinhDAL();
        ThemNamHocDAL GV = new ThemNamHocDAL();
        public string NamHocMoi()
        {
            string a;
            DataTable table = NamHoc.LayNamHoc();
            int max = 0;
            for (int i=0;i<table.Rows.Count;i++)
            {
                if(int.Parse(table.Rows[i][1].ToString().Substring(0,4))>max)
                {
                    max = int.Parse(table.Rows[i][1].ToString().Substring(0, 4));
                }
            }
            if (max == 0)
            {
                DateTime time = DateTime.Now;
                max = time.Year;
            }
            a = (max+1).ToString() + " - " + (max + 2).ToString();
            return a;
        }
        public string TenTruong()
        {
            return Truong.LoadTenTruong();
        }
        
        public DataTable LayTenGiaoVien()
        {
            return GV.LoadTatCaGiaoVien();
        }
        public void LuuNamHoc(string TenNamHoc)
        {
            string MaNH = "NH" + TenNamHoc.Substring(0, 4);
            GV.LuuNamHoc(MaNH,TenNamHoc);
        }
        public void LuuLop(string TenNamHoc, string TenLop, string MaGV)
        {
            string MaNH = "NH" + TenNamHoc.Substring(0, 4);
            string MaLop = "LP" + TenNamHoc.Substring(2, 2) + TenLop;
            GV.TaoLop(MaNH, MaLop, TenLop, MaGV);
        }
    }
}
