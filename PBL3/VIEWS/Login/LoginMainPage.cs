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
using PBL3.VIEWS.Admin;
using PBL3.VIEWS.User;

namespace PBL3.VIEWS.Login
{
    public partial class LoginMainPage : Form
    {
        bool hidePass = true;

        //Constructor
        public LoginMainPage()
        {
            InitializeComponent();
        }

        //Open child form
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
            panelSignIn.Controls.Add(ChildForm);
            panelSignIn.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        //Login
        public void Login()
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (ValidatePass(passWord))
            {
                Management_BookingTicket_BLL.Instance.Login(userName, passWord);
                USER loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
                if (loginAccount != null)
                {

                    if (loginAccount.isAdmin)
                    {
                        this.Hide();
                        AdminPage f = new AdminPage();
                        f.ShowDialog();
                        this.Close();
                      
                    }
                    else
                    {
                        this.Hide();
                        UserPage f = new UserPage();
                        f.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    txtUserName.BorderColor = Color.Red;
                    txtPassWord.BorderColor = Color.Red;
                    loginError.Text = ("Sai tên tài khoản hoặc mật khẩu");
                    loginError.Visible = true;
                }
            }
        }

        //Validate password
        public bool ValidatePass(string passWord)
        {
            if (passWord == null || passWord.Length < 6)
            {
                passError.Text = "Nhập mật khẩu tối thiểu 6 ký tự";
                passError.Visible = true;
                txtPassWord.BorderColor = Color.Red;
                return false;
            }
            return true;
        }


        //Button sign in click
        private void butSignIn_Click(object sender, EventArgs e)
        {
            Login();
        }

        //Hide and show password
        private void butHidePass_Click(object sender, EventArgs e)
        {
            hidePass = !hidePass;
            if (hidePass == false)
            {
                butHidePass.Image = Properties.Resources.eye_outline; 
                txtPassWord.PasswordChar = false;
            }
            else
            {
                butHidePass.Image = Properties.Resources.eye_off_outline;
                txtPassWord.PasswordChar = true;
            }
        }


        //Open sign up page
        private void butSignUp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignUpPage());
        }


        //Open reset pass Page
        private void butForgotPass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResetPassPage());
        }


        //reset border color when text change
        private void txtUserName__TextChanged(object sender, EventArgs e)
        {
            txtUserName.BorderColor = Color.White;
            loginError.Visible = false;
        }
        private void txtPassWord__TextChanged(object sender, EventArgs e)
        {
            txtPassWord.BorderColor = Color.White;
            passError.Visible = false;
            loginError.Visible = false;
        }
    }
}
