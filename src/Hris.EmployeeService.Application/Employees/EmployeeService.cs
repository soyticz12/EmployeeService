using Hris.EmployeeService.Application.Abstractions;
using Hris.EmployeeService.Domain.Entities;

namespace Hris.EmployeeService.Application.Employees;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;

    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
    }

    public async Task<EmployeeDto> CreateAsync(CreateEmployeeRequest request, CancellationToken ct = default)
    {
        var employee = new Employee(request.EmployeeNo, request.FullName);
        await _repo.AddAsync(employee, ct);

        return new EmployeeDto(employee.Id, employee.EmployeeNo, employee.FullName);
    }

    public async Task<EmployeeDto?> GetAsync(Guid id, CancellationToken ct = default)
    {
        var employee = await _repo.GetByIdAsync(id, ct);
        return employee is null ? null : new EmployeeDto(employee.Id, employee.EmployeeNo, employee.FullName);
    }
}