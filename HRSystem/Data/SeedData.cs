using HRSystem.Models;

namespace HRSystem.Data;

public static class SeedData
{
    public static void Initialize(HRDbContext context)
    {
        var dep1 = new Department { Id = Guid.Parse("00020000-0000-0000-0000-000000000001"), Name = "Sales"};
        var dep2 = new Department { Id = Guid.Parse("00020000-0000-0000-0000-000000000002"), Name = "BackEnd"};
        context.AddRange(dep1,dep2);
        context.SaveChanges();

        var emp1 = new Employee { Id = Guid.Parse("00030000-0000-0000-0000-000000000001"), Name = "Rayan" };
        var emp2 = new Employee { Id = Guid.Parse("00030000-0000-0000-0000-000000000002"), Name = "Hala" };
        var emp3 = new Employee { Id = Guid.Parse("00030000-0000-0000-0000-000000000003"), Name = "Rama" };
        var emp4 = new Employee { Id = Guid.Parse("00030000-0000-0000-0000-000000000004"), Name = "Fatima" };
        var emp5 = new Employee { Id = Guid.Parse("00030000-0000-0000-0000-000000000005"), Name = "Hour" };
        context.AddRange(emp1,emp2,emp3,emp4,emp5);
        context.SaveChanges();
    }
    
}
