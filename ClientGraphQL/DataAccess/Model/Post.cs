using ClientGraphQL.DataAcess.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientGraphQL.DataAccess.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? CreateAt { get; set; }
        public string? Author { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public override string? ToString()
        {
            return $"Content:{Content}, Author:{Author}," +
                $" Title:{Title}";
        }
    }
}
