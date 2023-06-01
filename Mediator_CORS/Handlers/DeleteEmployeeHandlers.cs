using Mediator_CORS.Command;
using Mediator_CORS.Services;
using MediatR;

namespace Mediator_CORS.Handlers
{
    public class DeleteEmployeeHandlers:IRequestHandler<DeleteEmployeeCommand,int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandlers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;   
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            return await _employeeRepository.DeleteEmployeeAsync(request.Id);
        }
    }
}
