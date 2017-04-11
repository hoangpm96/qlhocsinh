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
    public partial class frm_BaoCaoTongKet : Form
    {
        BaoCaoTongKetBLL BaoCao = new BaoCaoTongKetBLL();
        DataTable DSLop = new DataTable();
        public frm_BaoCaoTongKet()
        {
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNamHoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHocKy1.Enabled = true;
            txtMonHoc.Enabled = false;
            dgv1.Rows.Clear();
            //Load học kỳ
            txtHocKy1.Items.Clear();
            txtHocKy1.Items.Add("Học kỳ 1");
            txtHocKy1.Items.Add("Học kỳ 2");
            txtMonHoc.Items.Clear();
        }
        private void txtHocKy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMonHoc.Enabled = true;
            dgv1.Rows.Clear();
            //Load môn
            txtMonHoc.Items.Clear();
            txtMonHoc.Items.Add("Toán");
            txtMonHoc.Items.Add("Ngữ Văn");
            txtMonHoc.Items.Add("Ngoại Ngữ");
            txtMonHoc.Items.Add("Vật Lý");
            txtMonHoc.Items.Add("Hóa Học");
            txtMonHoc.Items.Add("Sinh Học");
            txtMonHoc.Items.Add("Lịch Sử");
            txtMonHoc.Items.Add("Địa Lý");
            txtMonHoc.Items.Add("Tin Học");
            txtMonHoc.Items.Add("Thể Dục");
            txtMonHoc.Items.Add("GDCD");
            txtMonHoc.Items.Add("GDQP");
            txtMonHoc.Items.Add("Công Nghệ");
        }
        private void txtMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load tất cả các lớp vào năm học 20xx
            #region -load lớp-
            DSLop = BaoCao.LoadLop(txtNamHoc1.Text);
            dgv1.Rows.Clear();
            for (int i = 0; i < DSLop.Rows.Count; i++)
            {
                dgv1.Rows.Add("", DSLop.Rows[i][0], DSLop.Rows[i][1], "", "");
            }
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                dgv1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            #endregion
            #region - Load Số lượng học sinh đạt - và từ đó tính tỉ lệ đạt
            for (int i = 0; i < DSLop.Rows.Count; i++)
            {
                dgv1.Rows[i].Cells[3].Value = BaoCao.Dem(DSLop.Rows[i][2].ToString(), txtMonHoc.Text, txtHocKy1.Text, txtNamHoc1.Text);
                dgv1.Rows[i].Cells[4].Value = (Math.Round(float.Parse(dgv1.Rows[i].Cells[3].Value.ToString()) * 100 / float.Parse(DSLop.Rows[i][1].ToString()), 2)).ToString()+"%";
            }
            #endregion
        }
        private void txtNamHoc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHocKy2.Enabled = true;
            dgv2.Rows.Clear();
            //load học kỳ 2
            txtHocKy2.Items.Clear();
            txtHocKy2.Items.Add("Học kỳ 1");
            txtHocKy2.Items.Add("Học kỳ 2");
        }
        private void txtHocKy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            // load dữ liệu 2
            DSLop = BaoCao.LoadLop(txtNamHoc2.Text);
            for (int i = 0; i < DSLop.Rows.Count; i++)
            {
                dgv2.Rows.Add("", DSLop.Rows[i][0], DSLop.Rows[i][1], "", "");
            }
            for (int i = 0; i < dgv2.RowCount; i++)
            {
                dgv2.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            #region -- load số lượng học sinh đạt -> tính tỉ lệ đạt
            for (int i = 0; i < DSLop.Rows.Count; i++)
            {
                dgv2.Rows[i].Cells[3].Value = BaoCao.Dem2(DSLop.Rows[i][2].ToString(), txtHocKy2.Text, txtNamHoc2.Text);
                dgv2.Rows[i].Cells[4].Value = (Math.Round(float.Parse(dgv2.Rows[i].Cells[3].Value.ToString())*100 / float.Parse(DSLop.Rows[i][1].ToString()), 2)).ToString()+"%";
            }
            #endregion 
        }
        private void LoadNamHoc()
        {
            DataTable abc = BaoCao.LayNamHoc();
            txtNamHoc1.Items.Clear();
            txtNamHoc2.Items.Clear();
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                txtNamHoc1.Items.Add(abc.Rows[i][1]);
                txtNamHoc2.Items.Add(abc.Rows[i][1]);
            }
        }
        private void frm_BaoCaoTongKet_Load(object sender, EventArgs e)
        {
            txtNamHoc1.Enabled = true;
            LoadNamHoc();
            txtNamHoc2.Enabled = true;
            txtHocKy1.Enabled = false;
            txtHocKy2.Enabled = false;
            txtMonHoc.Enabled = false;
        }
    }
}
