using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using System.Threading;
using System.IO;

namespace PBL3.VIEWS.User
{
    public partial class AccountPage : Form
    {
        bool checkEdit = false;
        string fileName = "";
        public USER loginAccount;
        
        //Constructor
        public AccountPage()
        {
            InitializeComponent();
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            GUI();
        }
        
        //Set GUI, load user img
        private void GUI()
        {
            txtUserName.Enabled = false;
            txtFullName.Enabled = false;
            txtFullName.BackColor = Color.FromArgb(255, 223, 199);
            txtCMND.Enabled = false;
            txtCMND.BackColor = Color.FromArgb(255, 223, 199);
            txtPhone.Enabled = false;
            txtPhone.BackColor = Color.FromArgb(255, 223, 199);
            txtBirthday.Enabled = false;
            txtBirthday.BackColor = Color.FromArgb(255, 223, 199);
            if (loginAccount != null)
            {
                if (loginAccount.IMG != null && loginAccount.IMG != "")
                    AccountIMG.Image = Image.FromFile(@"..\..\Resources\" + loginAccount.IMG);
                else
                    AccountIMG.Image = Image.FromFile(@"..\..\Resources\DefaultUser.png");
                txtUserName.Text = loginAccount.UserNames;
                txtFullName.Text = loginAccount.HoTen;
                txtCMND.Text = loginAccount.CMND;
                txtPhone.Text = loginAccount.SDT;
                txtBirthday.Text = Convert.ToDateTime(loginAccount.NgaySinh).ToString("dd/MM/yyyy");
                txtDiemTichLuy.Text = loginAccount.DiemTichLuy.ToString();
            }
            btOK.Visible = false;
            btCancel.Visible = false;
        }

        
        //Change to edit mode
        private void Edit_Click(object sender, EventArgs e)
        {
            checkEdit = true;
            btOK.Visible = true;
            btCancel.Visible = true;
            txtUserName.Enabled = true;
            txtUserName.BorderStyle = BorderStyle.Fixed3D;
            txtFullName.Enabled = true;
            txtFullName.BackColor = Color.White;
            txtCMND.Enabled = true;
            txtCMND.BackColor = Color.White;
            txtPhone.Enabled = true;
            txtPhone.BackColor = Color.White;
            txtBirthday.Enabled = true;
            txtBirthday.BackColor = Color.White;
        }


        //Update Account 
        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime birth = new DateTime(Convert.ToInt32(txtBirthday.Text.Substring(6, 4)), Convert.ToInt32(txtBirthday.Text.Substring(3, 2)), Convert.ToInt32(txtBirthday.Text.Substring(0, 2)));
            if (Management_BookingTicket_BLL.Instance.GetAccByUserName(txtUserName.Text) == null || txtUserName.Text == loginAccount.UserNames)
            {
                USER u = new USER
                {
                    MaUser = loginAccount.MaUser,
                    UserNames = txtUserName.Text,
                    HoTen = txtFullName.Text,
                    CMND = txtCMND.Text,
                    SDT = txtPhone.Text,
                    NgaySinh = birth,
                    IMG = (fileName != "") ? fileName : loginAccount.IMG
                };
                Management_BookingTicket_BLL.Instance.UpdateUser(u);
                GUI();
                checkEdit = false;
            }
            else
                MessageBox.Show("Tên tài khoản đã tồn tại");
        }


        //Back to view mode, reset old values
        private void btCancel_Click(object sender, EventArgs e)
        {
            GUI();
            checkEdit = false;
        }


        //Hover animate add img button
        private void AccountIMG_MouseEnter(object sender, EventArgs e)
        {
            if (checkEdit)
            {
                addBut.Visible = true;
            }    
        }
        private void addBut_MouseLeave(object sender, EventArgs e)
        {
           addBut.Visible = false;
        }


        //Open IMG dialog, copy select img to resource folder
        private void ShowIMGDialog()
        {
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            Thread t = new Thread((ThreadStart)(() =>
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string sourceFile = openFileDialog1.FileName;
                    fileName = Path.GetFileName(sourceFile);
                    string destFile = Path.Combine(@"..\..\Resources", fileName);
                    if (!new FileInfo(destFile).Exists)
                        File.Copy(sourceFile, destFile);

                    Image img = Image.FromFile(sourceFile);
                    AccountIMG.Image = img;
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }


        //Add img
        private void addBut_Click(object sender, EventArgs e)
        {
            ShowIMGDialog();
        }

    }
}
