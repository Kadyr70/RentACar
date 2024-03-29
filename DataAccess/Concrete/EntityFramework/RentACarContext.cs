﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-JLGF32U\SQLEXPRESS;Database=RentACar;Trusted_Connection=true");
		}

		public DbSet<Car> Cars { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Rental> Rentals { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().HasKey(c => c.UserId);
		}
	}
}