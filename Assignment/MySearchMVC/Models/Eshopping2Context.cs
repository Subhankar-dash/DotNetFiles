using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySearchMVC.Models
{
    public partial class Eshopping2Context : DbContext
    {
        public Eshopping2Context()
        {
        }

        public Eshopping2Context(DbContextOptions<Eshopping2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductDetail> ProductDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Eshopping2;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__ProductD__B40CC6CDB1C8E06B");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ManufracturerName).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Seller)
                    .IsUnicode(false)
                    .HasColumnName("seller");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
