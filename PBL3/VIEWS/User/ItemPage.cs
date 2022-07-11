
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

namespace PBL3.VIEWS.User
{
    public partial class ItemPage : Form
    {
        private USER loginAccount;
        private Form currentChildForm;

        //Constructor
        public ItemPage()
        {
            InitializeComponent();
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            SetCBBGenre();
            ShowListItem(LoadListFilm());
        }


        //Set Genre combobox
        private void SetCBBGenre()
        {
            cbbGenre.Items.Add(new CBBItem { Value = "0", Text = "All" });
            foreach (THELOAI i in Management_BookingTicket_BLL.Instance.GetAllGenre())
            {
                cbbGenre.Items.Add(new CBBItem
                {
                    Text = i.TenTheLoai,
                    Value = i.MaTheLoai
                });
            }
            cbbGenre.SelectedIndex = 0;
        }


        //ReRender list film when genre combobox or date change
        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowListItem(LoadListFilm());
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowListItem(LoadListFilm());
        }


        //Load list film by genre and date
        private List<PHIM> LoadListFilm()
        {
            string genre = ((CBBItem)cbbGenre.SelectedItem).Text;
            DateTime date = ShowDate.Value.Date;
            List<PHIM> list = new List<PHIM>();
            foreach (SUATCHIEU i in Management_BookingTicket_BLL.Instance.GetScheduleByDate(genre, date))
                list.Add(i.PHIM);
            List<PHIM> newlist = new List<PHIM>();
            foreach (PHIM i in list.Distinct())
            {
                newlist.Add(i);
            }    
            return newlist;
        }


        //Show all film in list
        private void ShowListItem(List<PHIM> list)
        {
            pnList.Controls.Clear();
            foreach (PHIM p in list)
            {
                FilmItem item = new FilmItem();
                item.FilmName = p.TenPhim;
                item.FilmType = String.Join(", ", Management_BookingTicket_BLL.Instance.GetListGenreByIdFilm(p.MaPhim));
                if (p.IMG != null || p.IMG != "") item.FilmIMG = Image.FromFile(@"..\..\Resources\" + p.IMG);
                item.FilmDirect = p.DaoDien;
                item.FilmActor = p.DienVien;
                item.FilmTime = p.ThoiLuong.ToString();
                item.FilmRecap = p.NDTomTat;
                item.Click += new System.EventHandler(FilmDetailPage);
                pnList.Controls.Add(item);
            }
        }


        //----------Detail-Page----------

        //Open film detail page
        private void FilmDetailPage(object sender, EventArgs e)
        {
            FilmItem item = (FilmItem)sender;
            IMG.Image = item.FilmIMG;
            FilmName.Text = item.FilmName.ToUpper();
            Type.Text = "Thể loại:     " + item.FilmType;
            Direct.Text = "Đạo diễn:     " + item.FilmDirect;
            Actor.Text = "Diễn viên:     " + item.FilmActor;
            Time.Text = "Thời lượng:     " + item.FilmTime;
            Recap.Text = "Tóm tắt:     " + item.FilmRecap;
            pnDetail.Visible = true;
        }

        //Close detail form
        private void butBack_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
        }
        
        //Move to order page
        private void butOrder_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
            OpenChildForm(new OrderPage(FilmName.Text));
        }


        //-----------Order-Page----------

        //Open child form
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
            pn.Controls.Add(ChildForm);
            pn.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    
    }
}
