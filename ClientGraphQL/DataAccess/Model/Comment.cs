using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleGraphQL.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }
        public Guid PostId { get; set; }
        public Post? Post { get; set; }

        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" CreatedAt:{CreatedAt}";
        }
    }
}
