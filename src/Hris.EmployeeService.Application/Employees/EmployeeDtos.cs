namespace Hris.EmployeeService.Application.Employees;

public record CreateEmployeeRequest(string EmployeeNo, string FullName);
public record EmployeeDto(Guid Id, string EmployeeNo, string FullName);