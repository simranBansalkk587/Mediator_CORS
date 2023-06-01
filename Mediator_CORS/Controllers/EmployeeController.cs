using Mediator_CORS.Command;
using Mediator_CORS.Models;
using Mediator_CORS.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_CORS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<Employee>>EmployeeList()
        {
            var employeeList = await _mediator.Send(new GetEmployeeListQuery());
            return employeeList;    
        }
        [HttpGet("{id}")]
        public async Task<Employee> EmployeeById(int id)
        {
            var employee=await _mediator.Send(new GetEmployeeByIdQuery() { Id=id});  
            return employee;
        }
        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var employeeInDb=await _mediator.Send(new  CreateEmployeeCommand(employee.Name,employee.Address,employee.Email,employee.Phone));    
            return employeeInDb;
        }
        [HttpPut]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var employeeInDb = await _mediator.Send(new UpdateEmployeeCommand(employee.Id, employee.Name, employee.Address, employee.Email, employee.Phone));
            return employeeInDb;
        }
        [HttpDelete]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id= id });
        }
    }
}

