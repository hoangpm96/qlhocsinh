using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA;

namespace BLL
{
    public class QuyDinhBLL
    {
        QuyDinhDAL QuyDinh = new QuyDinhDAL();
        public DataTable LoadQuyDinh()
        {
            return QuyDinh.LoadQuyDinh();
        }
        public string LoadTenTruong()
        {
            return QuyDinh.LoadTenTruong();
        }
        public void LuuDuLieu(string TenTruong, int TuoiToiDa, int TuoiToiThieu, int SiSoToiDa, int SiSoToiThieu, float DiemQuaMon)
        {
            QuyDinh.LuuDuLieu(TenTruong, TuoiToiDa, TuoiToiThieu, SiSoToiDa, SiSoToiThieu, DiemQuaMon);
        }
    }
}
