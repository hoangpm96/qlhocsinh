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
    public partial class frm_XemDiemLop : Form
    {
        XemDSLopBLL XemDiemLop = new XemDSLopBLL();
        XemDiemLopBLL XemDiemLop2 = new XemDiemLopBLL();

        DataTable DuLieu = new DataTable();
        public frm_XemDiemLop()
        {
            InitializeComponent();
        }
        public void LayDuLieu(DataTable hocsinh)
        {
            DuLieu = hocsinh;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDuLieu()
        {
            dataGridView1.Rows.Clear();
            lbl_NamHoc.Text = "Năm học: " + DuLieu.Rows[0][0].ToString();
            lbl_Lop.Text = "Lớp: "+ DuLieu.Rows[0][1].ToString();
            if (DuLieu.Rows.Count == 0)
            {
                lbl_GVCN.Text = "Giáo viên chủ nhiệm: ";
                lbl_SiSo.Text = "Sĩ số: 0";
            }
            else
            {
                int a = DuLieu.Rows[0][2].ToString().IndexOf("\\");
                if(a>1)
                {
                    lbl_GVCN.Text = "Giáo viên chủ nhiệm: " + DuLieu.Rows[0][2].ToString().Substring(0, a);
                }
                else
                {
                    lbl_GVCN.Text = "Giáo viên chủ nhiệm: " + DuLieu.Rows[0][2].ToString();
                    }
                lbl_SiSo.Text = "Sĩ số:  " + DuLieu.Rows[0][3].ToString() ;
            }
            LoadDSLop();
         }
        private void LoadDSLop()
        {//load danh sách lớp dựa vào 
            dataGridView1.Rows.Clear();
            DataTable DL = XemDiemLop.LayDuLieu(DuLieu.Rows[0][0].ToString(), DuLieu.Rows[0][1].ToString());
            int x = DL.Rows.Count;
            for (int i = 0; i < DL.Rows.Count; i++)
            {
                dataGridView1.Rows.Add("", DL.Rows[i][0], DL.Rows[i][1]);
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void LoadDiem()
        {
            #region --load điểm tất cả các môn-
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                DataTable DT = XemDiemLop2.LoadDiemMon(cB_HocKy.Text, DuLieu.Rows[0][0].ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString());
                for (int j=0;j<13;j++)
                {
                    if(DT.Rows.Count<1)
                    {
                        dataGridView1.Rows[i].Cells[j + 3].Value = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j + 3].Value = DT.Rows[0][j + 1].ToString();
                    }
                }
                float DTB = 0;
                for (int j = 3; j < 16; j++)
                {
                    DTB += float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                dataGridView1.Rows[i].Cells[16].Value = (Math.Round(DTB/13,2)).ToString();
            }
            #endregion
        }
        private void frm_XemDiemLop_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void cB_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiem();
        }
    }
}
