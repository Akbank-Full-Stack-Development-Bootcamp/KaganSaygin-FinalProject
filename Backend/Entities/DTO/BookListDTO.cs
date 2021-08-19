namespace Entities.DTO
{
    public class BookListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string CoverImage { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
    }
}