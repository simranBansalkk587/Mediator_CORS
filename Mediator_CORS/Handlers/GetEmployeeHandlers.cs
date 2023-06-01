using Mediator_CORS.Models;
using Mediator_CORS.Query;
using Mediator_CORS.Services;
using MediatR;

namespace Mediator_CORS.Handlers
{
    public class GetEmployeeHandlers:IRequestHandler<GetEmployeeByIdQuery,Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeHandlers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;   
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
