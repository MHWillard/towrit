using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            var connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            Console.WriteLine("connectionstring:" + connectionString);
            options.UseNpgsql(connectionString);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
