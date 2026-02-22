namespace Hris.EmployeeService.Domain.Entities;

public class Employee
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string EmployeeNo { get; private set; }
    public string FullName { get; private set; }

    public Employee(string employeeNo, string fullName)
    {
        if (string.IsNullOrWhiteSpace(employeeNo))
            throw new ArgumentException("EmployeeNo is required.", nameof(employeeNo));

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("FullName is required.", nameof(fullName));

        EmployeeNo = employeeNo;
        FullName = fullName;
    }
}