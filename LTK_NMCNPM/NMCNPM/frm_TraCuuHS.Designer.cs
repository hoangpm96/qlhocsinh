namespace NMCNPM
{
    partial class frm_TraCuuHS
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
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.GroupBoxChonLop = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtLop = new System.Windows.Forms.ComboBox();
            this.txtKhoi = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Gb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_NamSinh = new System.Windows.Forms.NumericUpDown();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txt_GioiTinh = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_MHS = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxChonLop.SuspendLayout();
            this.Gb_ThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(217, 128);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(136, 24);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // GroupBoxChonLop
            // 
            this.GroupBoxChonLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBoxChonLop.Controls.Add(this.checkBox3);
            this.GroupBoxChonLop.Controls.Add(this.checkBox2);
            this.GroupBoxChonLop.Controls.Add(this.checkBox1);
            this.GroupBoxChonLop.Controls.Add(this.txtLop);
            this.GroupBoxChonLop.Controls.Add(this.txtKhoi);
            this.GroupBoxChonLop.Controls.Add(this.txtNamHoc);
            this.GroupBoxChonLop.Controls.Add(this.button3);
            this.GroupBoxChonLop.Controls.Add(this.button4);
            this.GroupBoxChonLop.Controls.Add(this.label8);
            this.GroupBoxChonLop.Location = new System.Drawing.Point(0, 12);
            this.GroupBoxChonLop.Name = "GroupBoxChonLop";
            this.GroupBoxChonLop.Size = new System.Drawing.Size(260, 110);
            this.GroupBoxChonLop.TabIndex = 23;
            this.GroupBoxChonLop.TabStop = false;
            this.GroupBoxChonLop.Text = "Phạm vi tìm kiếm:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(62, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Lớp";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(62, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Khối";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Tag = "1";
            this.checkBox1.Text = "Năm học";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtLop
            // 
            this.txtLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(134, 73);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(85, 21);
            this.txtLop.TabIndex = 2;
            // 
            // txtKhoi
            // 
            this.txtKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(134, 46);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(85, 21);
            this.txtKhoi.TabIndex = 1;
            this.txtKhoi.SelectedIndexChanged += new System.EventHandler(this.txtKhoi_SelectedIndexChanged);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNamHoc.Enabled = false;
            this.txtNamHoc.Location = new System.Drawing.Point(134, 16);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(85, 21);
            this.txtNamHoc.TabIndex = 0;
            this.txtNamHoc.SelectedIndexChanged += new System.EventHandler(this.txtNamHoc_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "LƯU";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "THOÁT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 6;
            // 
            // Gb_ThongTinHocSinh
            // 
            this.Gb_ThongTinHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_ThongTinHocSinh.Controls.Add(this.lbl_Status);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_NamSinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.checkBox7);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_GioiTinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.checkBox6);
            this.Gb_ThongTinHocSinh.Controls.Add(this.checkBox5);
            this.Gb_ThongTinHocSinh.Controls.Add(this.checkBox4);
            this.Gb_ThongTinHocSinh.Controls.Add(this.textBox1);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_MHS);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_HoTen);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label6);
            this.Gb_ThongTinHocSinh.Location = new System.Drawing.Point(266, 12);
            this.Gb_ThongTinHocSinh.Name = "Gb_ThongTinHocSinh";
            this.Gb_ThongTinHocSinh.Size = new System.Drawing.Size(544, 110);
            this.Gb_ThongTinHocSinh.TabIndex = 22;
            this.Gb_ThongTinHocSinh.TabStop = false;
            this.Gb_ThongTinHocSinh.Text = "Thông tin tìm kiếm:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(48, 85);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 19;
            // 
            // txt_NamSinh
            // 
            this.txt_NamSinh.Enabled = false;
            this.txt_NamSinh.Location = new System.Drawing.Point(387, 49);
            this.txt_NamSinh.Maximum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.txt_NamSinh.Minimum = new decimal(new int[] {
            1996,
            0,
            0,
            0});
            this.txt_NamSinh.Name = "txt_NamSinh";
            this.txt_NamSinh.Size = new System.Drawing.Size(86, 20);
            this.txt_NamSinh.TabIndex = 18;
            this.txt_NamSinh.Value = new decimal(new int[] {
            1996,
            0,
            0,
            0});
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(311, 50);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(70, 17);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Tag = "7";
            this.checkBox7.Text = "Năm sinh";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_GioiTinh.Enabled = false;
            this.txt_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txt_GioiTinh.Location = new System.Drawing.Point(387, 20);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(86, 21);
            this.txt_GioiTinh.TabIndex = 5;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(311, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 17);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Tag = "6";
            this.checkBox6.Text = "Giới tính";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(10, 52);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(73, 17);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Tag = "5";
            this.checkBox5.Text = "Họ và tên";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(10, 23);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Tag = "4";
            this.checkBox4.Text = "Mã học sinh";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(96, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "HS";
            // 
            // txt_MHS
            // 
            this.txt_MHS.Location = new System.Drawing.Point(117, 20);
            this.txt_MHS.MaxLength = 5;
            this.txt_MHS.Multiline = true;
            this.txt_MHS.Name = "txt_MHS";
            this.txt_MHS.Size = new System.Drawing.Size(176, 20);
            this.txt_MHS.TabIndex = 3;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(96, 49);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(197, 20);
            this.txt_HoTen.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(458, 128);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(142, 24);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.Lop,
            this.DTBHK1,
            this.DTBHK2,
            this.NgaySinh,
            this.GioiTinh,
            this.Email,
            this.DiaChi,
            this.NamHoc});
            this.dataGridView1.Location = new System.Drawing.Point(8, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 218);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Thông tin học sinh:";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            this.MaHS.Width = 90;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            this.Lop.Width = 70;
            // 
            // DTBHK1
            // 
            this.DTBHK1.HeaderText = "Điểm TBHK1";
            this.DTBHK1.Name = "DTBHK1";
            this.DTBHK1.ReadOnly = true;
            // 
            // DTBHK2
            // 
            this.DTBHK2.HeaderText = "Điểm TBHK2";
            this.DTBHK2.Name = "DTBHK2";
            this.DTBHK2.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 80;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 75;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NamHoc
            // 
            this.NamHoc.HeaderText = "Năm học";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
            // 
            // frm_TraCuuHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.GroupBoxChonLop);
            this.Controls.Add(this.Gb_ThongTinHocSinh);
            this.Controls.Add(this.btn_Thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TraCuuHS";
            this.Text = "Tra cứu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TraCuu_KeyDown);
            this.GroupBoxChonLop.ResumeLayout(false);
            this.GroupBoxChonLop.PerformLayout();
            this.Gb_ThongTinHocSinh.ResumeLayout(false);
            this.Gb_ThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox GroupBoxChonLop;
        private System.Windows.Forms.ComboBox txtLop;
        private System.Windows.Forms.ComboBox txtKhoi;
        private System.Windows.Forms.ComboBox txtNamHoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Gb_ThongTinHocSinh;
        private System.Windows.Forms.TextBox txt_MHS;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ComboBox txt_GioiTinh;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown txt_NamSinh;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
    }
}