namespace PBL3.VIEWS.Admin
{
    partial class StatisticPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPhim = new PBL3.CustomPanel();
            this.Chart_Statistical = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbPhim = new System.Windows.Forms.ComboBox();
            this.dtpFromDay = new System.Windows.Forms.DateTimePicker();
            this.butStatistical = new PBL3.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDay = new System.Windows.Forms.DateTimePicker();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.pnPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Statistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPhim
            // 
            this.pnPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(78)))));
            this.pnPhim.BorderColor = System.Drawing.Color.White;
            this.pnPhim.Controls.Add(this.Chart_Statistical);
            this.pnPhim.Controls.Add(this.label5);
            this.pnPhim.Controls.Add(this.cbbPhim);
            this.pnPhim.Controls.Add(this.dtpFromDay);
            this.pnPhim.Controls.Add(this.butStatistical);
            this.pnPhim.Controls.Add(this.label4);
            this.pnPhim.Controls.Add(this.txtTongDT);
            this.pnPhim.Controls.Add(this.label3);
            this.pnPhim.Controls.Add(this.label2);
            this.pnPhim.Controls.Add(this.label1);
            this.pnPhim.Controls.Add(this.dtpToDay);
            this.pnPhim.Controls.Add(this.dgv_thongke);
            this.pnPhim.Edge = 20;
            this.pnPhim.Location = new System.Drawing.Point(3, 0);
            this.pnPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPhim.Name = "pnPhim";
            this.pnPhim.Size = new System.Drawing.Size(1236, 631);
            this.pnPhim.TabIndex = 10;
            // 
            // Chart_Statistical
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Statistical.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Statistical.Legends.Add(legend1);
            this.Chart_Statistical.Location = new System.Drawing.Point(67, 244);
            this.Chart_Statistical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chart_Statistical.Name = "Chart_Statistical";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.Chart_Statistical.Series.Add(series1);
            this.Chart_Statistical.Size = new System.Drawing.Size(1101, 213);
            this.Chart_Statistical.TabIndex = 14;
            this.Chart_Statistical.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Chart_Statistical";
            title1.Text = "Biểu Đồ Thống Kê Doanh Thu";
            this.Chart_Statistical.Titles.Add(title1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phim:";
            // 
            // cbbPhim
            // 
            this.cbbPhim.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhim.FormattingEnabled = true;
            this.cbbPhim.Location = new System.Drawing.Point(684, 526);
            this.cbbPhim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbPhim.Name = "cbbPhim";
            this.cbbPhim.Size = new System.Drawing.Size(237, 27);
            this.cbbPhim.TabIndex = 12;
            // 
            // dtpFromDay
            // 
            this.dtpFromDay.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDay.Location = new System.Drawing.Point(280, 482);
            this.dtpFromDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFromDay.Name = "dtpFromDay";
            this.dtpFromDay.Size = new System.Drawing.Size(209, 27);
            this.dtpFromDay.TabIndex = 11;
            // 
            // butStatistical
            // 
            this.butStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.butStatistical.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.butStatistical.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butStatistical.BorderRadius = 5;
            this.butStatistical.BorderSize = 0;
            this.butStatistical.FlatAppearance.BorderSize = 0;
            this.butStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStatistical.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStatistical.ForeColor = System.Drawing.Color.White;
            this.butStatistical.Location = new System.Drawing.Point(945, 526);
            this.butStatistical.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.butStatistical.Name = "butStatistical";
            this.butStatistical.Size = new System.Drawing.Size(140, 32);
            this.butStatistical.TabIndex = 10;
            this.butStatistical.Text = "Thống kê";
            this.butStatistical.TextColor = System.Drawing.Color.White;
            this.butStatistical.UseVisualStyleBackColor = false;
            this.butStatistical.Click += new System.EventHandler(this.butStatistical_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1069, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "VNĐ";
            // 
            // txtTongDT
            // 
            this.txtTongDT.Enabled = false;
            this.txtTongDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDT.Location = new System.Drawing.Point(844, 475);
            this.txtTongDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(216, 24);
            this.txtTongDT.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 478);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày:";
            // 
            // dtpToDay
            // 
            this.dtpToDay.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDay.Location = new System.Drawing.Point(280, 519);
            this.dtpToDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.Size = new System.Drawing.Size(209, 27);
            this.dtpToDay.TabIndex = 4;
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thongke.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_thongke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(163)))));
            this.dgv_thongke.Location = new System.Drawing.Point(67, 85);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.ReadOnly = true;
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongke.Size = new System.Drawing.Size(1101, 142);
            this.dgv_thongke.TabIndex = 1;
            // 
            // StatisticPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.pnPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticPage";
            this.Text = "FormTK";
            this.pnPhim.ResumeLayout(false);
            this.pnPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Statistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnPhim;
        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.DateTimePicker dtpToDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDay;
        private CustomButton butStatistical;
        private System.Windows.Forms.ComboBox cbbPhim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Statistical;
    }
}