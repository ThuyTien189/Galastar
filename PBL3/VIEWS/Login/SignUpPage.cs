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
using PBL3.DAL;

namespace PBL3.VIEWS.Login
{
    public partial class SignUpPage : Form
    {
        bool hidePass = true;

        //Constructor
        public SignUpPage()
        {
            InitializeComponent();
        }
        
        //Close form
        public void CloseForm()
        {
            this.Close();
        }

        //Validate 
        private new bool Validate()
        {
            bool check = true;
            USER acc = Management_BookingTicket_BLL.Instance.GetAccByUserName(txtUserName.Text);

            if (txtHoTen.Text == "")
            {
                txtHoTen.BorderColor = Color.Red;
                check = false;
            }   
            
            if (txtUserName.Text == "")
            {
                txtUserName.BorderColor = Color.Red;
                check = false;
            }
            else 
            {
                if (acc != null)
                {
                    usernameError.Text = "Tên tài khoản đã tồn tại";
                    usernameError.Visible = true;
                    txtUserName.BorderColor = Color.Red;
                    check = false;
                }    
            }

            if (txtCMND.Text == "")
            {
                txtCMND.BorderColor = Color.Red;
                check = false;
            }

            if (txtSDT.Text == "")
            {
                txtSDT.BorderColor = Color.Red;
                check = false;
            }

            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.BorderColor = Color.Red;
                check = false;
            }

            if (txtPassWord.Text.Length < 6)
            {
                passError.Text = "Nhập mật khẩu tối thiểu 6 ký tự";
                passError.Visible = true;
                txtPassWord.BorderColor = Color.Red;
                check = false;
            }

            return check;
        }
        
        //Add new account
        private void SignUp()
        {
            string passWord = txtPassWord.Text;
            if (Validate())
            {
                int ma = Convert.ToInt32(Management_BookingTicket_BLL.Instance.GetMaxUserId());
                ma++;
                USER u = new USER
                {
                    MaUser = Convert.ToString(ma),
                    UserNames = txtUserName.Text,
                    PassWords = txtPassWord.Text,
                    isAdmin = false, //chỉ có khách hàng đc đki
                    HoTen = txtHoTen.Text,
                    CMND = txtCMND.Text,
                    SDT = txtSDT.Text,
                    NgaySinh = Convert.ToDateTime(txtNgaySinh.Text),
                    DiemTichLuy = 0
                };
                Management_BookingTicket_BLL.Instance.AddUser(u);
                MessageBox.Show("Tạo tài khoản thành công");
                CloseForm();
            }
        }

        //Hide-unhide password
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

        //Sign up
        private void butSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
        
        //Close form sign up, back to sign in form
        private void butSignIn_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        //reset border color when text change
        private void txtHoTen__TextChanged(object sender, EventArgs e)
        {
            txtHoTen.BorderColor = Color.White;
        }
        private void txtUserName__TextChanged(object sender, EventArgs e)
        {
            usernameError.Visible = false;
            txtUserName.BorderColor = Color.White;
        }
        private void txtCMND__TextChanged(object sender, EventArgs e)
        {
            txtCMND.BorderColor = Color.White;
        }
        private void txtSDT__TextChanged(object sender, EventArgs e)
        {
            txtSDT.BorderColor = Color.White;
        }
        private void txtNgaySinh__TextChanged(object sender, EventArgs e)
        {
            txtNgaySinh.BorderColor = Color.White;
        }
        private void txtPassWord__TextChanged(object sender, EventArgs e)
        {
            passError.Visible = false;
            txtPassWord.BorderColor = Color.White;
        }
    }
}
