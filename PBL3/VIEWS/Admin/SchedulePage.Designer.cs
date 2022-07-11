namespace PBL3.VIEWS.Admin
{
    partial class SchedulePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnOrder = new PBL3.CustomPanel();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btBack = new PBL3.CustomButton();
            this.btOrder = new PBL3.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lb = new System.Windows.Forms.Label();
            this.pnDetail = new PBL3.CustomPanel();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.btClose = new PBL3.CustomButton();
            this.btOrderPage = new PBL3.CustomButton();
            this.pnAddEdit = new PBL3.CustomPanel();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.cbbPhim_add_edit = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.txtMaSC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaSC = new System.Windows.Forms.Label();
            this.btCancel = new PBL3.CustomButton();
            this.btOK = new PBL3.CustomButton();
            this.pnSchedule = new PBL3.CustomPanel();
            this.btDetail = new PBL3.CustomButton();
            this.btSearch = new PBL3.CustomButton();
            this.cbbGioChieu = new System.Windows.Forms.ComboBox();
            this.cbbNgayChieu = new System.Windows.Forms.ComboBox();
            this.cbbPhim = new System.Windows.Forms.ComboBox();
            this.btDel = new PBL3.CustomButton();
            this.dgvSche = new System.Windows.Forms.DataGridView();
            this.btEdit = new PBL3.CustomButton();
            this.btAdd = new PBL3.CustomButton();
            this.pnOrder.SuspendLayout();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            this.pnAddEdit.SuspendLayout();
            this.pnSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOrder
            // 
            this.pnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnOrder.BorderColor = System.Drawing.Color.White;
            this.pnOrder.Controls.Add(this.txtUserPhone);
            this.pnOrder.Controls.Add(this.label7);
            this.pnOrder.Controls.Add(this.lbPrice);
            this.pnOrder.Controls.Add(this.lbAmount);
            this.pnOrder.Controls.Add(this.btBack);
            this.pnOrder.Controls.Add(this.btOrder);
            this.pnOrder.Controls.Add(this.label6);
            this.pnOrder.Controls.Add(this.label5);
            this.pnOrder.Controls.Add(this.pnSeat);
            this.pnOrder.Controls.Add(this.lb);
            this.pnOrder.Edge = 20;
            this.pnOrder.Location = new System.Drawing.Point(2, 0);
            this.pnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(927, 513);
            this.pnOrder.TabIndex = 12;
            this.pnOrder.Visible = false;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.Location = new System.Drawing.Point(25, 162);
            this.txtUserPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(164, 26);
            this.txtUserPhone.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(20, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 37);
            this.label7.TabIndex = 112;
            this.label7.Text = "Số điện thoại:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrice.Location = new System.Drawing.Point(100, 246);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(99, 37);
            this.lbPrice.TabIndex = 111;
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lbAmount.Location = new System.Drawing.Point(109, 202);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(79, 37);
            this.lbAmount.TabIndex = 110;
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btBack.Location = new System.Drawing.Point(62, 348);
            this.btBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(86, 28);
            this.btBack.TabIndex = 109;
            this.btBack.Text = "Quay lại";
            this.btBack.TextColor = System.Drawing.Color.DimGray;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
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
            this.btOrder.Location = new System.Drawing.Point(62, 306);
            this.btOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(86, 28);
            this.btOrder.TabIndex = 108;
            this.btOrder.Text = "Đặt vé";
            this.btOrder.TextColor = System.Drawing.Color.White;
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 37);
            this.label6.TabIndex = 107;
            this.label6.Text = "Tổng tiền:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 106;
            this.label5.Text = "Số lượng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSeat
            // 
            this.pnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnSeat.Location = new System.Drawing.Point(212, 76);
            this.pnSeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(683, 412);
            this.pnSeat.TabIndex = 105;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Corbel", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.lb.Location = new System.Drawing.Point(478, 24);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(152, 37);
            this.lb.TabIndex = 104;
            this.lb.Text = "SCREEN";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDetail
            // 
            this.pnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnDetail.BorderColor = System.Drawing.Color.White;
            this.pnDetail.Controls.Add(this.dgvSeat);
            this.pnDetail.Controls.Add(this.btClose);
            this.pnDetail.Controls.Add(this.btOrderPage);
            this.pnDetail.Edge = 20;
            this.pnDetail.Location = new System.Drawing.Point(2, 0);
            this.pnDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(927, 513);
            this.pnDetail.TabIndex = 11;
            this.pnDetail.Visible = false;
            // 
            // dgvSeat
            // 
            this.dgvSeat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.dgvSeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeat.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSeat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.dgvSeat.Location = new System.Drawing.Point(51, 56);
            this.dgvSeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeat.RowHeadersWidth = 51;
            this.dgvSeat.RowTemplate.Height = 24;
            this.dgvSeat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSeat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeat.Size = new System.Drawing.Size(826, 350);
            this.dgvSeat.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btClose.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btClose.BorderRadius = 10;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(537, 427);
            this.btClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(105, 26);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Đóng";
            this.btClose.TextColor = System.Drawing.Color.White;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOrderPage
            // 
            this.btOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btOrderPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btOrderPage.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btOrderPage.BorderRadius = 10;
            this.btOrderPage.BorderSize = 0;
            this.btOrderPage.FlatAppearance.BorderSize = 0;
            this.btOrderPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderPage.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPage.ForeColor = System.Drawing.Color.White;
            this.btOrderPage.Location = new System.Drawing.Point(316, 427);
            this.btOrderPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOrderPage.Name = "btOrderPage";
            this.btOrderPage.Size = new System.Drawing.Size(105, 26);
            this.btOrderPage.TabIndex = 1;
            this.btOrderPage.Text = "Đặt vé";
            this.btOrderPage.TextColor = System.Drawing.Color.White;
            this.btOrderPage.UseVisualStyleBackColor = false;
            this.btOrderPage.Click += new System.EventHandler(this.btOrderPage_Click);
            // 
            // pnAddEdit
            // 
            this.pnAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnAddEdit.BorderColor = System.Drawing.Color.White;
            this.pnAddEdit.Controls.Add(this.cbbPhong);
            this.pnAddEdit.Controls.Add(this.cbbPhim_add_edit);
            this.pnAddEdit.Controls.Add(this.dateTimePicker1);
            this.pnAddEdit.Controls.Add(this.txtGioChieu);
            this.pnAddEdit.Controls.Add(this.txtMaSC);
            this.pnAddEdit.Controls.Add(this.label4);
            this.pnAddEdit.Controls.Add(this.label3);
            this.pnAddEdit.Controls.Add(this.label2);
            this.pnAddEdit.Controls.Add(this.label1);
            this.pnAddEdit.Controls.Add(this.labelMaSC);
            this.pnAddEdit.Controls.Add(this.btCancel);
            this.pnAddEdit.Controls.Add(this.btOK);
            this.pnAddEdit.Edge = 20;
            this.pnAddEdit.Location = new System.Drawing.Point(2, 0);
            this.pnAddEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAddEdit.Name = "pnAddEdit";
            this.pnAddEdit.Size = new System.Drawing.Size(927, 513);
            this.pnAddEdit.TabIndex = 10;
            this.pnAddEdit.Visible = false;
            // 
            // cbbPhong
            // 
            this.cbbPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.cbbPhong.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(379, 228);
            this.cbbPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(304, 26);
            this.cbbPhong.TabIndex = 31;
            // 
            // cbbPhim_add_edit
            // 
            this.cbbPhim_add_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.cbbPhim_add_edit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhim_add_edit.FormattingEnabled = true;
            this.cbbPhim_add_edit.Location = new System.Drawing.Point(379, 150);
            this.cbbPhim_add_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhim_add_edit.Name = "cbbPhim_add_edit";
            this.cbbPhim_add_edit.Size = new System.Drawing.Size(304, 26);
            this.cbbPhim_add_edit.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 289);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 23);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtGioChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioChieu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioChieu.Location = new System.Drawing.Point(379, 352);
            this.txtGioChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.Size = new System.Drawing.Size(304, 25);
            this.txtGioChieu.TabIndex = 28;
            // 
            // txtMaSC
            // 
            this.txtMaSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.txtMaSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSC.Location = new System.Drawing.Point(379, 84);
            this.txtMaSC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.Size = new System.Drawing.Size(304, 25);
            this.txtMaSC.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(259, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giờ chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(259, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày chiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(259, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(259, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên phim:";
            // 
            // labelMaSC
            // 
            this.labelMaSC.AutoSize = true;
            this.labelMaSC.BackColor = System.Drawing.Color.Transparent;
            this.labelMaSC.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSC.ForeColor = System.Drawing.Color.Black;
            this.labelMaSC.Location = new System.Drawing.Point(254, 84);
            this.labelMaSC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaSC.Name = "labelMaSC";
            this.labelMaSC.Size = new System.Drawing.Size(108, 19);
            this.labelMaSC.TabIndex = 16;
            this.labelMaSC.Text = "Mã suất chiếu:";
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
            this.btCancel.Location = new System.Drawing.Point(537, 427);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 26);
            this.btCancel.TabIndex = 1;
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
            this.btOK.Location = new System.Drawing.Point(316, 427);
            this.btOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(105, 26);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "Xác nhận";
            this.btOK.TextColor = System.Drawing.Color.White;
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // pnSchedule
            // 
            this.pnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.pnSchedule.BorderColor = System.Drawing.Color.White;
            this.pnSchedule.Controls.Add(this.btDetail);
            this.pnSchedule.Controls.Add(this.btSearch);
            this.pnSchedule.Controls.Add(this.cbbGioChieu);
            this.pnSchedule.Controls.Add(this.cbbNgayChieu);
            this.pnSchedule.Controls.Add(this.cbbPhim);
            this.pnSchedule.Controls.Add(this.btDel);
            this.pnSchedule.Controls.Add(this.dgvSche);
            this.pnSchedule.Controls.Add(this.btEdit);
            this.pnSchedule.Controls.Add(this.btAdd);
            this.pnSchedule.Edge = 20;
            this.pnSchedule.Location = new System.Drawing.Point(2, 0);
            this.pnSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnSchedule.Name = "pnSchedule";
            this.pnSchedule.Size = new System.Drawing.Size(927, 513);
            this.pnSchedule.TabIndex = 9;
            // 
            // btDetail
            // 
            this.btDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btDetail.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btDetail.BorderRadius = 10;
            this.btDetail.BorderSize = 0;
            this.btDetail.FlatAppearance.BorderSize = 0;
            this.btDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetail.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetail.ForeColor = System.Drawing.Color.White;
            this.btDetail.Location = new System.Drawing.Point(663, 427);
            this.btDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(105, 26);
            this.btDetail.TabIndex = 25;
            this.btDetail.Text = "Chi tiết";
            this.btDetail.TextColor = System.Drawing.Color.White;
            this.btDetail.UseVisualStyleBackColor = false;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
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
            this.btSearch.Size = new System.Drawing.Size(105, 26);
            this.btSearch.TabIndex = 24;
            this.btSearch.Text = "Tìm Kiếm";
            this.btSearch.TextColor = System.Drawing.Color.White;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbbGioChieu
            // 
            this.cbbGioChieu.BackColor = System.Drawing.SystemColors.Window;
            this.cbbGioChieu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioChieu.FormattingEnabled = true;
            this.cbbGioChieu.Location = new System.Drawing.Point(607, 69);
            this.cbbGioChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbGioChieu.Name = "cbbGioChieu";
            this.cbbGioChieu.Size = new System.Drawing.Size(144, 23);
            this.cbbGioChieu.TabIndex = 23;
            this.cbbGioChieu.Text = "Chọn giờ chiếu";
            // 
            // cbbNgayChieu
            // 
            this.cbbNgayChieu.BackColor = System.Drawing.SystemColors.Window;
            this.cbbNgayChieu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgayChieu.FormattingEnabled = true;
            this.cbbNgayChieu.Location = new System.Drawing.Point(430, 69);
            this.cbbNgayChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNgayChieu.Name = "cbbNgayChieu";
            this.cbbNgayChieu.Size = new System.Drawing.Size(156, 23);
            this.cbbNgayChieu.TabIndex = 22;
            this.cbbNgayChieu.Text = "Chọn ngày chiếu";
            this.cbbNgayChieu.SelectedIndexChanged += new System.EventHandler(this.cbbNgayChieu_SelectedIndexChanged);
            // 
            // cbbPhim
            // 
            this.cbbPhim.BackColor = System.Drawing.SystemColors.Window;
            this.cbbPhim.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhim.FormattingEnabled = true;
            this.cbbPhim.Location = new System.Drawing.Point(230, 69);
            this.cbbPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhim.Name = "cbbPhim";
            this.cbbPhim.Size = new System.Drawing.Size(180, 23);
            this.cbbPhim.TabIndex = 21;
            this.cbbPhim.Text = "Chọn phim";
            this.cbbPhim.SelectedIndexChanged += new System.EventHandler(this.cbbPhim_SelectedIndexChanged);
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
            this.btDel.Location = new System.Drawing.Point(500, 427);
            this.btDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(105, 26);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Xóa";
            this.btDel.TextColor = System.Drawing.Color.White;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgvSche
            // 
            this.dgvSche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.dgvSche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSche.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSche.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.dgvSche.Location = new System.Drawing.Point(50, 113);
            this.dgvSche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSche.Name = "dgvSche";
            this.dgvSche.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(180)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSche.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSche.RowHeadersWidth = 51;
            this.dgvSche.RowTemplate.Height = 24;
            this.dgvSche.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSche.Size = new System.Drawing.Size(826, 293);
            this.dgvSche.TabIndex = 1;
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
            this.btEdit.Location = new System.Drawing.Point(339, 427);
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
            this.btAdd.Location = new System.Drawing.Point(175, 427);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(105, 26);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm";
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // SchedulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.pnOrder);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.pnAddEdit);
            this.Controls.Add(this.pnSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SchedulePage";
            this.Text = "FormSC";
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            this.pnDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            this.pnAddEdit.ResumeLayout(false);
            this.pnAddEdit.PerformLayout();
            this.pnSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnSchedule;
        private CustomButton btSearch;
        private System.Windows.Forms.ComboBox cbbGioChieu;
        private System.Windows.Forms.ComboBox cbbNgayChieu;
        private System.Windows.Forms.ComboBox cbbPhim;
        private CustomButton btDel;
        private System.Windows.Forms.DataGridView dgvSche;
        private CustomButton btEdit;
        private CustomButton btAdd;
        private CustomPanel pnAddEdit;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.ComboBox cbbPhim_add_edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.TextBox txtMaSC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaSC;
        private CustomButton btCancel;
        private CustomButton btOK;
        private CustomButton btDetail;
        private CustomPanel pnDetail;
        private System.Windows.Forms.DataGridView dgvSeat;
        private CustomButton btClose;
        private CustomPanel pnOrder;
        private CustomButton btOrderPage;
        private System.Windows.Forms.FlowLayoutPanel pnSeat;
        private System.Windows.Forms.Label lb;
        private CustomButton btBack;
        private CustomButton btOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAmount;
    }
}