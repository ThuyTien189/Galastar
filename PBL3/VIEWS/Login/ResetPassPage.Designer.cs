namespace PBL3.VIEWS.Login
{
    partial class ResetPassPage
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
            this.pnAccount = new System.Windows.Forms.Panel();
            this.existError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInput = new PBL3.CustomTextBox2();
            this.butCancel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.butNext = new PBL3.CustomButton();
            this.pnSetPass = new System.Windows.Forms.Panel();
            this.butHidePass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReNewPass = new PBL3.CustomTextBox2();
            this.txtNewPass = new PBL3.CustomTextBox2();
            this.label10 = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Label();
            this.butConfirm = new PBL3.CustomButton();
            this.pnAccount.SuspendLayout();
            this.pnSetPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.pnAccount.Controls.Add(this.existError);
            this.pnAccount.Controls.Add(this.label9);
            this.pnAccount.Controls.Add(this.txtInput);
            this.pnAccount.Controls.Add(this.butCancel);
            this.pnAccount.Controls.Add(this.label8);
            this.pnAccount.Controls.Add(this.butNext);
            this.pnAccount.Location = new System.Drawing.Point(0, 0);
            this.pnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(604, 761);
            this.pnAccount.TabIndex = 10;
            // 
            // existError
            // 
            this.existError.AutoSize = true;
            this.existError.BackColor = System.Drawing.Color.Transparent;
            this.existError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existError.ForeColor = System.Drawing.Color.DarkRed;
            this.existError.Location = new System.Drawing.Point(102, 309);
            this.existError.Name = "existError";
            this.existError.Size = new System.Drawing.Size(223, 22);
            this.existError.TabIndex = 12;
            this.existError.Text = "Không tìm thấy người dùng";
            this.existError.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(131, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 43);
            this.label9.TabIndex = 4;
            this.label9.Text = "Vui lòng nhập username hoặc số điện thoại của bạn?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.BorderColor = System.Drawing.Color.White;
            this.txtInput.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.txtInput.BorderRadius = 0;
            this.txtInput.BorderSize = 5;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.DimGray;
            this.txtInput.Location = new System.Drawing.Point(98, 344);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Multiline = false;
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.PasswordChar = false;
            this.txtInput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInput.PlaceholderText = "";
            this.txtInput.Size = new System.Drawing.Size(416, 38);
            this.txtInput.TabIndex = 11;
            this.txtInput.Tag = "";
            this.txtInput.UnderlinedStyle = true;
            this.txtInput._TextChanged += new System.EventHandler(this.txtInput__TextChanged);
            // 
            // butCancel
            // 
            this.butCancel.AutoSize = true;
            this.butCancel.BackColor = System.Drawing.Color.Transparent;
            this.butCancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butCancel.Location = new System.Drawing.Point(287, 501);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(49, 25);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Huỷ";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(135, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(349, 43);
            this.label8.TabIndex = 2;
            this.label8.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // butNext
            // 
            this.butNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butNext.BorderRadius = 5;
            this.butNext.BorderSize = 0;
            this.butNext.FlatAppearance.BorderSize = 0;
            this.butNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNext.ForeColor = System.Drawing.Color.White;
            this.butNext.Location = new System.Drawing.Point(241, 441);
            this.butNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(147, 46);
            this.butNext.TabIndex = 0;
            this.butNext.Text = "Tiếp tục";
            this.butNext.TextColor = System.Drawing.Color.White;
            this.butNext.UseVisualStyleBackColor = false;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // pnSetPass
            // 
            this.pnSetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.pnSetPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnSetPass.Controls.Add(this.butHidePass);
            this.pnSetPass.Controls.Add(this.label1);
            this.pnSetPass.Controls.Add(this.txtReNewPass);
            this.pnSetPass.Controls.Add(this.txtNewPass);
            this.pnSetPass.Controls.Add(this.label10);
            this.pnSetPass.Controls.Add(this.butBack);
            this.pnSetPass.Controls.Add(this.butConfirm);
            this.pnSetPass.Location = new System.Drawing.Point(0, 0);
            this.pnSetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSetPass.Name = "pnSetPass";
            this.pnSetPass.Size = new System.Drawing.Size(604, 761);
            this.pnSetPass.TabIndex = 13;
            this.pnSetPass.Visible = false;
            // 
            // butHidePass
            // 
            this.butHidePass.BackColor = System.Drawing.Color.Transparent;
            this.butHidePass.Image = global::PBL3.Properties.Resources.eye_off_outline;
            this.butHidePass.Location = new System.Drawing.Point(473, 308);
            this.butHidePass.Name = "butHidePass";
            this.butHidePass.Size = new System.Drawing.Size(25, 25);
            this.butHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butHidePass.TabIndex = 15;
            this.butHidePass.TabStop = false;
            this.butHidePass.Click += new System.EventHandler(this.butHidePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtReNewPass.BorderColor = System.Drawing.Color.White;
            this.txtReNewPass.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.txtReNewPass.BorderRadius = 0;
            this.txtReNewPass.BorderSize = 5;
            this.txtReNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtReNewPass.Location = new System.Drawing.Point(98, 302);
            this.txtReNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtReNewPass.Multiline = false;
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReNewPass.PasswordChar = true;
            this.txtReNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReNewPass.PlaceholderText = "Nhập lại mật khẩu";
            this.txtReNewPass.Size = new System.Drawing.Size(416, 38);
            this.txtReNewPass.TabIndex = 13;
            this.txtReNewPass.Tag = "";
            this.txtReNewPass.UnderlinedStyle = true;
            this.txtReNewPass._TextChanged += new System.EventHandler(this.txtReNewPass__TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass.BorderColor = System.Drawing.Color.White;
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.txtNewPass.BorderRadius = 0;
            this.txtNewPass.BorderSize = 5;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewPass.Location = new System.Drawing.Point(98, 241);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNewPass.PasswordChar = true;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "Nhập mật khẩu mới";
            this.txtNewPass.Size = new System.Drawing.Size(416, 38);
            this.txtNewPass.TabIndex = 13;
            this.txtNewPass.Tag = "";
            this.txtNewPass.UnderlinedStyle = true;
            this.txtNewPass._TextChanged += new System.EventHandler(this.txtNewPass__TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(65, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 132);
            this.label10.TabIndex = 12;
            this.label10.Text = "*Lưu ý:\r\n  - Mật khẩu phải dài ít nhất 6 ký tự.\r\n  - Mật khẩu nên kết hợp các số," +
    " chữ cái và dấu chấm câu.\r\n";
            // 
            // butBack
            // 
            this.butBack.AutoSize = true;
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butBack.Location = new System.Drawing.Point(270, 603);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(85, 25);
            this.butBack.TabIndex = 10;
            this.butBack.Text = "Quay lại";
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butConfirm.BorderRadius = 5;
            this.butConfirm.BorderSize = 0;
            this.butConfirm.FlatAppearance.BorderSize = 0;
            this.butConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfirm.ForeColor = System.Drawing.Color.White;
            this.butConfirm.Location = new System.Drawing.Point(241, 543);
            this.butConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(147, 46);
            this.butConfirm.TabIndex = 0;
            this.butConfirm.Text = "Xác nhận";
            this.butConfirm.TextColor = System.Drawing.Color.White;
            this.butConfirm.UseVisualStyleBackColor = false;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // ResetPassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 761);
            this.Controls.Add(this.pnSetPass);
            this.Controls.Add(this.pnAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassPage";
            this.Text = "SignUpForm";
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            this.pnSetPass.ResumeLayout(false);
            this.pnSetPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butHidePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.Label butCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CustomButton butNext;
        private CustomTextBox2 txtInput;
        private System.Windows.Forms.Label existError;
        private System.Windows.Forms.Panel pnSetPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label butBack;
        private CustomButton butConfirm;
        private System.Windows.Forms.Label label1;
        private CustomTextBox2 txtReNewPass;
        private CustomTextBox2 txtNewPass;
        private System.Windows.Forms.PictureBox butHidePass;
    }
}