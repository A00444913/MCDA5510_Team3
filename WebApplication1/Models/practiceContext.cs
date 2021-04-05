using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class practiceContext : DbContext
    {
        public practiceContext()
        {
        }

        public practiceContext(DbContextOptions<practiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Hotelroom> Hotelrooms { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Userdetail> Userdetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:a00442518.database.windows.net,1433;Initial Catalog=practice;Persist Security Info=False;User ID=gurpartap;Password=TEJwant@93;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => new { e.Cid, e.Uid, e.Rid, e.Hid });

                entity.ToTable("booking_detail");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Hid).HasColumnName("hid");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.GuestCount).HasColumnName("guest_count");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__customer__D837D05F1BFF495A");

                entity.ToTable("customer");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Province)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("province");

                entity.Property(e => e.Streetno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("streetno");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.Hid)
                    .HasName("PK__hotel__DF101B017F88CB96");

                entity.ToTable("hotel");

                entity.Property(e => e.Hid)
                    .ValueGeneratedNever()
                    .HasColumnName("hid");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Hotelroom>(entity =>
            {
                entity.HasKey(e => new { e.Hid, e.Type })
                    .HasName("PK__hotelroo__512F9E25C21E6BDA");

                entity.ToTable("hotelroom");

                entity.Property(e => e.Hid).HasColumnName("hid");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.AvailDate)
                    .HasColumnType("date")
                    .HasColumnName("avail_date");

                entity.Property(e => e.AvailNum).HasColumnName("avail_num");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => new { e.Rid, e.Type })
                    .HasName("PK__room__4C8868CC89B93839");

                entity.ToTable("room");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.MaxGuest).HasColumnName("max_guest");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.Hid });

                entity.ToTable("transaction");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Hid).HasColumnName("hid");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.Paymethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymethod");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transaction_date");
            });

            modelBuilder.Entity<Userdetail>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__userdeta__DD701264D12D7D92");

                entity.ToTable("userdetails");

                entity.Property(e => e.Uid)
                    .ValueGeneratedNever()
                    .HasColumnName("uid");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
