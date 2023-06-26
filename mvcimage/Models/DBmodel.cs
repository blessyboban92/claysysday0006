using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace mvcimage.Models
{
    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }

        public virtual DbSet<Mvcimagedb> Mvcimagedbs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mvcimagedb>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Mvcimagedb>()
                .Property(e => e.imgpath)
                .IsUnicode(false);
        }
    }
}
