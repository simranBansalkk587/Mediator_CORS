using Mediator_CORS.Models;
using Mediator_CORS.Query;
using Mediator_CORS.Services;
using MediatR;

namespace Mediator_CORS.Handlers
{
    public class GetEmployeeListHandlers : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeListHandlers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeListAsync();
        }
    }
}
