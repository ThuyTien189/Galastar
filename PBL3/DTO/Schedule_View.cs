using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Schedule_View
    {
        public string MaSuatChieu { get; set; }
        public string MaPhong { get; set; }
        public string TenPhim { get; set; }
        public string NgayChieu { get; set; }
        public TimeSpan GioChieu { get; set; }
        public int SoVeDaDat { get; set; }
        public int SoVeToiDa { get; set; }
        public string TrangThai { get; set; }
    }
}
