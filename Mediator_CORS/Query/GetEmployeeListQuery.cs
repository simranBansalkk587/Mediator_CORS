using Mediator_CORS.Models;
using MediatR;

namespace Mediator_CORS.Query
{
    public class GetEmployeeListQuery:IRequest<List<Employee>>
    {
    }
}
