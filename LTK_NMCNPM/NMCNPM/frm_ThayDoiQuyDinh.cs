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
    public partial class frm_ThayDoiQuyDinh : Form
    {
        QuyDinhBLL QuyDinh = new QuyDinhBLL();
        DataTable DuLieu = new DataTable();
        public frm_ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            LoadDuLieu();

        }
        private void LoadDuLieu()
        {
            lbl_Status.Text = "";
            DuLieu = QuyDinh.LoadQuyDinh();
            txt_DiemQuaMon1.Text = DuLieu.Rows[4][1].ToString();
            txt_TuoiToiDa.Text = DuLieu.Rows[0][1].ToString();
            txt_TuoiToiThieu.Text = DuLieu.Rows[1][1].ToString();
            txt_SiSoToiDa.Text = DuLieu.Rows[2][1].ToString();
            txt_SiSoToiThieu.Text = DuLieu.Rows[3][1].ToString();
            txt_TenTruong.Enabled = false;
            txt_TenTruongMoi.Enabled = true;
            txt_TenTruong.Text = QuyDinh.LoadTenTruong();
            txt_DiemQuaMon2.Text = txt_DiemQuaMon1.Text;
            num_TuoiToiDa.Value = int.Parse(txt_TuoiToiDa.Text);
            num_TuoiToiThieu.Value = int.Parse(txt_TuoiToiThieu.Text);
            num_SiSoToiDa.Value = int.Parse(txt_SiSoToiDa.Text);
            num_SiSoToiThieu.Value = int.Parse(txt_SiSoToiThieu.Text);
            txt_TenTruongMoi.Text = txt_TenTruong.Text;
            btn_Luu.Enabled = false;
        }
        private void txt_TenTruongMoi_TextChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            btn_Luu.Enabled = true;
        }
        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            lbl_Status.Text = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool bl = true;
            float a = 0;
            lbl_Status.Text = "";
            //Kiểm tra tuổi tối thiểu có nhỏ hơn tuổi tối đa hay không?
            if (num_SiSoToiDa.Value <= num_SiSoToiThieu.Value)
            {
                lbl_Status.Text = "Lỗi quy định sĩ số";
                bl = false;
            }
            if (num_TuoiToiDa.Value <= num_TuoiToiThieu.Value)
            {
                lbl_Status.Text = "Lỗi quy định tuổi tối thiểu";
                bl = false;
            }
            if (txt_TenTruongMoi.Text.Length < 10)
            {
                lbl_Status.Text = "Lỗi tên trường";
                bl = false;
            }
            if (txt_DiemQuaMon2.Text.Length > 4)
            {
                lbl_Status.Text = "Điểm không thể quá 4 ký tự, chỉ lấy 2 số sau dấu phẩy!";
                bl = false;
            }
            else
            {
                if (txt_DiemQuaMon2.Text.IndexOf("/") > 2)
                {
                    lbl_Status.Text = "Điểm không thể có nhiều dấu ',' hoặc quá nhiều số 0 ở trước";
                    bl = false;
                }
                else
                {
                    int dem = 0;
                    for (int i = 0; i < txt_DiemQuaMon2.Text.Length; i++)
                    {
                        if (txt_DiemQuaMon2.Text[i] == ',')
                        { dem++; }
                    }
                    if (dem > 1) { lbl_Status.Text = "Điểm không thể có nhiều dấu ','"; bl = false; }
                    else
                    {
                        try
                        {
                            a = float.Parse(txt_DiemQuaMon2.Text);
                            if (a > 10.0 || a < 0.1)
                            {
                                lbl_Status.Text = "Điểm không thể lớn hơn 10 và nhỏ hơn 0,1";
                                bl = false;
                            }
                        }
                        catch
                        {
                            lbl_Status.Text = "Lỗi điểm qua môn";
                            bl = false;
                        }
                    }
                }
            }
            if (bl)
            {
                try
                {
                    QuyDinh.LuuDuLieu(txt_TenTruongMoi.Text, int.Parse(num_TuoiToiDa.Value.ToString()), int.Parse(num_TuoiToiThieu.Value.ToString()), int.Parse(num_SiSoToiDa.Value.ToString()), int.Parse(num_SiSoToiThieu.Value.ToString()), a);
                    lbl_Status.Text = "Lưu dữ liệu thành công!";
                }
                catch
                {
                    lbl_Status.Text = "Lỗi lưu dữ liệu!";
                }
            }
        }
    }
}
