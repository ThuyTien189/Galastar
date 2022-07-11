using System.Drawing;

namespace PBL3.VIEWS.User
{
    partial class AccountPage
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
            this.Edit = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.addBut = new PBL3.CustomButton();
            this.AccountIMG = new CustomPictureBox();
            this.customPanel2 = new PBL3.CustomPanel();
            this.btCancel = new PBL3.CustomButton();
            this.btOK = new PBL3.CustomButton();
            this.txtDiemTichLuy = new PBL3.CustomTextBox();
            this.txtBirthday = new PBL3.CustomTextBox();
            this.txtPhone = new PBL3.CustomTextBox();
            this.txtCMND = new PBL3.CustomTextBox();
            this.txtFullName = new PBL3.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.addBut);
            this.panel1.Controls.Add(this.AccountIMG);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 631);
            this.panel1.TabIndex = 9;
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.Edit.Location = new System.Drawing.Point(217, 462);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(45, 21);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "EDIT";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(119, 409);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(243, 27);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.Text = "ACCOUNT NAME";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addBut
            // 
            this.addBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.addBut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.addBut.BorderColor = System.Drawing.Color.Black;
            this.addBut.BorderRadius = 280;
            this.addBut.BorderSize = 0;
            this.addBut.FlatAppearance.BorderSize = 0;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.ForeColor = System.Drawing.Color.White;
            this.addBut.Location = new System.Drawing.Point(104, 90);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(280, 280);
            this.addBut.TabIndex = 11;
            this.addBut.Text = "+";
            this.addBut.TextColor = System.Drawing.Color.White;
            this.addBut.UseCompatibleTextRendering = true;
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Visible = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            this.addBut.MouseLeave += new System.EventHandler(this.addBut_MouseLeave);
            // 
            // AccountIMG
            // 
            this.AccountIMG.BackColor = System.Drawing.Color.DarkGray;
            this.AccountIMG.Image = global::PBL3.Properties.Resources.DefaultUser;
            this.AccountIMG.Location = new System.Drawing.Point(104, 90);
            this.AccountIMG.Name = "AccountIMG";
            this.AccountIMG.Size = new System.Drawing.Size(280, 280);
            this.AccountIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountIMG.TabIndex = 10;
            this.AccountIMG.TabStop = false;
            this.AccountIMG.MouseEnter += new System.EventHandler(this.AccountIMG_MouseEnter);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(78)))));
            this.customPanel2.BorderColor = System.Drawing.Color.White;
            this.customPanel2.Controls.Add(this.btCancel);
            this.customPanel2.Controls.Add(this.btOK);
            this.customPanel2.Controls.Add(this.txtDiemTichLuy);
            this.customPanel2.Controls.Add(this.txtBirthday);
            this.customPanel2.Controls.Add(this.txtPhone);
            this.customPanel2.Controls.Add(this.txtCMND);
            this.customPanel2.Controls.Add(this.txtFullName);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.label16);
            this.customPanel2.Controls.Add(this.label17);
            this.customPanel2.Controls.Add(this.label18);
            this.customPanel2.Controls.Add(this.label19);
            this.customPanel2.Edge = 20;
            this.customPanel2.Location = new System.Drawing.Point(529, 0);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1076, 631);
            this.customPanel2.TabIndex = 8;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btCancel.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCancel.BorderRadius = 10;
            this.btCancel.BorderSize = 0;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(643, 531);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(150, 35);
            this.btCancel.TabIndex = 26;
            this.btCancel.Text = "Hủy bỏ";
            this.btCancel.TextColor = System.Drawing.Color.White;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btOK.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btOK.BorderRadius = 10;
            this.btOK.BorderSize = 0;
            this.btOK.FlatAppearance.BorderSize = 0;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(354, 531);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(150, 35);
            this.btOK.TabIndex = 25;
            this.btOK.Text = "Lưu";
            this.btOK.TextColor = System.Drawing.Color.White;
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.txtDiemTichLuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiemTichLuy.Enabled = false;
            this.txtDiemTichLuy.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTichLuy.Location = new System.Drawing.Point(503, 439);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(415, 27);
            this.txtDiemTichLuy.TabIndex = 24;
            this.txtDiemTichLuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiemTichLuy.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDiemTichLuy.WaterMarkText = "";
            // 
            // txtBirthday
            // 
            this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirthday.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(503, 372);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(415, 27);
            this.txtBirthday.TabIndex = 23;
            this.txtBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBirthday.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtBirthday.WaterMarkText = "";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(503, 304);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(415, 27);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPhone.WaterMarkText = "";
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMND.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(503, 236);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(415, 27);
            this.txtCMND.TabIndex = 21;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCMND.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtCMND.WaterMarkText = "";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(503, 167);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(415, 27);
            this.txtFullName.TabIndex = 20;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtFullName.WaterMarkText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(183, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Điểm tích lũy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(183, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label16.Location = new System.Drawing.Point(183, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 30);
            this.label16.TabIndex = 12;
            this.label16.Text = "Số điện thoại:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label17.Location = new System.Drawing.Point(183, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 30);
            this.label17.TabIndex = 11;
            this.label17.Text = "Căn cước công dân:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label18.Location = new System.Drawing.Point(183, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 30);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tên khách hàng:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label19.Location = new System.Drawing.Point(355, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(374, 37);
            this.label19.TabIndex = 9;
            this.label19.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountPage";
            this.Text = "FormInfor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIMG)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomPanel customPanel2;
        private CustomButton btCancel;
        private CustomButton btOK;
        private CustomTextBox txtDiemTichLuy;
        private CustomTextBox txtBirthday;
        private CustomTextBox txtPhone;
        private CustomTextBox txtCMND;
        private CustomTextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Edit;
        private CustomPictureBox AccountIMG;
        private CustomButton addBut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUserName;
    }
}