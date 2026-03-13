using HRSystem.Data;
using HRSystem.Models;
using HRSystem.Services.Dtos;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Services;

public class EmployeeService
{
    public readonly HRDbContext _context;

    public List<EmployeeDto> GetEmployeeSummary()
    {
        var result = _context.Employees.AsNoTracking()
            .Select(e => new EmployeeDto
            {
                Id=e.Id,
                Name=e.Name,
                DepartmentName = e.Department.Name
            }).ToList();
        return result;

    }
    public decimal UpdateSalary(Guid id,decimal salary)
    {
        var employee=_context.Employees.SingleOrDefault(e => e.Id == id);
        employee.Salary = salary;
        _context.SaveChanges();
        return employee.Salary;
    }
}
