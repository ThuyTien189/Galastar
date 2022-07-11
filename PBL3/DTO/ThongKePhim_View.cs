using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class ThongKePhim_View
    {
        public string TenPhim { get; set; }

        public Nullable<int> TongSuatChieu{ get; set; }

        public Nullable<int> TongSoVeDaDat { get; set; }

        public Nullable<int> DoanhThu { get; set; }

    }
}


