using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.VIEWS.AdminForm;
using PBL3.VIEWS.Login;

namespace PBL3.VIEWS.Admin
{
    public partial class AdminPage : Form
    {
        private USER loginAccount;
        public AdminPage()
        {
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            InitializeComponent();
            OpenChildForm(new FilmPage());
            AccName.Text = loginAccount.HoTen.ToString();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FilmPage());
        }

        private void btSC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SchedulePage());
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticPage());
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Management_BookingTicket_BLL.Instance.currentFilm = null;
            this.Close();
        }
    }
}
