using Microsoft.EntityFrameworkCore;
using Hris.EmployeeService.Domain.Entities;

namespace Hris.EmployeeService.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Employee> Employees => Set<Employee>();
}