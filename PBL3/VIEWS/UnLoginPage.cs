using PBL3.BLL;
using PBL3.DTO;
using PBL3.VIEWS.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.VIEWS
{
    public partial class UnLoginPage : Form
    {
        List<PHIM> list = new List<PHIM>();
        int current = 0;

        //Constructor
        public UnLoginPage()
        {
            InitializeComponent();
            //list = LoadListFilm();
            //if (list.Count > 0)
            //{
            //    ShowItem(list[current]);
            //    if (list.Count > 1)
            //    {
            //        btNext.Visible = true;
            //        btBack.Visible = true;
            //    }
            //}
            //else
            //{
            //    pnNoSche.Visible = true;
            //    pnSche.Visible = false;
            //}
            ReloadPage();
        }

        private void ReloadPage()
        {
            list.Clear();
            list = LoadListFilm();
            if (list.Count > 0)
            {
                ShowItem(list[current]);
                if (list.Count > 1)
                {
                    btNext.Visible = true;
                    btBack.Visible = true;
                }
            }
            else
            {
                pnNoSche.Visible = true;
                pnSche.Visible = false;
            }
        }

        //Load list film today
        private List<PHIM> LoadListFilm()
        {
            DateTime date = DateTime.Now.Date;
            List<PHIM> list = new List<PHIM>();
            foreach (SUATCHIEU i in Management_BookingTicket_BLL.Instance.GetScheduleByDate("All", date))
                list.Add(i.PHIM);
            list.Distinct();
            return list;
        }

        //Show each film in list
        private void ShowItem(PHIM item)
        {
            FilmName.Text = item.TenPhim.ToUpper();
            Type.Text = String.Join(", ", Management_BookingTicket_BLL.Instance.GetListGenreByIdFilm(item.MaPhim));
            if (item.IMG != null || item.IMG != "") pictureBox1.Image = Image.FromFile(@"..\..\Resources\" + item.IMG);
            Direct.Text = item.DaoDien;
            Actor.Text = item.DienVien;
            Time.Text = item.ThoiLuong.ToString();
        }


        //Move to next film
        private void btNext_Click(object sender, EventArgs e)
        {
            if (current < list.Count - 1)
                current++;
            else
                current = 0;
            ShowItem(list[current]);
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            if (current > 0)
                current--;
            else
                current = list.Count - 1;
            ShowItem(list[current]);
        }


        //Next and back button hover
        private void btMove_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DimGray;
        }
        private void btMove_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DarkGray;
        }


        //SignIn
        private void btSignIn_Click(object sender, EventArgs e)
        {
            LoginMainPage f = new LoginMainPage();
            this.Hide();
            f.ShowDialog();
            this.Show();
            ReloadPage();
        }


        //Open order page of current film
        private void butOrder_Click(object sender, EventArgs e)
        {
            Management_BookingTicket_BLL.Instance.currentFilm = list[current];
            LoginMainPage f = new LoginMainPage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
