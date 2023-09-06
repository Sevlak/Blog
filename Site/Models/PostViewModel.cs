using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class PostViewModel
    {
        public required int PostId { get; set; }

        [MinLength(1)]
        [Required]
        [StringLength(50, ErrorMessage = "Title length can't be more than 50 characters.")]
        public string Title { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public IFormFile MarkdownFile { get; set; }

        [StringLength(200, ErrorMessage = "Description can't be more than 200 characters.")]
        public string? Description { get; set; }
    }
}
