using Microsoft.EntityFrameworkCore;
using taskApi.Models;

namespace taskApi.DB
{
    public class ApplicationDbContext:DbContext  
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context):base(context)  
        {  
  
        }  
        public DbSet<TodoItem> TodoItems  { get; set; }   
    }
}  