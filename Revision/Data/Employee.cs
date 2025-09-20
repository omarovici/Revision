using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revision.Data;

[Table("EmpTable")]
public class Employee
{
    // [Key]
    public int EmpId { get; set; }
    // [Required]
    // [Column("EmployeeName", TypeName = "varchar")]
    [MaxLength(50,ErrorMessage = "Name cannot exceed 50 characters")]
    [MinLength(3,ErrorMessage = "Name should have at least 3 characters")]
    // [StringLength(50,MinimumLength = 3)]
    public string EmpName { get; set; }
    
    [Column("EmployeeSalary", TypeName = "decimal(10,2)")]
    public decimal Salary { get; set; }
    
    // [Range(18,65,ErrorMessage = "Age should be between 18 and 65")]
    // [AllowedValues(18,19,20,21,22)]
    [DeniedValues (25,30,35)]
    public int Age { get; set; }
    
    [Phone]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [NotMapped]
    public int MyProperty { get; set; }
}