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

    public DbSet<Employee>? Employees { get; set; }
}