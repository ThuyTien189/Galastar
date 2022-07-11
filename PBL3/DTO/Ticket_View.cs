using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Ticket_View
    {
        public string MaVe { get; set; }
        public string MaUser { get; set; }
        public string HoTen { get; set; }
        public string MaSuatChieu { get; set; }
        public string TenPhim { get; set; }
        public string MaPhong { get; set; }
        public string MaGhe { get; set; }
        public string NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public DateTime NgayDat { get; set; }
        public bool TrangThai { get; set; }
        public int GiaThanhTien { get; set; }

    }
}
