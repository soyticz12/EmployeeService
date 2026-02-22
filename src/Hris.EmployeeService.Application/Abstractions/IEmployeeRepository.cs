using Hris.EmployeeService.Domain.Entities;

namespace Hris.EmployeeService.Application.Abstractions;

public interface IEmployeeRepository
{
    Task AddAsync(Employee employee, CancellationToken ct = default);
    Task<Employee?> GetByIdAsync(Guid id, CancellationToken ct = default);
}