using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using PracticaDobosh.DAL.Entities;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Context
{
    public class EquipmentDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<SoftwareLicenses> SoftwareLicenses { get; set; }
        public DbSet<InstalledSoftware> InstalledSoftwares { get; set; }
        public DbSet<MovementHistory> MovementHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString;
                optionsBuilder.UseSqlServer(connString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>().HasKey(e => e.InventoryNumber);

            modelBuilder.Entity<InstalledSoftware>()
                .HasKey(isw => new { isw.EquipmentInventoryNumber, isw.LicenseId });

            modelBuilder.Entity<MovementHistory>()
                .HasOne(m => m.OldEmployee)
                .WithMany(e => e.OldMovements)
                .HasForeignKey(m => m.OldEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovementHistory>()
                .HasOne(m => m.NewEmployee)
                .WithMany(e => e.NewMovements)
                .HasForeignKey(m => m.NewEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);


        }

        public EquipmentDbContext() { }

        public EquipmentDbContext(DbContextOptions<EquipmentDbContext> options) : base(options) { }

    }
}
