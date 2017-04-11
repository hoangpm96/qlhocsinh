namespace NMCNPM
{
    partial class frm_HuongDanSuDung
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
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = global::NMCNPM.Properties.Resources.a;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thoat.Location = new System.Drawing.Point(946, 511);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 25);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_HuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NMCNPM.Properties.Resources.quyen;
            this.ClientSize = new System.Drawing.Size(1034, 538);
            this.Controls.Add(this.btn_Thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HuongDanSuDung";
            this.ShowIcon = false;
            this.Text = "Hướng dẫn sử dụng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
    }
}