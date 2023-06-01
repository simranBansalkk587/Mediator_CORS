using MediatR;

namespace Mediator_CORS.Command
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
