namespace NMCNPM
{
    partial class frm_NhapDiem
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
            this.GroupBoxChonLop = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.ComboBox();
            this.txtLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMon = new System.Windows.Forms.ComboBox();
            this.txtKhoi = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NamHoc = new System.Windows.Forms.Label();
            this.Khối = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.newdiem15p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem15p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxChonLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxChonLop
            // 
            this.GroupBoxChonLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBoxChonLop.Controls.Add(this.btn_Thoat);
            this.GroupBoxChonLop.Controls.Add(this.btn_Luu);
            this.GroupBoxChonLop.Controls.Add(this.txtHocKy);
            this.GroupBoxChonLop.Controls.Add(this.txtLop);
            this.GroupBoxChonLop.Controls.Add(this.label2);
            this.GroupBoxChonLop.Controls.Add(this.label3);
            this.GroupBoxChonLop.Controls.Add(this.txtMon);
            this.GroupBoxChonLop.Controls.Add(this.txtKhoi);
            this.GroupBoxChonLop.Controls.Add(this.txtNamHoc);
            this.GroupBoxChonLop.Controls.Add(this.button3);
            this.GroupBoxChonLop.Controls.Add(this.button4);
            this.GroupBoxChonLop.Controls.Add(this.label8);
            this.GroupBoxChonLop.Controls.Add(this.label1);
            this.GroupBoxChonLop.Controls.Add(this.lb_NamHoc);
            this.GroupBoxChonLop.Controls.Add(this.Khối);
            this.GroupBoxChonLop.Location = new System.Drawing.Point(6, 11);
            this.GroupBoxChonLop.Name = "GroupBoxChonLop";
            this.GroupBoxChonLop.Size = new System.Drawing.Size(816, 98);
            this.GroupBoxChonLop.TabIndex = 25;
            this.GroupBoxChonLop.TabStop = false;
            this.GroupBoxChonLop.Text = "Chọn lớp:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(558, 60);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(558, 20);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 20;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHocKy.Enabled = false;
            this.txtHocKy.Location = new System.Drawing.Point(227, 57);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(85, 21);
            this.txtHocKy.TabIndex = 15;
            this.txtHocKy.SelectedIndexChanged += new System.EventHandler(this.txtHocKy_SelectedIndexChanged);
            // 
            // txtLop
            // 
            this.txtLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(68, 57);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(85, 21);
            this.txtLop.TabIndex = 16;
            this.txtLop.SelectedIndexChanged += new System.EventHandler(this.txtLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lớp";
            // 
            // txtMon
            // 
            this.txtMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMon.Enabled = false;
            this.txtMon.Location = new System.Drawing.Point(395, 20);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(85, 21);
            this.txtMon.TabIndex = 1;
            this.txtMon.SelectedIndexChanged += new System.EventHandler(this.txtMon_SelectedIndexChanged);
            // 
            // txtKhoi
            // 
            this.txtKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(227, 20);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(85, 21);
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
            this.txtNamHoc.Location = new System.Drawing.Point(68, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn";
            // 
            // lb_NamHoc
            // 
            this.lb_NamHoc.AutoSize = true;
            this.lb_NamHoc.Location = new System.Drawing.Point(8, 26);
            this.lb_NamHoc.Name = "lb_NamHoc";
            this.lb_NamHoc.Size = new System.Drawing.Size(50, 13);
            this.lb_NamHoc.TabIndex = 2;
            this.lb_NamHoc.Text = "Năm học";
            // 
            // Khối
            // 
            this.Khối.AutoSize = true;
            this.Khối.Location = new System.Drawing.Point(193, 26);
            this.Khối.Name = "Khối";
            this.Khối.Size = new System.Drawing.Size(28, 13);
            this.Khối.TabIndex = 3;
            this.Khối.Text = "Khối";
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
            this.diem15p,
            this.GK,
            this.CK,
            this.TB});
            this.dataGridView1.Location = new System.Drawing.Point(6, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(561, 378);
            this.dataGridView1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Danh sách điểm của lớp 10A1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newdiem15p,
            this.newGK,
            this.newCK});
            this.dataGridView2.Location = new System.Drawing.Point(573, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(249, 378);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // newdiem15p
            // 
            this.newdiem15p.HeaderText = "15 phút";
            this.newdiem15p.Name = "newdiem15p";
            this.newdiem15p.Width = 70;
            // 
            // newGK
            // 
            this.newGK.HeaderText = "Giữa kỳ";
            this.newGK.Name = "newGK";
            this.newGK.Width = 70;
            // 
            // newCK
            // 
            this.newCK.HeaderText = "Cuối kỳ";
            this.newCK.Name = "newCK";
            this.newCK.Width = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cập nhật điểm";
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
            this.HoTen.Width = 170;
            // 
            // diem15p
            // 
            this.diem15p.HeaderText = "15 phút";
            this.diem15p.Name = "diem15p";
            this.diem15p.ReadOnly = true;
            this.diem15p.Width = 70;
            // 
            // GK
            // 
            this.GK.HeaderText = "Giữa kỳ";
            this.GK.Name = "GK";
            this.GK.ReadOnly = true;
            this.GK.Width = 70;
            // 
            // CK
            // 
            this.CK.HeaderText = "Cuối kỳ";
            this.CK.Name = "CK";
            this.CK.ReadOnly = true;
            this.CK.Width = 70;
            // 
            // TB
            // 
            this.TB.HeaderText = "ĐTB";
            this.TB.Name = "TB";
            this.TB.ReadOnly = true;
            this.TB.Width = 70;
            // 
            // frm_NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBoxChonLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NhapDiem";
            this.ShowIcon = false;
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.frm_NhapDiem_Load);
            this.GroupBoxChonLop.ResumeLayout(false);
            this.GroupBoxChonLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxChonLop;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox txtHocKy;
        private System.Windows.Forms.ComboBox txtLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMon;
        private System.Windows.Forms.ComboBox txtKhoi;
        private System.Windows.Forms.ComboBox txtNamHoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_NamHoc;
        private System.Windows.Forms.Label Khối;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn newdiem15p;
        private System.Windows.Forms.DataGridViewTextBoxColumn newGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem15p;
        private System.Windows.Forms.DataGridViewTextBoxColumn GK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB;
    }
}