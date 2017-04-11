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
    public partial class frm_XemDanhSachLop : Form
    {
        XemDSLopBLL XemDSL = new XemDSLopBLL();
        DataTable HocSinh = new DataTable();
        DataGridViewRow row = new DataGridViewRow();
        public delegate void LayDuLieuFrm(DataTable hocsinh);
        static public string quyendangnhap { set; get; }
        public frm_XemDanhSachLop()
        {
            InitializeComponent();
        }
        private void Quyen()
        {
            if(quyendangnhap == "MNDQT" || quyendangnhap == "MNDHT")
            {

            }
            else
            {
                btn_ChuyenLop.Enabled = false;
                btn_SuaHoSoHocSinh.Enabled = false;
                btn_XoaHoSo.Enabled = false;
            }
        }
        #region --button click--
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ChuyenLop_Click(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            HocSinh = GetDataTableFromDGV();
            if (HocSinh.Rows.Count <= 0)
            {
                lbl_status.Text = "Bạn chưa chọn dữ liệu";
            }
            else
            {
                lbl_status.Text = "";
                frm_PhanLop ChuyenLop = new frm_PhanLop();
                ChuyenLop.form_truoc = "DSL";
                LayDuLieuFrm DuLieu = new LayDuLieuFrm(ChuyenLop.LayDuLieu);
                DuLieu(this.HocSinh);
                ChuyenLop.ShowDialog();
                LoadDuLieu();
            }
        }
        private void btn_SuaHoSoHocSinh_Click(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            HocSinh = GetDataFromSelectDGV();
            int abc = HocSinh.Rows.Count;
            if (HocSinh.Rows.Count <= 0)
            {
                lbl_status.Text = "Bạn chưa chọn dữ liệu";
            }
            else
            {
                lbl_status.Text = "";
                frm_SuaHoSo SuaHoSo = new frm_SuaHoSo();
                LayDuLieuFrm DuLieu = new LayDuLieuFrm(SuaHoSo.LayDuLieu);
                DuLieu(this.HocSinh);
                SuaHoSo.ShowDialog();
                LoadDuLieu();
            }
        }
        private void btn_XoaHoSo_Click(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            HocSinh = GetDataFromSelectDGV();
            int abc = HocSinh.Rows.Count;
            if (HocSinh.Rows.Count <= 0)
            {
                lbl_status.Text = "Bạn chưa chọn dữ liệu";
            }
            else
            {
                lbl_status.Text = "";
                frm_XoaHoSoHocSinh XoaHoSo = new frm_XoaHoSoHocSinh();
                LayDuLieuFrm DuLieu = new LayDuLieuFrm(XoaHoSo.LayDuLieu);
                DuLieu(this.HocSinh);
                XoaHoSo.ShowDialog();
                LoadDuLieu();
            }
        }
        private void btn_XemDiemLop_Click(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            HocSinh = GetNamLop();
            int abc = HocSinh.Rows.Count;
            if (HocSinh.Rows.Count <= 0)
            {
                lbl_status.Text = "Lớp không có học sinh";
            }
            else
            {
                lbl_status.Text = "";
                frm_XemDiemLop XemDiemLop = new frm_XemDiemLop();
                LayDuLieuFrm DuLieu = new LayDuLieuFrm(XemDiemLop.LayDuLieu);
                DuLieu(this.HocSinh);
                XemDiemLop.ShowDialog();
                LoadDuLieu();
            }
        }
        #endregion
        #region--Load--
        private void LoadNamHoc()
        {
            btn_XoaHoSo.Enabled = false;
            btn_XemDiemLop.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            lbl_status.Text = "";
            txt_SiSo.Enabled = false;
            txt_SiSo.Text = "";
            lal_GVCN.Text = "";
            DataTable abc = XemDSL.LayNamHoc();
            txtNamHoc.Items.Clear();
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtNamHoc.Items.Add(abc.Rows[i][1]);
            }
        }
        private void LoadLop()
        {
            btn_XoaHoSo.Enabled = false;
            btn_XemDiemLop.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            lbl_status.Text = "";
            txtLop.Items.Clear();
            txtLop.Enabled = true;
            DataTable abc;
            abc = XemDSL.LayDSLopHoc(txtNamHoc.Text, txtKhoi.Text);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtLop.Items.Add(abc.Rows[i][0]);
            }
        }
        private void txtNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {//load khối
            btn_XoaHoSo.Enabled = false;
            btn_XemDiemLop.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            lbl_status.Text = "";
            txtKhoi.Enabled = true;
            txtKhoi.Items.Clear();
            txtKhoi.Items.Add("10");
            txtKhoi.Items.Add("11");
            txtKhoi.Items.Add("12");
            txtLop.Enabled = false;
            txtLop.Items.Clear();
            txt_SiSo.Text = "";
            lal_GVCN.Text = "";
        }
        private void LoadDuLieu()
        {
            btn_XoaHoSo.Enabled = false;
            btn_XemDiemLop.Enabled = true;
            btn_SuaHoSoHocSinh.Enabled = false;
            Quyen();
            lbl_status.Text = "";
            dataGridView1.Rows.Clear();
            DataTable DL = XemDSL.LayDuLieu(txtNamHoc.Text.ToString(), txtLop.Text.ToString());
            int x = DL.Rows.Count;
            if (DL.Rows.Count == 0)
            {
                lal_GVCN.Text = "";
                txt_SiSo.Text = "0";
            }
            else
            {
                lal_GVCN.Text =  DL.Rows[0][7].ToString();
                txt_SiSo.Text = DL.Rows[0][6].ToString();
            }
            for (int i = 0; i < DL.Rows.Count; i++)
            {
                string n = DL.Rows[i][2].ToString();
                int m1 = n.IndexOf("/");
                int m2 = n.LastIndexOf("/");
                string ngay = n.Substring(m1 + 1, m2 - m1) + n.Substring(0, m1 + 1) + n.Substring(m2 + 1, 4);
                dataGridView1.Rows.Add("", DL.Rows[i][0], DL.Rows[i][1],ngay, DL.Rows[i][3], DL.Rows[i][4], DL.Rows[i][5]);
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void frm_XemDanhSachLop_Load(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_XemDiemLop.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            LoadNamHoc();
        }
        private void txtKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_XoaHoSo.Enabled = false;
            btn_SuaHoSoHocSinh.Enabled = false;
            txtLop.Enabled = true;
            txt_SiSo.Text = "";
            lal_GVCN.Text = "";
            txtLop.Items.Clear();
            LoadLop();
        }

        private void txtLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        #endregion
        private DataTable GetNamLop()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NamHoc", typeof(string));
            dt.Columns.Add("Lop", typeof(string));
            dt.Columns.Add("GiaoVienChuNhiem", typeof(string));
            dt.Columns.Add("SiSo", typeof(string));
            DataRow row2 = dt.NewRow();
            row2["NamHoc"] = txtNamHoc.Text;
            row2["Lop"] = txtLop.Text;
            row2["GiaoVienChuNhiem"] =lal_GVCN.Text;
            row2["SiSo"] = txt_SiSo.Text;
            dt.Rows.Add(row2);
            return dt;
        }
        private DataTable GetDataFromSelectDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(string));
            dt.Columns.Add("Column2", typeof(string));
            dt.Columns.Add("Column3", typeof(string));
            dt.Columns.Add("Column4", typeof(string));
            dt.Columns.Add("Column5", typeof(string));
            dt.Columns.Add("Column6", typeof(string));
            dt.Columns.Add("Column7", typeof(string));
            dt.Columns.Add("Column8", typeof(string));
            dt.Columns.Add("Column9", typeof(string));
            dt.Columns.Add("Column10", typeof(string));
            DataRow row2=dt.NewRow();
            row2["Column1"] = row.Cells[0].Value.ToString();
            row2["Column2"] = row.Cells[1].Value.ToString();
            row2["Column3"] = row.Cells[2].Value.ToString();
            //string n = row.Cells[3].Value.ToString();
            //int m1 = n.IndexOf("/");
            //int m2 = n.LastIndexOf("/");
            //row2["Column4"] = n.Substring(m1 + 1, m2 - m1) + n.Substring(0, m1 + 1) + n.Substring(m2 + 1, 4);
            row2["Column4"] = row.Cells[3].Value.ToString();
            row2["Column5"] = row.Cells[4].Value.ToString();
            row2["Column6"] = row.Cells[5].Value.ToString();
            row2["Column7"] = row.Cells[6].Value.ToString();
            row2["Column8"] = txtNamHoc.Text;
            row2["Column9"] = txtKhoi.Text;
            row2["Column10"] = txtLop.Text;
            dt.Rows.Add(row2);
            //"  3  HS14019  Nguy?n Vi?t Hà  18/1/1999  Nam  bichngoc987@gmail.com  Bà R?a Vung Tàu  2014 - 2015  11  11B2"
            return dt;
        }
        private DataTable GetDataTableFromDGV()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataRow row;
                if (dataGridView1.Rows[i].Selected == true)
                {
                    row = dt.NewRow();
                    row["Column1"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    row["Column2"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    row["Column3"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    //row["Column4"] = dataGridView1.Rows[i].Cells[3].Value.ToString();//ngày sinh
                    //string n = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    //int m1 = n.IndexOf("/");
                    //int m2 = n.LastIndexOf("/");
                    //row["Column4"] = n.Substring(m1 + 1, m2 - m1) + n.Substring(0, m1 + 1) + n.Substring(m2 + 1, 4);
                    row["Column4"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    row["Column5"] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    row["Column6"] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    row["Column7"] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    dt.Rows.Add(row);
                }
            }
            dt.Columns.Add("NamHoc", typeof(string));
            dt.Columns.Add("Khoi", typeof(string));
            dt.Columns.Add("Lop", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["NamHoc"] = txtNamHoc.Text;
                dt.Rows[i]["Khoi"] = txtKhoi.Text;
                dt.Rows[i]["Lop"] = txtLop.Text;
            }
            return dt;
        }
        #region--sắp xếp STT trong DGV--
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_status.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_status.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    this.contextMenuStrip1.Show(this.dataGridView1, new Point(e.X, e.Y));
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_SuaHoSoHocSinh.Enabled = true;
                btn_XoaHoSo.Enabled = true;
                Quyen();
                lbl_status.Text = "";
                if (e.RowIndex >= 0)
                {
                    row = dataGridView1.Rows[e.RowIndex];
                }
            }
            catch
            { }
        }
    }
    #endregion

}
