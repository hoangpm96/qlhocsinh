namespace NMCNPM
{
    partial class frm_TiepNhanHocSinh
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.GroupBoxChonLop = new System.Windows.Forms.GroupBox();
            this.txtKhoi = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_NamHoc = new System.Windows.Forms.Label();
            this.lbl_Khoi = new System.Windows.Forms.Label();
            this.Gb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.tB_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tB_GioiTinh = new System.Windows.Forms.ComboBox();
            this.tB_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_STT = new System.Windows.Forms.TextBox();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.lbl_STT = new System.Windows.Forms.Label();
            this.tB_Ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_PhanLop = new System.Windows.Forms.Button();
            this.dgv_TiepNhan = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxChonLop.SuspendLayout();
            this.Gb_ThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiepNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(293, 149);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(66, 38);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // GroupBoxChonLop
            // 
            this.GroupBoxChonLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBoxChonLop.Controls.Add(this.txtKhoi);
            this.GroupBoxChonLop.Controls.Add(this.txtNamHoc);
            this.GroupBoxChonLop.Controls.Add(this.button3);
            this.GroupBoxChonLop.Controls.Add(this.button4);
            this.GroupBoxChonLop.Controls.Add(this.label8);
            this.GroupBoxChonLop.Controls.Add(this.lb_NamHoc);
            this.GroupBoxChonLop.Controls.Add(this.lbl_Khoi);
            this.GroupBoxChonLop.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxChonLop.Name = "GroupBoxChonLop";
            this.GroupBoxChonLop.Size = new System.Drawing.Size(186, 131);
            this.GroupBoxChonLop.TabIndex = 23;
            this.GroupBoxChonLop.TabStop = false;
            this.GroupBoxChonLop.Text = "Chọn lớp:";
            // 
            // txtKhoi
            // 
            this.txtKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(68, 81);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(85, 21);
            this.txtKhoi.TabIndex = 1;
            this.txtKhoi.SelectedIndexChanged += new System.EventHandler(this.txtKhoi_SelectedIndexChanged);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNamHoc.Location = new System.Drawing.Point(68, 31);
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
            // lb_NamHoc
            // 
            this.lb_NamHoc.AutoSize = true;
            this.lb_NamHoc.Location = new System.Drawing.Point(8, 34);
            this.lb_NamHoc.Name = "lb_NamHoc";
            this.lb_NamHoc.Size = new System.Drawing.Size(50, 13);
            this.lb_NamHoc.TabIndex = 2;
            this.lb_NamHoc.Text = "Năm học";
            // 
            // lbl_Khoi
            // 
            this.lbl_Khoi.AutoSize = true;
            this.lbl_Khoi.Location = new System.Drawing.Point(8, 84);
            this.lbl_Khoi.Name = "lbl_Khoi";
            this.lbl_Khoi.Size = new System.Drawing.Size(28, 13);
            this.lbl_Khoi.TabIndex = 3;
            this.lbl_Khoi.Text = "Khối";
            // 
            // Gb_ThongTinHocSinh
            // 
            this.Gb_ThongTinHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_NgaySinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_GioiTinh);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_DiaChi);
            this.Gb_ThongTinHocSinh.Controls.Add(this.txt_STT);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_Email);
            this.Gb_ThongTinHocSinh.Controls.Add(this.lbl_STT);
            this.Gb_ThongTinHocSinh.Controls.Add(this.tB_Ten);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label7);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label6);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label5);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label2);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label4);
            this.Gb_ThongTinHocSinh.Controls.Add(this.label3);
            this.Gb_ThongTinHocSinh.Location = new System.Drawing.Point(204, 13);
            this.Gb_ThongTinHocSinh.Name = "Gb_ThongTinHocSinh";
            this.Gb_ThongTinHocSinh.Size = new System.Drawing.Size(582, 130);
            this.Gb_ThongTinHocSinh.TabIndex = 22;
            this.Gb_ThongTinHocSinh.TabStop = false;
            this.Gb_ThongTinHocSinh.Text = "Thông tin chi tiết học sinh";
            // 
            // tB_NgaySinh
            // 
            this.tB_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.tB_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tB_NgaySinh.Location = new System.Drawing.Point(313, 64);
            this.tB_NgaySinh.Name = "tB_NgaySinh";
            this.tB_NgaySinh.Size = new System.Drawing.Size(263, 20);
            this.tB_NgaySinh.TabIndex = 6;
            this.tB_NgaySinh.ValueChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // tB_GioiTinh
            // 
            this.tB_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tB_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.tB_GioiTinh.Location = new System.Drawing.Point(77, 63);
            this.tB_GioiTinh.Name = "tB_GioiTinh";
            this.tB_GioiTinh.Size = new System.Drawing.Size(161, 21);
            this.tB_GioiTinh.TabIndex = 5;
            this.tB_GioiTinh.SelectedIndexChanged += new System.EventHandler(this.tB_GioiTinh_SelectedIndexChanged);
            this.tB_GioiTinh.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // tB_DiaChi
            // 
            this.tB_DiaChi.Location = new System.Drawing.Point(313, 100);
            this.tB_DiaChi.Name = "tB_DiaChi";
            this.tB_DiaChi.Size = new System.Drawing.Size(264, 20);
            this.tB_DiaChi.TabIndex = 8;
            this.tB_DiaChi.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // txt_STT
            // 
            this.txt_STT.Enabled = false;
            this.txt_STT.Location = new System.Drawing.Point(77, 31);
            this.txt_STT.Multiline = true;
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(161, 20);
            this.txt_STT.TabIndex = 3;
            this.txt_STT.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(77, 98);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(161, 20);
            this.tB_Email.TabIndex = 7;
            this.tB_Email.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // lbl_STT
            // 
            this.lbl_STT.AutoSize = true;
            this.lbl_STT.Location = new System.Drawing.Point(6, 34);
            this.lbl_STT.Name = "lbl_STT";
            this.lbl_STT.Size = new System.Drawing.Size(50, 13);
            this.lbl_STT.TabIndex = 7;
            this.lbl_STT.Text = "Số thứ tự";
            // 
            // tB_Ten
            // 
            this.tB_Ten.Location = new System.Drawing.Point(313, 30);
            this.tB_Ten.Name = "tB_Ten";
            this.tB_Ten.Size = new System.Drawing.Size(263, 20);
            this.tB_Ten.TabIndex = 4;
            this.tB_Ten.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(498, 149);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(66, 38);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(191, 149);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(66, 38);
            this.btn_Them.TabIndex = 25;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_PhanLop
            // 
            this.btn_PhanLop.Location = new System.Drawing.Point(406, 149);
            this.btn_PhanLop.Name = "btn_PhanLop";
            this.btn_PhanLop.Size = new System.Drawing.Size(66, 38);
            this.btn_PhanLop.TabIndex = 26;
            this.btn_PhanLop.Text = "Phân lớp";
            this.btn_PhanLop.UseVisualStyleBackColor = true;
            this.btn_PhanLop.Click += new System.EventHandler(this.btn_PhanLop_Click);
            // 
            // dgv_TiepNhan
            // 
            this.dgv_TiepNhan.AllowUserToAddRows = false;
            this.dgv_TiepNhan.AllowUserToDeleteRows = false;
            this.dgv_TiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TiepNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtSTT,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.Email,
            this.DiaChi,
            this.NamHoc,
            this.Khoi});
            this.dgv_TiepNhan.Location = new System.Drawing.Point(9, 211);
            this.dgv_TiepNhan.Name = "dgv_TiepNhan";
            this.dgv_TiepNhan.ReadOnly = true;
            this.dgv_TiepNhan.Size = new System.Drawing.Size(774, 210);
            this.dgv_TiepNhan.TabIndex = 27;
            this.dgv_TiepNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TiepNhan_CellClick);
            this.dgv_TiepNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TiepNhan_CellContentClick);
            this.dgv_TiepNhan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_TiepNhan_ColumnHeaderMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(20, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 31;
            // 
            // dtSTT
            // 
            this.dtSTT.HeaderText = "STT";
            this.dtSTT.Name = "dtSTT";
            this.dtSTT.ReadOnly = true;
            this.dtSTT.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 80;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
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
            // Khoi
            // 
            this.Khoi.HeaderText = "Khối";
            this.Khoi.Name = "Khoi";
            this.Khoi.ReadOnly = true;
            // 
            // frm_TiepNhanHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 425);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_TiepNhan);
            this.Controls.Add(this.btn_PhanLop);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.GroupBoxChonLop);
            this.Controls.Add(this.Gb_ThongTinHocSinh);
            this.Controls.Add(this.btn_Thoat);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TiepNhanHocSinh";
            this.Text = "Tiếp nhận học sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TiepNhan_FormClosing);
            this.Load += new System.EventHandler(this.frm_TiepNhanHocSinh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TiepNhan_KeyDown);
            this.GroupBoxChonLop.ResumeLayout(false);
            this.GroupBoxChonLop.PerformLayout();
            this.Gb_ThongTinHocSinh.ResumeLayout(false);
            this.Gb_ThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiepNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox GroupBoxChonLop;
        private System.Windows.Forms.ComboBox txtKhoi;
        private System.Windows.Forms.ComboBox txtNamHoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_NamHoc;
        private System.Windows.Forms.Label lbl_Khoi;
        private System.Windows.Forms.GroupBox Gb_ThongTinHocSinh;
        private System.Windows.Forms.DateTimePicker tB_NgaySinh;
        private System.Windows.Forms.ComboBox tB_GioiTinh;
        private System.Windows.Forms.TextBox tB_DiaChi;
        private System.Windows.Forms.TextBox txt_STT;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label lbl_STT;
        private System.Windows.Forms.TextBox tB_Ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_PhanLop;
        private System.Windows.Forms.DataGridView dgv_TiepNhan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
    }
}