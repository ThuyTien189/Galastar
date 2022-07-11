using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.VIEWS.Login;

namespace PBL3.VIEWS.User
{
    public partial class UserPage : Form
    {
        private USER loginAccount;
        private PHIM currentFilm;
        public UserPage()
        {
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            this.currentFilm = Management_BookingTicket_BLL.Instance.currentFilm;
            InitializeComponent();
            GUI();
            //Set default child page
            if (currentFilm == null)
                OpenChildForm(new ItemPage());
            else
                OpenChildForm(new OrderPage(currentFilm.TenPhim));
        }

        //GUI
        private void GUI()
        {
            //Show IMG
            if (loginAccount != null)
            {
                Console.WriteLine(Path.GetTempPath());
                if (loginAccount.IMG != null && loginAccount.IMG != "")
                    AccountIMG.Image = Image.FromFile(@"..\..\Resources\" + loginAccount.IMG);
                AccName.Text = loginAccount.UserNames.ToUpper();
            } 
        }


        //Set child form
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
            panel3.Controls.Add(ChildForm);
            panel3.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        //Open OderPage
        private void btOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemPage());
            AccountIMG.Visible = true;
            AccName.Visible = true;
            AccName.Text = loginAccount.UserNames.ToUpper();
            if (loginAccount.IMG != null && loginAccount.IMG != "")
                AccountIMG.Image = Image.FromFile(@"..\..\Resources\" + loginAccount.IMG);
            LogOut.Location = new Point(1466, 93);
        }


        //Open HistoryPage
        private void btHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HistoryPage());
            AccountIMG.Visible = true;
            AccName.Visible = true;
            AccName.Text = loginAccount.UserNames.ToUpper();
            if (loginAccount.IMG != null && loginAccount.IMG != "")
                AccountIMG.Image = Image.FromFile(@"..\..\Resources\" + loginAccount.IMG);
            LogOut.Location = new Point(1466, 93);
        }


        //Open AccountPage
        private void btInfor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountPage());
            AccountIMG.Visible = false;
            AccName.Visible = false;
            LogOut.Location = new Point(1550,93);
        }


        //LogOut, back to Sign in Page
        private void LogOut_Click(object sender, EventArgs e)
        {
            Management_BookingTicket_BLL.Instance.currentFilm = null;
            this.Close();
        }
    }
}
