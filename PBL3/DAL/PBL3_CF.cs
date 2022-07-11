using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class PBL3_CF : DbContext
    {
        public PBL3_CF()
            : base("name=PBL3_CF")
        {
            Database.SetInitializer<PBL3_CF>(new CreateDB());
        }
        public virtual DbSet<CHITIET_THELOAI> CHITIET_THELOAI { get; set; }
        public virtual DbSet<GHE> GHEs { get; set; }
        public virtual DbSet<VE_SC> VE_SCs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<PHIM> PHIMs { get; set; }
        public virtual DbSet<PHONGCHIEU> PHONGCHIEUs { get; set; }
        public virtual DbSet<SUATCHIEU> SUATCHIEUs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<VE> VEs { get; set; }
    }
}
