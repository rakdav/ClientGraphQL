using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleGraphQL.Models
{
    public class Post
    {
        public Guid Id { get; set; }
       
        public string? Title { get; set; }
       
        public string? Content { get; set; }
      
        public DateTime? CreateAt { get; set; }
        public string? Author { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" Title:{Title}";
        }
    }
}
