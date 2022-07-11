using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ThongKeSCPhim_View
    {
            public string MaSuatChieu { get; set; }
            public string TenPhim { get; set; }
            public string NgayChieu { get; set; }
            public Nullable<System.TimeSpan> GioChieu { get; set; }
            public Nullable<int> SoVeDaDat { get; set; }
            public Nullable<int> DoanhThu { get; set; }
    }
}
