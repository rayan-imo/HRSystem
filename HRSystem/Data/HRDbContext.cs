using HRSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HRSystem.Data;

public class HRDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
      "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Db;Integrated Security=True;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasIndex(e => e.Name).IsUnique();
            entity.Property(d => d.Name).IsRequired();

        });
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(d => d.Salary).HasColumnType("decimal(18,2)");
        });
    }
  
    public DbSet<Employee> Employees;
    public DbSet<Department> Department;
}
