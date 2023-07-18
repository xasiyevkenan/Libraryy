
namespace Library.DAL.Entities
{
    public class Book : TimeStample
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<AuthorBooks> AuthorBooks { get; set; }
    }
}
