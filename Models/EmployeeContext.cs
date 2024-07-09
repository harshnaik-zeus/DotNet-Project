using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Employee> Employees { get; set; }
}
