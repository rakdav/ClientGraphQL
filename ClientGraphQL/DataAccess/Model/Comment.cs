
using ClientGraphQL.DataAccess.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientGraphQL.DataAcess.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required]
        public Guid PostId { get; set; }
        public Post? Post { get; set; }

        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" CreatedAt:{CreatedAt}";
        }
    }
}
