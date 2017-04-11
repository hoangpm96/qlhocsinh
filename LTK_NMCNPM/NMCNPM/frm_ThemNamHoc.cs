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
    public partial class frm_ThemNamHoc : Form
    {
        ThemNamHocBLL ThemNamHoc = new ThemNamHocBLL();
        int[] dulieu = new int[3];
        public delegate void LayDuLieusllop(int[] lop);
        static public DataTable DuLieuLayVe { set; get; }//ds lớp lấy về
        static public string btn_truoc { set; get; }
        public frm_ThemNamHoc()
        {
            InitializeComponent();
        }

        private void frm_ThemNamHoc_Load(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            txt_NamHoc.Text = ThemNamHoc.NamHocMoi();
            txt_TenTruong.Text = ThemNamHoc.TenTruong();
            btn_Luu.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            btn_ThemLop.Enabled = true;
            num10.Enabled = true;
            num11.Enabled = true;
            num12.Enabled = true;
            btn_Them.Enabled = false;
            btn_Thoat.Text = "Hủy";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            if(btn_Them.Enabled == true && btn_ThemLop.Enabled ==false && btn_Luu.Enabled ==false)
            {
                this.Close();
            }         
            if(btn_Them.Enabled ==false && btn_Luu.Enabled == false && btn_truoc == "Luu")
            {
                this.Close();
            }
            else
            {
                if (btn_Them.Enabled == false)
                {
                    DialogResult qs;
                    qs=MessageBox.Show("Bạn có muốn hủy thêm năm học!","Hỏi?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(DialogResult.Yes ==qs)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            //kiểm tra lớp có vượt quá số lượng giáo viên hay không
            if (int.Parse(num10.Value.ToString())+ int.Parse(num11.Value.ToString())+ int.Parse(num12.Value.ToString())>ThemNamHoc.LayTenGiaoVien().Rows.Count)
            {
                lbl_stt.Text = "Lỗi! số lớp nhiều hơn số giáo viên!";
            }
            else
            {
                dulieu[0] = int.Parse(num10.Value.ToString());
                dulieu[1] = int.Parse(num11.Value.ToString());
                dulieu[2] = int.Parse(num12.Value.ToString());
                frm_ThemLop ThemLop = new frm_ThemLop();
                LayDuLieusllop DuLieu = new LayDuLieusllop(ThemLop.LayDuLieu);
                DuLieu(this.dulieu);
                ThemLop.ShowDialog();
                if (btn_truoc == "Luu")
                {
                    btn_ThemLop.Enabled = false;
                    btn_Luu.Enabled = true;
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
            //tạo năm học
            try
            {
                ThemNamHoc.LuuNamHoc(txt_NamHoc.Text);
                for (int i = 0; i < DuLieuLayVe.Rows.Count; i++)
                {
                    ThemNamHoc.LuuLop(txt_NamHoc.Text, DuLieuLayVe.Rows[i][0].ToString(), DuLieuLayVe.Rows[i][1].ToString());
                }
                lbl_stt.Text = "Lưu dữ liệu thành công!";
                btn_Luu.Enabled = false;
            }
            catch
            {
                lbl_stt.Text = "Lỗi lưu dữ liệu!";
            }

        }

        private void num10_ValueChanged(object sender, EventArgs e)
        {
            lbl_stt.Text = "";
        }
    }
}
