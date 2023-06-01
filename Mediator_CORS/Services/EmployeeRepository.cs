using Mediator_CORS.Data;
using Mediator_CORS.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Mediator_CORS.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<Employee> AddEmployeAsync(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return emp.Entity;


        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            _context.Employees.Remove(emp);
            return await _context.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var emp = await _context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var emp = await _context.Employees.ToListAsync();
            return emp;
        }

        public async Task<int> UpdateEmployeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            return await _context.SaveChangesAsync();
        }
    }
}
