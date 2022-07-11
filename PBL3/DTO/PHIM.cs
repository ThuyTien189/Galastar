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

    [Table("PHIM")]
    public class PHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIM()
        {
            this.CHITIET_THELOAI = new HashSet<CHITIET_THELOAI>();
            this.SUATCHIEUx = new HashSet<SUATCHIEU>();
            this.VEs = new HashSet<VE>();
        }
        [Key]
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public Nullable<System.TimeSpan> ThoiLuong { get; set; }
        public string NDTomTat { get; set; }
        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public string IMG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_THELOAI> CHITIET_THELOAI { get; set; }
        public virtual ICollection<SUATCHIEU> SUATCHIEUx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
