using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentCar;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarStatus> CarStates { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Color>().ToTable("Colors");
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Customer>().ToTable("Customers").HasNoKey();
            modelBuilder.Entity<Rental>().ToTable("Rentals");
            modelBuilder.Entity<CarStatus>().ToTable("CarStates");
            modelBuilder.Entity<CarImage>().ToTable("CarImages");
            modelBuilder.Entity<OperationClaim>().ToTable("OperationClaims");
            modelBuilder.Entity<UserOperationClaim>().ToTable("UserOperationClaims");

            modelBuilder.Entity<Car>().Property(p => p.CarId).HasColumnName("Id");
            modelBuilder.Entity<Car>().Property(p => p.CarName).HasColumnName("Name");
            modelBuilder.Entity<Car>().Property(p => p.BrandId).HasColumnName("BrandID");
            modelBuilder.Entity<Car>().Property(p => p.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(p => p.CarStatusId).HasColumnName("CarStatusId");
            modelBuilder.Entity<Car>().Property(p => p.ModelYear).HasColumnName("ModelYear");
            modelBuilder.Entity<Car>().Property(p => p.DailyPrice).HasColumnName("DailyPrice");
            

            modelBuilder.Entity<Color>().Property(p => p.ColorId).HasColumnName("Id");
            modelBuilder.Entity<Color>().Property(p => p.ColorName).HasColumnName("Name");

            modelBuilder.Entity<Brand>().Property(p => p.BrandId).HasColumnName("Id");
            modelBuilder.Entity<Brand>().Property(p => p.BrandName).HasColumnName("Name");

            modelBuilder.Entity<User>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<User>().Property(p => p.FirstName).HasColumnName("FirstName");
            modelBuilder.Entity<User>().Property(p => p.LastName).HasColumnName("LastName");
            modelBuilder.Entity<User>().Property(p => p.Email).HasColumnName("Email");
            modelBuilder.Entity<User>().Property(p => p.PasswordHash).HasColumnName("PasswordHash");
            modelBuilder.Entity<User>().Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");

            modelBuilder.Entity<Customer>().Property(p => p.UserId).HasColumnName("UserId");
            modelBuilder.Entity<Customer>().Property(p => p.CompanyName).HasColumnName("CompanyName");

            modelBuilder.Entity<Rental>().Property(p => p.RentalId).HasColumnName("Id");
            modelBuilder.Entity<Rental>().Property(p => p.CarId).HasColumnName("CarId");
            modelBuilder.Entity<Rental>().Property(p => p.CustomerId).HasColumnName("CustomerId");
            modelBuilder.Entity<Rental>().Property(p => p.RentDate).HasColumnName("RentDate");
            modelBuilder.Entity<Rental>().Property(p => p.ReturnDate).HasColumnName("ReturnDate");

            modelBuilder.Entity<CarStatus>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<CarStatus>().Property(p => p.Status).HasColumnName("Status");

            modelBuilder.Entity<CarImage>().Property(p=>p.Id).HasColumnName("Id");
            modelBuilder.Entity<CarImage>().Property(p => p.CarId).HasColumnName("CarId");
            modelBuilder.Entity<CarImage>().Property(p => p.ImagePath).HasColumnName("ImagePath");
            modelBuilder.Entity<CarImage>().Property(p => p.Date).HasColumnName("Date");

            modelBuilder.Entity<OperationClaim>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<OperationClaim>().Property(p => p.Name).HasColumnName("Name");

            modelBuilder.Entity<UserOperationClaim>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<UserOperationClaim>().Property(p => p.UserId).HasColumnName("UserId");
            modelBuilder.Entity<UserOperationClaim>().Property(p => p.OperationClaimId).HasColumnName("OperationClaimId");

        }
    }
}
