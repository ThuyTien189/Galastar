namespace PBL3.VIEWS.User
{
    partial class UserPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.AccName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountIMG = new CustomPictureBox();
            this.btInfor = new PBL3.CustomButton();
            this.btHistory = new PBL3.CustomButton();
            this.btOrder = new PBL3.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.AccName);
            this.panel1.Controls.Add(this.AccountIMG);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btInfor);
            this.panel1.Controls.Add(this.btHistory);
            this.panel1.Controls.Add(this.btOrder);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1677, 278);
            this.panel1.TabIndex = 0;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.LogOut.Location = new System.Drawing.Point(1466, 93);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(76, 23);
            this.LogOut.TabIndex = 7;
            this.LogOut.Text = "Log out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // AccName
            // 
            this.AccName.BackColor = System.Drawing.Color.Transparent;
            this.AccName.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccName.ForeColor = System.Drawing.Color.Black;
            this.AccName.Location = new System.Drawing.Point(1306, 59);
            this.AccName.Name = "AccName";
            this.AccName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccName.Size = new System.Drawing.Size(241, 34);
            this.AccName.TabIndex = 10;
            this.AccName.Text = "ACCOUNTNAME";
            this.AccName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3.Properties.Resources._277022722_1117882025656475_5259883700876752754_n;
            this.pictureBox2.Location = new System.Drawing.Point(39, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(389, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "CINEMA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(30, 281);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1617, 631);
            this.panel3.TabIndex = 2;
            // 
            // AccountIMG
            // 
            this.AccountIMG.BackColor = System.Drawing.Color.DarkGray;
            this.AccountIMG.Image = global::PBL3.Properties.Resources.DefaultUser;
            this.AccountIMG.Location = new System.Drawing.Point(1555, 44);
            this.AccountIMG.Name = "AccountIMG";
            this.AccountIMG.Size = new System.Drawing.Size(90, 90);
            this.AccountIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountIMG.TabIndex = 9;
            this.AccountIMG.TabStop = false;
            // 
            // btInfor
            // 
            this.btInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btInfor.BorderColor = System.Drawing.Color.LightGray;
            this.btInfor.BorderRadius = 15;
            this.btInfor.BorderSize = 1;
            this.btInfor.FlatAppearance.BorderSize = 0;
            this.btInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfor.ForeColor = System.Drawing.Color.Red;
            this.btInfor.Location = new System.Drawing.Point(1391, 211);
            this.btInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInfor.Name = "btInfor";
            this.btInfor.Size = new System.Drawing.Size(242, 45);
            this.btInfor.TabIndex = 2;
            this.btInfor.Text = "THÔNG TIN CÁ NHÂN";
            this.btInfor.TextColor = System.Drawing.Color.Red;
            this.btInfor.UseVisualStyleBackColor = false;
            this.btInfor.Click += new System.EventHandler(this.btInfor_Click);
            // 
            // btHistory
            // 
            this.btHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.btHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.btHistory.BorderColor = System.Drawing.Color.LightGray;
            this.btHistory.BorderRadius = 15;
            this.btHistory.BorderSize = 1;
            this.btHistory.FlatAppearance.BorderSize = 0;
            this.btHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btHistory.Location = new System.Drawing.Point(1181, 211);
            this.btHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(204, 45);
            this.btHistory.TabIndex = 1;
            this.btHistory.Text = "VÉ ĐÃ ĐẶT";
            this.btHistory.TextColor = System.Drawing.Color.SteelBlue;
            this.btHistory.UseVisualStyleBackColor = false;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.btOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.btOrder.BorderColor = System.Drawing.Color.LightGray;
            this.btOrder.BorderRadius = 15;
            this.btOrder.BorderSize = 1;
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.DarkGreen;
            this.btOrder.Location = new System.Drawing.Point(1004, 211);
            this.btOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(171, 45);
            this.btOrder.TabIndex = 0;
            this.btOrder.Text = "ĐẶT VÉ";
            this.btOrder.TextColor = System.Drawing.Color.DarkGreen;
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1680, 948);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private CustomButton btOrder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomButton btInfor;
        private CustomButton btHistory;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label label4;
        private CustomPictureBox AccountIMG;
        private System.Windows.Forms.Label AccName;
    }
}