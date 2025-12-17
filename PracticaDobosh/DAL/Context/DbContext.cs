using Microsoft.EntityFrameworkCore;
using PracticaDobosh.DAL.Entities;
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
  
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<SoftwareLicenses> SoftwareLicenses { get; set; }
        public DbSet<InstalledSoftware> InstalledSoftware { get; set; }
        public DbSet<MovementHistory> MovementHistory { get; set; }

        public EquipmentDbContext(DbContextOptions<EquipmentDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<Equipment>()
                .HasKey(e => e.InventoryNumber);

            modelBuilder.Entity<Equipment>()
                .HasIndex(e => e.SerialNumber)
                .IsUnique();

            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.EquipmentType)
                .WithMany(et => et.Equipments)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.ResponsibleEmployee)
                .WithMany(emp => emp.ResponsibleEquipment)
                .HasForeignKey(e => e.EmployeeId) 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InstalledSoftware>()
                .HasKey(ins => new { ins.EquipmentInventoryNumber, ins.LicenseId });

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
        }
    }
}
