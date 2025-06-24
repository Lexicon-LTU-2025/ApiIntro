using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Models.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; } 
    public int Salary { get; set; }

}
