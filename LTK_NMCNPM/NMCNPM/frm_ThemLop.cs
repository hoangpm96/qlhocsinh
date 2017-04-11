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
    public partial class frm_ThemLop : Form
    {
        int[] sllop = new int[3];
        int dem=0;
        int soluong = 0;
        DataTable GiaoVien = new DataTable();
        Label[]  lbl= new Label[30];// khai bao mang gom dem Label.
        ThemNamHocBLL NamHoc = new ThemNamHocBLL();
        DataTable DLTraVe = new DataTable();

        public frm_ThemLop()
        {
            InitializeComponent();
        }
        public void LayDuLieu(int[] lop)
        {
            sllop = lop;
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn thật sự muốn hủy tạo lớp");
            frm_ThemNamHoc.btn_truoc = "Huy";
            this.Close();
        }

        private void btn_Them10_Click(object sender, EventArgs e)
        {
            if(txt_10TenLop.Text.Length ==2)
            {
                bool kt = true;
                for (int i=0;i<soluong;i++)
                {
                    if (txt_Khoi.Text + txt_10TenLop.Text == lbl[i].Text.Substring(lbl[i].Text.IndexOf(".") + 3, 4))
                        {
                        kt = false;
                        }
                }
                if(kt ==true)
                {
                    #region -- nếu tên của length = 2, và không trùng tên lớp thì thực hiện
                    btn_Them10.Enabled = false;
                    this.Width = this.Width;
                    this.Height = this.Height + 20;
                    lbl[soluong] = new Label();
                    lbl[soluong].Name = "lbl" + (soluong + 100).ToString();
                    lbl[soluong].Text = (soluong + 1).ToString() + ".  " + txt_Khoi.Text + txt_10TenLop.Text + "  -  GVCN: " + cb_GiaoVien.Text;
                    lbl[soluong].Location = new System.Drawing.Point(92, 125 + soluong * 20); // vi tri xuat hien
                    lbl[soluong].Size = new System.Drawing.Size(250, 13);
                    this.Controls.Add(lbl[soluong]);
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    //lưu dữ liệu vào trong datatable
                    DataRow row = DLTraVe.NewRow();
                    row["Lop"] = txt_Khoi.Text + txt_10TenLop.Text;
                    row["gv"] = cb_GiaoVien.Text;
                    DLTraVe.Rows.Add(row);
                    cb_GiaoVien.Items.RemoveAt(cb_GiaoVien.SelectedIndex);
                    dem--;
                    soluong++;
                    txt_sl10.Text = dem.ToString();
                    if (int.Parse(txt_sl10.Text) < 1)
                    {
                        btn_Luu.Enabled = true;
                    }
                    txt_10TenLop.Text = "";
                    #region - xử lý hiện khối
                    if (dem <= sllop[2] + sllop[1])
                    {
                        //thuộc lớp 11 và 12
                        if (dem <= sllop[2])
                        {
                            //thuộc lớp 12
                            txt_Khoi.Text = "12";
                            if (dem <= 0)
                            {
                                txt_Khoi.Text = "";
                            }
                        }
                        else
                        {
                            //thuộc lớp 11
                            txt_Khoi.Text = "11";
                        }
                    }
                    else
                    {
                        // ở đây là thuộc lớp 10
                        txt_Khoi.Text = "10";
                    }
                    #endregion
                    #endregion
                }
                else { lbl_Status.Text = "Trùng tên lớp"; }
            }
            else
            {
                lbl_Status.Text = "Tên lớp chưa đủ 2 ký tự";
            }
            if(dem==0)
            {
                txt_10TenLop.Enabled = false;
            }
        }

        private void frm_ThemLop_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dem += sllop[i];
                txt_sl10.Text = dem.ToString();
            }
            txt_10TenLop.Text = "";
            DataColumn dc1 = new DataColumn();
            dc1.DataType = typeof(String);
            dc1.ColumnName = "Lop";
            DataColumn dc2 = new DataColumn();
            dc2.DataType = typeof(String);
            dc2.ColumnName = "gv";
            DLTraVe.Columns.Add(dc1);
            DLTraVe.Columns.Add(dc2);
            GiaoVien = NamHoc.LayTenGiaoVien();
            //Load dữ liệu gốc lên cb_10gv
            int x = GiaoVien.Rows.Count;
            cb_GiaoVien.Items.Clear();
            for (int i=0;i<GiaoVien.Rows.Count;i++)
            {
                cb_GiaoVien.Items.Add(GiaoVien.Rows[i][1].ToString());
            }
        }

        private void cb_GiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            btn_Them10.Enabled = true;
        }

        private void txt_10TenLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void txt_10TenLop_TextChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //trả dữ liệu về cho form tạo năm học và thoát
            for (int i=0;i<GiaoVien.Rows.Count;i++)
                for (int j=0; j<DLTraVe.Rows.Count;j++)
                {
                    if(GiaoVien.Rows[i][1].ToString()==DLTraVe.Rows[j][1].ToString())
                    {
                        string abc =DLTraVe.Rows[j][1].ToString();
                        DLTraVe.Rows[j][1] = GiaoVien.Rows[i][0];
                    }
                }
            frm_ThemNamHoc.DuLieuLayVe = DLTraVe;
            frm_ThemNamHoc.btn_truoc = "Luu";
            this.Close();
        }
    }
}
