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

    [Table("VE_SC")]
    public class VE_SC
    {
        [Key, Column(Order = 0)]
        public string ID_Ghe { get; set; }
        [Key, Column(Order = 1)]
        public string MaSuatChieu { get; set; }
        public string MaGhe { get; set; }
        public string MaPhong { get; set; }
        public int GiaVe { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("MaGhe, MaPhong")]
        public virtual GHE GHE { get; set; }
        [ForeignKey("MaSuatChieu")]
        public virtual SUATCHIEU SUATCHIEU { get; set; }
    }
}
