using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FilmItem : UserControl
    {
        //Constructor
        public FilmItem()
        {
            InitializeComponent();
        }

        //---
        //Property
        public string FilmName
        {
            get { return lb1.Text; }
            set
            {
                lb1.Text = value;
                this.Invalidate();
            }
        }
        public string FilmType
        {
            get { return lb2.Text; }
            set
            {
                lb2.Text = value;
                this.Invalidate();
            }
        }
        public string FilmDirect { get; set; }
        public string FilmActor { get; set; }
        public string FilmTime { get; set; }
        public string FilmRecap { get; set; }
        public Image FilmIMG
        {
            get { return pictureBox.Image; }
            set
            {
                pictureBox.Image = value;
                this.Invalidate();
            }
        }

        //---
        //Event
        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void lb1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void lb2_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
