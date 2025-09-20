using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Revision.Data;

namespace Revision.ModelConfigurations;

public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(e=>e.EmpId);
        builder.Property<string>("Name");
        builder.Property(e=>e.EmpName)
            .HasColumnName("EmployeeName")
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired(false);

    }
}