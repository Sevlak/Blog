using Microsoft.EntityFrameworkCore;

namespace Site.Models
{
    public class Post
    {
        public required int PostId { get; set; }
        public required string Title { get; set; }
        public required DateTime CreatedOn { get; set; }
        public required byte[] MarkdownFile { get; set; }
        public string? Description { get; set; }
    }

    public class PostContext: DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\Posts.db");
        }
    }
}
