using Microsoft.EntityFrameworkCore;
using WebApiMIddleware.Models;

namespace WebApiMIddleware.Data
{
    public class ApplicationContext:DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {
            
        }
        public DbSet<ErrorLogger> ErrorLogger { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
