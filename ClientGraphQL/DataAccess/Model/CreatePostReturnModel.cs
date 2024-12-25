namespace ClientGraphQL.DataAccess.Model
{
    public class CreatePostReturnModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? CreateAt { get; set; }
        public string? Author { get; set; }
    }
}
