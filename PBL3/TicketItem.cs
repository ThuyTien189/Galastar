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
    public partial class TicketItem : UserControl
    {
        //Constructor
        public TicketItem()
        {
            InitializeComponent();
        }
        
        //---
        //Property
        public string Id
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                this.Invalidate();
            }
        }
        public string FilmName
        {
            get { return label2.Text; }
            set
            {
                label2.Text = value;
                this.Invalidate();
            }
        }
        public string OrderDay
        {
            get { return label3.Text; }
            set
            {
                label3.Text = value;
                this.Invalidate();
            }
        }
        public string ShowDay
        {
            get { return label4.Text; }
            set
            {
                label4.Text = value;
                this.Invalidate();
            }
        }
        public string Status
        {
            get { return label5.Text; }
            set
            {
                label5.Text = value;
                this.Invalidate();
            }
        }
        public Color StatusForeColor
        {
            get { return label5.ForeColor; }
            set
            {
                label5.ForeColor = value;
                this.Invalidate();
            }
        }

        //---
        //Event
        private void label1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
