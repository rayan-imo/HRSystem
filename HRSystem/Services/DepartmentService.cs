using HRSystem.Data;
using HRSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Services;

public class DepartmentService
{
    public readonly HRDbContext _context;

    public List<Department>GetAllDepartmentWithActiveEmployee()
    {
        var result = _context.Department.Include(d => d.Employees
        .Where(e => e.IsActive)).ToList();
        return result;
    }

}
