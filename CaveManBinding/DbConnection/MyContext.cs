using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using CaveManBinding.Models;

namespace CaveManBinding.DbConnection
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<BmnUwModel> BMN_UW { get; set; }
        public virtual DbSet<KojModel> KOJ { get; set; }
        public virtual DbSet<KojUwModel> KOJ_UW { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BmnUwModel>()
                .ToTable("M_BMN_UW");

            modelBuilder.Entity<KojModel>()
                .ToTable("M_KOJ");

            modelBuilder.Entity<KojUwModel>()
                .ToTable("M_KOJ_UW");

            modelBuilder.Entity<KojModel>()
                .Property(e => e.KEIY_KIN)
                .HasPrecision(15, 0);

            modelBuilder.Entity<KojUwModel>()
                .Property(e => e.KEIY_KIN)
                .HasPrecision(15, 0);
        }
    }
}
