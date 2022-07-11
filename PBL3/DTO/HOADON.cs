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

    [Table("HOADON")]
    public class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.VEs = new HashSet<VE>();
        }
        [Key]
        public string MaHoaDon { get; set; }
        public string MaUser { get; set; }
        public Nullable<int> SoLuongVe { get; set; }
        public Nullable<int> ThanhTien { get; set; }
        [ForeignKey("MaUser")]
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
