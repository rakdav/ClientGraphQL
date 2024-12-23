using System.ComponentModel.DataAnnotations;

namespace ClientGraphQL.DataAccess.Model
{
    public class CreatePostModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string? Content { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }
    }
}
