using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Revision.Data;
using Revision.ModelConfigurations;

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
        // modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // automatically apply all configurations in the assembly
    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Product>? Products { get; set; }
}