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
    [Table("VE")]
    public class VE
    {
        [Key, Column(Order = 0)]
        public string ID_Ghe { get; set; }
        [Key, Column(Order = 1)]
        public string MaSuatChieu { get; set; }
        public string MaUser { get; set; }
        public string MaHoaDon { get; set; }

        public Nullable<System.DateTime> NgayBanVe { get; set; }
        public int GiaThanhTien { get; set; }

        [ForeignKey("ID_Ghe, MaSuatChieu")]
        public virtual VE_SC VE_SC { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HOADON HOADON { get; set; }

        [ForeignKey("MaSuatChieu")]
        public virtual SUATCHIEU SUATCHIEU { get; set; }
        [ForeignKey("MaUser")]
        public virtual USER USER { get; set; }
    }
}
