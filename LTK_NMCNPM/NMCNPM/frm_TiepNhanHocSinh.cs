using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Public;

namespace NMCNPM
{
    public partial class frm_TiepNhanHocSinh : Form
    {
        #region --biến khởi tạo--
        static public DataTable DuLieuLayVe { set; get; }
        TiepNhanBLL tiepnhan = new TiepNhanBLL();
        public int conxoaduoc = 0; //biến này vừa có tác dụng xác định có xóa được hay không, vừa tính toán số thứ tự khi thêm hoặc xóa học sinh
        DataTable HocSinh;
        // lấy dữ liệu qua form Phân lớp thực hiện -> sử dụng delegate
        public delegate void LayDuLieufmPhanLop(DataTable hocsinh);
        #endregion
        public frm_TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            this.Close();
        }
        private void btn_PhanLop_Click(object sender, EventArgs e)
        {
            frm_PhanLop PhanLop = new frm_PhanLop();
            PhanLop.form_truoc = "TiepNhan";
            HocSinh = GetDataTableFromDGV(dgv_TiepNhan);
            
            LayDuLieufmPhanLop DuLieu = new LayDuLieufmPhanLop(PhanLop.LayDuLieu);
            DuLieu(this.HocSinh);
            PhanLop.ShowDialog();
            LoadDuLieuTraVe();
        }
        private void LoadDuLieuTraVe() //lấy dữ liệu bỏ vô dgv lại.
        {

            try
            {
                dgv_TiepNhan.Rows.Clear();
                if (DuLieuLayVe.Rows.Count > 0)
                {
                    for (int i = 0; i < DuLieuLayVe.Rows.Count; i++)
                    {
                        conxoaduoc = DuLieuLayVe.Rows.Count;// chạy demo xem thử có cộng thêm 1 hay không
                        dgv_TiepNhan.Rows.Add(DuLieuLayVe.Rows[i][0], DuLieuLayVe.Rows[i][2], DuLieuLayVe.Rows[i][4], DuLieuLayVe.Rows[i][5], DuLieuLayVe.Rows[i][6], DuLieuLayVe.Rows[i][7], DuLieuLayVe.Rows[i][8], DuLieuLayVe.Rows[i][9]);
                    }
                }
                else
                {
                    btn_Xoa.Enabled = false;
                    conxoaduoc = 0;
                }
            }
            catch
            { }
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void txtNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
            txtKhoi.Enabled = true;
            txtKhoi.Items.Clear();
            txtKhoi.Items.Add("10");
            txtKhoi.Items.Add("11");
            txtKhoi.Items.Add("12");
            label10.Text = "";
        }

        private void frm_TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            DuLieuLayVe = new DataTable();
            txt_STT.Text = conxoaduoc.ToString();
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            DataTable abc = tiepnhan.LayNamHoc();
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtNamHoc.Items.Add(abc.Rows[i][1]);
            }
            txt_STT.Text = "1";
            btn_Xoa.Enabled = false;
            btn_PhanLop.Enabled = false;

        }
        private void frm_TiepNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            int tuoi = DateTime.Now.Year - tB_NgaySinh.Value.Year + 1;
            if (txtNamHoc.Text == "" || txtKhoi.Text == "" || txt_STT.Text == "" || tB_GioiTinh.Text == "" || tB_Ten.Text == "" || tB_NgaySinh.Text == "" || tB_Email.Text == "" || tB_DiaChi.Text == "")
            {
                label10.Text = "Chưa điền đầy đủ thông tin!";
            }
            else
            if (tiepnhan.KiemTraTuoi(tuoi) == false)
            {
                label10.Text = "Sai quy định tuổi! Bạn kiểm tra lại!";
            }
            else
            {
                string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(match);
                if (reg.IsMatch(this.tB_Email.Text))
                {
                    conxoaduoc++;
                    dgv_TiepNhan.Rows.Add((conxoaduoc).ToString(), tB_Ten.Text, tB_NgaySinh.Text, tB_GioiTinh.Text, tB_Email.Text, tB_DiaChi.Text, txtNamHoc.Text, txtKhoi.Text);
                    txt_STT.Text = (conxoaduoc + 1).ToString();
                    for (int i = 0; i < conxoaduoc; i++)
                    {//sắp xếp lại số thứ tự cho dgv
                        dgv_TiepNhan.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                }
                else label10.Text = "Email chưa đúng!";
            }
            if (conxoaduoc < 1)
            {
                btn_Xoa.Enabled = false;
                btn_PhanLop.Enabled = false;
                btn_PhanLop.Enabled = false;
            }
            else
            {
                btn_Xoa.Enabled = true;
                btn_PhanLop.Enabled = true;
            }

        }
        private void Frm_TiepNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (conxoaduoc > 0)
            {
                DialogResult thoat_qs;
                thoat_qs = MessageBox.Show("Dữ liệu còn lại sẽ bị mất!", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (thoat_qs == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
                   
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            if (conxoaduoc == 0)
            {// không xóa được nữa

            }
            else //xóa được
            {
                int rowIndex = dgv_TiepNhan.CurrentCell.RowIndex;
                dgv_TiepNhan.Rows.RemoveAt(rowIndex);
                conxoaduoc--;
                for (int i = 0; i < conxoaduoc; i++)
                {//sắp xếp lại số thứ tự cho dgv
                    dgv_TiepNhan.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
                if (conxoaduoc == 0)
                {
                    btn_Xoa.Enabled = false;
                    btn_PhanLop.Enabled = false;
                }
            }
        }
        private void dgv_TiepNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ngay = dgv_TiepNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                tB_NgaySinh.Value = new DateTime(int.Parse(ngay.Substring(6, 4)), int.Parse(ngay.Substring(3, 2)), int.Parse(ngay.Substring(0, 2)), 0, 0, 0);
                txt_STT.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                tB_Ten.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                //     tB_NgaySinh.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                tB_GioiTinh.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                tB_Email.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                tB_DiaChi.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNamHoc.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtKhoi.Text = dgv_TiepNhan.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {
//                MessageBox.Show("Bị lỗi, không được click ngoài bảng dữ liệu");
            }
        }
        /// <summary>
        /// Khi thay đổi item trên STT gán status trống
        /// </summary>
        private void txt_STT_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }
        #region--sắp xếp STT trong DGV--
        private void dgv_TiepNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_TiepNhan.RowCount; i++)
            {
                dgv_TiepNhan.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void dgv_TiepNhan_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgv_TiepNhan.RowCount; i++)
            {
                dgv_TiepNhan.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        #endregion

        private void txtKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }
        private void tB_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }
    }
}
