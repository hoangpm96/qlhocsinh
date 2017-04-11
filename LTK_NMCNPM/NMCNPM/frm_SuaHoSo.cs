using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace NMCNPM
{
    public partial class frm_SuaHoSo : Form
    {
        DataTable DuLieu;
        SuaHoSoBLL SuaHoSo = new SuaHoSoBLL();
        public frm_SuaHoSo()
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
        private void frm_SuaHoSo_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int tuoi = DateTime.Now.Year - tB_NgaySinh.Value.Year + 1;
            if (tB_GioiTinh.Text == "" || tB_Ten.Text == "" || tB_NgaySinh.Text == "" || tB_Email.Text == "" || tB_DiaChi.Text == "")
            {
                lbl_stt.Text = "Chưa điền đầy đủ thông tin!";
            }
            else
            if (SuaHoSo.KiemTraTuoi(tuoi) == false)
            {
                lbl_stt.Text = "Sai quy định tuổi! Bạn kiểm tra lại!";
            }
            else
            {
                string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(match);
                if (reg.IsMatch(this.tB_Email.Text))
                {
                    string a = tB_NgaySinh.Value.ToString();
                    try
                    {
                        int m1 = a.IndexOf("/");
                        int m2 = a.LastIndexOf("/");
                        string ng = a.Substring(m2 + 1, 4) + "/" + a.Substring(0, m1) + "/" + a.Substring(m1 + 1, m2 - m1 - 1);
                        SuaHoSo.UpdateHoSo(tB_MHS.Text, tB_Ten.Text, tB_NgaySinh.Value, tB_GioiTinh.Text, tB_Email.Text, tB_DiaChi.Text);
                        lbl_stt.Text = "Update thành công";
                    }
                    catch
                    { }
                }
                else lbl_stt.Text = "Email chưa đúng!";
           }
        }
        #region --xóa thông báo--
        private void tB_MHS_Click(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
        }

        private void tB_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
        }

        private void tB_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
        }
        #endregion
    }
}
