namespace NMCNPM
{
    partial class frm_ThayDoiQuyDinh
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_TenTruong = new System.Windows.Forms.TextBox();
            this.txt_TenTruongMoi = new System.Windows.Forms.TextBox();
            this.gb_TenTruong = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_TuoiToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_TuoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.txt_TuoiToiThieu = new System.Windows.Forms.TextBox();
            this.txt_TuoiToiDa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_SiSoToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_SiSoToiDa = new System.Windows.Forms.NumericUpDown();
            this.txt_SiSoToiThieu = new System.Windows.Forms.TextBox();
            this.txt_SiSoToiDa = new System.Windows.Forms.TextBox();
            this.lbl_SiSoToiThieu = new System.Windows.Forms.Label();
            this.lbl_SiSoToiDa = new System.Windows.Forms.Label();
            this.txt_DiemQuaMon1 = new System.Windows.Forms.TextBox();
            this.gb_QuyDinhDiem = new System.Windows.Forms.GroupBox();
            this.txt_DiemQuaMon2 = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.gb_TenTruong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TuoiToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TuoiToiDa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SiSoToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SiSoToiDa)).BeginInit();
            this.gb_QuyDinhDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(428, 211);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(101, 33);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_TenTruong
            // 
            this.txt_TenTruong.Location = new System.Drawing.Point(56, 19);
            this.txt_TenTruong.Name = "txt_TenTruong";
            this.txt_TenTruong.Size = new System.Drawing.Size(403, 20);
            this.txt_TenTruong.TabIndex = 1;
            this.txt_TenTruong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenTruongMoi
            // 
            this.txt_TenTruongMoi.Location = new System.Drawing.Point(56, 55);
            this.txt_TenTruongMoi.Name = "txt_TenTruongMoi";
            this.txt_TenTruongMoi.Size = new System.Drawing.Size(403, 20);
            this.txt_TenTruongMoi.TabIndex = 0;
            this.txt_TenTruongMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TenTruongMoi.TextChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            // 
            // gb_TenTruong
            // 
            this.gb_TenTruong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_TenTruong.Controls.Add(this.txt_TenTruong);
            this.gb_TenTruong.Controls.Add(this.txt_TenTruongMoi);
            this.gb_TenTruong.Location = new System.Drawing.Point(27, 12);
            this.gb_TenTruong.Name = "gb_TenTruong";
            this.gb_TenTruong.Size = new System.Drawing.Size(494, 93);
            this.gb_TenTruong.TabIndex = 3;
            this.gb_TenTruong.TabStop = false;
            this.gb_TenTruong.Text = "Tên trường:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_TuoiToiThieu);
            this.groupBox1.Controls.Add(this.num_TuoiToiDa);
            this.groupBox1.Controls.Add(this.txt_TuoiToiThieu);
            this.groupBox1.Controls.Add(this.txt_TuoiToiDa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy định tuổi";
            // 
            // num_TuoiToiThieu
            // 
            this.num_TuoiToiThieu.Location = new System.Drawing.Point(134, 55);
            this.num_TuoiToiThieu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TuoiToiThieu.Name = "num_TuoiToiThieu";
            this.num_TuoiToiThieu.Size = new System.Drawing.Size(44, 20);
            this.num_TuoiToiThieu.TabIndex = 2;
            this.num_TuoiToiThieu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_TuoiToiThieu.ValueChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            // 
            // num_TuoiToiDa
            // 
            this.num_TuoiToiDa.Location = new System.Drawing.Point(134, 24);
            this.num_TuoiToiDa.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_TuoiToiDa.Name = "num_TuoiToiDa";
            this.num_TuoiToiDa.Size = new System.Drawing.Size(44, 20);
            this.num_TuoiToiDa.TabIndex = 1;
            this.num_TuoiToiDa.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_TuoiToiDa.ValueChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            // 
            // txt_TuoiToiThieu
            // 
            this.txt_TuoiToiThieu.Enabled = false;
            this.txt_TuoiToiThieu.Location = new System.Drawing.Point(83, 54);
            this.txt_TuoiToiThieu.Name = "txt_TuoiToiThieu";
            this.txt_TuoiToiThieu.Size = new System.Drawing.Size(38, 20);
            this.txt_TuoiToiThieu.TabIndex = 1;
            this.txt_TuoiToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TuoiToiDa
            // 
            this.txt_TuoiToiDa.Enabled = false;
            this.txt_TuoiToiDa.Location = new System.Drawing.Point(83, 24);
            this.txt_TuoiToiDa.Name = "txt_TuoiToiDa";
            this.txt_TuoiToiDa.Size = new System.Drawing.Size(38, 20);
            this.txt_TuoiToiDa.TabIndex = 1;
            this.txt_TuoiToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tuổi tối thiểu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuổi tối đa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_SiSoToiThieu);
            this.groupBox2.Controls.Add(this.num_SiSoToiDa);
            this.groupBox2.Controls.Add(this.txt_SiSoToiThieu);
            this.groupBox2.Controls.Add(this.txt_SiSoToiDa);
            this.groupBox2.Controls.Add(this.lbl_SiSoToiThieu);
            this.groupBox2.Controls.Add(this.lbl_SiSoToiDa);
            this.groupBox2.Location = new System.Drawing.Point(226, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy định sĩ số";
            // 
            // num_SiSoToiThieu
            // 
            this.num_SiSoToiThieu.Location = new System.Drawing.Point(135, 55);
            this.num_SiSoToiThieu.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.num_SiSoToiThieu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SiSoToiThieu.Name = "num_SiSoToiThieu";
            this.num_SiSoToiThieu.Size = new System.Drawing.Size(44, 20);
            this.num_SiSoToiThieu.TabIndex = 4;
            this.num_SiSoToiThieu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_SiSoToiThieu.ValueChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            // 
            // num_SiSoToiDa
            // 
            this.num_SiSoToiDa.Location = new System.Drawing.Point(135, 24);
            this.num_SiSoToiDa.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.num_SiSoToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SiSoToiDa.Name = "num_SiSoToiDa";
            this.num_SiSoToiDa.Size = new System.Drawing.Size(44, 20);
            this.num_SiSoToiDa.TabIndex = 3;
            this.num_SiSoToiDa.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_SiSoToiDa.ValueChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            // 
            // txt_SiSoToiThieu
            // 
            this.txt_SiSoToiThieu.Enabled = false;
            this.txt_SiSoToiThieu.Location = new System.Drawing.Point(84, 54);
            this.txt_SiSoToiThieu.Name = "txt_SiSoToiThieu";
            this.txt_SiSoToiThieu.Size = new System.Drawing.Size(38, 20);
            this.txt_SiSoToiThieu.TabIndex = 1;
            this.txt_SiSoToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SiSoToiDa
            // 
            this.txt_SiSoToiDa.Enabled = false;
            this.txt_SiSoToiDa.Location = new System.Drawing.Point(84, 24);
            this.txt_SiSoToiDa.Name = "txt_SiSoToiDa";
            this.txt_SiSoToiDa.Size = new System.Drawing.Size(38, 20);
            this.txt_SiSoToiDa.TabIndex = 1;
            this.txt_SiSoToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SiSoToiThieu
            // 
            this.lbl_SiSoToiThieu.AutoSize = true;
            this.lbl_SiSoToiThieu.Location = new System.Drawing.Point(6, 57);
            this.lbl_SiSoToiThieu.Name = "lbl_SiSoToiThieu";
            this.lbl_SiSoToiThieu.Size = new System.Drawing.Size(76, 13);
            this.lbl_SiSoToiThieu.TabIndex = 0;
            this.lbl_SiSoToiThieu.Text = "Sĩ số tối thiểu:";
            // 
            // lbl_SiSoToiDa
            // 
            this.lbl_SiSoToiDa.AutoSize = true;
            this.lbl_SiSoToiDa.Location = new System.Drawing.Point(6, 27);
            this.lbl_SiSoToiDa.Name = "lbl_SiSoToiDa";
            this.lbl_SiSoToiDa.Size = new System.Drawing.Size(66, 13);
            this.lbl_SiSoToiDa.TabIndex = 0;
            this.lbl_SiSoToiDa.Text = "Sĩ số tối đa:";
            // 
            // txt_DiemQuaMon1
            // 
            this.txt_DiemQuaMon1.Enabled = false;
            this.txt_DiemQuaMon1.Location = new System.Drawing.Point(18, 19);
            this.txt_DiemQuaMon1.Name = "txt_DiemQuaMon1";
            this.txt_DiemQuaMon1.Size = new System.Drawing.Size(53, 20);
            this.txt_DiemQuaMon1.TabIndex = 5;
            this.txt_DiemQuaMon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_QuyDinhDiem
            // 
            this.gb_QuyDinhDiem.Controls.Add(this.txt_DiemQuaMon2);
            this.gb_QuyDinhDiem.Controls.Add(this.txt_DiemQuaMon1);
            this.gb_QuyDinhDiem.Location = new System.Drawing.Point(428, 116);
            this.gb_QuyDinhDiem.Name = "gb_QuyDinhDiem";
            this.gb_QuyDinhDiem.Size = new System.Drawing.Size(93, 89);
            this.gb_QuyDinhDiem.TabIndex = 6;
            this.gb_QuyDinhDiem.TabStop = false;
            this.gb_QuyDinhDiem.Text = "Điểm qua môn:";
            // 
            // txt_DiemQuaMon2
            // 
            this.txt_DiemQuaMon2.Location = new System.Drawing.Point(18, 54);
            this.txt_DiemQuaMon2.Name = "txt_DiemQuaMon2";
            this.txt_DiemQuaMon2.Size = new System.Drawing.Size(53, 20);
            this.txt_DiemQuaMon2.TabIndex = 5;
            this.txt_DiemQuaMon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DiemQuaMon2.TextChanged += new System.EventHandler(this.txt_TenTruongMoi_TextChanged);
            this.txt_DiemQuaMon2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(308, 211);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(101, 33);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Status.Location = new System.Drawing.Point(17, 221);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 8;
            // 
            // frm_ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.gb_QuyDinhDiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_TenTruong);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ThayDoiQuyDinh";
            this.ShowIcon = false;
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.frm_ThayDoiQuyDinh_Load);
            this.gb_TenTruong.ResumeLayout(false);
            this.gb_TenTruong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TuoiToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TuoiToiDa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SiSoToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SiSoToiDa)).EndInit();
            this.gb_QuyDinhDiem.ResumeLayout(false);
            this.gb_QuyDinhDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TenTruong;
        private System.Windows.Forms.TextBox txt_TenTruongMoi;
        private System.Windows.Forms.GroupBox gb_TenTruong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_TuoiToiThieu;
        private System.Windows.Forms.NumericUpDown num_TuoiToiDa;
        private System.Windows.Forms.TextBox txt_TuoiToiThieu;
        private System.Windows.Forms.TextBox txt_TuoiToiDa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_SiSoToiThieu;
        private System.Windows.Forms.NumericUpDown num_SiSoToiDa;
        private System.Windows.Forms.TextBox txt_SiSoToiThieu;
        private System.Windows.Forms.TextBox txt_SiSoToiDa;
        private System.Windows.Forms.Label lbl_SiSoToiThieu;
        private System.Windows.Forms.Label lbl_SiSoToiDa;
        private System.Windows.Forms.TextBox txt_DiemQuaMon1;
        private System.Windows.Forms.GroupBox gb_QuyDinhDiem;
        private System.Windows.Forms.TextBox txt_DiemQuaMon2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_Status;
    }
}