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

        public virtual DbSet<KojModel> KOJ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KojModel>()
                .ToTable("M_KOJ");

            modelBuilder.Entity<KojModel>()
                .Property(e => e.KEIY_KIN)
                .HasPrecision(15, 0);
        }
    }
}
