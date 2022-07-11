using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.VIEWS.Login
{
    public partial class ResetPassPage : Form
    {
        bool hidePass = true;
        USER acc = null;

        //Constructor
        public ResetPassPage()
        {
            InitializeComponent();
        }

        //Close form
        public void CloseForm()
        {
            this.Close();
        }

        //Check if acc exist
        private bool CheckExistAccount()
        {
            string input = txtInput.Text;
            acc = Management_BookingTicket_BLL.Instance.FindAccount(input);
            if (acc == null)
            {
                existError.Visible = true;
                txtInput.BorderColor = Color.Red;
                return false;
            }                   
            return true;
        }

        //Set new pasword
        private void SetNewPass (USER acc)
        {
            string newPass = txtNewPass.Text;
            string reEnterPass = txtReNewPass.Text;
            if (newPass.Length >= 6 && newPass == reEnterPass)
            {
                Management_BookingTicket_BLL.Instance.UpdatePassword(acc.UserNames, newPass);
                MessageBox.Show("Đổi mật khẩu thành công");
                CloseForm();
            }
            else
            {
                txtNewPass.BorderColor = Color.Red;
                txtReNewPass.BorderColor = Color.Red;
            }
        }

        //hide-unhide password
        private void butHidePass_Click(object sender, EventArgs e)
        {
            hidePass = !hidePass;
            if (hidePass == false)
            {
                butHidePass.Image = Properties.Resources.eye_outline;
                txtNewPass.PasswordChar = false;
                txtReNewPass.PasswordChar = false;
            }
            else
            {
                butHidePass.Image = Properties.Resources.eye_off_outline;
                txtNewPass.PasswordChar = true;
                txtReNewPass.PasswordChar = true;
            }
        }

        //Open form set new password
        private void butNext_Click(object sender, EventArgs e)
        {
            if (CheckExistAccount()) 
                pnSetPass.Visible = true;
        }

        //Close and Return sign in form
        private void butCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        //Set new pass for account
        private void butConfirm_Click(object sender, EventArgs e)
        {
            SetNewPass(acc);
        }

        //Back to choice another account
        private void butBack_Click(object sender, EventArgs e)
        {
            pnSetPass.Visible = false;
            acc = null;
            txtInput.Text = "";
        }

        //reset border color when text change
        private void txtInput__TextChanged(object sender, EventArgs e)
        {
            txtInput.BorderColor = Color.White;
            existError.Visible = false;
        }
        private void txtNewPass__TextChanged(object sender, EventArgs e)
        {
            txtNewPass.BorderColor = Color.White;
        }
        private void txtReNewPass__TextChanged(object sender, EventArgs e)
        {
            txtReNewPass.BorderColor = Color.White;
        }
        
    }
}
