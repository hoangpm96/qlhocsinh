using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DATA;
namespace BLL
{
    public class XemDiemLopBLL
    {
        XemDiemLopDAL Diem = new XemDiemLopDAL();
        public DataTable LoadDiemMon(string TenHocKy,string TenNamHoc, string MaHS)
        {
            string MaHocKy = ""; 
            if(TenHocKy == "1"|| TenHocKy =="2")
            {
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + TenHocKy;
                return Diem.LoadDiem(MaHocKy, MaHS);
            }
            else
            {
                // lấy của cả 2 học kỳ, sau đó + chia 2.
                
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "1";
                DataTable D1 = Diem.LoadDiem(MaHocKy, MaHS);
                if (D1.Rows.Count<1)
                {
                    D1.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                MaHocKy = "NH" + TenNamHoc.Substring(0, 4) + "2";
                DataTable D2 = Diem.LoadDiem(MaHocKy, MaHS);
                if (D2.Rows.Count < 1)
                {
                    D2.Rows.Add("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
                }
                DataTable DTB = new DataTable();
                for (int i=1;i<14;i++)
                {
                    D1.Rows[0][i] = (Math.Round((float.Parse(D1.Rows[0][i].ToString()) + float.Parse(D2.Rows[0][i].ToString())) / 2,2)).ToString();
                }
                return D1;
            }
        }
    }
}
