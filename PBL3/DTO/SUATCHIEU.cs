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

    [Table("SUATCHIEU")]
    public class SUATCHIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUATCHIEU()
        {
            this.GHE_SC = new HashSet<VE_SC>();
            this.VEs = new HashSet<VE>();
        }
        [Key]
        public string MaSuatChieu { get; set; }
        public string MaPhong { get; set; }
        public string MaPhim { get; set; }
        public Nullable<System.DateTime> NgayChieu { get; set; }
        public Nullable<System.TimeSpan> GioChieu { get; set; }
        public Nullable<int> SoVeDaDat { get; set; }

        [ForeignKey("MaPhim")]
        public virtual PHIM PHIM { get; set; }
        [ForeignKey("MaPhong")]
        public virtual PHONGCHIEU PHONGCHIEU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE_SC> GHE_SC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
