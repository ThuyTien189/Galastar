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

    [Table("CHITIET_THELOAI")]
    public class CHITIET_THELOAI
    {
        [Key]
        public string ID { get; set; }
        public string MaPhim { get; set; }
        public string MaTheLoai { get; set; }

        public virtual PHIM PHIM { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
