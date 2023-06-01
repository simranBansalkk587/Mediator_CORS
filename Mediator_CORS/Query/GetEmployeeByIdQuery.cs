using Mediator_CORS.Models;
using MediatR;

namespace Mediator_CORS.Query
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
