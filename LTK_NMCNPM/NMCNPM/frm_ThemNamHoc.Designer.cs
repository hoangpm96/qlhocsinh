namespace NMCNPM
{
    partial class frm_ThemNamHoc
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_NamHoc = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num12 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num11 = new System.Windows.Forms.NumericUpDown();
            this.num10 = new System.Windows.Forms.NumericUpDown();
            this.txt_TenTruong = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_stt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(207, 19);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_NamHoc
            // 
            this.txt_NamHoc.Enabled = false;
            this.txt_NamHoc.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NamHoc.Location = new System.Drawing.Point(32, 19);
            this.txt_NamHoc.Name = "txt_NamHoc";
            this.txt_NamHoc.Size = new System.Drawing.Size(118, 23);
            this.txt_NamHoc.TabIndex = 3;
            this.txt_NamHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(286, 215);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(45, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NamHoc);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm năm học mới";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ThemLop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.num12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.num11);
            this.groupBox2.Controls.Add(this.num10);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm lớp:";
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Enabled = false;
            this.btn_ThemLop.Location = new System.Drawing.Point(197, 21);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(75, 62);
            this.btn_ThemLop.TabIndex = 2;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lớp khối 12:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lớp khối 11:";
            // 
            // num12
            // 
            this.num12.Enabled = false;
            this.num12.Location = new System.Drawing.Point(99, 68);
            this.num12.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num12.Name = "num12";
            this.num12.ReadOnly = true;
            this.num12.Size = new System.Drawing.Size(44, 20);
            this.num12.TabIndex = 0;
            this.num12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num12.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num12.ValueChanged += new System.EventHandler(this.num10_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lớp khối 10:";
            // 
            // num11
            // 
            this.num11.Enabled = false;
            this.num11.Location = new System.Drawing.Point(99, 43);
            this.num11.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num11.Name = "num11";
            this.num11.ReadOnly = true;
            this.num11.Size = new System.Drawing.Size(44, 20);
            this.num11.TabIndex = 0;
            this.num11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num11.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num11.ValueChanged += new System.EventHandler(this.num10_ValueChanged);
            // 
            // num10
            // 
            this.num10.Enabled = false;
            this.num10.Location = new System.Drawing.Point(99, 19);
            this.num10.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num10.MinimumSize = new System.Drawing.Size(44, 0);
            this.num10.Name = "num10";
            this.num10.ReadOnly = true;
            this.num10.Size = new System.Drawing.Size(44, 20);
            this.num10.TabIndex = 0;
            this.num10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num10.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num10.ValueChanged += new System.EventHandler(this.num10_ValueChanged);
            // 
            // txt_TenTruong
            // 
            this.txt_TenTruong.Enabled = false;
            this.txt_TenTruong.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTruong.Location = new System.Drawing.Point(12, 12);
            this.txt_TenTruong.Multiline = true;
            this.txt_TenTruong.Name = "txt_TenTruong";
            this.txt_TenTruong.Size = new System.Drawing.Size(312, 22);
            this.txt_TenTruong.TabIndex = 3;
            this.txt_TenTruong.Text = "Trường trung học phổ thông bình sơn";
            this.txt_TenTruong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(235, 215);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(45, 23);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_stt
            // 
            this.lbl_stt.AutoSize = true;
            this.lbl_stt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_stt.Location = new System.Drawing.Point(12, 220);
            this.lbl_stt.Name = "lbl_stt";
            this.lbl_stt.Size = new System.Drawing.Size(0, 13);
            this.lbl_stt.TabIndex = 6;
            // 
            // frm_ThemNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 245);
            this.Controls.Add(this.lbl_stt);
            this.Controls.Add(this.txt_TenTruong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 284);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 284);
            this.Name = "frm_ThemNamHoc";
            this.ShowIcon = false;
            this.Text = "Thêm năm học mới";
            this.Load += new System.EventHandler(this.frm_ThemNamHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_NamHoc;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ThemLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num11;
        private System.Windows.Forms.NumericUpDown num10;
        private System.Windows.Forms.TextBox txt_TenTruong;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_stt;
    }
}