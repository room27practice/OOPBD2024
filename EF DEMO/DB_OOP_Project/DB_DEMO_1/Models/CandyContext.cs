using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DB_DEMO_1.Models
{
    public partial class CandyContext : DbContext
    {
        public CandyContext()
        {
        }

        public CandyContext(DbContextOptions<CandyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candy> Candies { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=A11_2024DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candy>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Candies__737584F62E469DD0")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Candies)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candies_Manufacturers");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.HasIndex(e => e.Email, "UQ__Manufact__A9D105341E22633C")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
