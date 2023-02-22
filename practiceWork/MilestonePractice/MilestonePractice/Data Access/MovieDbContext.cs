using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MilestonePractice.Models
{
    public partial class MovieDbContext : DbContext
    {
        public MovieDbContext()
        {
        }

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MovieInfoTable> MovieInfoTables { get; set; } = null!;
        public virtual DbSet<UserInfoTable> UserInfoTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=IN3281021W1;trusted_connection=true;database=MovieDb");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieInfoTable>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.ToTable("MovieInfoTable");

                entity.Property(e => e.MovieId).HasColumnName("movieId");

                entity.Property(e => e.MovieName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("movieName");

                entity.Property(e => e.MovieRating).HasColumnName("movieRating");

                entity.Property(e => e.MovieType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("movieType");
            });

            modelBuilder.Entity<UserInfoTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserInfoTable");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
