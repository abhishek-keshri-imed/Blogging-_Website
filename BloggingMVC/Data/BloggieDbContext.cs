
// BloggieDbContext for Database configured in program.cs

using BloggingMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggingMVC.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        // Table BlogPosts
        public DbSet<BlogPost> BlogPosts { get; set; }

        // Table Tags
        public DbSet<Tag> Tags { get; set; }
    }
}
