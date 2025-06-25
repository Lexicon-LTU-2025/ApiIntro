using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Models.Entities;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [StringLength(15)]
    public required string Name { get; set; } = string.Empty;

    [Range(0, 200000)]
    public int Salary { get; set; }

    public string Department { get; set; } = string.Empty;

}
public class EmployeeForCreationDto
{
   

    [Required]
    [StringLength(15, MinimumLength = 2)]
    public  string Name { get; set; } = string.Empty;

    [Range(0, 200000)]
    public int Salary { get; set; }

}
