namespace PBL3.VIEWS.Admin
{
    partial class AdminPage
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
            this.AccountIMG = new CustomPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btTK = new PBL3.CustomButton();
            this.btSC = new PBL3.CustomButton();
            this.btPhim = new PBL3.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.AccName);
            this.panel1.Controls.Add(this.AccountIMG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, -1);
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
            this.LogOut.TabIndex = 15;
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
            this.AccName.TabIndex = 17;
            this.AccName.Text = "ACCOUNTNAME";
            this.AccName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountIMG
            // 
            this.AccountIMG.BackColor = System.Drawing.Color.DarkGray;
            this.AccountIMG.Image = global::PBL3.Properties.Resources.DefaultUser;
            this.AccountIMG.Location = new System.Drawing.Point(1555, 44);
            this.AccountIMG.Name = "AccountIMG";
            this.AccountIMG.Size = new System.Drawing.Size(90, 90);
            this.AccountIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountIMG.TabIndex = 16;
            this.AccountIMG.TabStop = false;
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
            this.label4.TabIndex = 14;
            this.label4.Text = "CINEMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(85, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "ADMIN PAGE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3.Properties.Resources._277022722_1117882025656475_5259883700876752754_n;
            this.pictureBox2.Location = new System.Drawing.Point(39, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(399, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 631);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btTK);
            this.panel3.Controls.Add(this.btSC);
            this.panel3.Controls.Add(this.btPhim);
            this.panel3.Location = new System.Drawing.Point(12, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 607);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(140, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "MENU";
            // 
            // btTK
            // 
            this.btTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btTK.BorderRadius = 10;
            this.btTK.BorderSize = 0;
            this.btTK.FlatAppearance.BorderSize = 0;
            this.btTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTK.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.btTK.Location = new System.Drawing.Point(31, 413);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(314, 123);
            this.btTK.TabIndex = 3;
            this.btTK.Text = "THỐNG KÊ";
            this.btTK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.btTK.UseVisualStyleBackColor = false;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // btSC
            // 
            this.btSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.btSC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.btSC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btSC.BorderRadius = 10;
            this.btSC.BorderSize = 0;
            this.btSC.FlatAppearance.BorderSize = 0;
            this.btSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSC.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(223)))));
            this.btSC.Location = new System.Drawing.Point(31, 262);
            this.btSC.Name = "btSC";
            this.btSC.Size = new System.Drawing.Size(314, 123);
            this.btSC.TabIndex = 2;
            this.btSC.Text = "SUẤT CHIẾU";
            this.btSC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(223)))));
            this.btSC.UseVisualStyleBackColor = false;
            this.btSC.Click += new System.EventHandler(this.btSC_Click);
            // 
            // btPhim
            // 
            this.btPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.btPhim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.btPhim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btPhim.BorderRadius = 10;
            this.btPhim.BorderSize = 0;
            this.btPhim.FlatAppearance.BorderSize = 0;
            this.btPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhim.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.btPhim.Location = new System.Drawing.Point(31, 109);
            this.btPhim.Name = "btPhim";
            this.btPhim.Size = new System.Drawing.Size(314, 123);
            this.btPhim.TabIndex = 1;
            this.btPhim.Text = "PHIM";
            this.btPhim.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.btPhim.UseVisualStyleBackColor = false;
            this.btPhim.Click += new System.EventHandler(this.btPhim_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1680, 948);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomButton btPhim;
        private CustomButton btSC;
        private CustomButton btTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label AccName;
        private CustomPictureBox AccountIMG;
    }
}