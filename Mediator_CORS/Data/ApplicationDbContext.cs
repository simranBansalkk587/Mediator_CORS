using Mediator_CORS.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediator_CORS.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
