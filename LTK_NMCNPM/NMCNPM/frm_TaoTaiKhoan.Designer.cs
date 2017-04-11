namespace NMCNPM
{
    partial class frm_TaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TenGiaoVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Quyen = new System.Windows.Forms.ComboBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_XacNhan = new System.Windows.Forms.TextBox();
            this.btn_TaoTaiKhoan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_MaGiaoVien = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên giáo viên:";
            // 
            // cb_TenGiaoVien
            // 
            this.cb_TenGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenGiaoVien.FormattingEnabled = true;
            this.cb_TenGiaoVien.Location = new System.Drawing.Point(163, 28);
            this.cb_TenGiaoVien.Name = "cb_TenGiaoVien";
            this.cb_TenGiaoVien.Size = new System.Drawing.Size(257, 21);
            this.cb_TenGiaoVien.TabIndex = 0;
            this.cb_TenGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cb_TenGiaoVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền:";
            // 
            // cb_Quyen
            // 
            this.cb_Quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Quyen.FormattingEnabled = true;
            this.cb_Quyen.Location = new System.Drawing.Point(163, 60);
            this.cb_Quyen.Name = "cb_Quyen";
            this.cb_Quyen.Size = new System.Drawing.Size(165, 21);
            this.cb_Quyen.TabIndex = 1;
            this.cb_Quyen.SelectedIndexChanged += new System.EventHandler(this.cb_Quyen_SelectedIndexChanged);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Enabled = false;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(163, 102);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(257, 20);
            this.txt_TaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Enabled = false;
            this.txt_MatKhau.Location = new System.Drawing.Point(163, 141);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(257, 20);
            this.txt_MatKhau.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xác nhận:";
            // 
            // txt_XacNhan
            // 
            this.txt_XacNhan.Enabled = false;
            this.txt_XacNhan.Location = new System.Drawing.Point(163, 178);
            this.txt_XacNhan.Name = "txt_XacNhan";
            this.txt_XacNhan.PasswordChar = '*';
            this.txt_XacNhan.Size = new System.Drawing.Size(257, 20);
            this.txt_XacNhan.TabIndex = 5;
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.Location = new System.Drawing.Point(71, 226);
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.Size = new System.Drawing.Size(136, 23);
            this.btn_TaoTaiKhoan.TabIndex = 6;
            this.btn_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.btn_TaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_TaoTaiKhoan.Click += new System.EventHandler(this.btn_TaoTaiKhoan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(265, 226);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(136, 23);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_MaGiaoVien
            // 
            this.txt_MaGiaoVien.Enabled = false;
            this.txt_MaGiaoVien.Location = new System.Drawing.Point(334, 60);
            this.txt_MaGiaoVien.Name = "txt_MaGiaoVien";
            this.txt_MaGiaoVien.Size = new System.Drawing.Size(86, 20);
            this.txt_MaGiaoVien.TabIndex = 5;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Status.Location = new System.Drawing.Point(116, 14);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 6;
            // 
            // frm_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_MaGiaoVien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TaoTaiKhoan);
            this.Controls.Add(this.txt_XacNhan);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.cb_Quyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TenGiaoVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_TaoTaiKhoan";
            this.ShowIcon = false;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frm_TaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TenGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Quyen;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_XacNhan;
        private System.Windows.Forms.Button btn_TaoTaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_MaGiaoVien;
        private System.Windows.Forms.Label lbl_Status;
    }
}