namespace Site.Models
{
    public class Post
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required DateTime CreatedOn { get; set; }
        public required byte[] MarkdownFile { get; set; }
        public string? Description { get; set; }
    }
}
