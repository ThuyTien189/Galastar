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

    [Table("USERS")]
    public class USER
    {
        public USER()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.VEs = new HashSet<VE>();
        }

        [Key]
        [Required]
        public string MaUser { get; set; }
        public string UserNames { get; set; }
        [MinLength(6, ErrorMessage = "Mk min 6 ki tu")]
        public string PassWords { get; set; }
        [Required]
        public bool isAdmin { get; set; }
        public string HoTen { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> DiemTichLuy { get; set; }
        public string IMG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
