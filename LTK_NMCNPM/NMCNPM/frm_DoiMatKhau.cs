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
    public partial class frm_DoiMatKhau : Form
    {
        public string tai_khoan { get; set; }
        DoiMatKhauBLL DoiMatKhau = new DoiMatKhauBLL();
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = tai_khoan;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshForm()
        {
            txt_TaiKhoan.Text = string.Empty;
            txt_MatKhauCu.Text = string.Empty;
            txt_MatKhauMoi.Text = string.Empty;
            txt_XacNhan.Text = string.Empty;
            btn_DoiMatKhau.Enabled = false;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "";
            if (txt_MatKhauCu.Text == "" || txt_MatKhauMoi.Text == "")
                lbl_status.Text = "Chưa nhập mật khẩu !";
            else
            {
                if(txt_MatKhauCu.Text == txt_MatKhauMoi.Text)
                {
                    lbl_status.Text = "Không thể đổi mật khẩu trùng mật khẩu cũ";
                }
                else
                {
                    if (DoiMatKhau.KiemTraMatKhau(tai_khoan, txt_MatKhauCu.Text))
                    {
                        if (txt_MatKhauMoi.Text == txt_XacNhan.Text)
                        {
                            // tại đây code đổi mật khẩu
                            DoiMatKhau.DoiMK(tai_khoan, txt_MatKhauMoi.Text);
                        }
                        else
                        {
                            lbl_status.Text = "Xác nhận chưa đúng!";
                        }
                    }
                    else
                    {
                        lbl_status.Text = "Mật khẩu cũ chưa đúng!";
                    }
                }
                lbl_status.Text = "Đổi mật khẩu thành công!";
                RefreshForm();
            }
        }
    }
}
