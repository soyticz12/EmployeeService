using Microsoft.Extensions.DependencyInjection;
using Hris.EmployeeService.Application.Employees;

namespace Hris.EmployeeService.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, Employees.EmployeeService>();
        return services;
    }
}