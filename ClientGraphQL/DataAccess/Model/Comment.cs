
using ClientGraphQL.DataAccess.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientGraphQL.DataAcess.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Author { get; set; }
        [Required]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" CreatedAt:{CreatedAt}";
        }
    }
}
