using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLychiTieu.Models
{
    public partial class QLChiTieuModel : DbContext
    {
        public QLChiTieuModel()
            : base("name=QLChiTieuModel")
        {
        }

        public virtual DbSet<EXPENS> EXPENSES { get; set; }
        public virtual DbSet<EXPENSESTYPE> EXPENSESTYPEs { get; set; }
        public virtual DbSet<INCOME> INCOMEs { get; set; }
        public virtual DbSet<INCOMETYPE> INCOMETYPEs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EXPENS>()
                .Property(e => e.EXPENSESID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXPENS>()
                .Property(e => e.USERID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXPENS>()
                .Property(e => e.EXTYPEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXPENS>()
                .Property(e => e.MONEY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EXPENS>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<EXPENSESTYPE>()
                .Property(e => e.EXTYPEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EXPENSESTYPE>()
                .Property(e => e.NAMEEXTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INCOME>()
                .Property(e => e.INCOMEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INCOME>()
                .Property(e => e.USERID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INCOME>()
                .Property(e => e.INTYPEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INCOME>()
                .Property(e => e.MONEY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INCOME>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<INCOMETYPE>()
                .Property(e => e.INTYPEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INCOMETYPE>()
                .Property(e => e.NAMEINTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.USERID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USER>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.GENDER)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
