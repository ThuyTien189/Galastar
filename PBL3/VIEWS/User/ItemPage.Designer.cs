namespace PBL3.VIEWS.User
{
    partial class ItemPage
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
            this.pn = new System.Windows.Forms.Panel();
            this.pnDetail = new PBL3.CustomPanel();
            this.Recap = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Actor = new System.Windows.Forms.Label();
            this.Direct = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.FilmName = new System.Windows.Forms.Label();
            this.butBack = new PBL3.CustomButton();
            this.butOrder = new PBL3.CustomButton();
            this.IMG = new System.Windows.Forms.PictureBox();
            this.pnListFilm = new PBL3.CustomPanel();
            this.ShowDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbGenre = new System.Windows.Forms.ComboBox();
            this.pnList = new System.Windows.Forms.FlowLayoutPanel();
            this.pn.SuspendLayout();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).BeginInit();
            this.pnListFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.Controls.Add(this.pnDetail);
            this.pn.Controls.Add(this.pnListFilm);
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1617, 631);
            this.pn.TabIndex = 22;
            // 
            // pnDetail
            // 
            this.pnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnDetail.BorderColor = System.Drawing.Color.White;
            this.pnDetail.Controls.Add(this.Recap);
            this.pnDetail.Controls.Add(this.Time);
            this.pnDetail.Controls.Add(this.Actor);
            this.pnDetail.Controls.Add(this.Direct);
            this.pnDetail.Controls.Add(this.Type);
            this.pnDetail.Controls.Add(this.FilmName);
            this.pnDetail.Controls.Add(this.butBack);
            this.pnDetail.Controls.Add(this.butOrder);
            this.pnDetail.Controls.Add(this.IMG);
            this.pnDetail.Edge = 20;
            this.pnDetail.Location = new System.Drawing.Point(11, 0);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(1594, 631);
            this.pnDetail.TabIndex = 2;
            this.pnDetail.Visible = false;
            // 
            // Recap
            // 
            this.Recap.BackColor = System.Drawing.Color.Transparent;
            this.Recap.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recap.ForeColor = System.Drawing.Color.Black;
            this.Recap.Location = new System.Drawing.Point(598, 339);
            this.Recap.Name = "Recap";
            this.Recap.Size = new System.Drawing.Size(796, 123);
            this.Recap.TabIndex = 20;
            this.Recap.Text = "Tóm tắt:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Black;
            this.Time.Location = new System.Drawing.Point(598, 287);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(106, 25);
            this.Time.TabIndex = 19;
            this.Time.Text = "Thời lượng:";
            // 
            // Actor
            // 
            this.Actor.AutoSize = true;
            this.Actor.BackColor = System.Drawing.Color.Transparent;
            this.Actor.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actor.ForeColor = System.Drawing.Color.Black;
            this.Actor.Location = new System.Drawing.Point(598, 235);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(97, 25);
            this.Actor.TabIndex = 18;
            this.Actor.Text = "Diễn viên:";
            // 
            // Direct
            // 
            this.Direct.AutoSize = true;
            this.Direct.BackColor = System.Drawing.Color.Transparent;
            this.Direct.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direct.ForeColor = System.Drawing.Color.Black;
            this.Direct.Location = new System.Drawing.Point(598, 186);
            this.Direct.Name = "Direct";
            this.Direct.Size = new System.Drawing.Size(95, 25);
            this.Direct.TabIndex = 17;
            this.Direct.Text = "Đạo diễn:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.BackColor = System.Drawing.Color.Transparent;
            this.Type.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.Color.Black;
            this.Type.Location = new System.Drawing.Point(598, 138);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(85, 25);
            this.Type.TabIndex = 16;
            this.Type.Text = "Thể loại:";
            // 
            // FilmName
            // 
            this.FilmName.AutoSize = true;
            this.FilmName.BackColor = System.Drawing.Color.Transparent;
            this.FilmName.Font = new System.Drawing.Font("Corbel", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.FilmName.Location = new System.Drawing.Point(649, 69);
            this.FilmName.Name = "FilmName";
            this.FilmName.Size = new System.Drawing.Size(169, 41);
            this.FilmName.TabIndex = 10;
            this.FilmName.Text = "TÊN PHIM";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butBack.BorderRadius = 10;
            this.butBack.BorderSize = 0;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.White;
            this.butBack.Location = new System.Drawing.Point(1104, 540);
            this.butBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(146, 38);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "Quay lại";
            this.butBack.TextColor = System.Drawing.Color.White;
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butOrder
            // 
            this.butOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butOrder.BorderRadius = 10;
            this.butOrder.BorderSize = 0;
            this.butOrder.FlatAppearance.BorderSize = 0;
            this.butOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrder.ForeColor = System.Drawing.Color.White;
            this.butOrder.Location = new System.Drawing.Point(826, 540);
            this.butOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(146, 38);
            this.butOrder.TabIndex = 1;
            this.butOrder.Text = "Đặt vé";
            this.butOrder.TextColor = System.Drawing.Color.White;
            this.butOrder.UseVisualStyleBackColor = false;
            this.butOrder.Click += new System.EventHandler(this.butOrder_Click);
            // 
            // IMG
            // 
            this.IMG.Location = new System.Drawing.Point(113, 82);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(370, 465);
            this.IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG.TabIndex = 0;
            this.IMG.TabStop = false;
            // 
            // pnListFilm
            // 
            this.pnListFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnListFilm.BorderColor = System.Drawing.Color.White;
            this.pnListFilm.Controls.Add(this.ShowDate);
            this.pnListFilm.Controls.Add(this.label3);
            this.pnListFilm.Controls.Add(this.label1);
            this.pnListFilm.Controls.Add(this.cbbGenre);
            this.pnListFilm.Controls.Add(this.pnList);
            this.pnListFilm.Edge = 20;
            this.pnListFilm.Location = new System.Drawing.Point(11, 0);
            this.pnListFilm.Name = "pnListFilm";
            this.pnListFilm.Size = new System.Drawing.Size(1594, 631);
            this.pnListFilm.TabIndex = 21;
            // 
            // ShowDate
            // 
            this.ShowDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            this.ShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDate.Location = new System.Drawing.Point(959, 29);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.Size = new System.Drawing.Size(342, 27);
            this.ShowDate.TabIndex = 0;
            this.ShowDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(821, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày chiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(283, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thể loại:";
            // 
            // cbbGenre
            // 
            this.cbbGenre.BackColor = System.Drawing.Color.White;
            this.cbbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.ForeColor = System.Drawing.Color.Gray;
            this.cbbGenre.FormattingEnabled = true;
            this.cbbGenre.Location = new System.Drawing.Point(393, 26);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(301, 28);
            this.cbbGenre.TabIndex = 22;
            this.cbbGenre.SelectedIndexChanged += new System.EventHandler(this.cbbGenre_SelectedIndexChanged);
            // 
            // pnList
            // 
            this.pnList.AutoScroll = true;
            this.pnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnList.Location = new System.Drawing.Point(125, 74);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(1469, 557);
            this.pnList.TabIndex = 0;
            // 
            // ItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 631);
            this.Controls.Add(this.pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemPage";
            this.Text = "ItemPage";
            this.pn.ResumeLayout(false);
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).EndInit();
            this.pnListFilm.ResumeLayout(false);
            this.pnListFilm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnDetail;
        private System.Windows.Forms.PictureBox IMG;
        private CustomButton butOrder;
        private System.Windows.Forms.Label FilmName;
        private System.Windows.Forms.Label Recap;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Actor;
        private System.Windows.Forms.Label Direct;
        private System.Windows.Forms.Label Type;
        private CustomPanel pnListFilm;
        private System.Windows.Forms.FlowLayoutPanel pnList;
        private CustomButton butBack;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ShowDate;
    }
}