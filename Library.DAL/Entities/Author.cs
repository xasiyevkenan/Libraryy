
namespace Library.DAL.Entities
{
    public class Author : TimeStample
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<AuthorBooks> AuthorBooks { get; set; }
    }
}
