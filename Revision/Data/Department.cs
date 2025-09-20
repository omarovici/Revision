using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revision.Data;

public class Department
{
    [Key]
    public int DeptId { get; set; }
    public string DeptName { get; set; }
    public DateOnly DateOfCreation { get; set; }
    public Employee Manager { get; set; } = null!;
    // [ForeignKey(nameof(Manager))]
    public int DeptManagerId { get; set; }
    public Address DepartmentAddress { get; set; }
}