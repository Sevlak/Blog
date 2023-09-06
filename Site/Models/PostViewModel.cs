using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class PostViewModel
    {
        public required int PostId { get; set; }

        [MinLength(1)]
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, ErrorMessage = "Title length can't be more than 50 characters.")]
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required(ErrorMessage = "The MD file is required.")]
        public IFormFile MarkdownFile { get; set; }

        [StringLength(200, ErrorMessage = "Description can't be more than 200 characters.")]
        public string? Description { get; set; }
    }
}
