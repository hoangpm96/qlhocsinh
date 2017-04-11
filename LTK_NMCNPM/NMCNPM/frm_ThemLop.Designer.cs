namespace NMCNPM
{
    partial class frm_ThemLop
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
            this.txt_10TenLop = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Khoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Them10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sl10 = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cb_GiaoVien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_10TenLop
            // 
            this.txt_10TenLop.Location = new System.Drawing.Point(102, 20);
            this.txt_10TenLop.MaxLength = 2;
            this.txt_10TenLop.Name = "txt_10TenLop";
            this.txt_10TenLop.Size = new System.Drawing.Size(23, 20);
            this.txt_10TenLop.TabIndex = 1;
            this.txt_10TenLop.Text = "C1";
            this.txt_10TenLop.TextChanged += new System.EventHandler(this.txt_10TenLop_TextChanged);
            this.txt_10TenLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_10TenLop_KeyPress);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(263, 81);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(103, 30);
            this.btn_Huy.TabIndex = 2;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(113, 81);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(103, 30);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên lớp:";
            // 
            // txt_Khoi
            // 
            this.txt_Khoi.Enabled = false;
            this.txt_Khoi.Location = new System.Drawing.Point(83, 20);
            this.txt_Khoi.Name = "txt_Khoi";
            this.txt_Khoi.Size = new System.Drawing.Size(20, 20);
            this.txt_Khoi.TabIndex = 1;
            this.txt_Khoi.Text = "10";
            this.txt_Khoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_GiaoVien);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Them10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sl10);
            this.groupBox1.Controls.Add(this.txt_10TenLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Khoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 63);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm lớp";
            // 
            // btn_Them10
            // 
            this.btn_Them10.Enabled = false;
            this.btn_Them10.Location = new System.Drawing.Point(382, 14);
            this.btn_Them10.Name = "btn_Them10";
            this.btn_Them10.Size = new System.Drawing.Size(59, 30);
            this.btn_Them10.TabIndex = 2;
            this.btn_Them10.Text = "Thêm";
            this.btn_Them10.UseVisualStyleBackColor = true;
            this.btn_Them10.Click += new System.EventHandler(this.btn_Them10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GVCN:";
            // 
            // txt_sl10
            // 
            this.txt_sl10.Enabled = false;
            this.txt_sl10.Location = new System.Drawing.Point(6, 21);
            this.txt_sl10.Name = "txt_sl10";
            this.txt_sl10.Size = new System.Drawing.Size(23, 20);
            this.txt_sl10.TabIndex = 1;
            this.txt_sl10.Text = "5";
            this.txt_sl10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(179, 48);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 5;
            // 
            // cb_GiaoVien
            // 
            this.cb_GiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GiaoVien.FormattingEnabled = true;
            this.cb_GiaoVien.Location = new System.Drawing.Point(182, 19);
            this.cb_GiaoVien.Name = "cb_GiaoVien";
            this.cb_GiaoVien.Size = new System.Drawing.Size(184, 21);
            this.cb_GiaoVien.TabIndex = 6;
            this.cb_GiaoVien.SelectedIndexChanged += new System.EventHandler(this.cb_GiaoVien_SelectedIndexChanged);
            // 
            // frm_ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 128);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ThemLop";
            this.ShowIcon = false;
            this.Text = "Thêm lớp";
            this.Load += new System.EventHandler(this.frm_ThemLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_10TenLop;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Khoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them10;
        private System.Windows.Forms.TextBox txt_sl10;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cb_GiaoVien;
    }
}