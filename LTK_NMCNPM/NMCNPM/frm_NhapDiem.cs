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
    public partial class frm_NhapDiem : Form
    {
        NhapDiemBLL NhapDiem = new NhapDiemBLL();
        XemDSLopBLL DSL = new XemDSLopBLL();
        public frm_NhapDiem()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_NhapDiem_Load(object sender, EventArgs e)
        {
            txtNamHoc.Enabled = true;
            txtKhoi.Enabled = false;
            txtLop.Enabled = false;
            txtHocKy.Enabled = false;
            txtMon.Enabled = false;
            btn_Luu.Enabled = false;
            LoadNamHoc();
        }
        private void txtNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKhoi.Enabled = true;
            txtLop.Enabled = false;
            txtHocKy.Enabled = false;
            txtMon.Enabled = false;
            btn_Luu.Enabled = false;
            LoadKhoi();
        }
          private void txtKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLop.Enabled = true;
            txtHocKy.Enabled = false;
            txtMon.Enabled = false;
            btn_Luu.Enabled = false;
            LoadLop();
        }
        private void txtLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHocKy.Enabled = true;
            txtMon.Enabled = false;
            btn_Luu.Enabled = false;
            txtHocKy.Items.Clear();
            txtHocKy.Items.Add("Học kỳ 1");
            txtHocKy.Items.Add("Học kỳ 2");
        }
        private void txtHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMon.Enabled = true;
            btn_Luu.Enabled = false;
            LoadMon();
        }
        private void txtMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void LoadNamHoc()
        {
            DataTable abc = NhapDiem.LayNamHoc();
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
            txtLop.Items.Clear();
            DataTable abc;
            abc = NhapDiem.LayDSLopHoc(txtNamHoc.Text, txtKhoi.Text);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtLop.Items.Add(abc.Rows[i][0]);
            }
        }
        private void LoadMon()
        {
            txtMon.Items.Clear();
            txtMon.Items.Add("Toán");
            txtMon.Items.Add("Ngữ Văn");
            txtMon.Items.Add("Ngoại Ngữ");
            txtMon.Items.Add("Vật Lý");
            txtMon.Items.Add("Hóa Học");
            txtMon.Items.Add("Sinh Học");
            txtMon.Items.Add("Lịch Sử");
            txtMon.Items.Add("Địa Lý");
            txtMon.Items.Add("Tin Học");
            txtMon.Items.Add("Thể Dục");
            txtMon.Items.Add("GDCD");
            txtMon.Items.Add("GDQP");
            txtMon.Items.Add("Công Nghệ");
        }
        private void LoadDuLieu()
        {
            btn_Luu.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            #region - load ds lớp--
            DataTable dsl = DSL.LayDuLieu(txtNamHoc.Text,txtLop.Text);
            for (int i = 0; i < dsl.Rows.Count; i++)
            {
                dataGridView1.Rows.Add("", dsl.Rows[i][0], dsl.Rows[i][1],"","","","");
                dataGridView2.Rows.Add("0", "0", "0");
            }
            #endregion
            #region -Load Điểm-
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataTable dsd = NhapDiem.LayDSDiem(dataGridView1.Rows[i].Cells[1].Value.ToString(), txtNamHoc.Text, txtMon.Text, txtHocKy.Text);
                for (int j = 0; j < 3; j++)
                {
                    int g = dsd.Rows.Count;
                    if (dsd.Rows.Count > 0)
                    {
                        dataGridView1.Rows[i].Cells[j + 3].Value = dsd.Rows[0][j + 1]; // load điểm lên dgv1
                        dataGridView2.Rows[i].Cells[j].Value = dsd.Rows[0][j + 1]; // load điểm lên dgv 2
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j + 3].Value = "0";//dsd.Rows[0][j - 2]; // trường hợp chưa có điểm trong dữ liệu
                        dataGridView2.Rows[i].Cells[j].Value = "0";
                    }
                }
            }
            #endregion
            TinhDiemTB();
            #region-không cho sắp xếp
            foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn dgvc in dataGridView2.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion
            #region-Add Số thứ tự
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            #endregion

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {try
            {
                btn_Luu.Enabled = true;
            }
            catch
            {
                btn_Luu.Enabled = true;
            }
        }
        public void TinhDiemTB()
        {
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                float diem1 = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());//15p
                float diem2 = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());//giữa kỳ
                float diem3 = float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());//cuối kỳ
                dataGridView1.Rows[i].Cells[6].Value = Math.Round((diem1 * 1 + diem2 * 2 + diem3 * 3) / 6, 2);
            }
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)//kiểm tra điểm khi sửa, nhập
        {
            btn_Luu.Enabled = true;
            DataGridViewCell cuCell = dataGridView2.CurrentCell;
            string mainStr = dataGridView2.CurrentCell.Value.ToString();
            if(mainStr[0]=='0')
            {
                MessageBox.Show("Không được có số 0 đầu tiên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView2.CurrentCell.Value = 0;
                dataGridView2.ClearSelection();
                dataGridView2.CurrentCell = cuCell;
                dataGridView2.CurrentCell.Selected = true;
            }
            else
            {
                for (int scan = 0; scan < mainStr.Length; scan++)
                {
                    if (kiemtrachar(mainStr[scan])) { }
                    else
                    {
                        MessageBox.Show("Chỉ được nhập số, và phải >= 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridView2.CurrentCell.Value = 0;
                        dataGridView2.ClearSelection();
                        dataGridView2.CurrentCell = cuCell;
                        dataGridView2.CurrentCell.Selected = true;
                        break;
                    }
                }
            }
            if(double.Parse(cuCell.Value.ToString())>10.0)
            {
                MessageBox.Show("Số <=10 và >=0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView2.CurrentCell.Value = 0;
                dataGridView2.ClearSelection();
                dataGridView2.CurrentCell = cuCell;
                dataGridView2.CurrentCell.Selected = true;
            }
        }
        private bool kiemtrachar(char x)
        {
            bool kt = false;
            if (x == '0'|| x == '1' || x == '2' || x == '3' || x == '4' || x == '5' || x == '6' || x == '7' || x == '8' || x == '9' || x == '.')
            { kt = true; }
            return kt;
        }
        private void LuuDuLieuXuong()
        {
            #region --//copy dữ liệu từ dgv2->dgv1
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = dataGridView2.Rows[i].Cells[0].Value.ToString();
                dataGridView1.Rows[i].Cells[4].Value = dataGridView2.Rows[i].Cells[1].Value.ToString();
                dataGridView1.Rows[i].Cells[5].Value = dataGridView2.Rows[i].Cells[2].Value.ToString();
            }
            #endregion
            #region --// lưu dgv1 xuống.
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                //lưu dữ liệu mỗi dòng. lưu điểm dựa vào mã HS, mã học kỳ, mã môn
                NhapDiem.LuuDiem(dataGridView1.Rows[i].Cells[1].Value.ToString(), txtNamHoc.Text, txtMon.Text, txtHocKy.Text,float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()), float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()),float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
            }
            #endregion
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // lưu dữ liệu xuống/
            LuuDuLieuXuong();
            TinhDiemTB();
            //load lại dữ liệu lên.
        }
    }
}
