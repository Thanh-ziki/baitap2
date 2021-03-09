using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baitap2.Models
{
    public partial class DemoDbConText : DbContext
    {
        public DemoDbConText()
            : base("name=DemoDbConText")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }

        public virtual DbSet<ShopPet> ShopPets { get; set; }
        public virtual DbSet<ShopGiay> ShopGiays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
