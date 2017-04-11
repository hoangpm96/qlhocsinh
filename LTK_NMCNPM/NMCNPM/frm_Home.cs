using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Public;
using BLL;
namespace NMCNPM
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }
        static public bool dadangnhap = true;
        static public string tendangnhap { set; get; }
        static public string quyendangnhap { set; get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            DangNhap();
            frm_DangNhap dNhap = new frm_DangNhap();
            dNhap.ShowDialog(this);
            DangNhap();
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thật sự muốn thoát khỏi phần mềm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void bntTiepNhan_Click(object sender, EventArgs e)
        {
            frm_TiepNhanHocSinh TiepNhan = new frm_TiepNhanHocSinh();
            TiepNhan.ShowDialog();
        }
        private void bntTraCuu_Click(object sender, EventArgs e)
        {
            frm_TraCuuHS TraCuu = new frm_TraCuuHS();
            TraCuu.ShowDialog();
        }
        private void bntBaoCao_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTongKet TongKet = new frm_BaoCaoTongKet();
            TongKet.ShowDialog();
        }
        private void bnt_ThemNamHoc_Click(object sender, EventArgs e)
        {
            frm_ThemNamHoc ThemNamHoc = new frm_ThemNamHoc();
            ThemNamHoc.ShowDialog();
        }
        private void bntThayDoi_Click(object sender, EventArgs e)
        {
            frm_ThayDoiQuyDinh ThayDoiQuyDinh = new frm_ThayDoiQuyDinh();
            ThayDoiQuyDinh.ShowDialog();
        }
        private void bnt_TaoTaiKhoan(object sender, EventArgs e)
        {
            frm_TaoTaiKhoan TaoTaiKhoan = new frm_TaoTaiKhoan();
            TaoTaiKhoan.ShowDialog();
        }
        private void bnt_DoiMatKhau(object sender, EventArgs e)
        {
            frm_DoiMatKhau DoiMatKhau = new frm_DoiMatKhau();
            DoiMatKhau.tai_khoan = tendangnhap;
            DoiMatKhau.ShowDialog();
        }
        private void bnt_DangXuat(object sender, EventArgs e)
        {
            MacDinh();
            dadangnhap = false;
            frm_DangNhap dNhap = new frm_DangNhap();
            dNhap.ShowDialog(this);
            DangNhap();
        }
        private void bnt_ThongTin_Click(object sender, EventArgs e)
        {
            frm_ThongTinPhanMem ThongTin = new frm_ThongTinPhanMem();
            ThongTin.ShowDialog();
        }
        private void bnt_HuongDan_Click(object sender, EventArgs e)
        {
            frm_HuongDanSuDung HuongDan = new frm_HuongDanSuDung();
            HuongDan.ShowDialog();
        }
        private void bntNhapDiem_Click(object sender, EventArgs e)
        {
            frm_NhapDiem nhapdiem = new frm_NhapDiem();
            nhapdiem.ShowDialog();
        }
        private void MacDinh()
        {
            bntTiepNhan.Enabled = true;
            bntNhapDiem.Enabled = true;
            bntThayDoi.Enabled = true;
            bntBaoCao.Enabled = true;
            SmnitTiepNhan.Enabled = true;
            SmnitNhapDiem.Enabled = true;
            SmnitThemNamHoc.Enabled = true;
            SmnitBaoCaoTongKet.Enabled = true;
            MnitThayDoiQuyDinh.Enabled = true;
            SmnitTaoTK.Enabled = true;
            lbl_ThongTinDangNhap.BackColor = Color.Red;
            lbl_ThongTinDangNhap.Text = "ĐĂNG XUẤT";
            lbl_Quyen.Text = "";
        }
        private void DangNhap()
        {
            lbl_ThongTinDangNhap.BackColor = Color.Red;
            lbl_ThongTinDangNhap.Text = "Tài khoản đăng nhập: " + tendangnhap;
            lbl_Quyen.Text = "Quyền: " + quyendangnhap;

            if (quyendangnhap == "MNDHT")
            {
                bntTiepNhan.Enabled = true;
                bntNhapDiem.Enabled = true;
                bntThayDoi.Enabled = true;
                bntBaoCao.Enabled = true;
                SmnitTiepNhan.Enabled = true;
                SmnitNhapDiem.Enabled = true;
                SmnitThemNamHoc.Enabled = true;
                SmnitBaoCaoTongKet.Enabled = true;
                MnitThayDoiQuyDinh.Enabled = true;
                SmnitTaoTK.Enabled = true;
            }
            else
            {
                if (quyendangnhap == "MNDQT")
                {
                    bntTiepNhan.Enabled = false;
                    bntNhapDiem.Enabled = true;
                    bntThayDoi.Enabled = true;
                    bntBaoCao.Enabled = true;
                    SmnitTiepNhan.Enabled = false ;
                    SmnitNhapDiem.Enabled = true;
                    SmnitThemNamHoc.Enabled = true;
                    SmnitBaoCaoTongKet.Enabled = true;
                    MnitThayDoiQuyDinh.Enabled = true;
                    SmnitTaoTK.Enabled = true;
                }


                else
                {
                    if (quyendangnhap != "MNDGV")
                    {
                        bntNhapDiem.Enabled = false;
                        SmnitNhapDiem.Enabled = false;
                    }
                    bntTiepNhan.Enabled = false;
                    bntThayDoi.Enabled = false;
                    SmnitTiepNhan.Enabled = false;
                    SmnitThemNamHoc.Enabled = false;
                    MnitThayDoiQuyDinh.Enabled = false;
                    SmnitTaoTK.Enabled = false;
                }
            }
        }
        private void bntXemDanhSach_Click(object sender, EventArgs e)
        {
            frm_XemDanhSachLop DSL = new frm_XemDanhSachLop();
            frm_XemDanhSachLop.quyendangnhap = quyendangnhap;
            DSL.ShowDialog();
        }
    }
}
