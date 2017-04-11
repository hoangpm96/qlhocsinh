namespace NMCNPM
{
    partial class frm_BaoCaoTongKet
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
            this.lbl_BaoCaoMon = new System.Windows.Forms.Label();
            this.txtNamHoc1 = new System.Windows.Forms.ComboBox();
            this.txtMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblNamHoc1 = new System.Windows.Forms.Label();
            this.lbl_HocKy1 = new System.Windows.Forms.Label();
            this.txtHocKy1 = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.txtHocKy2 = new System.Windows.Forms.ComboBox();
            this.txtNamHoc2 = new System.Windows.Forms.ComboBox();
            this.lblHocKy2 = new System.Windows.Forms.Label();
            this.lblNamHoc2 = new System.Windows.Forms.Label();
            this.lbl_BaoCaoTongKet = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BaoCaoMon
            // 
            this.lbl_BaoCaoMon.AutoSize = true;
            this.lbl_BaoCaoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaoCaoMon.Location = new System.Drawing.Point(141, 9);
            this.lbl_BaoCaoMon.Name = "lbl_BaoCaoMon";
            this.lbl_BaoCaoMon.Size = new System.Drawing.Size(295, 25);
            this.lbl_BaoCaoMon.TabIndex = 0;
            this.lbl_BaoCaoMon.Text = "BÁO CÁO TỔNG KẾT MÔN";
            // 
            // txtNamHoc1
            // 
            this.txtNamHoc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNamHoc1.Location = new System.Drawing.Point(80, 45);
            this.txtNamHoc1.Name = "txtNamHoc1";
            this.txtNamHoc1.Size = new System.Drawing.Size(85, 21);
            this.txtNamHoc1.TabIndex = 3;
            this.txtNamHoc1.SelectedIndexChanged += new System.EventHandler(this.txtNamHoc1_SelectedIndexChanged);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMonHoc.Enabled = false;
            this.txtMonHoc.Items.AddRange(new object[] {
            "2013 - 2014",
            "2014 - 2015",
            "2015 - 2016"});
            this.txtMonHoc.Location = new System.Drawing.Point(368, 42);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(102, 21);
            this.txtMonHoc.TabIndex = 5;
            this.txtMonHoc.SelectedIndexChanged += new System.EventHandler(this.txtMonHoc_SelectedIndexChanged);
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(334, 45);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(28, 13);
            this.lblMon.TabIndex = 6;
            this.lblMon.Text = "Môn";
            // 
            // lblNamHoc1
            // 
            this.lblNamHoc1.AutoSize = true;
            this.lblNamHoc1.Location = new System.Drawing.Point(24, 45);
            this.lblNamHoc1.Name = "lblNamHoc1";
            this.lblNamHoc1.Size = new System.Drawing.Size(50, 13);
            this.lblNamHoc1.TabIndex = 7;
            this.lblNamHoc1.Text = "Năm học";
            // 
            // lbl_HocKy1
            // 
            this.lbl_HocKy1.AutoSize = true;
            this.lbl_HocKy1.Location = new System.Drawing.Point(184, 45);
            this.lbl_HocKy1.Name = "lbl_HocKy1";
            this.lbl_HocKy1.Size = new System.Drawing.Size(41, 13);
            this.lbl_HocKy1.TabIndex = 7;
            this.lbl_HocKy1.Text = "Học kỳ";
            // 
            // txtHocKy1
            // 
            this.txtHocKy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHocKy1.Enabled = false;
            this.txtHocKy1.Location = new System.Drawing.Point(231, 42);
            this.txtHocKy1.Name = "txtHocKy1";
            this.txtHocKy1.Size = new System.Drawing.Size(85, 21);
            this.txtHocKy1.TabIndex = 4;
            this.txtHocKy1.SelectedIndexChanged += new System.EventHandler(this.txtHocKy1_SelectedIndexChanged);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Lop,
            this.SiSo,
            this.SoLuongDat,
            this.TiLe});
            this.dgv1.Location = new System.Drawing.Point(15, 69);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(552, 163);
            this.dgv1.TabIndex = 9;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv2.Location = new System.Drawing.Point(15, 303);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(552, 163);
            this.dgv2.TabIndex = 18;
            // 
            // txtHocKy2
            // 
            this.txtHocKy2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHocKy2.Enabled = false;
            this.txtHocKy2.Location = new System.Drawing.Point(331, 276);
            this.txtHocKy2.Name = "txtHocKy2";
            this.txtHocKy2.Size = new System.Drawing.Size(85, 21);
            this.txtHocKy2.TabIndex = 7;
            this.txtHocKy2.SelectedIndexChanged += new System.EventHandler(this.txtHocKy2_SelectedIndexChanged);
            // 
            // txtNamHoc2
            // 
            this.txtNamHoc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNamHoc2.Location = new System.Drawing.Point(180, 279);
            this.txtNamHoc2.Name = "txtNamHoc2";
            this.txtNamHoc2.Size = new System.Drawing.Size(85, 21);
            this.txtNamHoc2.TabIndex = 6;
            this.txtNamHoc2.SelectedIndexChanged += new System.EventHandler(this.txtNamHoc2_SelectedIndexChanged);
            // 
            // lblHocKy2
            // 
            this.lblHocKy2.AutoSize = true;
            this.lblHocKy2.Location = new System.Drawing.Point(284, 279);
            this.lblHocKy2.Name = "lblHocKy2";
            this.lblHocKy2.Size = new System.Drawing.Size(41, 13);
            this.lblHocKy2.TabIndex = 15;
            this.lblHocKy2.Text = "Học kỳ";
            // 
            // lblNamHoc2
            // 
            this.lblNamHoc2.AutoSize = true;
            this.lblNamHoc2.Location = new System.Drawing.Point(124, 279);
            this.lblNamHoc2.Name = "lblNamHoc2";
            this.lblNamHoc2.Size = new System.Drawing.Size(50, 13);
            this.lblNamHoc2.TabIndex = 16;
            this.lblNamHoc2.Text = "Năm học";
            // 
            // lbl_BaoCaoTongKet
            // 
            this.lbl_BaoCaoTongKet.AutoSize = true;
            this.lbl_BaoCaoTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaoCaoTongKet.Location = new System.Drawing.Point(165, 248);
            this.lbl_BaoCaoTongKet.Name = "lbl_BaoCaoTongKet";
            this.lbl_BaoCaoTongKet.Size = new System.Drawing.Size(236, 25);
            this.lbl_BaoCaoTongKet.TabIndex = 10;
            this.lbl_BaoCaoTongKet.Text = "BÁO CÁO TỔNG KẾT";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(485, 473);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 24);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // SiSo
            // 
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.HeaderText = "Số lượng đạt";
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            this.TiLe.Width = 108;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sĩ số";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng đạt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tỉ lệ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // frm_BaoCaoTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 509);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txtHocKy2);
            this.Controls.Add(this.txtNamHoc2);
            this.Controls.Add(this.lblHocKy2);
            this.Controls.Add(this.lblNamHoc2);
            this.Controls.Add(this.lbl_BaoCaoTongKet);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtHocKy1);
            this.Controls.Add(this.txtNamHoc1);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.lbl_HocKy1);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.lblNamHoc1);
            this.Controls.Add(this.lbl_BaoCaoMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BaoCaoTongKet";
            this.Text = "Lập báo cáo tổng kết";
            this.Load += new System.EventHandler(this.frm_BaoCaoTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BaoCaoMon;
        private System.Windows.Forms.ComboBox txtNamHoc1;
        private System.Windows.Forms.ComboBox txtMonHoc;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblNamHoc1;
        private System.Windows.Forms.Label lbl_HocKy1;
        private System.Windows.Forms.ComboBox txtHocKy1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox txtHocKy2;
        private System.Windows.Forms.ComboBox txtNamHoc2;
        private System.Windows.Forms.Label lblHocKy2;
        private System.Windows.Forms.Label lblNamHoc2;
        private System.Windows.Forms.Label lbl_BaoCaoTongKet;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}