using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Глазки.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.KPP)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.ProductSale)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.MinCostForAgent)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductSale)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
