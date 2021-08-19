using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string CoverImage { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
        
    }
}