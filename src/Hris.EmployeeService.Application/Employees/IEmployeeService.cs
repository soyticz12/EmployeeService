namespace Hris.EmployeeService.Application.Employees;

public interface IEmployeeService
{
    Task<EmployeeDto> CreateAsync(CreateEmployeeRequest request, CancellationToken ct = default);
    Task<EmployeeDto?> GetAsync(Guid id, CancellationToken ct = default);
}