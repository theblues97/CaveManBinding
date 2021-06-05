using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DbConnection
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=DbConnection")
        {
        }

        public virtual DbSet<M_KOJ> M_KOJ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<M_KOJ>()
                .Property(e => e.KEIY_KIN)
                .HasPrecision(15, 0);
        }
    }
}
