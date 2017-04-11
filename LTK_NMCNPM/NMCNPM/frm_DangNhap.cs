using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Public;

using BLL;

namespace NMCNPM
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (txt_TaiKhoan.Text.Length == 0 || txt_MatKhau.Text.Length == 0)// nếu tài khoản hoặc mật khẩu trống
            {
                lblStatus.BackColor = Color.Pink;
                lblStatus.Text = "Bạn chưa nhập tên hoặc tài khoản";
                txt_TaiKhoan.Focus();
            }
            else
            {
                if (txt_MatKhau.Text.IndexOf(" ") > 0 || txt_MatKhau.Text.IndexOf("/") > 0 || txt_MatKhau.Text.IndexOf("*") > 0)
                {
                    lblStatus.Text = "Mật khẩu sai, không được có khoảng trắng, dấu /, dấu *";
                    txt_MatKhau.Focus();
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    DangNhapPublic clsLogin = new DangNhapPublic();
                    clsLogin.TaiKhoan = txt_TaiKhoan.Text.Trim();
                    clsLogin.MatKhau = txt_MatKhau.Text.Trim();
                    DangNhapBLL cls = new DangNhapBLL();
                    if (cls.BLL_DangNhap_Select(clsLogin))//trùng tài khoản mật khẩu
                    {
                        switch (cls.BLL_PhanQuyen(clsLogin))
                        {
                            case "MNDHT":
                                frm_Home.quyendangnhap = "MNDHT";
                                MessageBox.Show("Bạn đăng nhập với quyền của Hiệu trưởng");
                                break;
                            case "MNDGV":
                                frm_Home.quyendangnhap = "MNDGV";
                                MessageBox.Show("Bạn đăng nhập với quyền của Giáo viên");
                                break;
                            case "MNDQT":
                                frm_Home.quyendangnhap = "MNDQT";
                                MessageBox.Show("Bạn đăng nhập với quyền của Quản trị viên");
                                break;
                            default:
                                frm_Home.quyendangnhap = "Lỗi quyền đăng nhập!";
                                MessageBox.Show("Bạn đăng nhập với quyền của Khách");
                                break;

                        }
                        this.Close();
                        frm_Home.dadangnhap = true;
                        frm_Home.tendangnhap = txt_TaiKhoan.Text.Trim();
                    }
                    else
                    {
                        lblStatus.Text = "Tài khoản hoặc mật khẩu sai";
                        txt_TaiKhoan.Text = "";
                        txt_MatKhau.Text = "";
                        txt_TaiKhoan.Focus();
                        this.Cursor = Cursors.Default;
                    }

                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat_qs;
            thoat_qs = MessageBox.Show("Bạn thật sự muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat_qs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btn_DangNhap_Click(sender, e);
        }

        private void txt_TaiKhoan_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Focus();
            txt_MatKhau.Text = "";
            lblStatus.Text = "";
        }
    }
}
