using PBL3.DTO;
using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class Management_BookingTicket_BLL
    {
        PBL3_CF db = new PBL3_CF();
        private static Management_BookingTicket_BLL _Instance;
        public static Management_BookingTicket_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Management_BookingTicket_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public USER currentAccount;
        public PHIM currentFilm;


        #region --- ACCOUNT ---

        public void Login(string userName, string passWord)
        {
            currentAccount = db.USERs.Where(u => u.UserNames == userName && u.PassWords == passWord).FirstOrDefault();
        }


        //Get last id number
        public string GetMaxUserId()
        {
            return db.USERs.Max(x => x.MaUser);
        }

        //Get account by UserName
        public USER GetAccByUserName(string userName)
        {
            USER acc = db.USERs.Where(u => u.UserNames == userName).FirstOrDefault();
            return acc;
        }

        //Get account by Phone
        public USER GetAccByPhone(string phone)
        {
            USER acc = db.USERs.Where(u => u.SDT == phone).FirstOrDefault();
            return acc;
        }

        //Find account by Username or Phone
        public USER FindAccount(string input)
        {
            USER acc = GetAccByUserName(input);
            if (acc == null)
            {
                acc = GetAccByPhone(input);
            }
            return acc;
        }

        //Update password
        public void UpdatePassword(string userName, string passWord)
        {
            USER acc = GetAccByUserName(userName);
            acc.PassWords = passWord;
            db.SaveChanges();
        }

        //Add new user
        public void AddUser(USER u)
        {
            db.USERs.Add(u);
            db.SaveChanges();
        }

        //Update user
        public void UpdateUser(USER u)
        {
            USER s = db.USERs.Find(u.MaUser);
            s.HoTen = u.HoTen;
            s.UserNames = u.UserNames;
            s.CMND = u.CMND;
            s.SDT = u.SDT;
            s.NgaySinh = u.NgaySinh;
            s.IMG = u.IMG;
            db.SaveChanges();
        }

        #endregion

        #region --- FILM ---

        //Get all film
        public List<PHIM> GetAllFilm()
        {
            return db.PHIMs.ToList();
        }

        public List<Film_View> GetAllFilm_View()
        {
            List<Film_View> list = new List<Film_View>();
            foreach (PHIM p in GetAllFilm())
            {
                list.Add(new Film_View
                {
                    MaPhim = p.MaPhim,
                    TenPhim = p.TenPhim,
                    ThoiLuong = TimeSpan.Parse(p.ThoiLuong.ToString()),
                    NDTomTat = p.NDTomTat,
                    TheLoai = String.Join(", ", GetListGenreByIdFilm(p.MaPhim)),
                    DaoDien = p.DaoDien,
                    DienVien = p.DienVien,
                    IMG = p.IMG
                });
            }
            return list;
        }
        public PHIM GetFilmById(string Id)
        {
            return db.PHIMs.Find(Id);
        }
        public void AddNewPhim(PHIM p)
        {
            int ma = Convert.ToInt32(db.PHIMs.Max(x => x.MaPhim));
            ma++;
            p.MaPhim = Convert.ToString(ma);
            db.PHIMs.Add(p);
            db.SaveChanges();
        }
        public void UpdatePhim(PHIM p)
        {
            var s1 = GetFilmById(p.MaPhim);
            s1.TenPhim = p.TenPhim;
            s1.ThoiLuong = p.ThoiLuong;
            s1.DaoDien = p.DaoDien;
            s1.DienVien = p.DienVien;
            s1.IMG = p.IMG;
            s1.NDTomTat = p.NDTomTat;
            db.SaveChanges();
        }
        public void AddUpdate(PHIM p, List<THELOAI> list)
        {
            bool Check = true;
            foreach (PHIM s in GetAllFilm())
            {
                if (p.MaPhim.Trim() == s.MaPhim.Trim())
                {
                    Check = false;
                }
            }
            if (Check)
            {
                AddNewPhim(p);
                AddNewDetailGenre(p.MaPhim, list);
            }
            else
            {
                UpdatePhim(p);
                UpdateDetailGenre(p.MaPhim, list);
            }

        }
        public void DeleteFilm(List<string> list)
        {
            foreach (string s in list)
            {
                DeleteGenreForFilm(s);
            }
            foreach (string s in list)
            {
                PHIM p = db.PHIMs.Find(s);
                db.PHIMs.Remove(p);
                db.SaveChanges();
            }
        }
        public List<Film_View> SearchFilm(string txt)
        {
            List<Film_View> list = new List<Film_View>();
            foreach (Film_View p in GetAllFilm_View())
            {
                if (p.TenPhim.Contains(txt) || p.MaPhim == txt || GetListGenreByIdFilm(p.MaPhim).Exists(x => x == txt))
                {
                    list.Add(p);
                }
            }
            return list;
        }

        public string GetIdFilmByNameFilm(string nameFilm)
        {
            //return db.PHIMs.Find(nameFilm).MaPhim;
            return db.PHIMs.FirstOrDefault(p => p.TenPhim == nameFilm).MaPhim;
        }

        #endregion

        #region --- GENRE ---

        public List<THELOAI> GetAllGenre()
        {
            return db.THELOAIs.ToList();
        }
        public List<CHITIET_THELOAI> GetDetailGenreByIdFilm(string Id)
        {
            return db.CHITIET_THELOAI.Where(x => x.MaPhim == Id).ToList();
        }
        public List<string> GetListGenreByIdFilm(string Id)
        {
            return db.CHITIET_THELOAI.Where(x => x.MaPhim == Id).Select(x => x.THELOAI.TenTheLoai).ToList();
        }
        public List<THELOAI> GetGenreByIdFilm(List<CHITIET_THELOAI> list, string Id)
        {
            List<THELOAI> genre = new List<THELOAI>();
            list = GetDetailGenreByIdFilm(Id);
            foreach (CHITIET_THELOAI i in list)
            {
                THELOAI tl = new THELOAI();
                tl.MaTheLoai = i.MaTheLoai;
                tl.TenTheLoai = i.THELOAI.TenTheLoai;
                genre.Add(tl);
            }
            return genre;
        }

        public void AddNewDetailGenre(string MaPhim, List<THELOAI> list_genre)
        {
            int x = Convert.ToInt32(db.CHITIET_THELOAI.Max(c => c.ID));
            foreach (THELOAI i in list_genre)
            {
                x++;
                CHITIET_THELOAI detail = new CHITIET_THELOAI
                {
                    ID = Convert.ToString(x),
                    MaPhim = MaPhim,
                    MaTheLoai = i.MaTheLoai,
                };
                db.CHITIET_THELOAI.Add(detail);
                db.SaveChanges();
            }
        }
        public void UpdateDetailGenre(string MaPhim, List<THELOAI> list_genre)
        {
            //Idea : Delete all rows that contain MaPhim, then re-add all genre that have been chosen from CheckedListBox to 'CHITIET_THELOAI' with MaPhim
            DeleteGenreForFilm(MaPhim);
            AddNewDetailGenre(MaPhim, list_genre);
        }
        public void DeleteGenreForFilm(string MaPhim)
        {
            foreach (CHITIET_THELOAI i in db.CHITIET_THELOAI.Select(s => s).ToList())
            {
                if (i.MaPhim == MaPhim)
                {
                    db.CHITIET_THELOAI.Remove(i);
                    db.SaveChanges();
                }
            }
        }

        #endregion

        #region --- SCHEDULE ---

        public List<SUATCHIEU> GetAllSchedule()
        {
            return db.SUATCHIEUs.ToList();
        }

        //Change list schedule to schedule view
        public List<Schedule_View> GetSchedule_Views(List<SUATCHIEU> list)
        {
            List<Schedule_View> newlist = new List<Schedule_View>();
            foreach (SUATCHIEU p in list)
            {
                newlist.Add(new Schedule_View
                {
                    MaSuatChieu = p.MaSuatChieu,
                    MaPhong = p.MaPhong,
                    TenPhim = GetFilmById(p.MaPhim).TenPhim,
                    NgayChieu = Convert.ToDateTime(p.NgayChieu).ToString("dd/MM/yyyy"),
                    GioChieu = TimeSpan.Parse(p.GioChieu.ToString()),
                    SoVeDaDat = Convert.ToInt32(p.SoVeDaDat),
                    SoVeToiDa = GetRoomById(p.MaPhong).SoGheToiDa,
                    TrangThai = (((DateTime)p.NgayChieu == DateTime.Now.Date && (TimeSpan)p.GioChieu > DateTime.Now.TimeOfDay) || (DateTime)p.NgayChieu > DateTime.Now.Date) ? "Chưa chiếu" : (p.SoVeDaDat > 0) ? "Đã chiếu" : "Đã hủy",
                });
            }
            return newlist;
        }

        //Get all schedule view
        public List<Schedule_View> GetAllSchedule_View()
        {
            return GetSchedule_Views(db.SUATCHIEUs.ToList());
        }

        //Get all schedule for a period of time
        public List<Schedule_View> GetAllSchedule_View_ByTime(DateTime FromDay, DateTime ToDay)
        {
            return GetSchedule_Views(db.SUATCHIEUs.Where(p => p.NgayChieu >= FromDay && p.NgayChieu <= ToDay).ToList());
        }

        //Get all schedule by genre and date
        public List<SUATCHIEU> GetScheduleByDate(string genre, DateTime date)
        {
            List<SUATCHIEU> list = new List<SUATCHIEU>();
            if (genre == "All")
                foreach (SUATCHIEU p in GetAllSchedule())
                {
                    if (((DateTime)p.NgayChieu).Date == date.Date)
                        list.Add(p);
                }
            else
                foreach (SUATCHIEU p in GetAllSchedule())
                {
                    if (GetListGenreByIdFilm(p.PHIM.MaPhim).Exists(x => x == genre) && ((DateTime)p.NgayChieu).Date == date.Date)
                        list.Add(p);
                }
            return list;
        }

        //Get all Schedule by film
        public List<SUATCHIEU> GetScheduleByFilm(string filmName, DateTime now)
        {
            return db.SUATCHIEUs.Where(s => s.PHIM.TenPhim == filmName && s.NgayChieu >= now).ToList();
        }

        //Get all Schedule by film, date and time
        public List<SUATCHIEU> GetScheduleByDate(string filmName, string day, TimeSpan now)
        {
            List<SUATCHIEU> list = new List<SUATCHIEU>();
            if(day == DateTime.Now.ToString("dd/MM/yyyy"))
                foreach (SUATCHIEU p in GetAllSchedule())
                {
                    if (p.PHIM.TenPhim == filmName && ((DateTime)p.NgayChieu).ToString("dd/MM/yyyy") == day && p.GioChieu >= now)
                        list.Add(p);
                }
            else
                foreach (SUATCHIEU p in GetAllSchedule())
                {
                    if (p.PHIM.TenPhim == filmName && ((DateTime)p.NgayChieu).ToString("dd/MM/yyyy") == day)
                        list.Add(p);
                }
            return list;
        }

        //Get Schedule by ID
        public SUATCHIEU GetScheduleByID(string id)
        {
            return db.SUATCHIEUs.Find(id);
        }

        public int TotalSchedule_ByFilm(string filmName, DateTime FromDay, DateTime ToDay)
        {
            int count = 0;
            foreach (Schedule_View v in GetAllSchedule_View_ByTime(FromDay, ToDay))
            {
                if (v.TenPhim == filmName)
                {
                    count += 1;
                }
            }
            return count;
        }
        
        public int TotalSchedule_ByFilm(string filmName)
        {
            int count = 0;
            foreach (Schedule_View v in GetAllSchedule_View())
            {
                if (v.TenPhim == filmName)
                {
                    count += 1;
                }
            }
            return count;
        }

        public int TotalTicket_Booked_ByFilm(string filmName, DateTime FromDay, DateTime ToDay)
        {
            int count = 0;
            foreach (Schedule_View v in GetAllSchedule_View_ByTime(FromDay, ToDay))
            {
                if (v.TenPhim == filmName)
                {
                    count += Convert.ToInt32(v.SoVeDaDat);
                }
            }
            return count;
        }

        public List<string> GetShowDateByFilm(string filmName)
        {
            List<string> s = new List<string>();
            foreach (SUATCHIEU p in GetAllSchedule())
            {
                if (p.PHIM.TenPhim == filmName)
                {
                    s.Add(Convert.ToDateTime(p.NgayChieu).ToString("dd/MM/yyyy"));
                }
            }
            return s;
        }
        public List<string> GetShowTimeByFilm(string filmName)
        {
            List<string> s = new List<string>();
            foreach (SUATCHIEU p in GetAllSchedule())
            {
                if (p.PHIM.TenPhim == filmName)
                {
                    s.Add(p.GioChieu.ToString());
                }
            }
            return s;
        }
        public List<string> GetShowTimeByShowDateOfFilm(string showDate)
        {
            List<string> s = new List<string>();
            foreach (SUATCHIEU p in GetAllSchedule())
            {
                if (Convert.ToDateTime(p.NgayChieu).ToString("dd/MM/yyyy") == showDate)
                {
                    s.Add(p.GioChieu.ToString());
                }
            }
            return s;
        }

        public bool CheckTime(SUATCHIEU sc)
        {
            List<SUATCHIEU> list = new List<SUATCHIEU>();
            foreach (SUATCHIEU i in db.SUATCHIEUs.ToList())
            {
                if (i.MaSuatChieu == sc.MaSuatChieu)
                {
                    list.Add(i);
                }
            }
            foreach (SUATCHIEU i in db.SUATCHIEUs.ToList().Except(list))
            {
                if (sc.MaPhong == i.MaPhong && sc.NgayChieu == i.NgayChieu)
                {
                    if (sc.GioChieu <= i.GioChieu + GetFilmById(sc.MaPhim).ThoiLuong && sc.GioChieu >= i.GioChieu)
                    {
                        return false; //Thời Gian Chiếu đã trùng với một lịch chiếu khác cùng Phòng Chiếu
                    }
                }
            }
            return true;
        }

        //Add new schedule
        public void AddNewSchedule(SUATCHIEU sc)
        {
            //tăng mã tự động
            int ma = Convert.ToInt32(db.SUATCHIEUs.Max(x => x.MaSuatChieu));
            ma++;
            sc.MaSuatChieu = Convert.ToString(ma);
            db.SUATCHIEUs.Add(sc);
            db.SaveChanges();
        }

        //Update schdule
        public void UpdateSchedule(SUATCHIEU sc)
        {
            var s1 = db.SUATCHIEUs.Find(sc.MaSuatChieu);
            s1.MaPhong = sc.MaPhong;
            s1.MaPhim = sc.MaPhim;
            s1.NgayChieu = sc.NgayChieu;
            s1.GioChieu = sc.GioChieu;
            s1.SoVeDaDat = sc.SoVeDaDat;
            db.SaveChanges();
        }

        //Check add or update
        public void AddUpdate(SUATCHIEU sc)
        {
            int Price;
            if (db.SUATCHIEUs.Find(sc.MaSuatChieu) != null)
            {
                UpdateSchedule(sc);
            }
            else
            {
                sc.SoVeDaDat = 0;
                AddNewSchedule(sc);
                //45 for weekday and 60 for weekend
                Price = (Convert.ToDateTime(sc.NgayChieu).DayOfWeek == DayOfWeek.Sunday || Convert.ToDateTime(sc.NgayChieu).DayOfWeek == DayOfWeek.Saturday) ? 60000 : 45000;
                AddSeats(sc, Price);
            }
        }
        
        public List<string> GetShowDate()
        {
            List<string> list = new List<string>();
            foreach (SUATCHIEU s in GetAllSchedule())
            {
                string dt = Convert.ToDateTime(s.NgayChieu).ToString("dd/MM/yyyy");
                list.Add(dt);
            }
            return list;
        }
        public List<TimeSpan> GetShowTime()
        {
            List<TimeSpan> list = new List<TimeSpan>();
            foreach (SUATCHIEU s in GetAllSchedule())
            {
                TimeSpan dt = TimeSpan.Parse(s.GioChieu.ToString());
                list.Add(dt);
            }
            return list;
        }

        //Delete a schedule
        public void DeleteSchedule(List<string> list)
        {
            foreach (string s in list)
            {
                SUATCHIEU sc = db.SUATCHIEUs.Find(s);
                DelSeats(sc);
                db.SUATCHIEUs.Remove(sc);
                db.SaveChanges();
            }
        }
        
        public List<Schedule_View> SearchScheduleBy3Combobox(string txt)
        {
            string[] s = Regex.Split(txt, ",|[ ]{2,}");
            List<Schedule_View> list = new List<Schedule_View>();
            foreach (Schedule_View sc in GetAllSchedule_View())
            {
                if (sc.TenPhim == s[0].Trim() && sc.NgayChieu == s[1].Trim() && sc.GioChieu.ToString() == s[2].Trim())
                {
                    list.Add(sc);
                }
            }
            return list;
        }
        public List<Schedule_View> SearchScheduleBy2Combobox(string txt)
        {
            string[] s = Regex.Split(txt, ",|[ ]{2,}");
            List<Schedule_View> list = new List<Schedule_View>();
            foreach (Schedule_View sc in GetAllSchedule_View())
            {
                if ((sc.TenPhim == s[0].Trim() && sc.NgayChieu == s[1].Trim()) || (sc.TenPhim == s[0].Trim() && sc.GioChieu.ToString() == s[1].Trim()) || (sc.NgayChieu == s[0].Trim() && sc.GioChieu.ToString() == s[1].Trim()))
                {
                    list.Add(sc);
                }
            }
            return list;
        }
        public List<Schedule_View> SearchScheduleByCombobox(string txt)
        {
            List<Schedule_View> list = new List<Schedule_View>();
            foreach (Schedule_View sc in GetAllSchedule_View())
            {
                if (sc.TenPhim == txt || sc.NgayChieu == txt || sc.GioChieu.ToString() == txt)
                {
                    list.Add(sc);
                }
            }
            return list;
        }

        #endregion

        #region --- SEAT ---

        //Get all seat in schedule
        public List<VE_SC> GetAllSeatBySche(string idSchedule)
        {
            return db.VE_SCs.Where(s => s.MaSuatChieu == idSchedule).ToList();
        }

        //Order transaction
        public bool OrderTransaction(string scheID, List<VE> listTicket, List<VE_SC> listSeat, HOADON bill)
        {
            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    //Add new bill
                    db.HOADONs.Add(bill);
                    db.SaveChanges();

                    //Add new ticket
                    foreach (VE t in listTicket)
                    {
                        db.VEs.Add(t);
                        db.SaveChanges();
                    }

                    //Update order ticket
                    var schedule = db.SUATCHIEUs.Where(t => t.MaSuatChieu == scheID).FirstOrDefault();
                    schedule.SoVeDaDat += bill.SoLuongVe;
                    db.SaveChanges();

                    //Update user point
                    var user = db.USERs.Where(t => t.MaUser == bill.MaUser).FirstOrDefault();
                    user.DiemTichLuy += bill.SoLuongVe;
                    db.SaveChanges();

                    //Change seat status to order in db
                    foreach (VE_SC s in listSeat)
                    {
                        var seat = db.VE_SCs.Where(t => t.ID_Ghe == s.ID_Ghe).FirstOrDefault();
                        if (seat.TrangThai == false)
                        {
                            seat.TrangThai = true;
                            db.SaveChanges();
                        }
                        else
                            transaction.Rollback();
                    }

                    transaction.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.InnerException);
                    return false;
                }
            }
        }

        //Auto add seats when create schedule
        public void AddSeats(SUATCHIEU sc, int price)
        {
            int ma = Convert.ToInt32(db.VE_SCs.Max(x => x.ID_Ghe));
            foreach (GHE x in db.GHEs.Where(x => x.MaPhong == sc.MaPhong).ToList())
            {
                ma++;
                VE_SC v = new VE_SC()
                {
                    ID_Ghe = Convert.ToString(ma),
                    MaSuatChieu = sc.MaSuatChieu,
                    MaGhe = x.MaGhe,
                    MaPhong = sc.MaPhong,
                    GiaVe = price,
                    TrangThai = false
                };
                db.VE_SCs.Add(v);
            }
            db.SaveChanges();
        }

        //Auto delete seats when create schedule
        public void DelSeats(SUATCHIEU sc)
        {
            foreach (VE_SC v in db.VE_SCs.Select(x => x).ToList())
            {
                if (v.MaSuatChieu == sc.MaSuatChieu)
                {
                    db.VE_SCs.Remove(v);
                    db.SaveChanges();
                }
            }
        }

        public List<Seat_View> SetScheSeatView(string ScheId)
        {
            List<Seat_View> list = new List<Seat_View>();
            foreach (VE_SC s in GetAllSeatBySche(ScheId))
            {
                list.Add(new Seat_View
                {
                    ID_Ghe = s.ID_Ghe,
                    MaGhe = s.MaGhe,
                    MaSuatChieu = s.MaSuatChieu,
                    MaPhong = s.MaPhong,
                    GiaVe = s.GiaVe,
                    TrangThai = s.TrangThai,
                    MaUser = (s.TrangThai == true) ? GetTicketById(s.ID_Ghe).MaUser : null
                }); 
            }
            return list;    
        }

        #endregion

        #region --- STATISTICAL ---
        public List<CBBItem> GetCBB()
        {
            List<CBBItem> data = new List<CBBItem>();
            data.Add(new CBBItem { Value = "0", Text = "All" });
            foreach (PHIM i in db.PHIMs)
            {
                data.Add(new CBBItem
                {
                    Value = i.MaPhim,
                    Text = i.TenPhim
                });
            }
            return data;
        }
        public List<ThongKeSCPhim_View> GetAllStatistical_Schedule_Film_View_ByTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            List<ThongKeSCPhim_View> list = new List<ThongKeSCPhim_View>();
            foreach (Schedule_View p in GetAllSchedule_View_ByTime(FromDay, ToDay))
            {
                if (p.TenPhim == filmName)
                {

                    list.Add(new ThongKeSCPhim_View
                    {
                        MaSuatChieu = p.MaSuatChieu,
                        TenPhim = p.TenPhim,
                        NgayChieu = p.NgayChieu,
                        GioChieu = TimeSpan.Parse(p.GioChieu.ToString()),
                        SoVeDaDat = p.SoVeDaDat,
                        DoanhThu = CalRevenueBySche(p.MaSuatChieu)
                    });
                }
            }
            return list;
        }

        public List<Chart_Schedule_Film_View> Get_Data_Chart_Schedule_Film_View_ByTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            List<Chart_Schedule_Film_View> list = new List<Chart_Schedule_Film_View>();
            foreach (ThongKeSCPhim_View p in GetAllStatistical_Schedule_Film_View_ByTime(filmName, FromDay, ToDay))
            {
                list.Add(new Chart_Schedule_Film_View
                {
                    MaSuatChieu = p.MaSuatChieu,
                    DoanhThu = CalRevenueBySche(p.MaSuatChieu)
                });
            }
            return list;
        }



        public List<ThongKePhim_View> GetAllStatistical_Film_View_ByTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            List<ThongKePhim_View> list = new List<ThongKePhim_View>();
            List<string> list_film = new List<string>();
            foreach (Film_View i in GetAllFilm_View())
                foreach (Schedule_View p in GetAllSchedule_View())
                {
                    if (p.TenPhim == i.TenPhim)
                    {
                        list_film.Add(p.TenPhim);
                    }
                }
            foreach (string i in list_film.Distinct())
            {
                list.Add(new ThongKePhim_View
                {
                    TenPhim = i,
                    TongSuatChieu = TotalSchedule_ByFilm(i, FromDay, ToDay),
                    TongSoVeDaDat = TotalTicket_Booked_ByFilm(i, FromDay, ToDay),
                    DoanhThu = CalRevenueByFilm(i, FromDay, ToDay)
                });
            }
            return list;
        }
        public List<Chart_Film_View> Get_Data_Chart_Film_View_ByTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            List<Chart_Film_View> list = new List<Chart_Film_View>();
            foreach (ThongKePhim_View p in GetAllStatistical_Film_View_ByTime(filmName, FromDay, ToDay))
            {
                list.Add(new Chart_Film_View
                {
                    TenPhim = p.TenPhim,
                    DoanhThu = CalRevenueByFilm(p.TenPhim, FromDay, ToDay)
                });
            }
            return list;
        }
        public int TotalRevenueFilm_ByTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            int count = 0;
            List<ThongKePhim_View> list = new List<ThongKePhim_View>();
            foreach (ThongKePhim_View p in GetAllStatistical_Film_View_ByTime(filmName, FromDay, ToDay))
            {
                count += Convert.ToInt32(p.DoanhThu.ToString());
            }
            return count;
        }

        public int TotalRevenue_Schedule_Film_ByTime(string TenPhim, DateTime FromDay, DateTime ToDay)
        {
            int count = 0;
            List<ThongKeSCPhim_View> list = new List<ThongKeSCPhim_View>();
            foreach (ThongKeSCPhim_View p in GetAllStatistical_Schedule_Film_View_ByTime(TenPhim, FromDay, ToDay))
            {
                count += Convert.ToInt32(p.DoanhThu.ToString());
            }
            return count;
        }

        #endregion

        #region --- TICKET ---

        //Get all ticket in db
        public List<VE> GetAllTicket()
        {
            return db.VEs.ToList();
        }

        public VE GetTicketById(string ID)
        {
            return db.VEs.FirstOrDefault(t => t.ID_Ghe == ID);
        }

        //Change list ticket to ticket view
        public List<Ticket_View> GetTicket_Views(List<VE> list)
        {
            List<Ticket_View> newlist = new List<Ticket_View>();
            foreach (VE v in list)
            {
                newlist.Add(new Ticket_View
                {
                    MaVe = v.ID_Ghe,
                    MaUser = v.MaUser,
                    HoTen = v.USER.HoTen,
                    MaSuatChieu = v.MaSuatChieu,
                    TenPhim = v.SUATCHIEU.PHIM.TenPhim,
                    MaPhong = v.SUATCHIEU.MaPhong,
                    MaGhe = v.VE_SC.MaGhe,
                    NgayChieu = ((DateTime)v.SUATCHIEU.NgayChieu).ToString("dd-MM-yyyy"),
                    GioChieu = ((TimeSpan)v.SUATCHIEU.GioChieu).ToString(@"hh\:mm"),
                    NgayDat = (DateTime)v.NgayBanVe,
                    TrangThai = (((DateTime)v.SUATCHIEU.NgayChieu == DateTime.Now.Date && (TimeSpan)v.SUATCHIEU.GioChieu > DateTime.Now.TimeOfDay) || (DateTime)v.SUATCHIEU.NgayChieu > DateTime.Now.Date) ? true : false,
                    GiaThanhTien = (int)v.GiaThanhTien
                });
            }
            return newlist;
        }

        //Get ticket by user
        public List<Ticket_View> GetTicketByUser(string IdUser)
        {
            return GetTicket_Views(db.VEs.Where(t => t.MaUser == IdUser).ToList());
        }

        //Get ticket by film and time
        public List<Ticket_View> GetTicketByFilmAndTime(string filmName, DateTime FromDay, DateTime ToDay)
        {
            return GetTicket_Views(db.VEs.Where(v => v.SUATCHIEU.PHIM.TenPhim == filmName && v.SUATCHIEU.NgayChieu >= FromDay && v.SUATCHIEU.NgayChieu <= ToDay).ToList());
        }

        //Get ticket by schedule
        public List<Ticket_View> GetTicketBySchedule(string IdSchedule)
        {
            return GetTicket_Views(db.VEs.Where(v => v.MaSuatChieu == IdSchedule).ToList());
        }

        //Calculate film's revenue in a period
        public int CalRevenueByFilm(string filmName, DateTime FromDay, DateTime ToDay)
        {
            int count = 0;
            foreach (Ticket_View v in GetTicketByFilmAndTime(filmName, FromDay, ToDay))
            {
                count += Convert.ToInt32(v.GiaThanhTien);
            }
            return count;
        }

        //Calculate schedule's revenue 
        public int CalRevenueBySche(string IdSchedule)
        {
            int count = 0;
            foreach (Ticket_View v in GetTicketBySchedule(IdSchedule))
            {
                count += Convert.ToInt32(v.GiaThanhTien);
            }
            return count;
        }

        #endregion

        #region --- ROOM ---

        //Get all room in db
        public List<PHONGCHIEU> GetAllRoom()
        {
            return db.PHONGCHIEUs.ToList();
        }

        //Get room by ID
        public PHONGCHIEU GetRoomById(string Id)
        {
            return db.PHONGCHIEUs.Find(Id);
        }

        #endregion
    }
}
