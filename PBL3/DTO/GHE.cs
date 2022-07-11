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

    [Table("GHE")]
    public class GHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GHE()
        {
            this.GHE_SCs = new HashSet<VE_SC>();
        }
        [Key, Column(Order = 0)]
        public string MaGhe { get; set; }
        [Key, Column(Order = 1)]
        public string MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public virtual PHONGCHIEU PHONGCHIEU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE_SC> GHE_SCs { get; set; }
    }
}
