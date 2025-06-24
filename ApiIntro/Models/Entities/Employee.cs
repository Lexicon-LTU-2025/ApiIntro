using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Models.Entities;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [StringLength(15)]
    public string? Name { get; set; }

    [Range(0, 200000)]
    public int Salary { get; set; }

}
