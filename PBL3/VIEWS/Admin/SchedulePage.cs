using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.VIEWS.Admin
{
    public partial class SchedulePage : Form
    {
        private SUATCHIEU selectSche;
        private int? price = 0;
        private int amount = 0;
        List<VE_SC> listSeatSelected = new List<VE_SC>();
        USER userAccount;

        public SchedulePage()
        {
            InitializeComponent();
            CBB();
            dgvSche.DataSource = Management_BookingTicket_BLL.Instance.GetAllSchedule_View();
        }
        void CBB()
        {
            foreach (PHIM i in Management_BookingTicket_BLL.Instance.GetAllFilm().Distinct())
            {
                cbbPhim.Items.Add(i.TenPhim);
                cbbPhim_add_edit.Items.Add(i.TenPhim);
            }
            foreach (string i in Management_BookingTicket_BLL.Instance.GetShowDate().Distinct())
            {
                cbbNgayChieu.Items.Add(i);
            }
            foreach (TimeSpan i in Management_BookingTicket_BLL.Instance.GetShowTime().Distinct())
            {
                cbbGioChieu.Items.Add(i);
            }
            foreach (PHONGCHIEU i in Management_BookingTicket_BLL.Instance.GetAllRoom().Distinct())
            {
                cbbPhong.Items.Add(i.MaPhong);
            }
        }
        void CloseAddEditForm()
        {
            pnSchedule.Visible = true;
            pnAddEdit.Visible = false;
        }
        
        //Add new schedule
        private void btAdd_Click(object sender, EventArgs e)
        {
            pnSchedule.Visible = false;
            pnAddEdit.Visible = true;
            labelMaSC.Visible = false;
            txtMaSC.Visible = false;
            txtMaSC.Text = "";
            txtGioChieu.Text = "";
            cbbPhim_add_edit.SelectedItem = null;
            cbbPhong.SelectedItem = null;
        }

        //Update schedule if order ticket = 0
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvSche.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(dgvSche.SelectedRows[0].Cells[5].Value) > 0 || dgvSche.SelectedRows[0].Cells[7].Value.ToString() == "Đã hủy")
                {
                    MessageBox.Show("Không thể sửa suất chiếu đã được đặt vé hoặc đã quá hạn");
                    return;
                }
                else
                {
                    pnSchedule.Visible = false;
                    pnAddEdit.Visible = true;
                    labelMaSC.Visible = true;
                    txtMaSC.Visible = true;
                    txtMaSC.Text = dgvSche.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString();
                    txtMaSC.Enabled = false;
                    SUATCHIEU s = Management_BookingTicket_BLL.Instance.GetScheduleByID(txtMaSC.Text);
                    string TenPhim = s.PHIM.TenPhim;
                    string MaPhong = s.MaPhong;
                    foreach (string i in cbbPhim_add_edit.Items)
                    {
                        if (TenPhim == i)
                        {
                            cbbPhim_add_edit.SelectedItem = i;
                        }
                    }
                    foreach (string i in cbbPhong.Items)
                    {
                        if (MaPhong == i)
                        {
                            cbbPhong.SelectedItem = i;
                        }
                    }
                    dateTimePicker1.Value = Convert.ToDateTime(s.NgayChieu);
                    txtGioChieu.Text = s.GioChieu.ToString();
                }
            }
        }

        //Delete schedule if order ticket = 0
        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgvSche.SelectedRows.Count > 0)
            {
                List<string> listdel = new List<string>();
                foreach (DataGridViewRow i in dgvSche.SelectedRows)
                {
                    if (Convert.ToInt32(i.Cells[5].Value) > 0)
                    {
                        MessageBox.Show("Không thể xóa suất chiếu " + i.Cells[0].Value.ToString());
                        return;
                    }
                    else
                        listdel.Add(i.Cells["MaSuatChieu"].Value.ToString());
                }
                Management_BookingTicket_BLL.Instance.DeleteSchedule(listdel);
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.GetAllSchedule_View();
            }
        }
        
        //Open schedule detail panel
        private void btDetail_Click(object sender, EventArgs e)
        {
            if (dgvSche.SelectedRows.Count == 1)
            {
                pnDetail.Visible = true;
                selectSche = Management_BookingTicket_BLL.Instance.GetScheduleByID(dgvSche.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString());
                dgvSeat.DataSource = Management_BookingTicket_BLL.Instance.SetScheSeatView(dgvSche.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString());
                dgvSeat.Columns[0].Visible = false;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //tìm theo phim
            if (cbbPhim.SelectedIndex > -1)
            {
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleByCombobox(cbbPhim.SelectedItem.ToString());
            }
            //tìm theo ngày
            if (cbbNgayChieu.SelectedIndex > -1)
            {
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleByCombobox(cbbNgayChieu.SelectedItem.ToString());
            }
            //tìm theo giờ
            if (cbbGioChieu.SelectedIndex > -1)
            {
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleByCombobox(cbbGioChieu.SelectedItem.ToString());
            }
            //tìm theo phim + ngày
            if (cbbPhim.SelectedIndex > -1 && cbbNgayChieu.SelectedIndex > -1)
            {
                string txt = cbbPhim.SelectedItem.ToString() + ", " + cbbNgayChieu.SelectedItem.ToString();
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleBy2Combobox(txt);
            }
            //tìm theo phim + giờ
            if (cbbPhim.SelectedIndex > -1 && cbbGioChieu.SelectedIndex > -1)
            {
                string txt = cbbPhim.SelectedItem.ToString() + ", " + cbbGioChieu.SelectedItem.ToString();
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleBy2Combobox(txt);
            }
            //tìm theo ngày + giờ
            if (cbbNgayChieu.SelectedIndex > -1 && cbbGioChieu.SelectedIndex > -1)
            {
                string txt = cbbNgayChieu.SelectedItem.ToString() + ", " + cbbGioChieu.SelectedItem.ToString();
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleBy2Combobox(txt);
            }
            //tìm theo phim + ngày + giờ
            if (cbbPhim.SelectedIndex > -1 && cbbNgayChieu.SelectedIndex > -1 && cbbGioChieu.SelectedIndex > -1)
            {
                string txt = cbbPhim.SelectedItem.ToString() + ", " + cbbNgayChieu.SelectedItem.ToString() + ", " + cbbGioChieu.SelectedItem.ToString();
                dgvSche.DataSource = Management_BookingTicket_BLL.Instance.SearchScheduleBy3Combobox(txt);
            }
        }
        private void cbbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNgayChieu.Items.Clear();
            cbbGioChieu.Items.Clear();
            foreach (string i in Management_BookingTicket_BLL.Instance.GetShowDateByFilm(cbbPhim.SelectedItem.ToString()))
            {
                cbbNgayChieu.Items.Add(i);
            }
            foreach (string i in Management_BookingTicket_BLL.Instance.GetShowTimeByFilm(cbbPhim.SelectedItem.ToString()))
            {
                cbbGioChieu.Items.Add(i);
            }
        }
        private void cbbNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbGioChieu.Items.Clear();
            foreach (string i in Management_BookingTicket_BLL.Instance.GetShowTimeByShowDateOfFilm(cbbNgayChieu.SelectedItem.ToString()))
            {
                cbbGioChieu.Items.Add(i);
            }
        }
        private new bool Validate()
        {
            bool check = true;

            if (cbbPhim_add_edit.Text == "" || cbbPhong.Text == "" || dateTimePicker1.Text == "" || txtGioChieu.Text == "")
            {
                check = false;
            }

            if (check == false)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Warning!");
            }
            return check;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                SUATCHIEU sc = new SUATCHIEU
                {
                    MaSuatChieu = txtMaSC.Text,
                    MaPhim = Management_BookingTicket_BLL.Instance.GetIdFilmByNameFilm(cbbPhim_add_edit.SelectedItem.ToString()),
                    MaPhong = cbbPhong.SelectedItem.ToString(),
                    NgayChieu = dateTimePicker1.Value.Date,
                    GioChieu = TimeSpan.Parse(txtGioChieu.Text),
                };
                if (Management_BookingTicket_BLL.Instance.CheckTime(sc))
                {
                    Management_BookingTicket_BLL.Instance.AddUpdate(sc);
                    CloseAddEditForm();
                    dgvSche.DataSource = Management_BookingTicket_BLL.Instance.GetAllSchedule_View();
                }
                else
                {
                    MessageBox.Show("Thời Gian Chiếu đã trùng với một Suất Chiếu khác cùng Phòng Chiếu");
                }
            }
        }

        //Close edit schedule panel
        private void btCancel_Click(object sender, EventArgs e)
        {
            CloseAddEditForm();
        }


        #region DETAIL SCHEDULE
        
        //Close schedule detail panel
        private void btClose_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
        }

        //Open order panel
        private void btOrderPage_Click(object sender, EventArgs e)
        {
            if (dgvSche.SelectedRows[0].Cells[7].Value.ToString() == "Chưa chiếu")
            {
                pnOrder.Visible = true;
                pnDetail.Visible = false;
                RenderSeat(selectSche);
            }
            else
                MessageBox.Show("Suất chiếu đã hết hạn");
        }

        #endregion


        #region ORDER TICKET

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

        //Get or create user account by phone
        private void GetUserAccount()
        {
            userAccount = Management_BookingTicket_BLL.Instance.GetAccByPhone(txtUserPhone.Text);
            //If account not exist create new account
            if (userAccount == null)
            {
                int ma = Convert.ToInt32(Management_BookingTicket_BLL.Instance.GetMaxUserId());
                ma++;
                USER u = new USER
                {
                    MaUser = Convert.ToString(ma),
                    UserNames = txtUserPhone.Text,
                    PassWords = txtUserPhone.Text,
                    isAdmin = false,
                    NgaySinh = DateTime.Now.Date,
                    SDT = txtUserPhone.Text,
                    DiemTichLuy = 0
                };
                Management_BookingTicket_BLL.Instance.AddUser(u);
                userAccount = u;
            }
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
                    MaUser = userAccount.MaUser,
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
                MaUser = userAccount.MaUser,
                SoLuongVe = amount,
                ThanhTien = price
            };

            List<VE> listTicket = CreatListTicket(id, listSeatSelected);

            return Management_BookingTicket_BLL.Instance.OrderTransaction(selectSche.MaSuatChieu, listTicket, listSeatSelected, bill);
        }

        //Order
        private void btOrder_Click(object sender, EventArgs e)
        {
            if (txtUserPhone.Text.Length >= 10)
            {
                if (amount > 0)
                {
                    GetUserAccount();
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
            else 
                MessageBox.Show("Vui lòng nhập số điện thoại đặt vé");
        }

        //Close order page
        private void btBack_Click_1(object sender, EventArgs e)
        {
            ResetOrder();
            pnOrder.Visible = false;
            pnDetail.Visible = true;
        }

        #endregion
    }
}
