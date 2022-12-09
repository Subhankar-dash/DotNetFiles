using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySearchConsole.Models
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

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Manufracturer> Manufracturers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDetail> ProductDetails { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;

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
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Manufracturer>(entity =>
            {
                entity.HasKey(e => e.ManufractureId)
                    .HasName("PK__Manufrac__54D53AB74622DF86");

                entity.ToTable("Manufracturer");

                entity.Property(e => e.ManufractureId)
                    .ValueGeneratedNever()
                    .HasColumnName("ManufractureID");

                entity.Property(e => e.ManufractureAdderess)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufractureCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufractureName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufractureState)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductUniqueId)
                    .HasName("PK__Product__8377B53AFA483F62");

                entity.ToTable("Product");

                entity.Property(e => e.Descrition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ManufractureId).HasColumnName("ManufractureID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manufracture)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ManufractureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Manufra__2C3393D0");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__SubCate__2B3F6F97");
            });

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

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.Property(e => e.SubCategoryId).ValueGeneratedNever();

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubCatego__Categ__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
