using Mediator_CORS.Command;
using Mediator_CORS.Models;
using Mediator_CORS.Services;
using MediatR;

namespace Mediator_CORS.Handlers
{
    public class CreateEmployeeHandlers : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeHandlers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;  
        }
        

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee
            {
                Name = request.Name,
                Address = request.Address,

                Email = request.Email,
                Phone = request.Phone,
            };
            return await _employeeRepository.AddEmployeAsync(emp);

        }
    }
}
