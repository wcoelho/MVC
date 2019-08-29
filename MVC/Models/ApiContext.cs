using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{    
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
 
        public DbSet<Collaborator> Collaborators { get; set; }
    }
}