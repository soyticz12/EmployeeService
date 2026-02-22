using Microsoft.AspNetCore.Mvc;
using Hris.EmployeeService.Application.Employees;

namespace Hris.EmployeeService.Api.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public async Task<ActionResult<EmployeeDto>> Create([FromBody] CreateEmployeeRequest request, CancellationToken ct)
    {
        var result = await _employeeService.CreateAsync(request, ct);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<EmployeeDto>> GetById(Guid id, CancellationToken ct)
    {
        var result = await _employeeService.GetAsync(id, ct);
        return result is null ? NotFound() : Ok(result);
    }
}