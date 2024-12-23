using ClientGraphQL.DataAcess.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientGraphQL.DataAccess.Model
{
    public class Post
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string? Content { get; set; }
      
        public DateTime? CreateAt { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" Title:{Title}";
        }
    }
}
