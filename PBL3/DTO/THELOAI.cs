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

    [Table("THELOAI")]
    public class THELOAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THELOAI()
        {
            this.CHITIET_THELOAI = new HashSet<CHITIET_THELOAI>();
        }
        [Key]
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_THELOAI> CHITIET_THELOAI { get; set; }
    }
}
