namespace Entities.DTO
{
    public class BookDetailDTO : Book
    {
        public string Category { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}