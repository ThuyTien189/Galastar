namespace PBL3.VIEWS.Login
{
    partial class LoginMainPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.butHidePass = new System.Windows.Forms.PictureBox();
            this.txtUserName = new PBL3.CustomTextBox2();
            this.loginError = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.butSignUp = new System.Windows.Forms.Label();
            this.butForgotPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butSignIn = new PBL3.CustomButton();
            this.txtPassWord = new PBL3.CustomTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PBL3.Properties.Resources._277022722_1117882025656475_5259883700876752754_n;
            this.pictureBox1.Location = new System.Drawing.Point(163, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "CINEMA";
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.panelSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSignIn.Controls.Add(this.butHidePass);
            this.panelSignIn.Controls.Add(this.txtUserName);
            this.panelSignIn.Controls.Add(this.loginError);
            this.panelSignIn.Controls.Add(this.passError);
            this.panelSignIn.Controls.Add(this.butSignUp);
            this.panelSignIn.Controls.Add(this.butForgotPass);
            this.panelSignIn.Controls.Add(this.label1);
            this.panelSignIn.Controls.Add(this.butSignIn);
            this.panelSignIn.Controls.Add(this.txtPassWord);
            this.panelSignIn.Location = new System.Drawing.Point(967, 91);
            this.panelSignIn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(604, 761);
            this.panelSignIn.TabIndex = 13;
            // 
            // butHidePass
            // 
            this.butHidePass.BackColor = System.Drawing.Color.Transparent;
            this.butHidePass.Image = global::PBL3.Properties.Resources.eye_off_outline;
            this.butHidePass.Location = new System.Drawing.Point(474, 343);
            this.butHidePass.Name = "butHidePass";
            this.butHidePass.Size = new System.Drawing.Size(25, 25);
            this.butHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butHidePass.TabIndex = 9;
            this.butHidePass.TabStop = false;
            this.butHidePass.Click += new System.EventHandler(this.butHidePass_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.White;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.txtUserName.BorderRadius = 0;
            this.txtUserName.BorderSize = 5;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(98, 241);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "UserName";
            this.txtUserName.Size = new System.Drawing.Size(416, 40);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "";
            this.txtUserName.UnderlinedStyle = true;
            this.txtUserName._TextChanged += new System.EventHandler(this.txtUserName__TextChanged);
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.BackColor = System.Drawing.Color.Transparent;
            this.loginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginError.ForeColor = System.Drawing.Color.DarkRed;
            this.loginError.Location = new System.Drawing.Point(99, 214);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(58, 22);
            this.loginError.TabIndex = 7;
            this.loginError.Text = "label6";
            this.loginError.Visible = false;
            // 
            // passError
            // 
            this.passError.AutoSize = true;
            this.passError.BackColor = System.Drawing.Color.Transparent;
            this.passError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passError.ForeColor = System.Drawing.Color.DarkRed;
            this.passError.Location = new System.Drawing.Point(99, 306);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(58, 22);
            this.passError.TabIndex = 8;
            this.passError.Text = "label6";
            this.passError.Visible = false;
            // 
            // butSignUp
            // 
            this.butSignUp.AutoSize = true;
            this.butSignUp.BackColor = System.Drawing.Color.Transparent;
            this.butSignUp.Font = new System.Drawing.Font("Microsoft YaHei", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSignUp.Location = new System.Drawing.Point(274, 547);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(83, 25);
            this.butSignUp.TabIndex = 4;
            this.butSignUp.Text = "Sign Up";
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // butForgotPass
            // 
            this.butForgotPass.AutoSize = true;
            this.butForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.butForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butForgotPass.ForeColor = System.Drawing.Color.White;
            this.butForgotPass.Location = new System.Drawing.Point(335, 408);
            this.butForgotPass.Name = "butForgotPass";
            this.butForgotPass.Size = new System.Drawing.Size(142, 22);
            this.butForgotPass.TabIndex = 4;
            this.butForgotPass.Text = "Quên mật khẩu?";
            this.butForgotPass.Click += new System.EventHandler(this.butForgotPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // butSignIn
            // 
            this.butSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butSignIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSignIn.BorderRadius = 5;
            this.butSignIn.BorderSize = 0;
            this.butSignIn.FlatAppearance.BorderSize = 0;
            this.butSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSignIn.ForeColor = System.Drawing.Color.White;
            this.butSignIn.Location = new System.Drawing.Point(241, 487);
            this.butSignIn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(147, 46);
            this.butSignIn.TabIndex = 0;
            this.butSignIn.Text = "Sign In";
            this.butSignIn.TextColor = System.Drawing.Color.White;
            this.butSignIn.UseVisualStyleBackColor = false;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassWord.BorderColor = System.Drawing.Color.White;
            this.txtPassWord.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.txtPassWord.BorderRadius = 0;
            this.txtPassWord.BorderSize = 2;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassWord.Location = new System.Drawing.Point(98, 335);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassWord.Multiline = false;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassWord.PasswordChar = true;
            this.txtPassWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassWord.PlaceholderText = "Password";
            this.txtPassWord.Size = new System.Drawing.Size(416, 40);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UnderlinedStyle = true;
            this.txtPassWord._TextChanged += new System.EventHandler(this.txtPassWord__TextChanged);
            // 
            // LoginMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::PBL3.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 948);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "LoginMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galastar Cinema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butHidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.PictureBox butHidePass;
        private CustomTextBox2 txtUserName;
        private System.Windows.Forms.Label loginError;
        private System.Windows.Forms.Label passError;
        private System.Windows.Forms.Label butSignUp;
        private System.Windows.Forms.Label butForgotPass;
        private System.Windows.Forms.Label label1;
        private CustomButton butSignIn;
        private CustomTextBox2 txtPassWord;
    }
}