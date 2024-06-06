using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Transport_App.Entities;

public class TransportContext : DbContext
{
 
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transport> Transports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=TransportDb;Integrated Security=True;",
            options => options.EnableRetryOnFailure());

    }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transport>()
                .HasOne(t => t.Driver)
                .WithMany()
                .HasForeignKey(t => t.DriverId);

            modelBuilder.Entity<Transport>()
                .HasOne(t => t.Route)
                .WithMany()
                .HasForeignKey(t => t.RouteId);
        }
    }



