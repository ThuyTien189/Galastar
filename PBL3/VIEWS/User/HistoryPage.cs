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

namespace PBL3.VIEWS.User
{
    public partial class HistoryPage : Form
    {
        public USER loginAccount;
        
        //Constructor
        public HistoryPage()
        {
            InitializeComponent();
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            LoadListItem();
        }

        //Load list ticket item
        private void LoadListItem()
        {
            foreach(Ticket_View t in Management_BookingTicket_BLL.Instance.GetTicketByUser(loginAccount.MaUser))
            {
                TicketItem item = new TicketItem();
                item.Id = t.MaVe;
                item.FilmName = t.TenPhim;
                item.OrderDay = t.NgayDat.ToString("dd-MM-yyyy");
                item.ShowDay = t.GioChieu + " " + t.NgayChieu;
                item.Status = (t.TrangThai) ? "Đặt thành công" : "Đã hết hạn";
                item.StatusForeColor = (t.TrangThai) ? Color.LimeGreen : Color.DimGray;
                item.Tag = t;
                item.Click += new System.EventHandler(ShowTicket);
                pnList.Controls.Add(item);
            }    
        }

        //Show ticket detail
        private void ShowTicket(object sender, EventArgs e)
        {
            TicketItem t = sender as TicketItem;
            Ticket_View item = t.Tag as Ticket_View;
            ID.Text = item.MaVe;
            FilmName.Text = item.TenPhim;
            Time.Text = item.GioChieu;
            Date.Text = item.NgayChieu;
            Room.Text = item.MaPhong;
            Seat.Text = item.MaGhe;
            OrderDate.Text = item.NgayDat.ToString("dd-MM-yyyy");
            pnTicket.Visible = true;
        }

        //Close ticket detail
        private void butBack_Click(object sender, EventArgs e)
        {
            pnTicket.Visible = false;
        }

    }
}
