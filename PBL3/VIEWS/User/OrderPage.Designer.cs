namespace PBL3.VIEWS.User
{
    partial class OrderPage
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
            this.cbbGenre = new System.Windows.Forms.ComboBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.cbbDate = new System.Windows.Forms.ComboBox();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btBack = new PBL3.CustomButton();
            this.btOrder = new PBL3.CustomButton();
            this.customPanel1 = new PBL3.CustomPanel();
            this.pnSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lb = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbGenre
            // 
            this.cbbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(207)))), ((int)(((byte)(181)))));
            this.cbbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.ForeColor = System.Drawing.Color.Gray;
            this.cbbGenre.FormattingEnabled = true;
            this.cbbGenre.Location = new System.Drawing.Point(62, 69);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(368, 28);
            this.cbbGenre.TabIndex = 20;
            this.cbbGenre.SelectedIndexChanged += new System.EventHandler(this.ccbGenre_SelectedIndexChanged);
            // 
            // cbbName
            // 
            this.cbbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(207)))), ((int)(((byte)(181)))));
            this.cbbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbName.ForeColor = System.Drawing.Color.Gray;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(62, 151);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(368, 28);
            this.cbbName.TabIndex = 21;
            this.cbbName.SelectedIndexChanged += new System.EventHandler(this.ccbName_SelectedIndexChanged);
            // 
            // cbbDate
            // 
            this.cbbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(207)))), ((int)(((byte)(181)))));
            this.cbbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDate.ForeColor = System.Drawing.Color.Gray;
            this.cbbDate.FormattingEnabled = true;
            this.cbbDate.Location = new System.Drawing.Point(62, 235);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.Size = new System.Drawing.Size(368, 28);
            this.cbbDate.TabIndex = 22;
            this.cbbDate.SelectedIndexChanged += new System.EventHandler(this.ccbDate_SelectedIndexChanged);
            // 
            // cbbTime
            // 
            this.cbbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(207)))), ((int)(((byte)(181)))));
            this.cbbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTime.ForeColor = System.Drawing.Color.Gray;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(62, 321);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(368, 28);
            this.cbbTime.TabIndex = 23;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.ccbTime_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(58, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giờ chiếu";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.04478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(59, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 46);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.04478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(59, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 46);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng tiền:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 12.89552F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lbAmount.Location = new System.Drawing.Point(240, 405);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(145, 46);
            this.lbAmount.TabIndex = 29;
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 12.89552F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrice.Location = new System.Drawing.Point(228, 451);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(172, 46);
            this.lbPrice.TabIndex = 30;
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.BackgroundColor = System.Drawing.Color.White;
            this.btBack.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btBack.BorderRadius = 10;
            this.btBack.BorderSize = 1;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.DimGray;
            this.btBack.Location = new System.Drawing.Point(264, 531);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(114, 35);
            this.btBack.TabIndex = 32;
            this.btBack.Text = "Quay lại";
            this.btBack.TextColor = System.Drawing.Color.DimGray;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.DimGray;
            this.btOrder.BackgroundColor = System.Drawing.Color.DimGray;
            this.btOrder.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btOrder.BorderRadius = 10;
            this.btOrder.BorderSize = 0;
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.White;
            this.btOrder.Location = new System.Drawing.Point(117, 531);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(114, 35);
            this.btOrder.TabIndex = 31;
            this.btOrder.Text = "Đặt vé";
            this.btOrder.TextColor = System.Drawing.Color.White;
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.Controls.Add(this.pnSeat);
            this.customPanel1.Controls.Add(this.lb);
            this.customPanel1.Edge = 20;
            this.customPanel1.Location = new System.Drawing.Point(517, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1088, 631);
            this.customPanel1.TabIndex = 9;
            // 
            // pnSeat
            // 
            this.pnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnSeat.Location = new System.Drawing.Point(91, 93);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(911, 507);
            this.pnSeat.TabIndex = 103;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Corbel", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.lb.Location = new System.Drawing.Point(447, 29);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(203, 46);
            this.lb.TabIndex = 9;
            this.lb.Text = "SCREEN";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1617, 631);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTime);
            this.Controls.Add(this.cbbDate);
            this.Controls.Add(this.cbbName);
            this.Controls.Add(this.cbbGenre);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderPage";
            this.Text = "OderPage";
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ComboBox cbbGenre;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.ComboBox cbbDate;
        private System.Windows.Forms.ComboBox cbbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel pnSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPrice;
        private CustomButton btOrder;
        private CustomButton btBack;
    }
}