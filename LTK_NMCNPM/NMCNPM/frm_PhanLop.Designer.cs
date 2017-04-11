namespace NMCNPM
{
    partial class frm_PhanLop
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
            this.cB_LopMoi = new System.Windows.Forms.ComboBox();
            this.Gb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tB_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_LopCu = new System.Windows.Forms.TextBox();
            this.txt_Khoi = new System.Windows.Forms.TextBox();
            this.txt_NamHoc = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.tB_MHS = new System.Windows.Forms.TextBox();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.lb_MHS = new System.Windows.Forms.Label();
            this.tB_Ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_PhanLop = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gb_ThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_LopMoi
            // 
            this.cB_LopMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_LopMoi.Location = new System.Drawing.Point(109, 112);
            this.cB_LopMoi.Name = "cB_LopMoi";
            this.cB_LopMoi.Size = new System.Drawing.Size(85, 21);
            this.cB_LopMoi.TabIndex = 15;
            this.cB_LopMoi.SelectedIndexChanged += new System.EventHandler(this.cB_LopMoi_SelectedIndexChanged);
            // 
            // Gb_ThongTinHocSinh
            // 
            this.Gb_ThongTinHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_ThongTinHocSinh.Controls.Add(this.label6);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label12);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label11);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label8);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label1);
            this.Gb_ThongTinHocSinh.Controls.Add(this.cB_LopMoi);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label10);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_NgaySinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_DiaChi);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_LopCu);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_Khoi);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_NamHoc);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_GioiTinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_MHS);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_Email);
            this.Gb_ThongTinHocSinh.Controls.Add(this.lb_MHS);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_Ten);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label7);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label5);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label2);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label4);
            this.Gb_ThongTinHocSinh.Location = new System.Drawing.Point(6, 12);
            this.Gb_ThongTinHocSinh.Name = "Gb_ThongTinHocSinh";
            this.Gb_ThongTinHocSinh.Size = new System.Drawing.Size(840, 152);
            this.Gb_ThongTinHocSinh.TabIndex = 19;
            this.Gb_ThongTinHocSinh.TabStop = false;
            this.Gb_ThongTinHocSinh.Text = "Thông tin chi tiết học sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(228, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Lớp mới";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Lớp cũ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Năm học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày sinh";
            // 
            // tB_NgaySinh
            // 
            this.tB_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.tB_NgaySinh.Enabled = false;
            this.tB_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tB_NgaySinh.Location = new System.Drawing.Point(317, 107);
            this.tB_NgaySinh.Name = "tB_NgaySinh";
            this.tB_NgaySinh.Size = new System.Drawing.Size(115, 20);
            this.tB_NgaySinh.TabIndex = 6;
            // 
            // tB_DiaChi
            // 
            this.tB_DiaChi.Enabled = false;
            this.tB_DiaChi.Location = new System.Drawing.Point(544, 107);
            this.tB_DiaChi.Name = "tB_DiaChi";
            this.tB_DiaChi.Size = new System.Drawing.Size(264, 20);
            this.tB_DiaChi.TabIndex = 8;
            // 
            // txt_LopCu
            // 
            this.txt_LopCu.Enabled = false;
            this.txt_LopCu.Location = new System.Drawing.Point(109, 87);
            this.txt_LopCu.Multiline = true;
            this.txt_LopCu.Name = "txt_LopCu";
            this.txt_LopCu.Size = new System.Drawing.Size(85, 20);
            this.txt_LopCu.TabIndex = 3;
            // 
            // txt_Khoi
            // 
            this.txt_Khoi.Enabled = false;
            this.txt_Khoi.Location = new System.Drawing.Point(109, 54);
            this.txt_Khoi.Multiline = true;
            this.txt_Khoi.Name = "txt_Khoi";
            this.txt_Khoi.Size = new System.Drawing.Size(85, 20);
            this.txt_Khoi.TabIndex = 3;
            // 
            // txt_NamHoc
            // 
            this.txt_NamHoc.Enabled = false;
            this.txt_NamHoc.Location = new System.Drawing.Point(109, 20);
            this.txt_NamHoc.Multiline = true;
            this.txt_NamHoc.Name = "txt_NamHoc";
            this.txt_NamHoc.Size = new System.Drawing.Size(85, 20);
            this.txt_NamHoc.TabIndex = 3;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Enabled = false;
            this.txt_GioiTinh.Location = new System.Drawing.Point(317, 72);
            this.txt_GioiTinh.Multiline = true;
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(115, 20);
            this.txt_GioiTinh.TabIndex = 3;
            // 
            // tB_MHS
            // 
            this.tB_MHS.Enabled = false;
            this.tB_MHS.Location = new System.Drawing.Point(317, 35);
            this.tB_MHS.Multiline = true;
            this.tB_MHS.Name = "tB_MHS";
            this.tB_MHS.Size = new System.Drawing.Size(115, 20);
            this.tB_MHS.TabIndex = 3;
            // 
            // tB_Email
            // 
            this.tB_Email.Enabled = false;
            this.tB_Email.Location = new System.Drawing.Point(544, 72);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(264, 20);
            this.tB_Email.TabIndex = 7;
            // 
            // lb_MHS
            // 
            this.lb_MHS.AutoSize = true;
            this.lb_MHS.Location = new System.Drawing.Point(246, 38);
            this.lb_MHS.Name = "lb_MHS";
            this.lb_MHS.Size = new System.Drawing.Size(65, 13);
            this.lb_MHS.TabIndex = 7;
            this.lb_MHS.Text = "Mã học sinh";
            // 
            // tB_Ten
            // 
            this.tB_Ten.Enabled = false;
            this.tB_Ten.Location = new System.Drawing.Point(544, 37);
            this.tB_Ten.Name = "tB_Ten";
            this.tB_Ten.Size = new System.Drawing.Size(263, 20);
            this.tB_Ten.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách sinh viên xếp lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Danh sách sinh viên có lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaHS1,
            this.HoTen1,
            this.Lop1,
            this.NgaySinh1,
            this.GioiTinh1,
            this.Email1,
            this.DiaChi1,
            this.NamHoc1,
            this.Khoi1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 217);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.ReadOnly = true;
            // 
            // MaHS1
            // 
            this.MaHS1.HeaderText = "Mã học sinh";
            this.MaHS1.Name = "MaHS1";
            this.MaHS1.ReadOnly = true;
            // 
            // HoTen1
            // 
            this.HoTen1.HeaderText = "Họ và tên";
            this.HoTen1.Name = "HoTen1";
            this.HoTen1.ReadOnly = true;
            // 
            // Lop1
            // 
            this.Lop1.HeaderText = "Lớp";
            this.Lop1.Name = "Lop1";
            this.Lop1.ReadOnly = true;
            // 
            // NgaySinh1
            // 
            this.NgaySinh1.HeaderText = "Ngày sinh";
            this.NgaySinh1.Name = "NgaySinh1";
            this.NgaySinh1.ReadOnly = true;
            // 
            // GioiTinh1
            // 
            this.GioiTinh1.HeaderText = "Giới tính";
            this.GioiTinh1.Name = "GioiTinh1";
            this.GioiTinh1.ReadOnly = true;
            // 
            // Email1
            // 
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            // 
            // DiaChi1
            // 
            this.DiaChi1.HeaderText = "Địa chỉ";
            this.DiaChi1.Name = "DiaChi1";
            this.DiaChi1.ReadOnly = true;
            // 
            // NamHoc1
            // 
            this.NamHoc1.HeaderText = "Năm học";
            this.NamHoc1.Name = "NamHoc1";
            this.NamHoc1.ReadOnly = true;
            // 
            // Khoi1
            // 
            this.Khoi1.HeaderText = "Khối";
            this.Khoi1.Name = "Khoi1";
            this.Khoi1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_PhanLop);
            this.groupBox1.Location = new System.Drawing.Point(343, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(58, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(7, 147);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(45, 36);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(7, 105);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(45, 36);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(7, 63);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(45, 36);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "<<";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_PhanLop
            // 
            this.btn_PhanLop.Location = new System.Drawing.Point(6, 21);
            this.btn_PhanLop.Name = "btn_PhanLop";
            this.btn_PhanLop.Size = new System.Drawing.Size(45, 36);
            this.btn_PhanLop.TabIndex = 0;
            this.btn_PhanLop.Text = "Phân lớp";
            this.btn_PhanLop.UseVisualStyleBackColor = true;
            this.btn_PhanLop.Click += new System.EventHandler(this.btn_PhanLop_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.MaHS2,
            this.HoTen2,
            this.Lop2,
            this.NgaySinh2,
            this.GioiTinh2,
            this.Email2,
            this.DiaChi2,
            this.NamHoc2,
            this.Khoi2,
            this.LopCu});
            this.dataGridView2.Location = new System.Drawing.Point(401, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(459, 217);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.ReadOnly = true;
            // 
            // MaHS2
            // 
            this.MaHS2.HeaderText = "Mã học sinh";
            this.MaHS2.Name = "MaHS2";
            this.MaHS2.ReadOnly = true;
            // 
            // HoTen2
            // 
            this.HoTen2.HeaderText = "Họ và tên";
            this.HoTen2.Name = "HoTen2";
            this.HoTen2.ReadOnly = true;
            // 
            // Lop2
            // 
            this.Lop2.HeaderText = "Lớp mới";
            this.Lop2.Name = "Lop2";
            this.Lop2.ReadOnly = true;
            // 
            // NgaySinh2
            // 
            this.NgaySinh2.HeaderText = "Ngày sinh";
            this.NgaySinh2.Name = "NgaySinh2";
            this.NgaySinh2.ReadOnly = true;
            // 
            // GioiTinh2
            // 
            this.GioiTinh2.HeaderText = "Giới tính";
            this.GioiTinh2.Name = "GioiTinh2";
            this.GioiTinh2.ReadOnly = true;
            // 
            // Email2
            // 
            this.Email2.HeaderText = "Email";
            this.Email2.Name = "Email2";
            this.Email2.ReadOnly = true;
            // 
            // DiaChi2
            // 
            this.DiaChi2.HeaderText = "Địa chỉ";
            this.DiaChi2.Name = "DiaChi2";
            this.DiaChi2.ReadOnly = true;
            // 
            // NamHoc2
            // 
            this.NamHoc2.HeaderText = "Năm học";
            this.NamHoc2.Name = "NamHoc2";
            this.NamHoc2.ReadOnly = true;
            // 
            // Khoi2
            // 
            this.Khoi2.HeaderText = "Khối";
            this.Khoi2.Name = "Khoi2";
            this.Khoi2.ReadOnly = true;
            // 
            // LopCu
            // 
            this.LopCu.HeaderText = "Lớp cũ";
            this.LopCu.Name = "LopCu";
            this.LopCu.ReadOnly = true;
            // 
            // frm_PhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Gb_ThongTinHocSinh);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PhanLop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Phân lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_PhanLop_FormClosing);
            this.Load += new System.EventHandler(this.frm_PhanLop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PhanLop_KeyDown);
            this.Gb_ThongTinHocSinh.ResumeLayout(false);
            this.Gb_ThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cB_LopMoi;
        private System.Windows.Forms.GroupBox Gb_ThongTinHocSinh;
        private System.Windows.Forms.DateTimePicker tB_NgaySinh;
        private System.Windows.Forms.TextBox tB_DiaChi;
        private System.Windows.Forms.TextBox tB_MHS;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label lb_MHS;
        private System.Windows.Forms.TextBox tB_Ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_PhanLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi1;
        private System.Windows.Forms.TextBox txt_NamHoc;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.TextBox txt_Khoi;
        private System.Windows.Forms.TextBox txt_LopCu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopCu;
        private System.Windows.Forms.Label label6;
    }
}