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
using Public;

namespace NMCNPM
{
    public partial class frm_TraCuuHS : Form
    {
        TraCuuBLL TraCuu = new TraCuuBLL();
        DataTable DuLieuUp = new DataTable();
        public frm_TraCuuHS()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_TraCuu_KeyDown(object sender, KeyEventArgs e)//ấn esc thì thoát
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //check thì hiện ra để điền thông tin
        {
            switch (int.Parse(((CheckBox)sender).Tag.ToString()))
            {
                case 1:
                    {
                        if (txtNamHoc.Enabled == false)
                        {//trường hợp ở vị trí cB1 ấn mở.
                            txtNamHoc.Enabled = true;
                            LoadNamHoc();
                        }
                        else
                        {//trường hợp vị trí cB1 ấn không sử dụng
                            txtNamHoc.Enabled = false;
                            checkBox3.Checked = false;
                            XoaNamHoc();
                            XoaLop();
                        }
                        checkBox3.Enabled = false;
                        txtLop.Enabled = false;
                        break;
                    }
                case 2: //thay đổi trong checkBox2
                    if (txtKhoi.Enabled == false)
                    {//trường hợp khối mở
                        txtKhoi.Enabled = true;
                        LoadKhoi();
                    }
                    else
                    {
                        XoaKhoi();
                        txtKhoi.Enabled = false;
                        XoaLop();
                        checkBox3.Checked = false;
                    }
                    txtLop.Enabled = false;
                    checkBox3.Enabled = false;
                    break;
                case 3:
                    {
                        if (txtLop.Enabled == false)
                        {
                            txtLop.Enabled = true;
                            LoadLop();
                        }
                        else
                        {
                            txtLop.Enabled = false;
                        }
                        break;
                    }

                case 4:
                    if (txt_MHS.Enabled == false)
                        txt_MHS.Enabled = true;
                    else
                    {
                        txt_MHS.Text = "";
                        txt_MHS.Enabled = false;
                    }
                    break;
                case 5:
                    if (txt_HoTen.Enabled == false)
                        txt_HoTen.Enabled = true;
                    else
                    {
                        txt_HoTen.Text = "";
                        txt_HoTen.Enabled = false;
                    }
                    break;
                case 6:
                    if (txt_GioiTinh.Enabled == false)
                    {
                        txt_GioiTinh.Enabled = true;
                        TaoGioiTinh();
                    }
                    else
                    {
                        txt_GioiTinh.Enabled = false;
                        XoaGioiTinh();
                    }
                    break;
                case 7:
                    if (txt_NamSinh.Enabled == false)
                        txt_NamSinh.Enabled = true;
                    else
                        txt_NamSinh.Enabled = false;
                    break;
            }
        }
        #region --Load năm học, khối, lớp--
        private void LoadNamHoc()
        {
            DataTable abc = TraCuu.LayNamHoc();
            txtNamHoc.Items.Clear();
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtNamHoc.Items.Add(abc.Rows[i][1]);
            }
        }
        private void LoadKhoi()
        {
            txtKhoi.Items.Clear();
            txtKhoi.Items.Add("10");
            txtKhoi.Items.Add("11");
            txtKhoi.Items.Add("12");
        }
        private void LoadLop()
        {
            //txtLop.Items.Clear();
            //txtLop.Items.Add("10A1");
            //txtLop.Items.Add("11A1");
            //txtLop.Items.Add("12A1");
            txtLop.Items.Clear();
            txtLop.Enabled = true;
            DataTable abc;
            abc = TraCuu.LayDSLopHoc(txtNamHoc.Text, txtKhoi.Text);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtLop.Items.Add(abc.Rows[i][0]);
            }
        }
        private void TaoGioiTinh()
        {
            txt_GioiTinh.Items.Clear();
            txt_GioiTinh.Items.Add("Nam");
            txt_GioiTinh.Items.Add("Nữ");
        }
        #endregion
        #region --Xóa năm học, khối, lớp--
        private void XoaNamHoc()
        {
            txtNamHoc.Items.Clear();
            txtNamHoc.Items.Add("");
            txtNamHoc.SelectedIndex = 0;
        }
        private void XoaKhoi()
        {
            txtKhoi.Items.Clear();
            txtKhoi.Items.Add("");
            txtKhoi.SelectedIndex = 0;
        }
        private void XoaLop()
        {
            txtLop.Items.Clear();
            txtLop.Items.Add("");
            txtLop.SelectedIndex = 0;
        }
        private void XoaGioiTinh()
        {
            txt_GioiTinh.Items.Clear();
            txt_GioiTinh.Items.Add("");
            txt_GioiTinh.SelectedIndex = 0;
        }
        #endregion
        #region --sự kiện thay đổi chọn năm học, khối--
        private void txtNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtKhoi..ToString() != "")//chọn năm học rồi, và ở khối có chọn, ở lớp có chọn -> mở khối + load khối
            //{

            //}
            if (txtKhoi.Text.CompareTo("") == 0)
            {
                //                MessageBox.Show("không có item");
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
                txtLop.Enabled = false;
                XoaLop();
            }
            else
            {//có item
                checkBox3.Enabled = true;
                if(checkBox3.Checked == true)
                {
                    LoadLop();
                }
                else
                {
                    XoaLop();
                }

            }
        }
        private void txtKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNamHoc.Text.CompareTo("") == 0)
            {
                //                MessageBox.Show("không có item");
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
                txtLop.Enabled = false;
                XoaLop();
            }
            else
            {//có item
                checkBox3.Enabled = true;
                if (checkBox3.Checked == true)
                {
                    LoadLop();
                }
                else
                {
                    XoaLop();
                }

            }
        }
        #endregion
        #region--Lấy dữ liệu tìm kiếm--
        //nếu tất cả không có check nào -> thông báo phải có một thông tin được điền vào.
        private TraCuuPublic LayDLTimKiem()
        {
            TraCuuPublic info = new TraCuuPublic();
            info.NamHoc = txtNamHoc.Text;
            info.Khoi = txtKhoi.Text;
            info.Lop = txtLop.Text;
            info.HoTen = txt_HoTen.Text;
            info.MaHocSinh = txt_MHS.Text;
            info.GioiTinh = txt_GioiTinh.Text;
            if(checkBox7.Checked ==true)
            {
                info.NamSinh = txt_NamSinh.Value.ToString();
            }
            else
            {
                info.NamSinh = "";
            }
//            lbl_Status.Text = "Năm học: "+ info.NamHoc +"  Khối  " +info.Khoi+"  Lớp:  "+info.Lop+"   Họ Tên:  " +info.HoTen + " Mã học sinh: " +info.MaHocSinh+"   Giới tính   " +info.GioiTinh+"   Năm sinh:   "+info.NamSinh;
            return info;
        }
        private string Kiemtrathongtin()
        {
            string str = "";
            if(checkBox1.Checked ==true && txtNamHoc.Text =="")
            {
                str = "Bạn chưa chọn năm học";
            }
            if (checkBox2.Checked == true && txtKhoi.Text=="")
            {
                str = "Bạn chưa chọn khối";
            }
            if (checkBox3.Checked == true && txtLop.Text == "")
            {
                str = "Bạn chưa chọn lớp";
            }
            if (checkBox4.Checked == true && txt_MHS.Text == "")
            {
                str = "Bạn chưa điền mã học sinh";
            }
            if (checkBox5.Checked == true && txt_HoTen.Text == "")
            {
                str = "Bạn chưa điền tên";
            }
            if (checkBox6.Checked == true && txt_GioiTinh.Text == "")
            {
                str = "Bạn chưa chọn giới tính";
            }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false )
            //{
            //    str = "Bạn phải điền vào ít nhất một thông tin để tìm kiếm";
            //}
            //if (txtNamHoc.Text.CompareTo("") == 0 && txtKhoi.Text.CompareTo("") == 0 && txtLop.Text.CompareTo("") == 0 && txt_MHS.Text == "" && txt_HoTen.Text =="" && txt_GioiTinh.Text.CompareTo("") == 0 && checkBox7.Checked == false)
            //{
            //    str = "Bạn phải điền vào ít nhất một thông tin để tìm kiếm";
            //}
            return str;
        }
        #endregion
        #region --TimKiem--

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(Kiemtrathongtin()=="")
            {
                lbl_Status.Text = "";
                TraCuuPublic x = LayDLTimKiem();
                    DuLieuUp = TraCuu.TimKiem(x.NamHoc, x.Khoi, x.Lop, x.MaHocSinh, x.HoTen, x.GioiTinh, x.NamSinh);
                    Loaddulieu();
            }
            else
            {
                lbl_Status.BackColor = Color.Pink;
                lbl_Status.Text = Kiemtrathongtin();
            }
        }
        #endregion
        #region --Up dữ liệu tìm kiếm --
        private void Loaddulieu()
        {
                for (int i = 0; i < DuLieuUp.Rows.Count; i++)
                {
                    //string mm = DuLieuUp.Rows[i][3].ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);// DuLieuUp.Rows[i][3].ToString();
                    //int a = (DuLieuUp.Rows[i][3].ToString()).IndexOf(" ");
                    //mm = mm.Substring(0, a + 1);
                    //dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                    //9/24/2001
                    string mNamHoc = "20" + DuLieuUp.Rows[i][0].ToString().Substring(2, 2) + " - 20" + (Int32.Parse(DuLieuUp.Rows[i][0].ToString().Substring(2, 2)) + 1).ToString();
                    string ngay = DuLieuUp.Rows[i][3].ToString();
                    int m1 = ngay.LastIndexOf("/");
                    int m2 = ngay.IndexOf("/"); //--------------Năm-------------------------------------Tháng-----------------------------------------------Ngày----------------------
                    //tB_NgaySinh.Value = new DateTime(int.Parse(ngay.Substring(m1 + 1, 4)), int.Parse(ngay.Substring(m2 + 1, m1 - m2 - 1)), int.Parse(ngay.Substring(0, m2)), 0, 0, 0);
                   // ---------------------------------------------------------------------------------------------------------------------------ngày sinh---
                    string ngayud = ngay.Substring(m2 + 1, m1 - m2 - 1) + "/" + ngay.Substring(0, m2) + "/" + ngay.Substring(m1 + 1, 4);
                    dataGridView1.Rows.Add("", DuLieuUp.Rows[i][0], DuLieuUp.Rows[i][1], DuLieuUp.Rows[i][2].ToString().Substring(4, 4),"","", ngayud, DuLieuUp.Rows[i][4].ToString(), DuLieuUp.Rows[i][5], DuLieuUp.Rows[i][6], mNamHoc);
                }
            // ở đây code load dữ liệu điểm TB HK1 và TKHK2
                for (int i = 0; i < dataGridView1.RowCount;i++ )
                {
                    float DTBHS = 0;
                    DTBHS = TraCuu.DTB(dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[10].Value.ToString(),"1");
                    dataGridView1.Rows[i].Cells[4].Value = (Math.Round(DTBHS, 2)).ToString();
                    DTBHS = TraCuu.DTB(dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[10].Value.ToString(), "2");
                    dataGridView1.Rows[i].Cells[5].Value = (Math.Round(DTBHS,2)).ToString();
                }
                for (int i=0;i<dataGridView1.RowCount;i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i+1).ToString();
                }
            }

        #endregion
        #region --Sắp xếp trong dataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        #endregion
    }
}
