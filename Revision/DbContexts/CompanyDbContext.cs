using Microsoft.EntityFrameworkCore;
using Revision.Data;

namespace Revision.DbContexts;

public class CompanyDbContext : DbContext
{
    public CompanyDbContext():base()
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CompanyDB1;User Id=SA;Password=MyStrongPass123;TrustServerCertificate=True;MultipleActiveResultSets=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasKey(e => e.EmpId);
        
        modelBuilder.Entity<Employee>().Property(e => e.EmpName)
            .HasColumnName("EmployeeName")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        
    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Product>? Products { get; set; }
}