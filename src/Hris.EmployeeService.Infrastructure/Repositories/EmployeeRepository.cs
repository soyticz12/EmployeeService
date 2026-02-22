using Microsoft.EntityFrameworkCore;
using Hris.EmployeeService.Application.Abstractions;
using Hris.EmployeeService.Domain.Entities;
using Hris.EmployeeService.Infrastructure.Persistence;

namespace Hris.EmployeeService.Infrastructure.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _db;

    public EmployeeRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task AddAsync(Employee employee, CancellationToken ct = default)
    {
        _db.Employees.Add(employee);
        await _db.SaveChangesAsync(ct);
    }

    public Task<Employee?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        return _db.Employees.FirstOrDefaultAsync(x => x.Id == id, ct);
    }
}