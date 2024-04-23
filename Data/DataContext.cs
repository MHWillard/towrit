using App.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace App.Data
{
    public class DataContext : DbContext
    {
        //protected readonly IConfiguration Configuration;

        /*public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }*/

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<UserPostModel> UserPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserPost>().ToTable("UserPost");*/
            modelBuilder.UseSerialColumns();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql("Host=localhost;Port=5432;Database=towritDB;Username=postgres;Password=12Wilko$10");
        }
    }
    /*
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=towritDB;Username=postgres;Password=12Wilko$10");
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }*/
}
