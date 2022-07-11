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
    public partial class OrderPage : Form
    {
        private string filmIndex;
        private USER loginAccount;
        private SUATCHIEU selectSche;
        private int? price = 0;
        private int amount = 0;
        List<VE_SC> listSeatSelected = new List<VE_SC>();

        //Constructor
        public OrderPage(string FilmName)
        {
            this.filmIndex = FilmName;
            InitializeComponent();
            this.loginAccount = Management_BookingTicket_BLL.Instance.currentAccount;
            SetInitCBB();
            ShowPrice();
        }

        //Set init combobox
        private void SetInitCBB()
        {
            //Set Genre combobox
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

            SetCBBName();
            //set index film name in ccb
            foreach (CBBItem i in cbbName.Items)
                if (filmIndex == i.Text)
                    cbbName.SelectedItem = i;

            SetCBBDate();
        }

        //Set Name combobox depent genre
        private void SetCBBName()
        {
            cbbName.Items.Clear();
            cbbName.ResetText();
            string genre = ((CBBItem)cbbGenre.SelectedItem).Text;
            if (genre == "All")
            {
                foreach (PHIM i in Management_BookingTicket_BLL.Instance.GetAllFilm())
                {
                    CBBItem ccbItem = new CBBItem
                    {
                        Text = i.TenPhim,
                        Value = i.MaPhim

                    };
                    cbbName.Items.Add(ccbItem);
                }
            }
            else
            {
                foreach (Film_View i in Management_BookingTicket_BLL.Instance.SearchFilm(genre))
                {
                    cbbName.Items.Add(new CBBItem
                    {
                        Text = i.TenPhim,
                        Value = i.MaPhim
                    });
                }
            }
        }

        //Set Date combobox depent filmname
        private void SetCBBDate()
        {
            ResetCBBDate();
            DateTime today = DateTime.Today;
            List<String> list = new List<string>();
            foreach (SUATCHIEU i in Management_BookingTicket_BLL.Instance.GetScheduleByFilm(filmIndex, today))
            {
                list.Add(((DateTime)i.NgayChieu).ToString("dd/MM/yyyy"));
            }
            foreach (string i in list.Distinct())
            {
                cbbDate.Items.Add(new CBBItem
                {
                    Text = i,
                    Value = ""
                });
            }
        }

        //Set Time combobox depent filmname, day
        private void SetCBBTime()
        {
            ResetCBBTime();
            string day = ((CBBItem)cbbDate.SelectedItem).Text;
            TimeSpan now = DateTime.Now.TimeOfDay;
            Console.WriteLine(now);
            foreach (SUATCHIEU i in Management_BookingTicket_BLL.Instance.GetScheduleByDate(filmIndex, day, now))
            {
                cbbTime.Items.Add(new CBBItem
                {
                    Text = ((TimeSpan)i.GioChieu).ToString(@"hh\:mm"),
                    Value = i.MaSuatChieu
                });
            }
        }

        //Reset combobox Date
        private void ResetCBBDate()
        {
            cbbDate.Items.Clear();
            cbbDate.ResetText();
        }

        //Reset combobox Time
        private void ResetCBBTime()
        {
            cbbTime.Items.Clear();
            cbbTime.ResetText();
        }

        //Reset Name, Date, Time combobox and screen when Name change
        private void ccbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBBName();
            ResetCBBDate();
            ResetCBBTime();
            ResetOrder();
        }

        //Reset Date, Time combobox and screen when Name change
        private void ccbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmIndex = ((CBBItem)cbbName.SelectedItem).Text;
            SetCBBDate();
            ResetCBBTime();
            ResetOrder();
        }

        //Reset Time combobox and screen when Date change
        private void ccbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetOrder();
            SetCBBTime();
        }

        //Reset screen when Time change
        private void ccbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetOrder();
            if (cbbTime.Items.Count != 0)
                selectSche = Management_BookingTicket_BLL.Instance.GetScheduleByID(((CBBItem)cbbTime.SelectedItem).Value);
            RenderSeat(selectSche);
        }

        //Render Seat 
        private void RenderSeat(SUATCHIEU p)
        {
            foreach (VE_SC i in Management_BookingTicket_BLL.Instance.GetAllSeatBySche(p.MaSuatChieu))
            {
                CustomButton btnSeat = new CustomButton()
                {
                    Width = 75,
                    Height = 45,
                    Margin = new Padding(8, 3, 8, 3),
                    Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold),
                    BorderRadius = 0
                };
                btnSeat.Text = i.MaGhe;
                btnSeat.Tag = i;
                btnSeat.Click += new System.EventHandler(btSeat_Click);
                if (i.TrangThai == true)
                {

                    btnSeat.BackColor = ColorTranslator.FromHtml("#D0D0D0");
                    btnSeat.ForeColor = ColorTranslator.FromHtml("#656565");
                }
                else
                {
                    btnSeat.BackColor = ColorTranslator.FromHtml("#FEC5A3");
                    btnSeat.ForeColor = ColorTranslator.FromHtml("#FA6728");
                }
                pnSeat.Controls.Add(btnSeat);
            }
        }

        //Button seat click
        private void btSeat_Click(object sender, EventArgs e)
        {
            CustomButton btnSeat = sender as CustomButton;
            VE_SC ticket = btnSeat.Tag as VE_SC;

            if (ticket.TrangThai == false)
            {
                if (btnSeat.BackColor == ColorTranslator.FromHtml("#FEC5A3"))
                {
                    btnSeat.BackColor = Color.SpringGreen;
                    btnSeat.ForeColor = Color.DimGray;
                    amount++;
                    price += ticket.GiaVe;
                    listSeatSelected.Add(ticket);
                }
                else
                {
                    btnSeat.BackColor = ColorTranslator.FromHtml("#FEC5A3");
                    btnSeat.ForeColor = ColorTranslator.FromHtml("#FA6728");
                    amount--;
                    price -= ticket.GiaVe;
                    listSeatSelected.Remove(ticket);
                }
            }
            else
            {
                MessageBox.Show("Ghế " + btnSeat.Text + " đã có người mua");
            }
            ShowPrice();
        }

        //Reset order
        private void ResetOrder()
        {
            selectSche = null;
            pnSeat.Controls.Clear();
            price = 0;
            amount = 0;
            listSeatSelected.Clear();
            ShowPrice();
        }

        //Show price
        private void ShowPrice()
        {
            lbAmount.Text = amount.ToString();
            lbPrice.Text = price.ToString() + " VNĐ";
        }

        //Create list ticket
        private List<VE> CreatListTicket(string idBill, List<VE_SC> listSeat)
        {
            List<VE> list = new List<VE>();
            foreach (VE_SC t in listSeat)
            {
                VE ticket = new VE
                {
                    ID_Ghe = t.ID_Ghe,
                    MaUser = loginAccount.MaUser,
                    MaHoaDon = idBill,
                    MaSuatChieu = t.MaSuatChieu,
                    NgayBanVe = DateTime.Now,
                    GiaThanhTien = t.GiaVe
                };
                list.Add(ticket);
            }
            return list;
        }

        //Create new bill
        private bool Transaction(string id)
        {
            HOADON bill = new HOADON
            {
                MaHoaDon = id,
                MaUser = loginAccount.MaUser,
                SoLuongVe = amount,
                ThanhTien = price
            };

            List<VE> listTicket = CreatListTicket(id, listSeatSelected);

            return Management_BookingTicket_BLL.Instance.OrderTransaction(selectSche.MaSuatChieu, listTicket, listSeatSelected, bill);
        }

        //Order
        private void btOrder_Click(object sender, EventArgs e)
        {
            if (selectSche != null)
            {
                if (amount > 0)
                {
                    string idBill = DateTime.Now.ToString("yyyyMMddTHH:mm:ss.fffffff");
                    if (Transaction(idBill))
                        MessageBox.Show("Đặt vé thành công");
                    else
                        MessageBox.Show("Đặt vé thất bại");
                    pnSeat.Controls.Clear();
                    RenderSeat(selectSche);
                    price = 0;
                    amount = 0;
                    listSeatSelected.Clear();
                    ShowPrice();
                }
                else
                    MessageBox.Show("Vui lòng chọn chỗ ngồi");
            }
            else MessageBox.Show("Vui lòng chọn suất chiếu");

        }

        //Close order page
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
