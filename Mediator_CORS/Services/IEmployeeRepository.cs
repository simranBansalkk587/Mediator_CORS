using Mediator_CORS.Models;

namespace Mediator_CORS.Services
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployeeListAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
        public Task<Employee> AddEmployeAsync(Employee employee);
        public Task<int> UpdateEmployeAsync(Employee employee);
        
        public Task<int>DeleteEmployeeAsync(int id);    
    }
}
