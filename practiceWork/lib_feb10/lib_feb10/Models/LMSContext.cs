using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lib_feb10.Models
{
    public partial class LMSContext : DbContext
    {
        public LMSContext()
        {
        }

        public LMSContext(DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Borrow> Borrows { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=IN3281021W1;trusted_connection=true;database=LMS");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("authors");

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("authorName");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("books");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bookName");

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__books__authorId__3D5E1FD2");
            });

            modelBuilder.Entity<Borrow>(entity =>
            {
                entity.ToTable("borrows");

                entity.Property(e => e.BorrowId).HasColumnName("borrowId");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.BroughtDate)
                    .HasColumnType("date")
                    .HasColumnName("broughtDate");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.TakenDate)
                    .HasColumnType("date")
                    .HasColumnName("takenDate");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__borrows__bookId__3F466844");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__borrows__student__3E52440B");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.StudentFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("studentFirstName");

                entity.Property(e => e.StudentLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("studentLastName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
