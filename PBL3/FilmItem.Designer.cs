namespace PBL3
{
    partial class FilmItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Corbel", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(40)))));
            this.lb1.Location = new System.Drawing.Point(68, 346);
            this.lb1.Name = "lb1";
            this.lb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb1.Size = new System.Drawing.Size(300, 70);
            this.lb1.TabIndex = 11;
            this.lb1.Text = "NAME FILM";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Corbel", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.DimGray;
            this.lb2.Location = new System.Drawing.Point(89, 413);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(255, 46);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Thể loại";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PBL3.Properties.Resources.film1;
            this.pictureBox.Location = new System.Drawing.Point(89, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 317);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // FilmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "FilmItem";
            this.Size = new System.Drawing.Size(435, 485);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}
