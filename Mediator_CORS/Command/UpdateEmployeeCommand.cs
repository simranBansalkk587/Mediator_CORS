using MediatR;

namespace Mediator_CORS.Command
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public UpdateEmployeeCommand( int id,string name,string address,string email,string phone)
        {
            id = id;
            name = name;
            address = address;
            email = email;
            phone = phone;

        }
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Address { get; set; }     
        public string Email { get; set; }   
        public string Phone { get; set; }   
    }
}
