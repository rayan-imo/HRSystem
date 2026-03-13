using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public bool IsActive {  get; set; }
    public DateTime HireDate {  get; set; }
    public Department Department { get; set; }
}
