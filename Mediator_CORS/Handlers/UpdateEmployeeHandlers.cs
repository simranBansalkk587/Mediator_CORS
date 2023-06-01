using Mediator_CORS.Command;
using Mediator_CORS.Services;
using MediatR;

namespace Mediator_CORS.Handlers
{
    public class UpdateEmployeeHandlers:IRequestHandler<UpdateEmployeeCommand,int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandlers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;    
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            employee.Name= request.Name;    
            employee.Email= request.Email;  
            employee.Address= request.Address;  
            employee.Phone  = request.Phone;    
            return await _employeeRepository.UpdateEmployeAsync(employee);
        }
    }
}
