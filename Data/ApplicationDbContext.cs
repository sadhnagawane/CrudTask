using CrudTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudTask.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public DbSet<Product> Products { get; set; }
    }
}
