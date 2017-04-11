namespace NMCNPM
{
    partial class frm_XemDanhSachLop
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
            this.components = new System.ComponentModel.Container();
            this.GroupBoxChonLop = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.lal_GVCN = new System.Windows.Forms.Label();
            this.lal_GVCN1 = new System.Windows.Forms.Label();
            this.btn_XemDiemLop = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ChuyenLop = new System.Windows.Forms.Button();
            this.btn_XoaHoSo = new System.Windows.Forms.Button();
            this.btn_SuaHoSoHocSinh = new System.Windows.Forms.Button();
            this.txt_SiSo = new System.Windows.Forms.TextBox();
            this.lb_MHS = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.ComboBox();
            this.txtKhoi = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.ComboBox();
            this.NamHoc = new System.Windows.Forms.Label();
            this.Khối = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chuyểnLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHồSơHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHồSơHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐiểmLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxChonLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxChonLop
            // 
            this.GroupBoxChonLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBoxChonLop.Controls.Add(this.lbl_status);
            this.GroupBoxChonLop.Controls.Add(this.lbl_Lop);
            this.GroupBoxChonLop.Controls.Add(this.lal_GVCN);
            this.GroupBoxChonLop.Controls.Add(this.lal_GVCN1);
            this.GroupBoxChonLop.Controls.Add(this.btn_XemDiemLop);
            this.GroupBoxChonLop.Controls.Add(this.btn_Thoat);
            this.GroupBoxChonLop.Controls.Add(this.btn_ChuyenLop);
            this.GroupBoxChonLop.Controls.Add(this.btn_XoaHoSo);
            this.GroupBoxChonLop.Controls.Add(this.btn_SuaHoSoHocSinh);
            this.GroupBoxChonLop.Controls.Add(this.txt_SiSo);
            this.GroupBoxChonLop.Controls.Add(this.lb_MHS);
            this.GroupBoxChonLop.Controls.Add(this.txtLop);
            this.GroupBoxChonLop.Controls.Add(this.txtKhoi);
            this.GroupBoxChonLop.Controls.Add(this.txtNamHoc);
            this.GroupBoxChonLop.Controls.Add(this.NamHoc);
            this.GroupBoxChonLop.Controls.Add(this.Khối);
            this.GroupBoxChonLop.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxChonLop.Name = "GroupBoxChonLop";
            this.GroupBoxChonLop.Size = new System.Drawing.Size(913, 68);
            this.GroupBoxChonLop.TabIndex = 20;
            this.GroupBoxChonLop.TabStop = false;
            this.GroupBoxChonLop.Text = "Chọn lớp:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_status.Location = new System.Drawing.Point(443, 48);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 27;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(231, 20);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
            this.lbl_Lop.TabIndex = 26;
            this.lbl_Lop.Text = "Lớp";
            // 
            // lal_GVCN
            // 
            this.lal_GVCN.AutoSize = true;
            this.lal_GVCN.Location = new System.Drawing.Point(171, 49);
            this.lal_GVCN.Name = "lal_GVCN";
            this.lal_GVCN.Size = new System.Drawing.Size(0, 13);
            this.lal_GVCN.TabIndex = 25;
            // 
            // lal_GVCN1
            // 
            this.lal_GVCN1.AutoSize = true;
            this.lal_GVCN1.Location = new System.Drawing.Point(58, 49);
            this.lal_GVCN1.Name = "lal_GVCN1";
            this.lal_GVCN1.Size = new System.Drawing.Size(107, 13);
            this.lal_GVCN1.TabIndex = 25;
            this.lal_GVCN1.Text = "Giáo viên chủ nhiệm:";
            // 
            // btn_XemDiemLop
            // 
            this.btn_XemDiemLop.Location = new System.Drawing.Point(698, 9);
            this.btn_XemDiemLop.Name = "btn_XemDiemLop";
            this.btn_XemDiemLop.Size = new System.Drawing.Size(75, 47);
            this.btn_XemDiemLop.TabIndex = 24;
            this.btn_XemDiemLop.Text = "Xem điểm lớp";
            this.btn_XemDiemLop.UseVisualStyleBackColor = true;
            this.btn_XemDiemLop.Click += new System.EventHandler(this.btn_XemDiemLop_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(814, 15);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 33);
            this.btn_Thoat.TabIndex = 23;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ChuyenLop
            // 
            this.btn_ChuyenLop.Location = new System.Drawing.Point(455, 9);
            this.btn_ChuyenLop.Name = "btn_ChuyenLop";
            this.btn_ChuyenLop.Size = new System.Drawing.Size(75, 36);
            this.btn_ChuyenLop.TabIndex = 20;
            this.btn_ChuyenLop.Text = "Chuyển lớp";
            this.btn_ChuyenLop.UseVisualStyleBackColor = true;
            this.btn_ChuyenLop.Click += new System.EventHandler(this.btn_ChuyenLop_Click);
            // 
            // btn_XoaHoSo
            // 
            this.btn_XoaHoSo.Location = new System.Drawing.Point(617, 11);
            this.btn_XoaHoSo.Name = "btn_XoaHoSo";
            this.btn_XoaHoSo.Size = new System.Drawing.Size(75, 36);
            this.btn_XoaHoSo.TabIndex = 19;
            this.btn_XoaHoSo.Text = "Xóa hồ sơ học sinh";
            this.btn_XoaHoSo.UseVisualStyleBackColor = true;
            this.btn_XoaHoSo.Click += new System.EventHandler(this.btn_XoaHoSo_Click);
            // 
            // btn_SuaHoSoHocSinh
            // 
            this.btn_SuaHoSoHocSinh.Location = new System.Drawing.Point(536, 10);
            this.btn_SuaHoSoHocSinh.Name = "btn_SuaHoSoHocSinh";
            this.btn_SuaHoSoHocSinh.Size = new System.Drawing.Size(75, 39);
            this.btn_SuaHoSoHocSinh.TabIndex = 19;
            this.btn_SuaHoSoHocSinh.Text = "Sửa hồ sơ học sinh";
            this.btn_SuaHoSoHocSinh.UseVisualStyleBackColor = true;
            this.btn_SuaHoSoHocSinh.Click += new System.EventHandler(this.btn_SuaHoSoHocSinh_Click);
            // 
            // txt_SiSo
            // 
            this.txt_SiSo.Enabled = false;
            this.txt_SiSo.Location = new System.Drawing.Point(368, 17);
            this.txt_SiSo.Multiline = true;
            this.txt_SiSo.Name = "txt_SiSo";
            this.txt_SiSo.Size = new System.Drawing.Size(33, 20);
            this.txt_SiSo.TabIndex = 18;
            // 
            // lb_MHS
            // 
            this.lb_MHS.AutoSize = true;
            this.lb_MHS.Location = new System.Drawing.Point(326, 21);
            this.lb_MHS.Name = "lb_MHS";
            this.lb_MHS.Size = new System.Drawing.Size(36, 13);
            this.lb_MHS.TabIndex = 17;
            this.lb_MHS.Text = "Sĩ số:";
            // 
            // txtLop
            // 
            this.txtLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(262, 15);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(58, 21);
            this.txtLop.TabIndex = 15;
            this.txtLop.SelectedIndexChanged += new System.EventHandler(this.txtLop_SelectedIndexChanged);
            // 
            // txtKhoi
            // 
            this.txtKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(178, 13);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(47, 21);
            this.txtKhoi.TabIndex = 1;
            this.txtKhoi.SelectedIndexChanged += new System.EventHandler(this.txtKhoi_SelectedIndexChanged);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNamHoc.Items.AddRange(new object[] {
            "2013 - 2014",
            "2014 - 2015",
            "2015 - 2016"});
            this.txtNamHoc.Location = new System.Drawing.Point(53, 13);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(85, 21);
            this.txtNamHoc.TabIndex = 0;
            this.txtNamHoc.SelectedIndexChanged += new System.EventHandler(this.txtNamHoc_SelectedIndexChanged);
            // 
            // NamHoc
            // 
            this.NamHoc.AutoSize = true;
            this.NamHoc.Location = new System.Drawing.Point(6, 16);
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Size = new System.Drawing.Size(50, 13);
            this.NamHoc.TabIndex = 2;
            this.NamHoc.Text = "Năm học";
            // 
            // Khối
            // 
            this.Khối.AutoSize = true;
            this.Khối.Location = new System.Drawing.Point(144, 16);
            this.Khối.Name = "Khối";
            this.Khối.Size = new System.Drawing.Size(28, 13);
            this.Khối.TabIndex = 3;
            this.Khối.Text = "Khối";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHS,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.Email,
            this.DiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(8, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(917, 284);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 120;
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
            this.Email.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnLớpToolStripMenuItem,
            this.sửaHồSơHọcSinhToolStripMenuItem,
            this.xóaHồSơHọcSinhToolStripMenuItem,
            this.xemĐiểmLớpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 92);
            // 
            // chuyểnLớpToolStripMenuItem
            // 
            this.chuyểnLớpToolStripMenuItem.Name = "chuyểnLớpToolStripMenuItem";
            this.chuyểnLớpToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chuyểnLớpToolStripMenuItem.Text = "Chuyển lớp";
            this.chuyểnLớpToolStripMenuItem.Click += new System.EventHandler(this.btn_ChuyenLop_Click);
            // 
            // sửaHồSơHọcSinhToolStripMenuItem
            // 
            this.sửaHồSơHọcSinhToolStripMenuItem.Name = "sửaHồSơHọcSinhToolStripMenuItem";
            this.sửaHồSơHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sửaHồSơHọcSinhToolStripMenuItem.Text = "Sửa hồ sơ học sinh";
            this.sửaHồSơHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.btn_SuaHoSoHocSinh_Click);
            // 
            // xóaHồSơHọcSinhToolStripMenuItem
            // 
            this.xóaHồSơHọcSinhToolStripMenuItem.Name = "xóaHồSơHọcSinhToolStripMenuItem";
            this.xóaHồSơHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.xóaHồSơHọcSinhToolStripMenuItem.Text = "Xóa hồ sơ học sinh";
            this.xóaHồSơHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.btn_XoaHoSo_Click);
            // 
            // xemĐiểmLớpToolStripMenuItem
            // 
            this.xemĐiểmLớpToolStripMenuItem.Name = "xemĐiểmLớpToolStripMenuItem";
            this.xemĐiểmLớpToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.xemĐiểmLớpToolStripMenuItem.Text = "Xem điểm lớp";
            this.xemĐiểmLớpToolStripMenuItem.Click += new System.EventHandler(this.btn_XemDiemLop_Click);
            // 
            // frm_XemDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBoxChonLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_XemDanhSachLop";
            this.ShowIcon = false;
            this.Text = "Danh sách lớp";
            this.Load += new System.EventHandler(this.frm_XemDanhSachLop_Load);
            this.GroupBoxChonLop.ResumeLayout(false);
            this.GroupBoxChonLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxChonLop;
        private System.Windows.Forms.ComboBox txtLop;
        private System.Windows.Forms.ComboBox txtKhoi;
        private System.Windows.Forms.ComboBox txtNamHoc;
        private System.Windows.Forms.Label NamHoc;
        private System.Windows.Forms.Label Khối;
        private System.Windows.Forms.Label lb_MHS;
        private System.Windows.Forms.Button btn_ChuyenLop;
        private System.Windows.Forms.Button btn_XoaHoSo;
        private System.Windows.Forms.Button btn_SuaHoSoHocSinh;
        private System.Windows.Forms.TextBox txt_SiSo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_XemDiemLop;
        private System.Windows.Forms.Label lal_GVCN1;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chuyểnLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHồSơHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHồSơHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐiểmLớpToolStripMenuItem;
        private System.Windows.Forms.Label lal_GVCN;
    }
}