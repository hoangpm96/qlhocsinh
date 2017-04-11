namespace NMCNPM
{
    partial class frm_XemDiemLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_HocKy = new System.Windows.Forms.ComboBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_NamHoc = new System.Windows.Forms.Label();
            this.lbl_SiSo = new System.Windows.Forms.Label();
            this.lbl_GVCN = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Van = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Su = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDQP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheDuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cB_HocKy);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_NamHoc);
            this.groupBox1.Controls.Add(this.lbl_SiSo);
            this.groupBox1.Controls.Add(this.lbl_GVCN);
            this.groupBox1.Controls.Add(this.lbl_Lop);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp:";
            // 
            // cB_HocKy
            // 
            this.cB_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_HocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "Cả năm"});
            this.cB_HocKy.Location = new System.Drawing.Point(336, 47);
            this.cB_HocKy.Name = "cB_HocKy";
            this.cB_HocKy.Size = new System.Drawing.Size(67, 21);
            this.cB_HocKy.TabIndex = 0;
            this.cB_HocKy.SelectedIndexChanged += new System.EventHandler(this.cB_HocKy_SelectedIndexChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(557, 39);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Học kỳ:";
            // 
            // lbl_NamHoc
            // 
            this.lbl_NamHoc.AutoSize = true;
            this.lbl_NamHoc.Location = new System.Drawing.Point(286, 16);
            this.lbl_NamHoc.Name = "lbl_NamHoc";
            this.lbl_NamHoc.Size = new System.Drawing.Size(107, 13);
            this.lbl_NamHoc.TabIndex = 3;
            this.lbl_NamHoc.Text = "Năm học: 2012-2013";
            // 
            // lbl_SiSo
            // 
            this.lbl_SiSo.AutoSize = true;
            this.lbl_SiSo.Location = new System.Drawing.Point(165, 30);
            this.lbl_SiSo.Name = "lbl_SiSo";
            this.lbl_SiSo.Size = new System.Drawing.Size(51, 13);
            this.lbl_SiSo.TabIndex = 2;
            this.lbl_SiSo.Text = "Sĩ số: 53";
            // 
            // lbl_GVCN
            // 
            this.lbl_GVCN.AutoSize = true;
            this.lbl_GVCN.Location = new System.Drawing.Point(57, 64);
            this.lbl_GVCN.Name = "lbl_GVCN";
            this.lbl_GVCN.Size = new System.Drawing.Size(88, 13);
            this.lbl_GVCN.TabIndex = 1;
            this.lbl_GVCN.Text = "GVCN: Trần Hớn";
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(57, 30);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(56, 13);
            this.lbl_Lop.TabIndex = 0;
            this.lbl_Lop.Text = "Lớp: 10A2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHS,
            this.HoTen,
            this.Toan,
            this.Ly,
            this.Hoa,
            this.NgoaiNgu,
            this.Van,
            this.Sinh,
            this.Su,
            this.Dia,
            this.GDCD,
            this.GDQP,
            this.CongNghe,
            this.TinHoc,
            this.TheDuc,
            this.DTB});
            this.dataGridView1.Location = new System.Drawing.Point(10, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // Toan
            // 
            this.Toan.HeaderText = "Toán";
            this.Toan.Name = "Toan";
            this.Toan.ReadOnly = true;
            // 
            // Ly
            // 
            this.Ly.HeaderText = "Vật lý";
            this.Ly.Name = "Ly";
            this.Ly.ReadOnly = true;
            // 
            // Hoa
            // 
            this.Hoa.HeaderText = "Hóa học";
            this.Hoa.Name = "Hoa";
            this.Hoa.ReadOnly = true;
            // 
            // NgoaiNgu
            // 
            this.NgoaiNgu.HeaderText = "Ngoại ngữ";
            this.NgoaiNgu.Name = "NgoaiNgu";
            this.NgoaiNgu.ReadOnly = true;
            // 
            // Van
            // 
            this.Van.HeaderText = "Ngữ Văn";
            this.Van.Name = "Van";
            this.Van.ReadOnly = true;
            // 
            // Sinh
            // 
            this.Sinh.HeaderText = "Sinh học";
            this.Sinh.Name = "Sinh";
            this.Sinh.ReadOnly = true;
            // 
            // Su
            // 
            this.Su.HeaderText = "Lịch sử";
            this.Su.Name = "Su";
            this.Su.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Địa lý";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // GDCD
            // 
            this.GDCD.HeaderText = "GDCD";
            this.GDCD.Name = "GDCD";
            this.GDCD.ReadOnly = true;
            // 
            // GDQP
            // 
            this.GDQP.HeaderText = "GDQP";
            this.GDQP.Name = "GDQP";
            this.GDQP.ReadOnly = true;
            // 
            // CongNghe
            // 
            this.CongNghe.HeaderText = "Công nghệ";
            this.CongNghe.Name = "CongNghe";
            this.CongNghe.ReadOnly = true;
            // 
            // TinHoc
            // 
            this.TinHoc.HeaderText = "Tin Học";
            this.TinHoc.Name = "TinHoc";
            this.TinHoc.ReadOnly = true;
            // 
            // TheDuc
            // 
            this.TheDuc.HeaderText = "Thể dục";
            this.TheDuc.Name = "TheDuc";
            this.TheDuc.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "ĐTB";
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            // 
            // frm_XemDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_XemDiemLop";
            this.ShowIcon = false;
            this.Text = "Bảng điểm lớp";
            this.Load += new System.EventHandler(this.frm_XemDiemLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_NamHoc;
        private System.Windows.Forms.Label lbl_SiSo;
        private System.Windows.Forms.Label lbl_GVCN;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cB_HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Van;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Su;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDQP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheDuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    }
}