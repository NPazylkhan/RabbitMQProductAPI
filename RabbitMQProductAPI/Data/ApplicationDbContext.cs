using Microsoft.EntityFrameworkCore;
using RabbitMQProductAPI.Models;

namespace RabbitMQProductAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
    }
}
