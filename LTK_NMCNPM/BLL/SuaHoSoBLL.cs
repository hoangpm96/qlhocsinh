using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data;
namespace BLL
{
    public class SuaHoSoBLL
    {
        SuaHoSoDAL SuaHoSo = new SuaHoSoDAL();
        public void UpdateHoSo(string MaHS, string Ten, DateTime NgaySinh, string GioiTinh, string Mail, string DiaChi)
        {
            
            SuaHoSo.SuaHoSo(MaHS,Ten,NgaySinh,GioiTinh,Mail,DiaChi);
        }
        public bool KiemTraTuoi(int tuoi)
        {
            DataTable mLayTuoi = SuaHoSo.LayTuoi();
            int b = mLayTuoi.Rows.Count;
            int[] abc = new int[b];
            for (int i = 0; i < mLayTuoi.Rows.Count; i++)
            {
                abc[i] = Int32.Parse(mLayTuoi.Rows[i][2].ToString());
            }
            if (abc[0] < tuoi)
            { return false; }
            if (abc[1] > tuoi)
                return false;
            else
                return true;
        }
    }
}
