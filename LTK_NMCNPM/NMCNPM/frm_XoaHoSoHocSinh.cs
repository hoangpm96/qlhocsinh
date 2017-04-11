using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
namespace NMCNPM
{
    public partial class frm_XoaHoSoHocSinh : Form
    {
        DataTable DuLieu = new DataTable();
        XoaHoSoHocSinhBLL XoaHoSoHS = new XoaHoSoHocSinhBLL();
        TiepNhanBLL SiSo = new TiepNhanBLL();
        public frm_XoaHoSoHocSinh()
        {
            InitializeComponent();
        }
        public void LayDuLieu(DataTable hocsinh)
        {
            DuLieu = hocsinh;
        }
        private void LoadDuLieu()
        {
            txtNamHoc.Text = DuLieu.Rows[0][7].ToString();
            txtKhoi.Text = DuLieu.Rows[0][8].ToString();
            txtLop.Text = DuLieu.Rows[0][9].ToString();
            string ngay = DuLieu.Rows[0][3].ToString();
            int m1 = ngay.LastIndexOf("/");
            int m2 = ngay.IndexOf("/");
            tB_NgaySinh.Value = new DateTime(int.Parse(ngay.Substring(m1 + 1, 4)), int.Parse(ngay.Substring(m2 + 1, m1 - m2 - 1)), int.Parse(ngay.Substring(0, m2)), 0, 0, 0);
            tB_MHS.Text = DuLieu.Rows[0][1].ToString();
            tB_Ten.Text = DuLieu.Rows[0][2].ToString();
            tB_GioiTinh.Text = DuLieu.Rows[0][4].ToString();
            tB_Email.Text = DuLieu.Rows[0][5].ToString();
            tB_DiaChi.Text = DuLieu.Rows[0][6].ToString();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_XoaHoSoHocSinh_Load(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            LoadDuLieu();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int x = SiSo.SiSo(txtNamHoc.Text, txtLop.Text);
            int y = SiSo.SiSoToiThieu();
            if (SiSo.SiSo(txtNamHoc.Text, txtLop.Text) <= SiSo.SiSoToiThieu())
            {
                lbl_stt.Text = "Lỗi sĩ số tối thiểu!";
            }
            else
            {
                try
                {
                    XoaHoSoHS.XoaHoSo(tB_MHS.Text, txtNamHoc.Text, txtLop.Text);
                    lbl_stt.Text = "Xóa hồ sơ thành công";
                    btn_Xoa.Enabled = false;
                    btn_Thoat.Text = "Thoát";
                }
                catch
                {
                    lbl_stt.Text = "Lỗi xóa dữ liệu!";
                }
            }
        }
    }
}
