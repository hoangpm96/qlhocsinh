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
    public class TiepNhanBLL
    {
        TiepNhanDAL TNhan = new TiepNhanDAL();
        QuyDinhDAL QuyDinh = new QuyDinhDAL();
        public DataTable LayNamHoc()
        {
            return TNhan.LayNamHoc();
        }
        public int LayMaHocSinh(string NamHoc)
        {
            return TNhan.LayMaHocSinh(NamHoc);
        }
        public void LuuHocSinh(string MaHocSinh, string TenNamHoc, string HoTen, DateTime NgaySinh, string Email, string GioiTinh, string DiaChi, string MaLop)
        {// lưu sinh viên xuống với Tên năm học + số học sinh -> lưu vào trong table năm học số lượng hs của năm học đó
            // 
            string Masp = "";
            string HK1 = "NH"+TenNamHoc.Substring(0, 4) + "1";
            string HK2 = "NH"+TenNamHoc.Substring(0, 4) + "2";
            if (MaHocSinh == "")
            {//trường hợp chưa có mã học sinh thì + thêm vào
                MaHocSinh = ChuanHoaMHS(TenNamHoc);
                Masp = "insert";
            }
            else
            {//đã có mã học sinh -> update lại dữ liệu
                Masp = "update";
            }
            TNhan.LuuHocSinh(Masp, TenNamHoc, MaHocSinh, HoTen, NgaySinh, Email, GioiTinh, DiaChi, MaLop);
            TNhan.LuuBangDiem(Masp, HK1, HK2, MaHocSinh, MaLop);
        }
        public DataTable LayDSLopHoc(string TenNamHoc, string Khoi)
        {
            TenNamHoc = "NH" + TenNamHoc.Substring(0, 4);
            return TNhan.LayDanhSachCacLop(TenNamHoc, Khoi);
        }
        private string ChuanHoaMHS(string namhoc) // hàm này lấy stt -> biến thành MSHS (mã hs = mã hs cũ load từ dữ liệu + 1)
        {
            //năm học "2014 - 2015"
            int sl = TNhan.LayMaHocSinh(namhoc);
            string mhs = "";
            mhs += "HS";
            mhs += namhoc.Substring(2, 2);
            sl = sl + 1;
            if (sl / 100 >= 1)//số 3 chữ số
            {
                mhs += sl;
            }
            else
            {
                if (sl / 10 >= 1)//số 2 chữ số
                { mhs += "0" + sl; }
                else
                {
                    mhs += "00" + sl;
                }
            }

            return mhs;
        }
        public bool KiemTraTuoi(int tuoi)
        {
            DataTable mLayTuoi = TNhan.LayTuoi();
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
        public int SiSoToiDa()
        {
            DataTable x = QuyDinh.LoadQuyDinh();
            return int.Parse(x.Rows[2][1].ToString());
        }
        public int SiSoToiThieu()
        {
            DataTable x = QuyDinh.LoadQuyDinh();
            return int.Parse(x.Rows[3][1].ToString());
        }
        public int SiSo(string NamHoc, string TenLop)
        {
            DataTable x = TNhan.SiSo(NamHoc,TenLop);
            return int.Parse(x.Rows[0][0].ToString());
        }
    }
}
