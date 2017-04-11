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
    public partial class frm_TaoTaiKhoan : Form
    {
        TaoTaiKhoanBLL TaiKhoan = new TaoTaiKhoanBLL();
        DataTable GiaoVien = new DataTable();
        string Quyen = "";
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            //Load Tên giáo viên
            GiaoVien = TaiKhoan.LayGiaoVien();
            cb_TenGiaoVien.Items.Clear();
            for (int i = 0; i < GiaoVien.Rows.Count; i++)
            {
                cb_TenGiaoVien.Items.Add(GiaoVien.Rows[i][1]);
            }
            cb_Quyen.Enabled = false;
            txt_MaGiaoVien.Text = "";
            txt_MatKhau.Text = "";
            txt_TaiKhoan.Text = "";
            txt_XacNhan.Text = "";
            cb_Quyen.Items.Add("Giáo viên");
            cb_Quyen.Items.Add("Hiệu trưởng");
            cb_Quyen.Items.Add("Quản trị viên");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cb_TenGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            cb_Quyen.Enabled = true;
            txt_MaGiaoVien.Text = "";
            cb_Quyen.Items.Clear();
            cb_Quyen.Items.Add("Giáo viên");
            cb_Quyen.Items.Add("Hiệu trưởng");
            cb_Quyen.Items.Add("Quản trị viên");
            for (int i = 0; i < GiaoVien.Rows.Count; i++)
            {
                if (cb_TenGiaoVien.Text == GiaoVien.Rows[i][1].ToString())
                {
                    txt_MaGiaoVien.Text = GiaoVien.Rows[i][0].ToString();
                }
            }
        }
        private void cb_Quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            switch (cb_Quyen.Text)
            {
                case "Giáo viên":
                    Quyen = "MNDGV";
                    break;
                case "Hiệu trưởng":
                    Quyen = "MNDHT";
                    break;
                case "Quản trị viên":
                    Quyen = "MNDQT";
                    break;
            }
            txt_TaiKhoan.Enabled = true;
            txt_MatKhau.Enabled = true;
            txt_XacNhan.Enabled = true;
        }
        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            if (txt_TaiKhoan.Text == ""||txt_MatKhau.Text=="")
                lbl_Status.Text = "Không được để tài khoản hoặc mật khẩu trống";
            else
            {
                if(txt_MatKhau.Text.Length<6)
                {
                    lbl_Status.Text = "Mật khẩu phải dài hơn 6 ký tự!";
                }
                else
                {
                    if (!TaiKhoan.KiemTraTaiKhoan(txt_TaiKhoan.Text)) // kiểm tra trùng tài khoản
                    {
                        if (txt_MatKhau.Text != txt_XacNhan.Text)
                        {
                            lbl_Status.Text = "Xác nhận mật khẩu không đúng";
                        }
                        else
                        {
                            TaiKhoan.LuuTaiKhoan(txt_TaiKhoan.Text, txt_MatKhau.Text, txt_MaGiaoVien.Text, Quyen);

                            lbl_Status.Text = "Tạo tài khoản thành công!";
                        }
                    }
                    else
                    {
                        lbl_Status.Text = "Tài khoản đã tồn tại!";
                    }
                }
            }
        }

    }
}
