using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IMove.DataAccess
{
    public partial class IMoveDBContext : DbContext
    {
        public virtual DbSet<Availability> Availability { get; set; }
        public virtual DbSet<BookingDetails> BookingDetails { get; set; }
        public virtual DbSet<CarInfo> CarInfo { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategory { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server=tcp:imoveserver.database.windows.net,1433;Initial Catalog=IMoveDB;Persist Security Info=False;User ID=lee;Password=Imoveadmin1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //            }
        //        }
        public IMoveDBContext(DbContextOptions<IMoveDBContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>(entity =>
            {
                entity.HasKey(e => e.AvailabityId);

                entity.Property(e => e.AvailabityId).HasColumnName("AvailabityID");

                entity.Property(e => e.DayofWeekAvailable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkDriverId).HasColumnName("FK_DriverID");

                entity.Property(e => e.LocationAvalailable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkDriver)
                    .WithMany(p => p.Availability)
                    .HasForeignKey(d => d.FkDriverId)
                    .HasConstraintName("FK_Availability_Driver");
            });

            modelBuilder.Entity<BookingDetails>(entity =>
            {
                entity.Property(e => e.BookingDetailsId).HasColumnName("BookingDetailsID");

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkDriverId).HasColumnName("FK_DriverID");

                entity.Property(e => e.FkUserId).HasColumnName("FK_UserID");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");

                entity.Property(e => e.Pickup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkDriver)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.FkDriverId)
                    .HasConstraintName("FK_BookingDetails_Driver");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_BookingDetails_User");
            });

            modelBuilder.Entity<CarInfo>(entity =>
            {
                entity.Property(e => e.CarInfoId).HasColumnName("CarInfoID");

                entity.Property(e => e.CarMake)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkDriverId).HasColumnName("FK_DriverID");

                entity.Property(e => e.FkVehicleCategory).HasColumnName("FK_VehicleCategory");

                entity.HasOne(d => d.FkDriver)
                    .WithMany(p => p.CarInfo)
                    .HasForeignKey(d => d.FkDriverId)
                    .HasConstraintName("FK_CarInfo_Driver");

                entity.HasOne(d => d.FkVehicleCategoryNavigation)
                    .WithMany(p => p.CarInfo)
                    .HasForeignKey(d => d.FkVehicleCategory)
                    .HasConstraintName("FK_CarInfo_VehicleCategory");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.Property(e => e.VehicleCategoryId).HasColumnName("VehicleCategoryID");

                entity.Property(e => e.VehicleCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
