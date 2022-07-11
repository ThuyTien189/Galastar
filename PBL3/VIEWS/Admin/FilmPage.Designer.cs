namespace PBL3.VIEWS.AdminForm
{
    partial class FilmPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnAddEdit = new PBL3.CustomPanel();
            this.btCancel = new PBL3.CustomButton();
            this.btOK = new PBL3.CustomButton();
            this.btAddPic = new PBL3.CustomButton();
            this.FilmIMG = new System.Windows.Forms.PictureBox();
            this.txtND = new System.Windows.Forms.TextBox();
            this.listGenre = new System.Windows.Forms.CheckedListBox();
            this.txtDienVien = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.lbMaPhim = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnPhim = new PBL3.CustomPanel();
            this.btDel = new PBL3.CustomButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btEdit = new PBL3.CustomButton();
            this.btAdd = new PBL3.CustomButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new PBL3.CustomButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmIMG)).BeginInit();
            this.pnPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddEdit
            // 
            this.pnAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnAddEdit.BorderColor = System.Drawing.Color.White;
            this.pnAddEdit.Controls.Add(this.btCancel);
            this.pnAddEdit.Controls.Add(this.btOK);
            this.pnAddEdit.Controls.Add(this.btAddPic);
            this.pnAddEdit.Controls.Add(this.FilmIMG);
            this.pnAddEdit.Controls.Add(this.txtND);
            this.pnAddEdit.Controls.Add(this.listGenre);
            this.pnAddEdit.Controls.Add(this.txtDienVien);
            this.pnAddEdit.Controls.Add(this.txtDaoDien);
            this.pnAddEdit.Controls.Add(this.txtThoiLuong);
            this.pnAddEdit.Controls.Add(this.lbMaPhim);
            this.pnAddEdit.Controls.Add(this.txtTenPhim);
            this.pnAddEdit.Controls.Add(this.label1);
            this.pnAddEdit.Controls.Add(this.txtMaPhim);
            this.pnAddEdit.Controls.Add(this.label2);
            this.pnAddEdit.Controls.Add(this.label6);
            this.pnAddEdit.Controls.Add(this.label7);
            this.pnAddEdit.Controls.Add(this.label3);
            this.pnAddEdit.Controls.Add(this.label4);
            this.pnAddEdit.Edge = 20;
            this.pnAddEdit.Location = new System.Drawing.Point(2, 0);
            this.pnAddEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAddEdit.Name = "pnAddEdit";
            this.pnAddEdit.Size = new System.Drawing.Size(927, 513);
            this.pnAddEdit.TabIndex = 10;
            this.pnAddEdit.Visible = false;
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
            this.btCancel.Location = new System.Drawing.Point(502, 452);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 26);
            this.btCancel.TabIndex = 52;
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
            this.btOK.Location = new System.Drawing.Point(325, 452);
            this.btOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(105, 26);
            this.btOK.TabIndex = 51;
            this.btOK.Text = "Xác nhận";
            this.btOK.TextColor = System.Drawing.Color.White;
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btAddPic
            // 
            this.btAddPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btAddPic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btAddPic.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btAddPic.BorderRadius = 10;
            this.btAddPic.BorderSize = 0;
            this.btAddPic.FlatAppearance.BorderSize = 0;
            this.btAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPic.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddPic.ForeColor = System.Drawing.Color.White;
            this.btAddPic.Location = new System.Drawing.Point(72, 245);
            this.btAddPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddPic.Name = "btAddPic";
            this.btAddPic.Size = new System.Drawing.Size(88, 26);
            this.btAddPic.TabIndex = 50;
            this.btAddPic.Text = "Thêm ảnh";
            this.btAddPic.TextColor = System.Drawing.Color.White;
            this.btAddPic.UseVisualStyleBackColor = false;
            this.btAddPic.Click += new System.EventHandler(this.btAddPic_Click);
            // 
            // FilmIMG
            // 
            this.FilmIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmIMG.Image = global::PBL3.Properties.Resources.DefaultFilm;
            this.FilmIMG.Location = new System.Drawing.Point(50, 64);
            this.FilmIMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilmIMG.Name = "FilmIMG";
            this.FilmIMG.Size = new System.Drawing.Size(133, 173);
            this.FilmIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilmIMG.TabIndex = 49;
            this.FilmIMG.TabStop = false;
            // 
            // txtND
            // 
            this.txtND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtND.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(50, 320);
            this.txtND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtND.Size = new System.Drawing.Size(826, 117);
            this.txtND.TabIndex = 48;
            // 
            // listGenre
            // 
            this.listGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.listGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGenre.CheckOnClick = true;
            this.listGenre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGenre.FormattingEnabled = true;
            this.listGenre.Location = new System.Drawing.Point(323, 163);
            this.listGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listGenre.Name = "listGenre";
            this.listGenre.Size = new System.Drawing.Size(184, 100);
            this.listGenre.TabIndex = 47;
            // 
            // txtDienVien
            // 
            this.txtDienVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtDienVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienVien.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienVien.Location = new System.Drawing.Point(665, 163);
            this.txtDienVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDienVien.Multiline = true;
            this.txtDienVien.Name = "txtDienVien";
            this.txtDienVien.Size = new System.Drawing.Size(211, 137);
            this.txtDienVien.TabIndex = 46;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtDaoDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaoDien.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.Location = new System.Drawing.Point(665, 116);
            this.txtDaoDien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(211, 25);
            this.txtDaoDien.TabIndex = 45;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtThoiLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThoiLuong.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiLuong.Location = new System.Drawing.Point(665, 67);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(211, 25);
            this.txtThoiLuong.TabIndex = 44;
            // 
            // lbMaPhim
            // 
            this.lbMaPhim.AutoSize = true;
            this.lbMaPhim.BackColor = System.Drawing.Color.Transparent;
            this.lbMaPhim.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhim.ForeColor = System.Drawing.Color.Black;
            this.lbMaPhim.Location = new System.Drawing.Point(226, 67);
            this.lbMaPhim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaPhim.Name = "lbMaPhim";
            this.lbMaPhim.Size = new System.Drawing.Size(74, 19);
            this.lbMaPhim.TabIndex = 34;
            this.lbMaPhim.Text = "Mã phim:";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtTenPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(323, 116);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(185, 25);
            this.txtTenPhim.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(226, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên phim:";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtMaPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhim.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(323, 67);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(185, 25);
            this.txtMaPhim.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(226, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thể loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(57, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nội dung:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(550, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Diễn viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(550, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Thời lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(550, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Đạo diễn:";
            // 
            // pnPhim
            // 
            this.pnPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnPhim.BorderColor = System.Drawing.Color.White;
            this.pnPhim.Controls.Add(this.btDel);
            this.pnPhim.Controls.Add(this.dataGridView2);
            this.pnPhim.Controls.Add(this.btEdit);
            this.pnPhim.Controls.Add(this.btAdd);
            this.pnPhim.Controls.Add(this.txtSearch);
            this.pnPhim.Controls.Add(this.btSearch);
            this.pnPhim.Edge = 20;
            this.pnPhim.Location = new System.Drawing.Point(2, 0);
            this.pnPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnPhim.Name = "pnPhim";
            this.pnPhim.Size = new System.Drawing.Size(927, 513);
            this.pnPhim.TabIndex = 9;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btDel.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btDel.BorderRadius = 10;
            this.btDel.BorderSize = 0;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Location = new System.Drawing.Point(578, 427);
            this.btDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(105, 26);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Xóa";
            this.btDel.TextColor = System.Drawing.Color.White;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.dataGridView2.Location = new System.Drawing.Point(50, 113);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(826, 293);
            this.dataGridView2.TabIndex = 1;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btEdit.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btEdit.BorderRadius = 10;
            this.btEdit.BorderSize = 0;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(416, 427);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(105, 26);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Sửa";
            this.btEdit.TextColor = System.Drawing.Color.White;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btAdd.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btAdd.BorderRadius = 10;
            this.btAdd.BorderSize = 0;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(252, 427);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(105, 26);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm";
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(531, 67);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 27);
            this.txtSearch.TabIndex = 14;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSearch.BorderRadius = 10;
            this.btSearch.BorderSize = 0;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(769, 67);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(107, 26);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.TextColor = System.Drawing.Color.White;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.pnAddEdit);
            this.Controls.Add(this.pnPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FilmPage";
            this.Text = "FormPhim";
            this.pnAddEdit.ResumeLayout(false);
            this.pnAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmIMG)).EndInit();
            this.pnPhim.ResumeLayout(false);
            this.pnPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnPhim;
        private CustomButton btDel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CustomButton btEdit;
        private CustomButton btAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private CustomButton btSearch;
        private CustomPanel pnAddEdit;
        private CustomButton btCancel;
        private CustomButton btOK;
        private CustomButton btAddPic;
        private System.Windows.Forms.PictureBox FilmIMG;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.CheckedListBox listGenre;
        private System.Windows.Forms.TextBox txtDienVien;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaPhim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}