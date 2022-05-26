using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Color>().ToTable("Colors");
            modelBuilder.Entity<Brand>().ToTable("Brands");

            modelBuilder.Entity<Car>().Property(p => p.CarId).HasColumnName("Id");
            modelBuilder.Entity<Car>().Property(p => p.BrandId).HasColumnName("BrandID");
            modelBuilder.Entity<Car>().Property(p => p.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(p => p.ModelYear).HasColumnName("ModelYear");
            modelBuilder.Entity<Car>().Property(p => p.DailyPrice).HasColumnName("DailyPrice");

            modelBuilder.Entity<Color>().Property(p => p.ColorId).HasColumnName("Id");
            modelBuilder.Entity<Color>().Property(p => p.ColorName).HasColumnName("Name");

            modelBuilder.Entity<Brand>().Property(p => p.BrandId).HasColumnName("Id");
            modelBuilder.Entity<Brand>().Property(p => p.BrandName).HasColumnName("Name");
        }
    }
}
