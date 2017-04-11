using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Public;
using BLL;

namespace NMCNPM
{
    public partial class frm_PhanLop : Form
    {
        public frm_PhanLop()
        {
            InitializeComponent();
            btn_PhanLop.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = false;
        }
        DataTable DuLieu;
        TiepNhanBLL PhanLop = new TiepNhanBLL();
        public string form_truoc { get; set; }
        public void LayDuLieu(DataTable hocsinh)
        {
            DuLieu = hocsinh;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_PhanLop_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            if (form_truoc == "TiepNhan")
            {
                string MHS = "";
                string Lop = "";
                for (int i = 0; i < DuLieu.Rows.Count; i++)
                {
                    MHS = "Học sinh mới";
                    Lop = "Chưa nhận lớp";
                    dataGridView1.Rows.Add(DuLieu.Rows[i][0], MHS, DuLieu.Rows[i][1], Lop, DuLieu.Rows[i][2], DuLieu.Rows[i][3], DuLieu.Rows[i][4], DuLieu.Rows[i][5], DuLieu.Rows[i][6], DuLieu.Rows[i][7]);
                }
            }
            else
            {
                //code cách load dữ liệu lấy từ form xem danh sách lớp
                for (int i = 0; i < DuLieu.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add("", DuLieu.Rows[i][1], DuLieu.Rows[i][2], DuLieu.Rows[i][9], DuLieu.Rows[i][3], DuLieu.Rows[i][4], DuLieu.Rows[i][5], DuLieu.Rows[i][6], DuLieu.Rows[i][7], DuLieu.Rows[i][8]);
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ngay = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                int m1 = ngay.LastIndexOf("/");
                int m2 = ngay.IndexOf("/");
                tB_NgaySinh.Value = new DateTime(int.Parse(ngay.Substring(m1 + 1, 4)), int.Parse(ngay.Substring(m2 + 1, m1 - m2 - 1)), int.Parse(ngay.Substring(0, m2)), 0, 0, 0);
                tB_MHS.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tB_Ten.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_GioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tB_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tB_DiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_NamHoc.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_Khoi.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_LopCu.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                btn_PhanLop.Enabled = true;
                btn_Xoa.Enabled = false;
                label6.Text = "";
                LoadDSLop();
            }
            catch
            {
                //label6.Text ="Bị lỗi, không được click ngoài bảng dữ liệu";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ngay = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                int m1 = ngay.LastIndexOf("/");
                int m2 = ngay.IndexOf("/");
                tB_NgaySinh.Value = new DateTime(int.Parse(ngay.Substring(m1 + 1, 4)), int.Parse(ngay.Substring(m2 + 1, m1 - m2 - 1)), int.Parse(ngay.Substring(0, m2)), 0, 0, 0);
                tB_MHS.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                tB_Ten.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_GioiTinh.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                tB_Email.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                tB_DiaChi.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_NamHoc.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_Khoi.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                cB_LopMoi.Items.Clear();
                cB_LopMoi.Items.Add(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                cB_LopMoi.SelectedIndex = 0;
                txt_LopCu.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = true;
                btn_PhanLop.Enabled = false;
                cB_LopMoi.Enabled = false;
            }
            catch
            {
                //               MessageBox.Show("Bị lỗi, không được click ngoài bảng dữ liệu");
            }
        }

        private void LoadDSLop()
        {
            cB_LopMoi.Items.Clear();
            cB_LopMoi.Enabled = true;
            DataTable abc;
            abc = PhanLop.LayDSLopHoc(txt_NamHoc.Text, txt_Khoi.Text);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                cB_LopMoi.Items.Add(abc.Rows[i][0]);
            }

        }
        #region--sắp xếp STT trong DGV--
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
        private void btn_PhanLop_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
                {
                    if (cB_LopMoi.Text != "")
                    {
                        dataGridView2.Rows.Add(" ", tB_MHS.Text, tB_Ten.Text, cB_LopMoi.Text, tB_NgaySinh.Text, txt_GioiTinh.Text, tB_Email.Text, tB_DiaChi.Text, txt_NamHoc.Text, txt_Khoi.Text, txt_LopCu.Text);
                        dataGridView1.Rows.RemoveAt(item.RowIndex);
                        btn_PhanLop.Enabled = false;
                        // Cài đặt lại số thứ tự
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                        }
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            dataGridView2.Rows[i].Cells[0].Value = (i + 1).ToString();
                        }
                    }
                    else label6.Text = "Chưa chọn lớp mới!, bạn kiểm tra lại";
                }
            }
            catch
            {
            }
            if (dataGridView2.RowCount > 0)
            {
                btn_Luu.Enabled = true;
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell item in this.dataGridView2.SelectedCells)
                {
                    dataGridView1.Rows.Add(" ", tB_MHS.Text, tB_Ten.Text, txt_LopCu.Text, tB_NgaySinh.Text, txt_GioiTinh.Text, tB_Email.Text, tB_DiaChi.Text, txt_NamHoc.Text, txt_Khoi.Text);
                    dataGridView2.Rows.RemoveAt(item.RowIndex);
                    btn_Xoa.Enabled = false;
                    // Cài đặt lại số thứ tự
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView2.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                }
            }
            catch
            {
            }
            if (dataGridView2.RowCount <= 0)
            {
                btn_Luu.Enabled = false;
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //khi chọn button này thì sẽ lưu dữ liệu bên datagridView 2 xuống, lưu xong sẽ xóa dữ liệu ở đó đi.
            //kiểm tra sĩ số tối đa so với só học sinh sau khi tăng 1
            LuuDuLieu();
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        private void LuuDuLieu()
        {
            if (form_truoc == "TiepNhan")
            {
                #region--lưu dữ liệu với xử lý tiếp nhận--
                //kiểm tra sĩ số tối đa ở đây
                if (PhanLop.SiSo(txt_NamHoc.Text, cB_LopMoi.Text) >= PhanLop.SiSoToiDa())
                {
                    label6.Text = "Đã vượt quá sĩ số tối đa, không thể thêm sinh viên được nữa";
                }
                else
                {
                    try
                    {

                        for (int i = 0; i < dataGridView2.RowCount; i++)// tại đây đã xóa -1, nếu có lỗi, sửa tại chỗ này
                        {
                            string mMaHS = "";
                            string ngay = dataGridView2.Rows[i].Cells[4].Value.ToString();
                            if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "Học sinh mới")
                            {
                                mMaHS = ""; //trường hợp học sinh chưa có mã học sinh-> mã học sinh trống
                            }
                            else// trường hợp học sinh đã có mã học sinh, nên mMaHS là mã học sinh hiện tại
                            {
                                mMaHS = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            }
                            string mMaLop = "LP" + dataGridView2.Rows[i].Cells[8].Value.ToString().Substring(2, 2) + dataGridView2.Rows[i].Cells[3].Value.ToString();
                            DateTime mngay = new DateTime(int.Parse(ngay.Substring(6, 4)), int.Parse(ngay.Substring(3, 2)), int.Parse(ngay.Substring(0, 2)), 0, 0, 0);
                            //           mã học sinh trống            năm học                                        Họ tên                      ngày sinh                        Email                                        giới tính                         địa chỉ
                            PhanLop.LuuHocSinh(mMaHS, dataGridView2.Rows[i].Cells[8].Value.ToString(), dataGridView2.Rows[i].Cells[2].Value.ToString(), mngay, dataGridView2.Rows[i].Cells[6].Value.ToString(), dataGridView2.Rows[i].Cells[5].Value.ToString(), dataGridView2.Rows[i].Cells[7].Value.ToString(), mMaLop);
                        }
                        dataGridView2.Rows.Clear();
                        label6.Text = "Lưu dữ liệu thành công !";
                    }
                    catch
                    {
                        label6.Text = "Lỗi lưu dữ liệu!";
                    }
                }              
                #endregion
            }
            else
            #region--Update dữ liệu với xử lý chuyển lớp--
            {
                if (PhanLop.SiSo(txt_NamHoc.Text, cB_LopMoi.Text) >= PhanLop.SiSoToiDa())
                {
                    label6.Text = "Đã vượt quá sĩ số tối đa, không thể thêm sinh viên được nữa";
                }
                else
                {
                    if(PhanLop.SiSo(txt_NamHoc.Text,txt_LopCu.Text)<=PhanLop.SiSoToiThieu())
                    {
                        label6.Text = "Lỗi sĩ số tối thiểu!";
                    }
                    else
                    {
                        try
                        {
                            for (int i = 0; i < dataGridView2.RowCount; i++)
                            {
                                string ngay = dataGridView2.Rows[i].Cells[4].Value.ToString();
                                string mMaHS = dataGridView2.Rows[i].Cells[1].Value.ToString();
                                string mMaLop = "LP" + dataGridView2.Rows[i].Cells[8].Value.ToString().Substring(2, 2) + dataGridView2.Rows[i].Cells[3].Value.ToString();
                                DateTime mngay = new DateTime(int.Parse(ngay.Substring(6, 4)), int.Parse(ngay.Substring(3, 2)), int.Parse(ngay.Substring(0, 2)), 0, 0, 0);
                                //           mã học sinh trống            năm học                                        Họ tên                      ngày sinh                        Email                                        giới tính                         địa chỉ
                                PhanLop.LuuHocSinh(mMaHS, dataGridView2.Rows[i].Cells[8].Value.ToString(), dataGridView2.Rows[i].Cells[2].Value.ToString(), mngay, dataGridView2.Rows[i].Cells[6].Value.ToString(), dataGridView2.Rows[i].Cells[5].Value.ToString(), dataGridView2.Rows[i].Cells[7].Value.ToString(), mMaLop);
                            }
                            dataGridView2.Rows.Clear();
                            label6.Text = "Lưu dữ liệu thành công !";

                        }
                        catch
                        {
                            label6.Text = "Lỗi lưu dữ liệu!";
                        }
                    }
                }
            }
            #endregion
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            //code lấy các dữ liệu còn lại trả về dgv1 từ dgv2
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView1.Rows.Add(" ", dataGridView2.Rows[i].Cells[1].Value.ToString(), dataGridView2.Rows[i].Cells[2].Value.ToString(), dataGridView2.Rows[i].Cells[10].Value.ToString(), dataGridView2.Rows[i].Cells[4].Value.ToString(), dataGridView2.Rows[i].Cells[5].Value.ToString(), dataGridView2.Rows[i].Cells[6].Value.ToString(), dataGridView2.Rows[i].Cells[7].Value.ToString(), dataGridView2.Rows[i].Cells[8].Value.ToString(), dataGridView2.Rows[i].Cells[9].Value.ToString());
            }

            for (int i = 0; i < dataGridView1.RowCount; i++) // sắp xếp lại stt bên dgv1
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            //
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
        private void frm_PhanLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }

        private void cB_LopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void frm_PhanLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (form_truoc == "TiepNhan")
            {
                frm_TiepNhanHocSinh.DuLieuLayVe = GetDataTableFromDGV(dataGridView1);
            }
            else
            {
            }
        }
    }
}
