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
    public class DangNhapBLL
    {
        DangNhapDAL dnhap = new DangNhapDAL();
        public bool BLL_DangNhap_Select(DangNhapPublic login )
        {
            bool blKey = false;
            try
            {
                DangNhapDAL clsDAL = new DangNhapDAL();
                int intRow = clsDAL.DAL_DangNhap_Select(login).Rows.Count;
                if (intRow!=0)
                {
                    blKey = true;
                }
            }
            catch
            {
            }
            return blKey;
        }
        public string BLL_PhanQuyen(DangNhapPublic login)
        {
            try
            {
                DangNhapDAL clsDAL = new DangNhapDAL();
                string txt = clsDAL.DAL_DangNhap_Select(login).Rows[0][2].ToString();
                return txt;
            }
            catch
            { }
            return "";
        }

    }
}
